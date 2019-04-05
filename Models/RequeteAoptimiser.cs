using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class RequeteAoptimiser
    {
        public int Idrequete { get; set; }
        public int? IdorigineRequete { get; set; }
        public int Idutilisateur { get; set; }
        public int? Idmarketing { get; set; }
        public int TempsAffichage { get; set; }
        public DateTime RequeteHeure { get; set; }
        public string Requete { get; set; }
    }
}
