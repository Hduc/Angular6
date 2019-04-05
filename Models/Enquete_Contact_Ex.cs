using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class Enquete_Contact_Ex
    {
        public int ID { get; set; }
        public int IDIDEnquete { get; set; }
        public int IDEnqueteSociete { get; set; }
        public int OrderLevel { get; set; }
    }
}
