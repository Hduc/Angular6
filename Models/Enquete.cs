using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class Enquete
    {
        public short Idenquete { get; set; }
        public int IdtypeEnquete { get; set; }
        public int? Idcontact { get; set; }
        public int Idutilisateur { get; set; }
        public string Enquete1 { get; set; }
        public DateTime DateDebutEnquete { get; set; }
        public DateTime DateFinEnquete { get; set; }
        public string TitreNomenclature { get; set; }
        public bool? NomenclatureObligatoire { get; set; }
        public int? IdnomenclatureSelection { get; set; }
        public int? IdsousTypeNomenclature { get; set; }
        public int? IdnomenclatureSelectionAttributionAutomatique { get; set; }
        public int? IdlisteService { get; set; }
        public int? IdlisteSousService { get; set; }
        public int? Idlangue { get; set; }
        public int? Iddocument { get; set; }
        public bool? PourVendeur { get; set; }
        public bool? PourAcheteur { get; set; }
        public int? IddocumentSelection { get; set; }
        public int? IdquestionPardefaut { get; set; }
        public bool? DoublonInterdit { get; set; }
        public bool? AffichageEnTableau { get; set; }
        public bool? SaisieExterne { get; set; }
        public int? GestionDocumentAttache { get; set; }
        public int? IdlisteTypeAutreContact { get; set; }
    }
}
