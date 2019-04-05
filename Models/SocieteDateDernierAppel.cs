using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class SocieteDateDernierAppel
    {
        public int Idsociete { get; set; }
        public DateTime DateDernierAppel { get; set; }
        public int Idutilisateur { get; set; }
        public string NomUtilisateur { get; set; }
        public string Idhistorique { get; set; }
        public int? Idcontact { get; set; }
    }
}
