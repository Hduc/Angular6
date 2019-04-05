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
using PremiumcontactMaster.Models;

namespace PremiumcontactMaster.PremiumContactDA
{
    public class Parametres_ServiceProgrameDA
    {
        db.DBContext _context;
        public Parametres_ServiceProgrameDA(db.DBContext context)
        {
            _context = context;
        }
        // Insert, update Parametres_ServicePrograme
        public async Task<int> InsertUpdate_Parametres(int IDParametreServicePrograme, int IDListeService, string Temps,string Titres, string  Contenu)
        {
            var obj_Parametres = new db.Parametres_ServicePrograme();
            try
            {
                var idParametreServicePrograme = IDParametreServicePrograme;
                //If idParametreServicePrograme > 0 ? Update : Insert
                if (idParametreServicePrograme > 0)
                {
                    obj_Parametres = await _context.Parametres_ServicePrograme.FirstOrDefaultAsync(x => x.IDParametreServicePrograme == idParametreServicePrograme);
                    obj_Parametres.IDListeService = IDListeService;
                    obj_Parametres.Temps = Temps;
                    obj_Parametres.Titres = Titres;
                    obj_Parametres.Contenu = Contenu;

                    _context.SaveChanges();
                    return 1;
                }
                else
                {
                    obj_Parametres.IDListeService = IDListeService;
                    obj_Parametres.Temps = Temps;
                    obj_Parametres.Titres = Titres;
                    obj_Parametres.Contenu = Contenu;

                    _context.Parametres_ServicePrograme.Add(obj_Parametres);
                    _context.SaveChanges();
                    return 1;
                }
            }
            catch (System.Exception)
            {
                return 0;
            }
        }
        // Load Parametres_ServicePrograme by IDListeService
         public async Task<db.Parametres_ServicePrograme> LoadParametres_byID(int IDParametreServicePrograme)
        {
            var obj = await _context.Parametres_ServicePrograme.FirstOrDefaultAsync(x => x.IDParametreServicePrograme == IDParametreServicePrograme);
            return obj;
        }
         public async Task<List<db.Parametres_ServicePrograme>> LoadData_Parametres(int idListeService)
        {
            var obj = await _context.Parametres_ServicePrograme.Where(x => x.IDListeService == idListeService).Distinct().ToListAsync();
            return obj;
        }
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public async Task<int> Delete_Parametres(int IDParametreServicePrograme)
        {
            var obj = new db.Parametres_ServicePrograme();
            obj = await _context.Parametres_ServicePrograme.FirstOrDefaultAsync(x => x.IDParametreServicePrograme == IDParametreServicePrograme);
            if (obj != null)
            {
                _context.Parametres_ServicePrograme.Remove(obj);
                _context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
