using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class FactureEcheance
    {
        public int Idecheance { get; set; }
        public int Idfacture { get; set; }
        public int? IdmodePaiement { get; set; }
        public DateTime Echeance { get; set; }
        public decimal MontantEcheance { get; set; }
        public bool Paye { get; set; }
        public DateTime? RecuEcheance { get; set; }
        public byte? IdstatutEcheance { get; set; }
    }
}
