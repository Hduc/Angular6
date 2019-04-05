using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class FactureFournisseurEcheance
    {
        public int IdfactureFournisseurEcheance { get; set; }
        public int IdfactureFournisseur { get; set; }
        public DateTime DateEcheance { get; set; }
        public decimal Montant { get; set; }
        public byte Idstatut { get; set; }
        public DateTime? DateReglementEcheance { get; set; }
    }
}
