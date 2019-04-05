using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public class Liste_Parametres_Service
    {
        public int IDListeService { get; set; }

        public string Service { get; set; }

        public string ServiceAbrege { get; set; }

        public string Couleur { get; set; }

        public int? IDChaine { get; set; }

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

        public string Lien_Tweet { get; set; }

        public string EmailResponsable { get; set; }

        public string PortableResponsable { get; set; }

        public string NomDomaine { get; set; }

        public string FonctionResponsable { get; set; }

        public string Lien_Linkedin { get; set; }

        public string Lien_Facebook { get; set; }

        public bool? ISActivePUB { get; set; }

        public bool? ISActiveAterlie { get; set; }

        public DateTime? ODC_Date { get; set; }

        public DateTime? FDC_Date { get; set; }
        public string PUB_FilePath { get; set; }
        public string PUB_FileName { get; set; }
        public string PUB_FileExtend { get; set; }
        public string MapLink { get; set; }
        public string MapBus { get; set; }
        public string MapCar { get; set; }
        public string MapPlane { get; set; }

    }
}
