using System;
using System.Web;
using System.IO;
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
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;

namespace PremiumcontactMaster.Controllers
{
    [Route("api/upload")]
    public class UploadFileController : Controller
    {
        private DBContext _context;
        public UploadFileController(DBContext context)
        {
            _context = context;
        }
        [HttpPost, DisableRequestSizeLimit]
        [Route("logosociete")]
        public async Task<IActionResult> UploadFile(int idSociete, IFormFile file)
        {
            try
            {
                var societe = await _context.view_Liste_Societe_Logo.Where(x => x.IDSociete == idSociete && x.Officiel == true).FirstOrDefaultAsync();
                // var file = Request.Form.Files[0];
                string folderName = "DocumentsPublics/Logosociete";
                string webRootPath = "wwwroot";
                string newPath = Path.Combine(webRootPath, folderName);
                if (!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                }
                if (file.Length > 0 && societe != null)
                {
                    // File name 
                    string fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    string url = "logo_" + fileName.Split('.')[0] + "_" + societe.IDDocument + "." + fileName.Split('.')[1];
                    string fullPath = Path.Combine(newPath, fileName);
                    //save UrlLogo 
                    societe.UrlLogo = folderName + "/" + url;
                    societe.Officiel = true;
                    await _context.SaveChangesAsync();
                    //save img to DocumentsPublics/Logosociete
                    using (var stream = new FileStream(url, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                }

                return Json("Upload Successful.");
            }
            catch (System.Exception ex)
            {
                return Json("Upload Failed: " + ex.Message);
            }
        }
        [HttpPost, DisableRequestSizeLimit]
        [Route("updateAvatarMB")]
        public async Task<IActionResult> updateAvatarMB(string idDocument, string strToken)
        {
            try
            {
                var DA = new Parametres_ServiceProgrameDA(_context);
                List<string> str = new List<string>();
                str.Add(strToken);
                // Decode char token
                var objUser = Commons.Decode(str.ToArray());
                if (objUser.UserName.Trim() != "" && objUser.Password.Trim() != "")
                {
                    var da = new Liste_UtilisateurDA(_context);
                    var data = await da.Login(objUser.UserName, objUser.Password);

                    if (data.IDUtilisateur > 0)
                    {
                        int intIdidDocument = Convert.ToInt32(idDocument);
                        var file = Request.Form.Files[0];
                        string folderName = "FileUpload/Photodidentite";
                        string webRootPath = "wwwroot";
                        string newPath = Path.Combine(webRootPath, folderName);
                        if (!Directory.Exists(newPath))
                        {
                            Directory.CreateDirectory(newPath);
                        }
                        if (file.Length < 1 && intIdidDocument < 1)
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
                        var res = new ContactDA(_context).Update_MediathequeDocument(intIdidDocument, name, extension);
                        await Task.WhenAll(res);

                        if (res.Result == 1)
                        {
                            _context.SaveChanges();
                            return Ok(new ApiResultDTO(1, strToken));
                        }
                        else
                        {
                            return BadRequest(new ApiResultDTO(0, "400", "Bad Request"));
                        }
                    }
                    else
                        return NotFound(new ApiResultDTO(data, "404", "Not Found"));
                }
                else
                    return NotFound(new ApiResultDTO("", "404", "Not Found"));




            }
            catch (System.Exception err)
            {
                return BadRequest(new ApiResultDTO(0, "400", err.ToString()));
            }
        }

    }
}