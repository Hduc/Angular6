using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PremiumcontactMaster.ModelData
{
    public class Model_Liste_Parametres_Service
    {
        public int IDListeService { get; set; }
        public string Service { get; set; }
        public string ServiceAbrege { get; set; }
        public string Couleur { get; set; }
        public int IDChaine { get; set; }
        public string CodeSiteGoogleAnalytics { get; set; }
        public string IDUtilisateurVendeur { get; set; }
        public string IDAdminCommunaute { get; set; }
        public int IDSiteEvenement { get; set; }
        public string CallToAction { get; set; }
        public string Fonction_ACH_Cible { get; set; }
        public string BackgroundColor { get; set; }
        public string TypeEvenement { get; set; }
        public string Default_Folder { get; set; }
        public string PrenomResponsable { get; set; }
        public string NomResponsable { get; set; }
        public string TelephoneResponsable { get; set; }
        public string Lien_Tweetpublic { get; set; }
        public string EmailResponsablepublic { get; set; }
        public string ableResponsablepublic { get; set; }
        public string NomDomainepublic { get; set; }
        public string FonctionResponsablepublic { get; set; }
        public string Lien_Linkedinpublic { get; set; }
        public string Lien_Facebookpublic { get; set; }
        public bool? ISActivePUB { get; set; }
        public bool? ISActiveAterlie { get; set; }
        public DateTime? ODC_Date { get; set; }
        public DateTime? FDC_Date { get; set; }
        public string PUBFilePath { get; set; }
        public string PUBFileName { get; set; }
        public string PUBFileExtend { get; set; }

    }
}
