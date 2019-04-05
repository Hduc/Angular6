using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class ContactConnecte
    {
        public int IdcontactConnecte { get; set; }
        public int Idcontact { get; set; }
        public DateTime DateConnection { get; set; }
    }
}
