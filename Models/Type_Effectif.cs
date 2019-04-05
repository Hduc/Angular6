using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public class Type_Effectif
    {
        public int IDTypeEffectif { get; set; }
        public string TypeEffectif { get; set; }
        public short IDBiblio_Niv2 { get; set; }
        public bool? ParDefaut { get; set; }
        public string TypeEffectifAbrege { get; set; }
    }
}
