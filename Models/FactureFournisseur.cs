using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class FactureFournisseur
    {
        public int IdfactureFournisseur { get; set; }
        public int IdenqueteSociete { get; set; }
        public int IdtypeFactureFournisseur { get; set; }
        public byte Idstatut { get; set; }
        public DateTime? DateFacture { get; set; }
        public string ReferenceFournisseur { get; set; }
        public string ReferenceInterne { get; set; }
        public decimal? TotalTva { get; set; }
        public decimal? TotalHt { get; set; }
        public decimal? TotalTtc { get; set; }
        public string Commentaire { get; set; }
    }
}
