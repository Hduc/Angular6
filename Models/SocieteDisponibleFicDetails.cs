using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class SocieteDisponibleFicDetails
    {
        public int IddisponibleFicdetails { get; set; }
        public int Idsociete { get; set; }
        public int Idchaine { get; set; }
        public int Idcontact { get; set; }
        public DateTime DateDerniereMaj { get; set; }
        public int? IdenqueteSocieteProjet { get; set; }
        public string Redaction { get; set; }
    }
}
