using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class NavigationNiv3
    {
        public int Idnavigation3 { get; set; }
        public int Idnavigation2 { get; set; }
        public string Navigation3 { get; set; }
        public string SourceNavigation3 { get; set; }
        public int? ImportanceTypeUtilisateurRequise { get; set; }
    }
}
