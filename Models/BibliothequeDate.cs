using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class BibliothequeDate
    {
        public int IdbibliothequeDate { get; set; }
        public DateTime BibliothequeDate1 { get; set; }
        public string LibelleDate { get; set; }
        public byte Idstatut { get; set; }
        public short? Ordre { get; set; }
    }
}
