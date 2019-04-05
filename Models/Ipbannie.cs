using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class Ipbannie
    {
        public int Idipbannie { get; set; }
        public string Ip { get; set; }
        public string Motivation { get; set; }
        public byte Idstatut { get; set; }
        public DateTime DateInjectionSql { get; set; }
        public byte Compteur { get; set; }
        public string Commentaires { get; set; }
    }
}
