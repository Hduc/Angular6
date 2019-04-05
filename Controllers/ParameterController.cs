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
    [Route("api/parametres")]
    public class ParameterController : Controller
    {
        DBContext _context;
        public ParameterController(DBContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("parameter")]
        public async Task<IActionResult> LoadData_ParameterByID(string idListeService)
        {
            try
            {
                var DA = new ParameterDA(_context);
                var obj = DA.LoadAll_ParameterByID(Convert.ToInt32(idListeService));
                await Task.WhenAll(obj);

                if (obj.Result != null)
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
        [HttpPost]
        [Route("insertparameter")]
        public async Task<IActionResult> Insert_ParameterByID( Liste_Parametres_Service liste_parametres_service)
        {
            try
            {
                var DA = new ParameterDA(_context);
                var obj = DA.Insert_Parameter(liste_parametres_service);
                await Task.WhenAll(obj);

                if (obj!= null)
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
        [Route("parametermb")]
        public async Task<IActionResult> LoadContact_ParameterByIDMB(string idListeService, string strToken)
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
                        var pa = new ParameterDA(_context);
                        var obj = pa.LoadContact_ParameterByID(Convert.ToInt32(idListeService));
                        await Task.WhenAll(obj);
                        if (obj.Result != null)
                        {
                            return Ok(new ApiResultDTO(obj.Result, strToken));
                        }
                        else
                        {
                            return NotFound(new ApiResultDTO(obj.Result, "404", "Not Found"));
                        }
                    }
                    else
                    {
                        return NotFound(new ApiResultDTO(data, "404", "Not Found"));
                    }
                }
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