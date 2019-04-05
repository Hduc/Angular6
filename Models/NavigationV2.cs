using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class NavigationV2
    {
        public int Idnavigation { get; set; }
        public int IdnavigationParent { get; set; }
        public string Navigation { get; set; }
    }
}
