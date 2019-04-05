using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class ContactCoeurDeCible
    {
        public int IdcontactCoeurdeCible { get; set; }
        public int Idcontact { get; set; }
        public short Idenquete { get; set; }
        public int Idutilisateur { get; set; }
        public DateTime DateCoeurdeCible { get; set; }
    }
}
