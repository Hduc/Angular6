using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class ParametresService
    {
        public int IdparametreService { get; set; }
        public int IdlisteService { get; set; }
        public string CodeSiteGoogleAnalytics { get; set; }
        public string LienTweet { get; set; }
        public string LienLinkedin { get; set; }
        public string LienFacebook { get; set; }
        public string LienViadeoAsupprimer { get; set; }
        public int? IdresponsableVendeur { get; set; }
        public string IdutilisateurVendeur { get; set; }
        public string IdadminCommunaute { get; set; }
        public int IdsiteEvenement { get; set; }
        public string CallToAction { get; set; }
        public string FonctionAchCible { get; set; }
        public string BackgroundColor { get; set; }
        public string TypeEvenement { get; set; }
        public string DefaultFolder { get; set; }
        public string BaseLine { get; set; }
        public bool? ISActivePUB { get; set; }
        public bool? ISActiveAterlie { get; set; }
        public DateTime? ODCDate { get; set; }
        public DateTime? FDCDate { get; set; }
        public string PUBFilePath { get; set; }
        public string PUBFileName { get; set; }
        public string PUBFileExtend { get; set; }
        public string MapLink { get; set; }
        public string MapBus { get; set; }
        public string MapCar { get; set; }
        public string MapPlane { get; set; }
    }
}
