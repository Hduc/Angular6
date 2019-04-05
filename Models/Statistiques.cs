using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class Statistiques
    {
        public int Idstatistique { get; set; }
        public int IdtypeStatistique { get; set; }
        public DateTime DateStatistique { get; set; }
        public int NombreStatistique { get; set; }
    }
}
