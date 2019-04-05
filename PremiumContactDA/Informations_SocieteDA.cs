using System;
using System.Linq;
using db = PremiumcontactMaster.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PremiumcontactMaster.ModelData;
using System.Globalization;
using System.ComponentModel;

namespace PremiumcontactMaster.PremiumContactDA
{
    public class Informations_SocieteDA
    {
        public db.DBContext _context;
        public Informations_SocieteDA(db.DBContext context)
        {
            _context = context;
        }
        #region selection Profil Societe
        public async Task<List<db.Liste_Pays>> Liste_Pays()
        {
            // select * from dbo.Liste_Pays
            var Liste_Pays = new List<db.Liste_Pays>();
            Liste_Pays = await _context.Liste_Pays.ToListAsync();
            return Liste_Pays;
        }

        public async Task<List<db.Type_Effectif>> Type_Effectif()
        {
            // select * from dbo.Type_Effectif
            var Type_Effectif = new List<db.Type_Effectif>();
            Type_Effectif = await _context.Type_Effectif.ToListAsync();
            return Type_Effectif;
        }
        public async Task<List<db.BibliothequeApe2008>> BibliothequeApe2008()
        {
            // select * from dbo.Bibliotheque_APE_2008
            var BibliothequeApe2008 = new List<db.BibliothequeApe2008>();
            BibliothequeApe2008 = await _context.BibliothequeApe2008.ToListAsync();
            return BibliothequeApe2008;
        }
        public async Task<List<db.Type_Nature_Societe>> TypeNature()
        {
            // select * from dbo.Type_Nature_Societe
            var TypeNature = new List<db.Type_Nature_Societe>();
            TypeNature = await _context.Type_Nature_Societe.ToListAsync();
            return TypeNature;
        }
        public async Task<List<db.BibliothequeNiv3>> ListeFormeJuridique()
        {
            //SELECT IDBiblio_Niv3, Biblio_Niv3 FROM dbo.Bibliotheque_Niv3 WHERE IDBiblio_Niv2 = 30
            var ListeFormeJuridique = new List<db.BibliothequeNiv3>();
            ListeFormeJuridique = await _context.BibliothequeNiv3.Where(x => x.IdbiblioNiv2 == 30).ToListAsync();
            return ListeFormeJuridique;
        }
         public async Task<List<db.Type_CA>> Type_CA()
        {
            //SELECT * FROM dbo.Type_CA
            var Type_CA = new List<db.Type_CA>();
            Type_CA = await _context.Type_CA.ToListAsync();
            return Type_CA;
        }
        #endregion

    }
}