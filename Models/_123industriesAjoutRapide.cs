using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class _123industriesAjoutRapide
    {
        public int IdajoutRapide { get; set; }
        public int SessionId { get; set; }
        public int Idenquete { get; set; }
        public string Titre { get; set; }
        public string Apercu { get; set; }
        public DateTime DateAjout { get; set; }
        public string MotsCles { get; set; }
        public int? Idchaine { get; set; }
    }
}
