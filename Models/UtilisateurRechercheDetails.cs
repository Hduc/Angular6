using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class UtilisateurRechercheDetails
    {
        public int IdutilisateurRechercheDetails { get; set; }
        public int IdutilisateurRecherche { get; set; }
        public string RechercheName { get; set; }
        public string RechercheValue { get; set; }
    }
}
