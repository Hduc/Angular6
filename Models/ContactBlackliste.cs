using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class ContactBlackliste
    {
        public int IdcontactBlackliste { get; set; }
        public string EmailContact { get; set; }
        public int IdlisteService { get; set; }
        public DateTime DateDesabonnement { get; set; }
        public short Idcampagne { get; set; }
    }
}
