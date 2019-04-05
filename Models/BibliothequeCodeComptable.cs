using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class BibliothequeCodeComptable
    {
        public int IdbiblioCodeComptable { get; set; }
        public int IdtypeCodeComptable { get; set; }
        public int Ididtable { get; set; }
        public string CodeComptable { get; set; }
    }
}
