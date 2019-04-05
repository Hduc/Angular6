using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class EnqueteSociete
    {
        public int IdenqueteSociete { get; set; }
        public int Idsociete { get; set; }
        public short Idenquete { get; set; }
        public int? IdenqueteSocieteParent { get; set; }
        public int Idcontact { get; set; }
        public byte? Idstatut { get; set; }
        public int? IdstatutClient { get; set; }
        public int? Idutilisateur { get; set; }
        public int? IdutilisateurCreateur { get; set; }
        public DateTime? DateEnqueteSociete { get; set; }
        public DateTime? DateValidation { get; set; }
        public int? AncienId { get; set; }
        public DateTime? DateMajenqueteSociete { get; set; }
    }
}
