using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class BibliothequeNiv2
    {
        public short IdbiblioNiv2 { get; set; }
        public byte? IdbiblioNiv1 { get; set; }
        public string BiblioNiv2 { get; set; }
        public int? OrdreNiv2 { get; set; }
        public string DetailBiblioNiv { get; set; }
        public bool? ListeMorte { get; set; }
    }
}
