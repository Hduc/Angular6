using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class Mission
    {
        public int Idmission { get; set; }
        public int IdtypeMission { get; set; }
        public string Mission1 { get; set; }
        public short Idenquete { get; set; }
        public int IdlisteSousService { get; set; }
        public int? Idcontact { get; set; }
        public int Idutilisateur { get; set; }
        public int Idmarketing { get; set; }
        public DateTime DateDebutMission { get; set; }
        public DateTime DateFinMission { get; set; }
        public short IdstatutMission { get; set; }
    }
}
