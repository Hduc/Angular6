using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class FactureDetail
    {
        public int IdfactureDetail { get; set; }
        public int Idfacture { get; set; }
        public int IdfamillePrestation { get; set; }
        public string Designation { get; set; }
        public decimal MontantHt { get; set; }
        public int? Idabonnement { get; set; }
        public decimal? Remise { get; set; }
        public bool? GestionTva { get; set; }
        public decimal? TauxTva { get; set; }
    }
}
