using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PremiumcontactMaster.ModelData
{
    public class Model_SpeedMeeting
    {
        public int IDEnquete { get; set; }
        public string CodeAPE2008 { get; set; }
        public DateTime? DateCreationSociete { get; set; }
        public string dejaselectionne { get; set; }
        public int IDEnqueteSociete { get; set; }
        public string CiviliteAbrege { get; set; }
        public string NomContact{get;set;}
        public string FonctionContact{get;set;}
        public string FonctionGenerique{get;set;}
        public string Groupe {get;set;}
        public string NomSociete{get;set;}
        public string ActiviteSociete{get;set;}
        public string Departement{get;set;}
        public string Region{get;set;}
        public string TypeEffectif{get;set;}
        public string TypeCA{get;set;}
        public int IsCheck {get;set;}
        public DateTime DateEnqueteSociete {get;set;}
        public int IDIntermediationContact {get;set;}
    }
}