using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class EnqueteSelectionEnqueteSociete
    {
        public int IdselectionEnqueteSociete { get; set; }
        public int IdabonnementContact { get; set; }
        public int IdenqueteSociete { get; set; }
        public int? Idpanier { get; set; }
        public DateTime DatePanier { get; set; }
        public int Idstatut { get; set; }
        public int Idsociete { get; set; }
        public int IdcontactPrincipal { get; set; }
        public DateTime DateValidation { get; set; }
        public int IdtypeSelectionEnqueteSociete { get; set; }
    }
}
