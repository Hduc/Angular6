using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class FactureEncaissement
    {
        public int Idencaissement { get; set; }
        public int? Idecheance { get; set; }
        public int IdtypeModePaiement { get; set; }
        public int Idfacture { get; set; }
        public DateTime DateEncaissement { get; set; }
        public int? IdmoisSalaireXxx { get; set; }
        public decimal MontantEncaissement { get; set; }
        public bool? CorrespondAcompte { get; set; }
        public DateTime? DateTraitementEncaissement { get; set; }
        public DateTime? DateCommission { get; set; }
    }
}
