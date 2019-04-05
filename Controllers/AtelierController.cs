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
    public class AtelierController : Controller
    {
        private DBContext _context;
        public AtelierController(DBContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("listatelier")]
        public async Task<IActionResult> LoadData_Atelier(string idSociete)
        {
            try
            {
                var DA = new ContactDA(_context);
                var obj = DA.LoadData_Atelier(Convert.ToInt32(idSociete));
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
        [Route("insertImgAtelier")]
        public async Task<IActionResult> Insert_Img_Atelier(string idContact)
        {
            var DA = new ContactDA(_context);
            try
            {
                int intIdContact = Convert.ToInt32(idContact);
                var file = Request.Form.Files[0];
                string folderName = "FileUpload/Photodidentite";
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
        [Route("insertatelier")]
        public async Task<IActionResult> Insert_Atelier([FromBody] Model_Contact obj)
        {
            try
            {
                var DA = new ContactDA(_context);
                var res = DA.Insert_Atelier(obj);
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
        [Route("updateatelier")]
        public async Task<IActionResult> Update_Atelier([FromBody] Model_Contact obj)
        {
            try
            {
                var DA = new ContactDA(_context);
                var res = DA.Update_Atelier(obj);
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
        [Route("deletedatelier")]
        public async Task<IActionResult> Delete_Atelier(string idContact)
        {
            try
            {
                var DA = new ContactDA(_context);
                var res = DA.Delete_Atelier(Convert.ToInt32(idContact));
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
        public async Task<IActionResult> LoadUserAtelier_ByID(string idContact)
        {
            var da = new ContactDA(_context);
            try
            {
                var data = await da.LoadUserAtelier_ByID(Convert.ToInt32(idContact));
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
        public async Task<IActionResult> SearchUserAtelier(string prenom, string idSociete, string idListeService)
        {
            var da = new ContactDA(_context);
            try
            {
                var objUser = await da.SearchUserAtelier(prenom, Convert.ToInt32(idSociete), Convert.ToInt32(idListeService));
                if (objUser.Idcontact > 0)
                    return Ok(new ApiResultDTO(objUser));
                return NotFound(new ApiResultDTO(objUser, "404", "Not Found"));
            }
            catch (System.Exception)
            {
                return BadRequest(new ApiResultDTO("", "400", "Bag Request"));
            }
        }
    }
}