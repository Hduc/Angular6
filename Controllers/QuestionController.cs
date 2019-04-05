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
    [Route("api/question")]
    public class QuestionController : Controller
    {
        DBContext _context;
        public QuestionController(DBContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("questionbysociete")]
        public async Task<IActionResult> QuestionBySociete(int IDEnqueteSociete)
        {
            try
            {
                var DA = new Question(_context);
                var obj = DA.QuestionBySociete(Convert.ToInt32(IDEnqueteSociete));
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

        [HttpPost]
        [Route("reponse")]
        public async Task<IActionResult> InsertOrUpdateReponse(int idEnqueteSociete, int idQuestion, int typeStockage, string question)
        {
            try
            {
                var DA = new Question(_context);
                var obj = DA.InsertOrUpdateReponse( idEnqueteSociete,  idQuestion,  typeStockage,  question);
                await Task.WhenAll(obj);

                if (obj.Result !=null)
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