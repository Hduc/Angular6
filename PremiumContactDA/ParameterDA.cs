using System;
using System.Linq;
using db = PremiumcontactMaster.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using System.Net;
using PremiumcontactMaster.ModelData;
using System.ComponentModel;
using System.Net.Http;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PremiumcontactMaster.PremiumContactDA
{
    public class ParameterDA
    {
        db.DBContext _context;
        public ParameterDA(db.DBContext context)
        {
            _context = context;
        }
        #region Admin Parametres
        // Insert Parameter
        public async Task<string> Insert_Parameter(db.Liste_Parametres_Service obj)
        {
            try
            {
                
              var parametre = await _context.ParametresService.FirstOrDefaultAsync(x => x.IdparametreService == obj.IDListeService);
                if (parametre == null)
                {
                    var obj_Parameter = new db.ParametresService();
                    obj_Parameter.CodeSiteGoogleAnalytics = obj.CodeSiteGoogleAnalytics;
                    obj_Parameter.LienTweet = obj.Lien_Tweet;
                    obj_Parameter.LienLinkedin = obj.Lien_Linkedin;
                    obj_Parameter.LienFacebook = obj.Lien_Facebook;
                    // obj_Parameter.LienViadeoAsupprimer = 
                    obj_Parameter.CallToAction = obj.CallToAction;
                    // obj_Parameter.IdresponsableVendeur=
                    obj_Parameter.IdadminCommunaute = obj.IDAdminCommunaute;
                    obj_Parameter.BackgroundColor = obj.BackgroundColor;
                    obj_Parameter.TypeEvenement = obj.TypeEvenement;
                    obj_Parameter.IdsiteEvenement = obj.IDSiteEvenement;
                    // obj_Parameter.BaseLine = 
                    obj_Parameter.FonctionAchCible = obj.Fonction_ACH_Cible;
                    obj_Parameter.DefaultFolder = obj.Default_Folder;

                    obj_Parameter.ISActivePUB = obj.ISActivePUB;
                    obj_Parameter.ISActiveAterlie = obj.ISActiveAterlie;
                    obj_Parameter.ODCDate = obj.ODC_Date;
                    obj_Parameter.FDCDate = obj.FDC_Date;

                    obj_Parameter.MapLink = obj.MapLink;
                    obj_Parameter.MapBus = obj.MapBus;
                    obj_Parameter.MapCar = obj.MapCar;
                    obj_Parameter.MapPlane = obj.MapPlane;

                    //save file pub
                    obj_Parameter.PUBFileName = obj.PUB_FileName;
                    obj_Parameter.PUBFilePath = obj.PUB_FilePath;
                    obj_Parameter.PUBFileExtend = obj.PUB_FileExtend;

                    _context.ParametresService.Add(obj_Parameter);
                    _context.SaveChanges();


                }
                return "Succsess";

            }
            catch (System.Exception err)
            {
                return err.ToString();
            }
        }
        public async Task<object> LoadContact_ParameterByID(int IdlisteService)
        {
            var lst = await _context.Liste_Parametres_Service.Where(x => x.IDListeService == IdlisteService)
              .Select(x => new
              {
                  x.IDListeService,
                  x.PrenomResponsable,
                  x.NomResponsable,
                  x.TelephoneResponsable,
                  x.EmailResponsable,
                  x.FonctionResponsable
              }).FirstOrDefaultAsync();
            return lst;
        }
        public async Task<db.Liste_Parametres_Service> LoadAll_ParameterByID(int IdlisteService)
        {
            var lst = await _context.Liste_Parametres_Service.Where(x => x.IDListeService == IdlisteService).FirstOrDefaultAsync();
            return lst;
        }


        #endregion

    }
}
