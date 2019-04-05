using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class BibliothequeNiv3
    {
        public int IdbiblioNiv3 { get; set; }
        public short IdbiblioNiv2 { get; set; }
        public byte? IdstatutBiblioNiv3 { get; set; }
        public string BiblioNiv3 { get; set; }
        public string BiblioNiv3en { get; set; }
        public string BiblioNiv3de { get; set; }
        public string BiblioNiv3es { get; set; }
        public string DetailBiblio { get; set; }
        public string OrdreNiv3 { get; set; }
        public bool? ParDefaut { get; set; }
        public int? OldId { get; set; }
        public bool? Dictionnaire { get; set; }
        public string AutreBiblio { get; set; }
        public string IdnomBiblioNiv3 { get; set; }
        public int? IdutilisateurBiblioNiv3 { get; set; }
    }
}
