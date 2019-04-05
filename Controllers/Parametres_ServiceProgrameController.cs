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
    [Route("api/parametresService")]
    public class Parametres_ServiceProgrameController : Controller
    {
        DBContext _context;
        public Parametres_ServiceProgrameController(DBContext context)
        {
            _context = context;
        }
        #region API MOBBILE
        [HttpGet]
        [Route("getbyID_MB")]
        public async Task<IActionResult> LoadData_ParameterByIDMB(int IDParametreServicePrograme, string strToken)
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
                        var obj = DA.LoadParametres_byID(IDParametreServicePrograme);
                        await Task.WhenAll(obj);
                        if (obj.Result != null)
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
        [Route("listParameterMB")]
        public async Task<IActionResult> LoadData_Parameter(string idListeService, string strToken)
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
                        var obj = DA.LoadData_Parametres(Convert.ToInt32(idListeService));
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
        [HttpPost]
        [Route("insertUpdateParameterMB")]
        public async Task<IActionResult> InsertUpdate_Parametres(int IDParametreServicePrograme, int IDListeService, string Temps, string Titres, string Contenu, string strToken)
        {
            var DA = new Parametres_ServiceProgrameDA(_context);

            try
            {
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
                        var res = DA.InsertUpdate_Parametres(IDParametreServicePrograme, IDListeService, Temps, Titres, Contenu);
                        await Task.WhenAll(res);
                        if (res.Result > 0)
                            return Ok(new ApiResultDTO(res.Result,strToken));
                        else
                            return BadRequest(new ApiResultDTO(0, "400", "Bad Request"));
                    }
                    else
                        return NotFound(new ApiResultDTO(data, "404", "Not Found"));
                }
                else
                    return NotFound(new ApiResultDTO("", "404", "Not Found"));
            }
            catch (Exception err)
            {
                return BadRequest(new ApiResultDTO(0, "400", err.ToString()));
            }
        }
        [HttpPost]
        [Route("deletedParameterMB")]
        public async Task<IActionResult> Delete_Parameter(int IDParametreServicePrograme, string strToken)
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
                        var res = DA.Delete_Parametres(IDParametreServicePrograme);
                        await Task.WhenAll(res);

                        if (res.Result == 1)
                            return Ok(new ApiResultDTO(1, strToken));
                        else
                            return BadRequest(new ApiResultDTO(0, "400", "Bad Request"));
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