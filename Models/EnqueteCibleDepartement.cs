using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class EnqueteCibleDepartement
    {
        public int IdenqueteCibleDepartement { get; set; }
        public short Idenquete { get; set; }
        public string Iddepartement { get; set; }
        public int Idutilisateur { get; set; }
        public DateTime Date { get; set; }
    }
}
