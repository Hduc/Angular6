using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class UtilisateurMarketingTmp
    {
        public int SessionId { get; set; }
        public string NomMarketing { get; set; }
        public string RequeteMarketing { get; set; }
        public DateTime DateMarketing { get; set; }
        public int Idutilisateur { get; set; }
        public string MoteurHtml { get; set; }
        public string NomPageListe { get; set; }
        public int? NombreAffichage { get; set; }
    }
}
