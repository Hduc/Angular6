using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PremiumcontactMaster.ModelData
{
    public class Model_EventSociete
    {
        public int IDEnqueteSociete { get; set; }
        public int IDEnquete { get; set; }
        public int IDSociete { get; set; }
        public DateTime? DateEnqueteSociete { get; set; }
        public string NomSociete { get; set; }
        public string Localisation { get; set; }
        public string LibelleAPE2008 { get; set; }
        public string PrenomContact { get; set; }
        public string NomContact { get; set; }
        public int IDContact { get; set; }
        public string CodeAPE2008 { get; set; }
        public byte? IDStatut { get; set; }
        public int? IDStatutClient { get; set; }
        public string TypeEffectifAbrege { get; set; }
        public string FonctionGeneriqueAbrege { get; set; }
        public int? IDUtilisateur { get; set; }

        public int IDIntermediation { get; set; }
        public int? IDListeService { get; set; }
        public int? IDListeSousService { get; set; }
        public string Apercu { get; set; }
        public string TypeNature { get; set; }
        public string IcoNature { get; set; }
        public int IsCheck_Participants { get; set; }

    }
}