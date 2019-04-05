using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class Abonnement
    {
        public int Idabonnement { get; set; }
        public int Idutilisateur { get; set; }
        public string Abonnement1 { get; set; }
        public int IdtypeAbonnement { get; set; }
        public int? Idtable { get; set; }
        public int? GestionNomenclature { get; set; }
        public int? IdlisteFiltreApe { get; set; }
        public bool? Modification { get; set; }
        public bool? Suppression { get; set; }
        public bool? Creation { get; set; }
        public bool? Lecture { get; set; }
        public bool? Export { get; set; }
        public bool? Limite { get; set; }
        public byte Idstatut { get; set; }
        public bool? ConnexionPermanente { get; set; }
        public int? AncienIdabonnement { get; set; }
        public string Aide { get; set; }
    }
}
