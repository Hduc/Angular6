using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PremiumcontactMaster.ModelData
{
    public class Model_EnqueteSociete
    {
        public int Idintermediation { get; set; }
        public string Intermediation { get; set; }
        public int? IDSociete { get; set; }
        public string Lieu { get; set; }
        public DateTime? DateIntermediation { get; set; }
        public int? IdListeService { get; set; }
        public int Count {get; set;}
        public string SousService {get;set;}
        public int? IDListeSousService{get;set;}
        public string SiteWebIntermediation {get; set;}
        public int IDUtilisateur {get;set;}
        public int? IsEventHistory{get;set;}
    }
}