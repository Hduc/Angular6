using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class EnqueteReponse
    {
        public int Idreponse { get; set; }
        public int IdenqueteSociete { get; set; }
        public int Idquestion { get; set; }
        public string ReponseTexte { get; set; }
        public string ReponseMemo { get; set; }
        public DateTime? ReponseDate { get; set; }
        public bool? ReponseBit { get; set; }
        public int? Reponseint { get; set; }
    }
}
