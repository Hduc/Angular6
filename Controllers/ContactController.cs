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

using System.IO;
using System.Web;
using System.Web.Http;
using System.Net.Http.Headers;

namespace PremiumcontactMaster.Controllers
{

    [Route("api/participants")]
    public class ContactController : Controller
    {
        private DBContext _context;
        public ContactController(DBContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("listcontact")]
        public async Task<IActionResult> LoadData_Contact(string idSociete)
        {
            try
            {
                var DA = new ContactDA(_context);
                var obj = DA.LoadData_Contact(Convert.ToInt32(idSociete));
                await Task.WhenAll(obj);

                if (obj.Result.Count > 0)
                {
                    return Ok(new ApiResultDTO(obj.Result));
                }
                else
                {
                    return NotFound(new ApiResultDTO(obj.Result, "404", "Not Found"));
                }
            }
            catch (Exception err)
            {
                return BadRequest(new ApiResultDTO("", "400", err.ToString()));
            }
        }
        [HttpPost, DisableRequestSizeLimit]
        [Route("insertImgContact")]
        public async Task<IActionResult> Insert_Img_Contact(string idContact)
        {
            var DA = new ContactDA(_context);
            try
            {
                int intIdContact = Convert.ToInt32(idContact);
                var file = Request.Form.Files[0];
                string folderName = "DocumentsPublics/Photodidentite";
                string webRootPath = "wwwroot";
                string newPath = Path.Combine(webRootPath, folderName);
                if (!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                }
                if (file.Length < 1 && intIdContact < 1)
                {
                    return BadRequest(new ApiResultDTO(0, "400", "Bad Request"));
                }
                // File name 
                string fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                string name = fileName.Split('.')[0];
                string fullPath = Path.Combine(newPath, fileName);
                string extension = fileName.Split('.')[1];
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                var res = DA.Insert_MediathequeDocument(intIdContact, name, extension);
                await Task.WhenAll(res);

                if (res.Result == 1)
                {
                    _context.SaveChanges();
                    return Ok(new ApiResultDTO(1));
                }
                else
                {
                    return BadRequest(new ApiResultDTO(0, "400", "Bad Request"));
                }

            }
            catch (System.Exception err)
            {
                return BadRequest(new ApiResultDTO(0, "400", err.ToString()));
            }
        }
        [HttpPost]
        [Route("insertcontact")]
        public async Task<IActionResult> Insert_Contact([FromBody] Model_Contact obj)
        {
            try
            {
                var DA = new ContactDA(_context);
                var res = DA.Insert_Contact(obj);
                await Task.WhenAll(res);

                if (res.Result > 0)
                {
                    return Ok(new ApiResultDTO(res.Result));
                }
                else
                {
                    return BadRequest(new ApiResultDTO(0, "400", "Bad Request"));
                }
            }
            catch (Exception err)
            {
                return BadRequest(new ApiResultDTO(0, "400", err.ToString()));
            }
        }
        [HttpPost]
        [Route("updatecontact")]
        public async Task<IActionResult> Update_Contact([FromBody] Model_Contact obj)
        {
            try
            {
                var DA = new ContactDA(_context);
                var res = DA.Update_Contact(obj);
                await Task.WhenAll(res);

                if (res.Result == 1)
                {
                    return Ok(new ApiResultDTO(1));
                }
                else
                {
                    return BadRequest(new ApiResultDTO(0, "400", "Bad Request"));
                }
            }
            catch (Exception err)
            {
                return BadRequest(new ApiResultDTO(0, "400", err.ToString()));
            }
        }
        [HttpPost]
        [Route("deletedcontact")]
        public async Task<IActionResult> Delete_Contact(string idContact)
        {
            try
            {
                var DA = new ContactDA(_context);
                var res = DA.Delete_Contact(Convert.ToInt32(idContact));
                await Task.WhenAll(res);

                if (res.Result == 1)
                {
                    return Ok(new ApiResultDTO(1));
                }
                else
                {
                    return BadRequest(new ApiResultDTO(0, "400", "Bad Request"));
                }
            }
            catch (Exception err)
            {
                return BadRequest(new ApiResultDTO("", "400", err.ToString()));
            }
        }
        [Route("loaduserbyid")]
        [HttpGet]
        public async Task<IActionResult> LoadUser_ByID(string idContact)
        {
            var da = new ContactDA(_context);
            try
            {
                var data = await da.LoadUser_ByID(Convert.ToInt32(idContact));
                if (data.Idcontact > 0)
                    return Ok(new ApiResultDTO(data));
                return NotFound(new ApiResultDTO(data, "404", "Not Found"));

            }
            catch (System.Exception)
            {
                return BadRequest(new ApiResultDTO("", "400", "Bag Request"));
            }
        }
        [HttpGet]
        [Route("searchuserbyname")]
        public async Task<IActionResult> SearchUser(string prenom, string idSociete, string idListeService)
        {
            var da = new ContactDA(_context);
            try
            {
                var objUser = await da.SearchUser(prenom, Convert.ToInt32(idSociete), Convert.ToInt32(idListeService));
                if (objUser.Idcontact > 0)
                    return Ok(new ApiResultDTO(objUser));
                return NotFound(new ApiResultDTO(objUser, "404", "Not Found"));
            }
            catch (System.Exception)
            {
                return BadRequest(new ApiResultDTO("", "400", "Bag Request"));
            }
        }
        [HttpGet]
        [Route("loaduserofsociete")]
        public async Task<IActionResult> LoadUserOfSociete(string idSociete, string idListeService)
        {
            var da = new ContactDA(_context);
            try
            {
                var lstUser = await da.LoadUserOfSociete(Convert.ToInt32(idSociete), Convert.ToInt32(idListeService));
                if (lstUser.Count > 0)
                    return Ok(new ApiResultDTO(lstUser));
                return NotFound(new ApiResultDTO(lstUser, "404", "Not Found"));
            }
            catch (System.Exception)
            {
                return BadRequest(new ApiResultDTO("", "400", "Bag Request"));
            }
        }
        [HttpGet]
        [Route("loadfamillefonction")]
        public async Task<IActionResult> LoadData_FamilleFonction()
        {
            var da = new ContactDA(_context);
            try
            {
                var lstUser = await da.LoadData_FamilleFonction();
                if (lstUser.Count > 0)
                    return Ok(new ApiResultDTO(lstUser));
                return NotFound(new ApiResultDTO(lstUser, "404", "Not Found"));
            }
            catch (System.Exception)
            {
                return BadRequest(new ApiResultDTO("", "400", "Bag Request"));
            }
        }
        [HttpGet]
        [Route("loadfonctiongenerique")]
        public async Task<IActionResult> LoadData_FonctionGenerique(string idTypeFonction)
        {
            var da = new ContactDA(_context);
            try
            {
                var lstUser = await da.LoadData_FonctionGenerique(idTypeFonction);
                if (lstUser.Count > 0)
                    return Ok(new ApiResultDTO(lstUser));
                return NotFound(new ApiResultDTO(lstUser, "404", "Not Found"));
            }
            catch (System.Exception)
            {
                return BadRequest(new ApiResultDTO("", "400", "Bag Request"));
            }
        }
    }
}