using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class NomenclatureCodeApe
    {
        public int IdnomenclatureCodeApe { get; set; }
        public string CodeApe { get; set; }
        public int Idnomenclature { get; set; }
        public bool Achat { get; set; }
        public bool Vente { get; set; }
    }
}
