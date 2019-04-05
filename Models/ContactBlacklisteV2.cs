using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class ContactBlacklisteV2
    {
        public int IdcontactBlackliste { get; set; }
        public string EmailContact { get; set; }
        public int IdlisteService { get; set; }
        public DateTime DateDesabonnement { get; set; }
        public short? Idcampagne { get; set; }
        public DateTime? DateExpirationDesabonnement { get; set; }
        public bool? Acheteur { get; set; }
        public bool? Vendeur { get; set; }
        public int? Idutilisateur { get; set; }
    }
}
