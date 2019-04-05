using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class EnqueteSelectionSocieteMutualise
    {
        public int IdselectionSocieteMutualise { get; set; }
        public int Idchaine { get; set; }
        public int Idsociete { get; set; }
        public DateTime DateValidation { get; set; }
        public bool ProjetExiste { get; set; }
    }
}
