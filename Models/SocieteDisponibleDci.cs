using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class SocieteDisponibleDci
    {
        public int IdenqueteSociete { get; set; }
        public int Idchaine { get; set; }
        public DateTime DateValidation { get; set; }
        public int Idregion { get; set; }
        public bool Projet { get; set; }
        public string Redaction { get; set; }
        public string RedactionBrute { get; set; }
    }
}
