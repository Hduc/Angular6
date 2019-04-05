using System;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
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
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using OfficeOpenXml; // install dotnet add package EPPlus.Core --version 1.5.4
using OfficeOpenXml.Style;
using PremiumcontactMaster.ModelData;

namespace PremiumcontactMaster.Controllers
{
    [Route("api/speedmeeting")]
    public class MeetingController : Controller
    {
        DBContext _context;
        // public MeetingController(DBContext context)
        // {
        //     _context = context;
        // }
        private readonly IHostingEnvironment _hostingEnvironment;

        public MeetingController(IHostingEnvironment hostingEnvironment, DBContext context)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = context;
        }
    

        [HttpGet]
        [Route("export-excel")]
        // IDIntermediation, int IDUser, string nomSociete
        public FileResult ExportExcel(string strName, int intType, int intIdUser, int intIdIntermediation)
        {
            var DA = new Enquete_SocieteDA(_context);
            var lst = Task.FromResult(new List<Model_SpeedMeeting>());
            var lst_Societe = Task.FromResult(new List<Model_SpeedMeeting>());
            // if intType == 1 ? export All : export order chosen Vendeur    
            if (intType == 1)
            {
                lst_Societe = DA.LoadData_SpeedMeeting(intIdIntermediation, intIdUser, "");
            }
            else
            {
                lst_Societe = DA.LoadData_OrderchosenVendeur(intIdIntermediation, intIdUser, "");
            }
            var excelPackage = new ExcelPackage();
            #region Form Confirmation
            DataTable dt = new DataTable();
            var excelFormConfirmation = excelPackage.Workbook.Worksheets.Add("Speep Meeting");

            dt.Columns.Add("1", typeof(string));
            dt.Columns.Add("2", typeof(string));
            dt.Columns.Add("3", typeof(string));
            dt.Columns.Add("4", typeof(string));
            dt.Columns.Add("5", typeof(string));
            dt.Columns.Add("6", typeof(string));
            dt.Columns.Add("7", typeof(string));
            dt.Columns.Add("8", typeof(string));
            dt.Columns.Add("9", typeof(string));

            dt.Rows.Add("Speed Meeting");
            dt.Rows.Add("Date", DateTime.Now);
            dt.Rows.Add("Numéro", "Nom société", "Chiffre d’affaires", "Taille de l'entreprise", "Code APE", "Activite société", "Région", "Fonction(s) représentée(s)", "Fonctions de contact");
            dt.Rows.Add("1", "31.30Z:fabrication de matelas", "de 100 à 500 m€", "BOULOGNE-BILANCOURT (Hauts de seine, Ile de France", "www.cofel.fr", "Directeur des opération, Responsable Technique");
            dt.Rows.Add("2", "31.30Z:fabrication de matelas", "de 100 à 500 m€", "BOULOGNE-BILANCOURT (Hauts de seine, Ile de France", "www.cofel.fr", "Directeur des opération, Responsable Technique");
            dt.Rows.Add("3", "31.30Z:fabrication de matelas", "de 100 à 500 m€", "BOULOGNE-BILANCOURT (Hauts de seine, Ile de France", "www.cofel.fr", "Directeur des opération, Responsable Technique");
            dt.Rows.Add("4", "31.30Z:fabrication de matelas", "de 100 à 500 m€", "BOULOGNE-BILANCOURT (Hauts de seine, Ile de France", "www.cofel.fr", "Directeur des opération, Responsable Technique");
            dt.Rows.Add("5", "31.30Z:fabrication de matelas", "de 100 à 500 m€", "BOULOGNE-BILANCOURT (Hauts de seine, Ile de France", "www.cofel.fr", "Directeur des opération, Responsable Technique");

            int intCurrentRows = 1;
            foreach (var item in lst_Societe.Result)
            {
                dt.Rows.Add(intCurrentRows, item.NomSociete, item.TypeCA, item.TypeEffectif, item.CodeAPE2008, item.ActiviteSociete, item.Region, item.FonctionGenerique, item.FonctionContact);
                intCurrentRows++;
            }
            excelFormConfirmation.Cells["A1"].LoadFromDataTable(dt, true);

            using (var range = excelFormConfirmation.Cells["A1 : I2"])
            {
                range.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                range.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                range.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                range.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                range.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            }
            excelFormConfirmation.Column(1).Width = 10;
            excelFormConfirmation.Column(2).Width = 25;
            excelFormConfirmation.Column(3).Width = 20;
            excelFormConfirmation.Column(4).Width = 20;
            excelFormConfirmation.Column(5).Width = 10;
            excelFormConfirmation.Column(6).Width = 30;
            excelFormConfirmation.Column(7).Width = 15;
            excelFormConfirmation.Column(8).Width = 20;
            excelFormConfirmation.Column(9).Width = 20;

            excelFormConfirmation.Cells["A1:I9"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            excelFormConfirmation.Cells["A1:I9"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(224, 236, 248));
            excelFormConfirmation.Cells["A1:I9"].Style.Font.Size = 14;
            excelFormConfirmation.Row(1).Style.Font.Bold = true;
            excelFormConfirmation.Row(1).Style.Font.Size = 20;
            excelFormConfirmation.Row(2).Style.Font.Bold = true;
            excelFormConfirmation.Row(2).Style.Font.Size = 20;

            for (int index = 0; index < lst_Societe.Result.Count; index++)
            {
                using (var range = excelFormConfirmation.Cells[3 + index, 1, 3 + index, 9])
                {
                    range.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                    range.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    range.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                    range.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                }
            }

            excelFormConfirmation.DeleteRow(1);
            #endregion

            var stream = new MemoryStream(excelPackage.GetAsByteArray());

            return File(stream.ToArray(), "application/vnd.ms-excel", strName.ToString() + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + ".xlsx");
        }

        [HttpGet]
        [Route("getspeedmeeting")]
        public async Task<IActionResult> LoadData_SpeedMeeting(string idIntermediation, string idUser, string nomSociete)
        {
            try
            {
                var DA = new Enquete_SocieteDA(_context);
                var obj = DA.LoadData_SpeedMeeting(Convert.ToInt32(idIntermediation), Convert.ToInt32(idUser), nomSociete);
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
        [Route("getorderchosen")]
        public async Task<IActionResult> LoadData_OrderchosenVendeur(string idIntermediation, string IDUser, string nomSociete)
        {
            try
            {
                var DA = new Enquete_SocieteDA(_context);
                var obj = DA.LoadData_OrderchosenVendeur(Convert.ToInt32(idIntermediation), Convert.ToInt32(IDUser), nomSociete);
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
        [Route("insertorderchosen")]
        public async Task<IActionResult> Insert_Orderchosen(string idEnquete, string idEnqueteSociete)
        {
            try
            {
                var DA = new Enquete_SocieteDA(_context);
                var obj = DA.Insert_Orderchosen(Convert.ToInt32(idEnquete), Convert.ToInt32(idEnqueteSociete));
                await Task.WhenAll(obj);

                if (obj.Result.IDIDEnquete > 0)
                {
                    return Ok(new ApiResultDTO(obj.Result));
                }
                else
                {
                    return BadRequest(new ApiResultDTO(null, "400", "Bad Request"));
                }
            }
            catch (Exception err)
            {
                return BadRequest(new ApiResultDTO("", "400", err.ToString()));
            }
        }

        [HttpPost]
        [Route("deleteorderchosen")]
        public async Task<IActionResult> Delete_Orderchosen(string arrIDEnqueteSociete, string idEnquete)
        {
            try
            {
                var DA = new Enquete_SocieteDA(_context);
                var arrID = arrIDEnqueteSociete.Split(';');
                for (int i = 0; i < arrID.Length; i++)
                {
                    DA.Delete_Orderchosen(Convert.ToInt32(arrID[i]), Convert.ToInt32(idEnquete));
                }
               
                return Ok(new ApiResultDTO(null));

            }
            catch (Exception err)
            {
                return BadRequest(new ApiResultDTO("", "400", err.ToString()));
            }
        }
        [HttpPost]
        [Route("updateorderchose")]
        public async Task<IActionResult> Update_OrderIndex(string idEnquete, string strIdEnqueteSociete)
        {
            try
            {
                var DA = new Enquete_SocieteDA(_context);
                var res = DA.Update_OrderIndex(Convert.ToInt32(idEnquete), strIdEnqueteSociete);
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
    }
}