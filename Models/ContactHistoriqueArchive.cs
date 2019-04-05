using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class ContactHistoriqueArchive
    {
        public int Idhistorique { get; set; }
        public int Idsociete { get; set; }
        public int? Idcontact { get; set; }
        public byte? Idstatut { get; set; }
        public int IdtypeHistorique { get; set; }
        public int Idutilisateur { get; set; }
        public int? Idmediatheque { get; set; }
        public int? IdlisteTable { get; set; }
        public int? Ididtable { get; set; }
        public string Historique { get; set; }
        public DateTime DateHisto { get; set; }
        public int? IdnomenclatureNiv1 { get; set; }
        public int? IdlisteService { get; set; }
        public int? IdlisteSousService { get; set; }
        public int? IdmissionMarketing { get; set; }
        public int? IdenqueteSociete { get; set; }
    }
}
