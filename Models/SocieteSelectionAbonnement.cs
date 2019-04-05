using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class SocieteSelectionAbonnement
    {
        public int IdsocieteSelectionAbonnement { get; set; }
        public int Idsociete { get; set; }
        public int IdabonnementContact { get; set; }
        public int Idpanier { get; set; }
    }
}
