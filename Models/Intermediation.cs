using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class Intermediation
    {
        public int Idintermediation { get; set; }
        public int? IdlisteService { get; set; }
        public int? IdlisteSousService { get; set; }
        public DateTime? DateIntermediation { get; set; }
        public string Intermediation1 { get; set; }
        public string Lieu { get; set; }
        public string Description { get; set; }
        public bool? ChoixdeRdv { get; set; }
        public int? Iddocument { get; set; }
        public short? IdenquetePageWeb { get; set; }
        public int? IdselectionIntermediation { get; set; }
        public int? IdselectionListePlage { get; set; }
        public int? IdselectionListeIndisponibilite { get; set; }
        public string IntituleTypeVendeur { get; set; }
        public short? IdenqueteVendeur { get; set; }
        public int? IdabonnementVendeur { get; set; }
        public int IdutilisateurVendeur { get; set; }
        public string IntituleTypeAcheteur { get; set; }
        public short? IdenqueteAcheteur { get; set; }
        public short? IdenqueteAcheteurBesoin { get; set; }
        public int? IdabonnementAcheteur { get; set; }
        public int? IdutilisateurAcheteur { get; set; }
        public byte Idstatut { get; set; }
        public string SiteWebIntermediation { get; set; }
        public string IntermediationParametres { get; set; }
        public DateTime? OuvertureDateChoix { get; set; }
        public string OuvertureHeureChoix { get; set; }
        public DateTime? FermetureTheoriqueDateChoix { get; set; }
        public string FermetureTheoriqueHeureChoix { get; set; }
        public DateTime? FermetureDateChoix { get; set; }
        public string FermetureHeureChoix { get; set; }
    }
}
