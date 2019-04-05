using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class UtilisateurResultat
    {
        public int Idresultat { get; set; }
        public int Idsociete { get; set; }
        public int? Idcontact { get; set; }
        public int? IdenqueteSociete { get; set; }
        public int? Idmarketing { get; set; }
        public int IdtypeResultat { get; set; }
        public int Idutilisateur { get; set; }
        public DateTime DateResultat { get; set; }
        public DateTime? DateMajresultat { get; set; }
        public byte Idstatut { get; set; }
        public int? Idorigine { get; set; }
        public int? IdlisteSousService { get; set; }
        public bool? MeilleurResultat { get; set; }
    }
}
