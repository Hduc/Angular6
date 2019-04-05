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
using System.IO;
using System.Data;
using System.Drawing;
using OfficeOpenXml; // install dotnet add package EPPlus.Core --version 1.5.4
using OfficeOpenXml.Style;
using OfficeOpenXml.Table;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using PremiumcontactMaster.ModelData;

namespace PremiumcontactMaster.Controllers
{
    [Route("api/societe")]
    public class SocieteController : Controller
    {
        DBContext _context;
        public SocieteController(DBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Get(int ID)
        {
            try
            {
                var DA = new Enquete_SocieteDA(_context);
                var obj = DA.LoadSociete(Convert.ToInt32(ID));
                await Task.WhenAll(obj);

                if (obj != null)
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


        [HttpGet]
        [Route("logo")]
        public async Task<IActionResult> LoadSocieteLogo(int ID)
        {
            try
            {
                var DA = new Enquete_SocieteDA(_context);
                var societe = DA.LoadSocieteLogo(ID);
                await Task.WhenAll(societe);

                if (societe != null)
                {
                    return new JsonResult(societe.Result, new JsonSerializerSettings() { Formatting = Formatting.Indented });
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception err)
            {
                return new JsonResult(err.Message, new JsonSerializerSettings() { Formatting = Formatting.Indented });
            }
        }
        // Post Update Societe => profil Société
        [HttpPost]
        [Route("updatesociete")]
        public async Task<IActionResult> Update_Societe([FromBody] Societe Societe)
        {
            try
            {
                var DA = new Enquete_SocieteDA(_context);
                var obj = DA.Update_Societe(Societe);
                await Task.WhenAll(obj);

                if (obj != null)
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
        // get all Liste_Pays
        [HttpGet]
        [Route("listepays")]
        public async Task<IActionResult> Liste_Pays()
        {
            try
            {
                var DA = new Informations_SocieteDA(_context);
                var obj = DA.Liste_Pays();
                await Task.WhenAll(obj);

                if (obj != null)
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
        // get all Type_Effectif
        [HttpGet]
        [Route("typeeffectif")]
        public async Task<IActionResult> Type_Effectif()
        {
            try
            {
                var DA = new Informations_SocieteDA(_context);
                var obj = DA.Type_Effectif();
                await Task.WhenAll(obj);

                if (obj != null)
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
        // get all BibliothequeApe2008
        [HttpGet]
        [Route("codeape2008")]
        public async Task<IActionResult> BibliothequeApe2008()
        {
            try
            {
                var DA = new Informations_SocieteDA(_context);
                var obj = DA.BibliothequeApe2008();
                await Task.WhenAll(obj);

                if (obj != null)
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

        // get all TypeNature
        [HttpGet]
        [Route("typenature")]
        public async Task<IActionResult> TypeNature()
        {
            try
            {
                var DA = new Informations_SocieteDA(_context);
                var obj = DA.TypeNature();
                await Task.WhenAll(obj);

                if (obj != null)
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
        // get all TypeNature
        [HttpGet]
        [Route("formeJuridique")]
        public async Task<IActionResult> FormeJuridique()
        {
            try
            {
                var DA = new Informations_SocieteDA(_context);
                var obj = DA.ListeFormeJuridique();
                await Task.WhenAll(obj);

                if (obj != null)
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
        // get all Type_CA
        [HttpGet]
        [Route("typeCA")]
        public async Task<IActionResult> Type_CA()
        {
            try
            {
                var DA = new Informations_SocieteDA(_context);
                var obj = DA.Type_CA();
                await Task.WhenAll(obj);

                if (obj != null)
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
    }
}