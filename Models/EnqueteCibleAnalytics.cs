using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class EnqueteCibleAnalytics
    {
        public int IdenqueteCibleAnalytics { get; set; }
        public short Idenquete { get; set; }
        public int Idsociete { get; set; }
        public int? Idcontact { get; set; }
        public DateTime DateMiseAjour { get; set; }
    }
}
