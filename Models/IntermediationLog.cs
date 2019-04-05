using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class IntermediationLog
    {
        public int Idlog { get; set; }
        public int Idintermediation { get; set; }
        public int IdtypeLog { get; set; }
        public int? Idcontact { get; set; }
        public int IdlisteTable { get; set; }
        public int Idutilisateur { get; set; }
        public int Ididtable { get; set; }
        public DateTime HeureLog { get; set; }
        public int Idresultat { get; set; }
    }
}
