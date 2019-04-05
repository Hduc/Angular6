using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class UtilisateurTache
    {
        public int Idtache { get; set; }
        public int Idsociete { get; set; }
        public int IdtypeTache { get; set; }
        public int? Idmediatheque { get; set; }
        public int Idutilisateur { get; set; }
        public int? Idcontact { get; set; }
        public byte Idstatut { get; set; }
        public string LibelleTache { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateTache { get; set; }
        public DateTime? DateExecution { get; set; }
        public bool? Alerte { get; set; }
        public int? IdutilisateurCreateur { get; set; }
        public int? Idmission { get; set; }
        public int? IdlisteSousService { get; set; }
        public int? Idenquete { get; set; }
    }
}
