using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class Facture
    {
        public int Idfacture { get; set; }
        public int Idcontact { get; set; }
        public int Idsociete { get; set; }
        public int? IdlistePays { get; set; }
        public int? Idabonnement { get; set; }
        public int Idutilisateur { get; set; }
        public int? IdtypeFacture { get; set; }
        public int? Idmediatheque { get; set; }
        public int? Idstatut { get; set; }
        public string NomSociete { get; set; }
        public string Civilite { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string Adresse3 { get; set; }
        public string Cp { get; set; }
        public string Ville { get; set; }
        public DateTime DateFacture { get; set; }
        public string ReferenceFacture { get; set; }
        public string ReferenceFactureParent { get; set; }
        public string ReferenceClient { get; set; }
        public string NumCommande { get; set; }
        public DateTime? DateDebutAbonnement { get; set; }
        public DateTime? DateFinAbonnement { get; set; }
        public decimal? AcompteTtc { get; set; }
        public int? EtatFacture { get; set; }
        public DateTime? DateReglement { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public decimal? Remise { get; set; }
        public decimal? MontantHt { get; set; }
        public double? TvaBkp { get; set; }
        public decimal? Tva { get; set; }
        public string TvanumIntracommunautaire { get; set; }
        public string Commentaire { get; set; }
        public string CommentaireInterne { get; set; }
        public int? DemandeSfac { get; set; }
        public DateTime? DemandeSfacdate { get; set; }
        public int? DeclarationSfac { get; set; }
        public DateTime? DeclarationSfacdate { get; set; }
        public DateTime? DateContrat { get; set; }
        public bool? IdtypeTacite { get; set; }
        public bool? IdstatutTacite { get; set; }
        public DateTime? DateDedonciationTacite { get; set; }
        public int? IdtransactionCyberPlus { get; set; }
        public byte? CommissionCommercial { get; set; }
        public DateTime? DateCreation { get; set; }
        public bool? EnvoiAutoMail { get; set; }
    }
}
