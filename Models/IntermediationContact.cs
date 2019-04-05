using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class IntermediationContact
    {
        public int IdintermediationContact { get; set; }
        public int IdtypeIntermediation { get; set; }
        public int Idintermediation { get; set; }
        public int Idutilisateur { get; set; }
        public int Idplage { get; set; }
        public string Commentaire { get; set; }
        public DateTime DateIntermediation { get; set; }
        public int? SessionIdacheteur { get; set; }
        public int IdsocieteAcheteur { get; set; }
        public int? IdcontactAcheteur { get; set; }
        public int IdenqueteSocieteAcheteur { get; set; }
        public string Ipacheteur { get; set; }
        public int? OrdreChoixAcheteur { get; set; }
        public DateTime? DateRecapitulatifAcheteur { get; set; }
        public int? SessionIdvendeur { get; set; }
        public int? IdsocieteVendeur { get; set; }
        public int IdcontactVendeur { get; set; }
        public int? IdenqueteSocieteVendeur { get; set; }
        public string Ipvendeur { get; set; }
        public short OrdreChoixVendeur { get; set; }
        public DateTime? DateRecapitulatifVendeur { get; set; }
        public byte Idstatut { get; set; }
        public short? OrdreChoixUtilisateur { get; set; }
        public int? IddocumentVendeur { get; set; }
    }
}
