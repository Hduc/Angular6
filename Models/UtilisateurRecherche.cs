using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class UtilisateurRecherche
    {
        public int IdutilisateurRecherche { get; set; }
        public int IdabonnementContact { get; set; }
        public DateTime DateRecherche { get; set; }
        public string NomRecherche { get; set; }
        public int NombreRecherche { get; set; }
        public int Idstatut { get; set; }
    }
}
