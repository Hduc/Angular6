using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class SaisieExterneCommentaire
    {
        public string NomSociete { get; set; }
        public string CodePostal { get; set; }
        public string PrenomContact { get; set; }
        public string NomContact { get; set; }
        public string Commentaire { get; set; }
        public DateTime DateCommentaire { get; set; }
        public int Idutilisateur { get; set; }
    }
}
