using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class EmailDemande
    {
        public int IdemailDemande { get; set; }
        public int Idemail { get; set; }
        public int IdtypeDemande { get; set; }
        public int IdlisteService { get; set; }
        public DateTime DateDemande { get; set; }
        public byte Idstatut { get; set; }
    }
}
