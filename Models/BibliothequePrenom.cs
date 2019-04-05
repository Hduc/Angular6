using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class BibliothequePrenom
    {
        public int IdbibliothequePrenom { get; set; }
        public int Importance { get; set; }
        public string Prenom { get; set; }
        public byte Civilite { get; set; }
        public string Idprenom { get; set; }
        public bool Mixte { get; set; }
    }
}
