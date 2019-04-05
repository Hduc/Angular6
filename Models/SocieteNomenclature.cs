using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class SocieteNomenclature
    {
        public int Idnomenclature { get; set; }
        public int IdtypeNomenclature { get; set; }
        public int Idutilisateur { get; set; }
        public int Idsociete { get; set; }
        public int? Idcontact { get; set; }
        public int? IdenqueteSociete { get; set; }
        public int? IdabonnementContact { get; set; }
        public int IdnomenclatureSelectionne { get; set; }
        public bool Achat { get; set; }
        public bool Vente { get; set; }
        public byte? NbreInteret { get; set; }
    }
}
