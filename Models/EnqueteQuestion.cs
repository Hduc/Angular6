using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class EnqueteQuestion
    {
        public int Idquestion { get; set; }
        public short Idenquete { get; set; }
        public int IdtypeAffichageQuestion { get; set; }
        public int? IdtypeStockageQuestion { get; set; }
        public int? IdtypeValeurQuestion { get; set; }
        public int? IdlisteValeurQuestion { get; set; }
        public string TitreQuestion { get; set; }
        public string Question { get; set; }
        public string QuestionAide { get; set; }
        public string Questionnaire { get; set; }
        public int? OrdreQuestion { get; set; }
        public string ValeurParDefaut { get; set; }
        public bool? NonImprimable { get; set; }
        public bool? AfficheQuestion { get; set; }
        public string ComportementQuestion { get; set; }
        public byte Idstatut { get; set; }
        public int? IdquestionParent { get; set; }
        public bool? Obligatoire { get; set; }
        public int? AutreIdtypeEnquete { get; set; }
        public bool PourRecherche { get; set; }
        public int? OrdreQuestionImpression { get; set; }
    }
}
