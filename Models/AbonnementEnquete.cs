using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class AbonnementEnquete
    {
        public int IdabonnementEnquete { get; set; }
        public int Idabonnement { get; set; }
        public short Idenquete { get; set; }
        public int? IdtypeAbonnementEnquete { get; set; }
    }
}
