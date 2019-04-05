using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class FactureFournisseurPaiement
    {
        public int IdfactureFournisseurPaiement { get; set; }
        public int IdfactureFournisseur { get; set; }
        public DateTime DateReglement { get; set; }
        public DateTime? DateExpedition { get; set; }
        public int? ModePaiement { get; set; }
        public decimal? MontantPaye { get; set; }
        public string DetailsModePaiement { get; set; }
        public string Notes { get; set; }
    }
}
