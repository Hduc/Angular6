using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public class Liste_Pays
    {
        public int IDListePays { get; set; }

        public string Pays { get; set; }

        public bool? ParDefaut { get; set; }

        public string Indicatif { get; set; }

        public string AbreviationPays { get; set; }
    }
}
