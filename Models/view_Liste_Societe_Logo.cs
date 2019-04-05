using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class view_Liste_Societe_Logo
    {
        public string UrlLogo { get; set; }
        public int IDTypeDocument { get; set; }

        public int IDSociete { get; set; }
        public bool? Officiel { get; set; }
        public int? IDDocument { get; set; }
    }
}
