using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class EnqueteSocieteStatut
    {
        public int IdenqueteSocieteStatut { get; set; }
        public int IdenqueteSociete { get; set; }
        public byte Idstatut { get; set; }
        public byte IdstatutClient { get; set; }
        public int Idutilisateur { get; set; }
        public DateTime DateMajStatut { get; set; }
    }
}
