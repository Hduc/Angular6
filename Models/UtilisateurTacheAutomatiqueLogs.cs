using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class UtilisateurTacheAutomatiqueLogs
    {
        public int IdutilisateurTacheAutomatiqueLogs { get; set; }
        public int IdutilisateurTacheAutomatique { get; set; }
        public byte IdstatutExecution { get; set; }
        public DateTime DateHeureDebutExecution { get; set; }
        public DateTime? DateHeureFinExecution { get; set; }
    }
}
