using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class EnqueteSelectionSociete
    {
        public short Idenquete { get; set; }
        public int IdtypePanier { get; set; }
        public int Idsociete { get; set; }
        public DateTime DatePanier { get; set; }
    }
}
