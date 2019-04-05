using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class BugLog
    {
        public int Idbug { get; set; }
        public DateTime BugDate { get; set; }
        public int IdtypeBug { get; set; }
        public int? Idutilisateur { get; set; }
        public string Bug { get; set; }
        public string Commentaire { get; set; }
    }
}
