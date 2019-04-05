using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class UtilisateurTacheInfo
    {
        public int IdtacheInfo { get; set; }
        public int Idservice { get; set; }
        public int? Idrubrique { get; set; }
        public int Idutilisateur { get; set; }
        public int? Idcontact { get; set; }
        public byte Idstatut { get; set; }
        public string LibelleTache { get; set; }
        public string DetailTache { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateTache { get; set; }
        public DateTime? DateExecution { get; set; }
        public int Duree { get; set; }
        public int TacheOrdre { get; set; }
    }
}
