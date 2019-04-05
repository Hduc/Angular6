using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class Aide
    {
        public short Idaide { get; set; }
        public short IdaideParent { get; set; }
        public int? Idstatut { get; set; }
        public int? Idutilisateur { get; set; }
        public string TitreAide { get; set; }
        public string Htmlaide { get; set; }
        public DateTime? DateMajaide { get; set; }
        public short? Ordre { get; set; }
        public string Note { get; set; }
        public string Resume { get; set; }
    }
}
