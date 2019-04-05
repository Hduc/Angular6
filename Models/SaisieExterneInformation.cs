using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class SaisieExterneInformation
    {
        public string NomSociete { get; set; }
        public string CodePostal { get; set; }
        public string PrenomContact { get; set; }
        public string NomContact { get; set; }
        public int Idenquete { get; set; }
        public string IdquestionType { get; set; }
        public int? IdquestionType1 { get; set; }
        public string IdquestionType2 { get; set; }
        public string IdquestionType3 { get; set; }
        public string IdquestionType4 { get; set; }
    }
}
