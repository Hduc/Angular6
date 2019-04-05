using System;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PremiumcontactMaster.Models;
using Microsoft.IdentityModel.Tokens;
using PremiumcontactMaster.PremiumContactDA;
using Microsoft.AspNetCore.Authorization;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using PremiumcontactMaster.ModelData;
using System.Net.Http;
using System.Net;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;

namespace PremiumcontactMaster.Controllers
{

    [Route("api/login")]
    public class LoginController : Controller
    {
        private DBContext _context;
        private IConfiguration _config;

        public LoginController(DBContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }
        public async Task<IActionResult> Get(string id, string pass)
        {
            var da = new Liste_UtilisateurDA(_context);
            try
            {
                var data = await da.Login(id, pass);
                return Ok(data);
            }
            catch (System.Exception)
            {
                return Forbid();
            }
        }

        [HttpGet]
        [Route("checkusername")]
        public Task<bool> checkUserName(string id)
        {
            var da = new Liste_UtilisateurDA(_context);
            var data = da.checkUserName(id);
            return data;
        }
        [HttpGet]
        [Route("checkemail")]
        public Task<bool> checkEmail(string email)
        {
            var da = new Liste_UtilisateurDA(_context);
            var data = da.checkEmail(email);
            return data;
        }

        [HttpPost]
        [Route("sendemailwithid")]
        public bool sendEmailWithID(string email)
        {
            var da = new Liste_UtilisateurDA(_context);
            try
            {
                da.sendEmailIsID(email);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        [HttpPost]
        [Route("sendemailnotid")]
        public bool sendEmailNotID(string email)
        {
            var da = new Liste_UtilisateurDA(_context);
            try
            {
                da.sendEmailNotID(email);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        [Route("loaduserbyid")]
        [HttpGet]
        public async Task<IActionResult> LoadUser_ByID(string id)
        {
            var da = new Liste_UtilisateurDA(_context);
            try
            {
                var data = await da.LoadUser_ByID(id);
                if (data.IDUtilisateur > 0)
                    return Ok(new ApiResultDTO(data));
                return NotFound(new ApiResultDTO(data, "404", "Not Found"));

            }
            catch (System.Exception err)
            {
                return BadRequest(new ApiResultDTO("", "400", err.ToString()));
            }
        }
        [Route("listuser")]
        [HttpGet]
        public async Task<IActionResult> LoadUser_InEvent(int id)
        {
            var da = new Liste_UtilisateurDA(_context);
            try
            {
                var data = await da.LoadUser_InEvent(id);
                if (data.Count > 0)
                    return Ok(new ApiResultDTO(data));
                return NotFound(new ApiResultDTO(data, "404", "Not Found"));
            }
            catch (System.Exception)
            {
                return BadRequest(new ApiResultDTO("", "400", "Bad Request"));
            }
        }
        // tao token
        [HttpPost]
        [Route("createtoken")]
        public async Task<IActionResult> CreateToken_MB([FromBody]ObjLogin login)
        {
            try
            {
                var tokenString = BuildToken_MB(login);
                await Task.WhenAny(tokenString);
                if (tokenString.Result != "" || tokenString.Result != null)
                {
                    return Ok(new ApiResultDTO(tokenString.Result,tokenString.Result));
                }
                else
                    return BadRequest(new ApiResultDTO("", "400", ""));
            }
            catch (System.Exception err)
            {
                return BadRequest(new ApiResultDTO("", "400", err.ToString()));
            }
        }
        // encoding token
        private async Task<string> BuildToken_MB(ObjLogin user)
        {
            var da = new Liste_UtilisateurDA(_context);
            var data = await da.Login(user.UserName, user.Password);
            if (data.IDUtilisateur > 0)
            {
                var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Sub, user.Password),
            };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                    _config["Jwt:Issuer"],
                    claims,
                     expires: DateTime.Now.AddMinutes(30), //expire time 30 min
                    signingCredentials: creds);


                return new JwtSecurityTokenHandler().WriteToken(token);
            }
            else
            {
                return new JwtSecurityTokenHandler().WriteToken(null);
            }
        }
    [HttpPost]
    // [Route("listevent")]
    public async Task<IActionResult> Login_MB([FromHeader]string strToken)
    {
        try
        {
            HttpClientHandler handler = new HttpClientHandler()
            {
                Proxy = new WebProxy(Commons.Http),
                UseProxy = true,
            };
            // HttpClient client = new HttpClient(handler);
            // var byteArray = Encoding.ASCII.GetBytes(_config["Jwt:Key"]);
            // var objHeader = client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            // get string token
            var strtoken = strToken.Split("==");
            var handlers = new JwtSecurityTokenHandler();
            var decode = handlers.ReadToken(strtoken[0]) as JwtSecurityToken;
            var arrsub = decode.Payload.Sub.Replace("[", "").Replace("]", "").Replace("\\", "").Replace("\"", "").Trim().Split(',');
            string username = arrsub[0] + "";
            string pass = arrsub[1] + "";
            if (username.Trim() != "" && pass.Trim() != "")
            {
                var da = new Liste_UtilisateurDA(_context);
                var daEvent = new Enquete_SocieteDA(_context);

                var data = await da.Login(username, pass);
                if (data.IDUtilisateur > 0)
                {
                    // return Ok();
                    return Ok(new ApiResultDTO(data, strToken));
                }
                else
                {
                    return NotFound(new ApiResultDTO(data, "404", "Not Found"));
                }
            }
            else
            {
                return BadRequest(new ApiResultDTO("", "400", ""));
            }
        }
        catch (Exception err)
        {
            return BadRequest(new ApiResultDTO("", "400", err.ToString()));
        }
    }

}
}