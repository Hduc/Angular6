using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class UtilisateurTacheAutomatique
    {
        public int IdutilisateurTacheAutomatique { get; set; }
        public byte Idstatut { get; set; }
        public string NomTache { get; set; }
        public int Frequence { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string ActionTache { get; set; }
        public bool JoursOuvres { get; set; }
    }
}
