using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class UtilisateurCampagneLien
    {
        public int IdcampagneLien { get; set; }
        public short Idcampagne { get; set; }
        public byte NumeroLien { get; set; }
        public string Lien { get; set; }
        public byte Idstatut { get; set; }
    }
}
