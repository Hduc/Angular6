using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class UtilisateurPanier
    {
        public int Idpanier { get; set; }
        public int Idutilisateur { get; set; }
        public int? Idicone { get; set; }
        public string NomPanier { get; set; }
    }
}
