using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class MotsCles
    {
        public int IdmotCles { get; set; }
        public int Idutilisateur { get; set; }
        public string MotCles { get; set; }
        public DateTime DateMotCles { get; set; }
        public bool? Inconnu { get; set; }
    }
}
