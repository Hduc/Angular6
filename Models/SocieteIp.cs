using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class SocieteIp
    {
        public int SocieteIp1 { get; set; }
        public int Idsociete { get; set; }
        public string Ip { get; set; }
        public string Iddepartement { get; set; }
        public int? Idcontact { get; set; }
        public string Navigateur { get; set; }
        public int? DoublonSteSurIp { get; set; }
    }
}
