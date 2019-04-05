using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public class Liste_Sous_Service
    {
        public int IDListeSousService { get; set; }

        public string IDListeSousServiceParent { get; set; }

        public string SousService { get; set; }

        public string IDListeService { get; set; }

        public byte? IDStatut_Biblio_Niv3 { get; set; }

        public bool? ParDefaut { get; set; }

        public string RepertoireSousService { get; set; }

        public string Lieu { get; set; }

        public string IDServiceLieu { get; set; }

        public int? IDNomenclature { get; set; }

        public bool? Dictionnaire { get; set; }

        public short IDBiblio_Niv2 { get; set; }
    }
}
