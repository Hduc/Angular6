using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class UtilisateurMarketing
    {
        public int Idmarketing { get; set; }
        public byte? Idstatut { get; set; }
        public string NomRequete { get; set; }
        public string Requete { get; set; }
        public string CommentaireMarketing { get; set; }
        public int? IdgroupeMarketing { get; set; }
        public bool? UtilisationListe { get; set; }
        public bool? UtilisationRecherche { get; set; }
        public bool? UtilisationCampagne { get; set; }
        public bool? UtilisationXls { get; set; }
        public DateTime? DateUtilisateurMarketing { get; set; }
        public DateTime? DateMajutilisateurMarketing { get; set; }
        public int? IdlisteService { get; set; }
        public int? IdlisteSousService { get; set; }
        public bool? PourAcheteurs { get; set; }
        public bool? PourVendeurs { get; set; }
        public DateTime? DateDerniereUtilisation { get; set; }
        public int? IdutilisateurCreateur { get; set; }
        public int? NombreSociete { get; set; }
        public int? IdtypeEnquete { get; set; }
    }
}
