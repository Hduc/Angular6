using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class FactureRelance
    {
        public int Idrelance { get; set; }
        public int IdtypeRelance { get; set; }
        public int Idstatut { get; set; }
        public int? Idmediatheque { get; set; }
        public int Idecheance { get; set; }
        public DateTime DateRelance { get; set; }
        public DateTime? DateExecutionRelance { get; set; }
        public string Details { get; set; }
    }
}
