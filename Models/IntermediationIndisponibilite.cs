using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class IntermediationIndisponibilite
    {
        public int Idparticipant { get; set; }
        public int Idplage { get; set; }
        public int IdtypeIndispo { get; set; }
        public string Indisponibilite { get; set; }
    }
}
