using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class UtilisateurObjectif
    {
        public int Idobjectif { get; set; }
        public int IdtypeObjectif { get; set; }
        public int Idutilisateur { get; set; }
        public int IdfactureFamille { get; set; }
        public int Objectif { get; set; }
        public DateTime? DateDebutObjectif { get; set; }
        public DateTime DateFinObjectif { get; set; }
        public int? IdtypeEnqueteCible { get; set; }
    }
}
