using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class EnqueteSocieteVisite
    {
        public int IdenqueteSocieteVisite { get; set; }
        public int IdenqueteSociete { get; set; }
        public int Idsite { get; set; }
        public DateTime DateVisite { get; set; }
        public string Ip { get; set; }
        public int? Idcompte { get; set; }
    }
}
