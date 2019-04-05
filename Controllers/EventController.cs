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
using PremiumcontactMaster.ModelData;

namespace PremiumcontactMaster.Controllers
{
    [Route("api/event")]
    public class EventController : Controller
    {
        DBContext _context;
        public EventController(DBContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("eventwithcount")]
        public async Task<IActionResult> EventWidthCount(int count)
        {
            try
            {
                var DA = new Enquete_SocieteDA(_context);
                var obj = DA.EventWidthCount(Convert.ToInt32(count));
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
        [HttpGet]
        [Route("listevent")]
        public async Task<IActionResult> LoadData_Event(string idUser, string societe)
        {
            try
            {
                var DA = new Enquete_SocieteDA(_context);
                var obj = DA.LoadEvent(Convert.ToInt32(idUser), Convert.ToInt32(societe));
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

        [HttpGet]
        [Route("list-history")]
        public async Task<IActionResult> LoadEvent_CbbHistory(string idUser, string societe)
        {
            try
            {
                var DA = new Enquete_SocieteDA(_context);
                var obj = DA.LoadEvent_CbbHistory(Convert.ToInt32(idUser), Convert.ToInt32(societe));
                await Task.WhenAll(obj);

                if (obj.Result.Count > 0)
                {
                    // return Ok(lstEnqueteSociete.Result);
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
        [Route("geteventbyid")]
        public async Task<IActionResult> LoadSociete_byID(string idIntermediation)
        {
            try
            {
                var DA = new Enquete_SocieteDA(_context);
                var obj = DA.LoadSociete_byID(Convert.ToInt32(idIntermediation));
                await Task.WhenAll(obj);

                if (obj.Result.Idintermediation > 0)
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
        [Route("listsocieteinevent")]
        public async Task<IActionResult> LoadData_SocieteInEvent(string Idintermediation)
        {
            try
            {
                var DA = new Enquete_SocieteDA(_context);
                var obj = DA.LoadData_SocieteInEvent(Convert.ToInt32(Idintermediation));
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


        #region API MOBBILE
        [HttpGet]
        [Route("listeventMB")]
        public async Task<IActionResult> LoadData_EventMB(string societe, string strToken)
        {
            try
            {
                var DA = new Enquete_SocieteDA(_context);

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
                        var obj = DA.LoadEvent(data.IDUtilisateur, Convert.ToInt32(societe));
                        await Task.WhenAll(obj);
                        if (obj.Result.Count > 0)
                            return Ok(new ApiResultDTO(obj.Result, strToken));
                        else
                            return NotFound(new ApiResultDTO(obj.Result, "404", "Not Found"));
                    }
                    else
                        return NotFound(new ApiResultDTO(data, "404", "Not Found"));
                }
                else
                    return NotFound(new ApiResultDTO("", "404", "Not Found"));

            }
            catch (Exception err)
            {
                return BadRequest(new ApiResultDTO("", "400", err.ToString()));
            }
        }


        [HttpGet]
        [Route("listlieumb")]
        public async Task<IActionResult> List_LieuMB(string strToken)
        {
            try
            {
                var DA = new Enquete_SocieteDA(_context);

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
                        var obj = _context.Intermediation.Where(x => x.Lieu != null).Select(x => x.Lieu).Distinct().ToListAsync();
                        await Task.WhenAll(obj);
                        if (obj.Result.Count > 0)
                            return Ok(new ApiResultDTO(obj.Result, strToken));
                        else
                            return NotFound(new ApiResultDTO(obj.Result, "404", "Not Found"));
                    }
                    else
                        return NotFound(new ApiResultDTO(data, "404", "Not Found"));
                }
                else
                    return NotFound(new ApiResultDTO("", "404", "Not Found"));

            }
            catch (Exception err)
            {
                return BadRequest(new ApiResultDTO("", "400", err.ToString()));
            }
        }
        [HttpGet]
        [Route("listintermediationmb")]
        public async Task<IActionResult> List_IntermediationMB(string strToken)
        {
            try
            {
                var DA = new Enquete_SocieteDA(_context);

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
                        var obj = _context.Intermediation.Where(x => x.Intermediation1 != null).Select(x => x.Intermediation1).Distinct().ToListAsync();
                        await Task.WhenAll(obj);
                        if (obj.Result.Count > 0)
                            return Ok(new ApiResultDTO(obj.Result, strToken));
                        else
                            return NotFound(new ApiResultDTO(obj.Result, "404", "Not Found"));
                    }
                    else
                        return NotFound(new ApiResultDTO(data, "404", "Not Found"));
                }
                else
                    return NotFound(new ApiResultDTO("", "404", "Not Found"));

            }
            catch (Exception err)
            {
                return BadRequest(new ApiResultDTO("", "400", err.ToString()));
            }
        }



        [HttpGet]
        [Route("filtereventmb")]
        public async Task<IActionResult> filter_EventMB(string societe, string strToken, string lieu = "", string idIntermediation = "")
        {
            try
            {
                var DA = new Enquete_SocieteDA(_context);

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
                        var obj = DA.LoadEvent(data.IDUtilisateur, Convert.ToInt32(societe), lieu, idIntermediation);
                        await Task.WhenAll(obj);
                        if (obj.Result.Count > 0)
                            return Ok(new ApiResultDTO(obj.Result, strToken));
                        else
                            return NotFound(new ApiResultDTO(obj.Result, "404", "Not Found"));
                    }
                    else
                        return NotFound(new ApiResultDTO(data, "404", "Not Found"));
                }
                else
                    return NotFound(new ApiResultDTO("", "404", "Not Found"));

            }
            catch (Exception err)
            {
                return BadRequest(new ApiResultDTO("", "400", err.ToString()));
            }
        }
        #endregion
    }
}