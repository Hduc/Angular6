using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class EnqueteQuestionHeritage
    {
        public int IdquestionHeritage { get; set; }
        public int IdquestionEnfant { get; set; }
        public int IdquestionParent { get; set; }
    }
}
