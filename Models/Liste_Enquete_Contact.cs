using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public class Liste_Enquete_Contact
    {
        public int IDEnqueteSociete { get; set; }
        public short IDEnquete { get; set; }
        public int IDSociete { get; set; }
        public int IDContact { get; set; }
        public byte? IDStatut { get; set; }
        public int? IDStatutClient { get; set; }
        public string ContactPrincipal { get; set; }
        public int IDTypeEnquete { get; set; }
        public int? IDListeService { get; set; }
        public bool? Vendeur { get; set; }
        public bool? Acheteur { get; set; }
        public DateTime DateFinEnquete { get; set; }
    }
}
