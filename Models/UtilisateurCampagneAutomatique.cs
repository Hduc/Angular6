using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class UtilisateurCampagneAutomatique
    {
        public int IdutilisateurCampagneAutomatique { get; set; }
        public short Idcampagne { get; set; }
        public int IdutilisateurTacheAutomatique { get; set; }
        public bool EnregistrementEmail { get; set; }
        public int DureeNonRenvoi { get; set; }
        public bool ForcerEnvoi { get; set; }
        public bool EnvoiClients { get; set; }
        public bool EnvoiAnciensClients { get; set; }
        public bool EnvoiCoupon { get; set; }
        public bool EnvoiJamaisReagi { get; set; }
        public bool LienVisualisation { get; set; }
        public int NombreErreurEmail { get; set; }
    }
}
