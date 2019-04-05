using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class FactureFamillePrestation
    {
        public int IdfactureFamille { get; set; }
        public int? Idstatut { get; set; }
        public int Idservice { get; set; }
        public string Libelle { get; set; }
        public string Designation { get; set; }
        public int PrixDeVente { get; set; }
        public bool Tacite { get; set; }
        public int? IdtypeAbonnement { get; set; }
        public DateTime? DateSpecifique { get; set; }
        public int? IdsousService { get; set; }
        public string CodeComptable { get; set; }
        public string AxeAnalytique { get; set; }
    }
}
