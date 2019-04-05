using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class MissionTypeResultat
    {
        public short IdmissionTypeResultat { get; set; }
        public short IdmissionTypeResultatParent { get; set; }
        public string TypeResultat { get; set; }
        public bool ImpactGeneral { get; set; }
        public bool? ImpactChaine { get; set; }
        public bool ImpactService { get; set; }
        public bool ImpactSousService { get; set; }
        public bool ContactArgumente { get; set; }
        public bool ArgumentationPositive { get; set; }
        public byte? OrdreProspection { get; set; }
        public string ClassCss { get; set; }
        public short? EtapeQualification { get; set; }
    }
}
