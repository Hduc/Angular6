using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class FactureFournisseurSociete
    {
        public int IdfactureFournisseurSociete { get; set; }
        public string NomFournisseur { get; set; }
        public int? IdtypeFournisseur { get; set; }
        public int? Idsociete { get; set; }
    }
}
