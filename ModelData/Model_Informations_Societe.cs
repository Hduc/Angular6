using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PremiumcontactMaster.ModelData
{
    public class Model_Informations_Societe
    {
        public int IDSociete { get; set; }
        public string NomSociete { get; set; }
        public string Groupe { get; set; }
        public string CodeAPE2008 { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string SIRET { get; set; }
        public string TelephoneSociete { get; set; }
        public string FaxSociete { get; set; }
        public string EmailSociete { get; set; }
        public string SiteInternet { get; set; }
        public string ActiviteSociete { get; set; }
        public int? IDTypeNature { get; set; }
        public int? IDTypeEffectif { get; set; }
        public int IDListeFormeJuridique { get; set; }
        public string Pays { get; set; }
        public string TypeCA { get; set; }
        public string ListeFormeJuridique { get; set; }
        public string LibelleAPE2008 { get; set; }
        public string TypeEffectif { get; set; }
    }
}