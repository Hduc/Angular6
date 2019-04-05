using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class NavigationNiv2
    {
        public int Idnavigation2 { get; set; }
        public byte Idnavigation1 { get; set; }
        public string Navigation2 { get; set; }
        public string SourceNavigation2 { get; set; }
        public int? OrdreNavigation2 { get; set; }
        public int? ImportanceTypeUtilisateurRequiseNiv2 { get; set; }
        public string IconeNavigation2 { get; set; }
    }
}
