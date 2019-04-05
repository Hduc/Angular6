using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class Nomenclature
    {
        public short Idnomenclature { get; set; }
        public short? IdappartenanceA { get; set; }
        public short? IdappartenanceB { get; set; }
        public short? IdappartenanceC { get; set; }
        public string Nomenclature1 { get; set; }
        public int Idstatut { get; set; }
        public string NomenclatureMotsCles { get; set; }
        public string IdnomNomenclature { get; set; }
        public short? OrdreNomenclature { get; set; }
        public string Commentaire { get; set; }
        public byte? Profondeur { get; set; }
        public string Commentaire123industries { get; set; }
    }
}
