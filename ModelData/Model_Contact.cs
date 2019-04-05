using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PremiumcontactMaster.ModelData
{
    public class Model_Contact
    {
        public int Idcontact { get; set; }
        public int IdSociete { get; set; }
        public string NomSociete {get;set;}
        public string PrenomContact { get; set; }
        public string NomContact { get; set; }
        public string TelephoneContact { get; set; }
        public string FonctionContact { get; set; }
        public string EmailContact{get;set;}
        public int Idcivilite{get;set;}
        public string PortableContact{get;set;}
        public int IDListeFonction {get;set;}
        public string FonctionGeneriqueAbrege{get;set;}
        public string FonctionGenerique {get;set;}
        public int IDStatut{get;set;}
        public int? ContactPardefaut{get;set;}
        public string IDTypeFonction{get;set;}
        public int Idutilisateur{get;set;}
        public string PhotoUrl{get;set;}
    }
}