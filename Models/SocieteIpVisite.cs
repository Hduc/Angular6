using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class SocieteIpVisite
    {
        public int IdsocieteIpVisite { get; set; }
        public int Idsite { get; set; }
        public string Ip { get; set; }
        public DateTime DateVisite { get; set; }
        public int Compteur { get; set; }
        public string Origine { get; set; }
        public string Ordinateur { get; set; }
        public string PageVisitee { get; set; }
        public int? CompteurConversion { get; set; }
        public int? IdlisteSousService { get; set; }
    }
}
