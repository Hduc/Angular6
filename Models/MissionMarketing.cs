using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class MissionMarketing
    {
        public int IdmissionMarketing { get; set; }
        public int Idmission { get; set; }
        public int Idsociete { get; set; }
        public int? Idcontact { get; set; }
        public DateTime? DateMiseAdisposition { get; set; }
        public byte NombreAppel { get; set; }
        public DateTime? DateResultat { get; set; }
        public short IdtypeResultat { get; set; }
        public int? Idoperateur { get; set; }
        public bool? AutoAttribution { get; set; }
    }
}
