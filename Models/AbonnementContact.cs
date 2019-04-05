using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class AbonnementContact
    {
        public int IdabonnementContact { get; set; }
        public int? Idabonnement { get; set; }
        public int? Ididtable { get; set; }
        public int? Idcontact { get; set; }
        public int? Idsociete { get; set; }
        public int? Idutilisateur { get; set; }
        public string Commentaire { get; set; }
        public bool DroitModif { get; set; }
        public bool DroitSup { get; set; }
        public bool DroitAjout { get; set; }
        public bool DroitLecture { get; set; }
        public bool? Export { get; set; }
        public bool? Import { get; set; }
        public decimal? Limite { get; set; }
        public decimal? LimiteAjout { get; set; }
        public DateTime? DateDebutAcces { get; set; }
        public DateTime? DateFinAcces { get; set; }
        public DateTime? DateDebutAdhesion { get; set; }
        public DateTime? DateFinAdhesion { get; set; }
        public byte? Idstatut { get; set; }
        public DateTime? DateCreation { get; set; }
        public int? NombreConnexion { get; set; }
        public int? DureeAbonnement { get; set; }
    }
}
