using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class EnqueteCibleSocieteSelection
    {
        public int IdenqueteCibleSocieteSelection { get; set; }
        public short Idenquete { get; set; }
        public int IdsocieteSelection { get; set; }
        public int Idutilisateur { get; set; }
        public DateTime Date { get; set; }
    }
}
