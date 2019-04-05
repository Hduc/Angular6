using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class SaisieExterneContact
    {
        public string NomSociete { get; set; }
        public string CodePostal { get; set; }
        public int? Idutilisateur { get; set; }
        public int? IdlisteFonction { get; set; }
        public int? Idstatut { get; set; }
        public string PrenomContact { get; set; }
        public string NomContact { get; set; }
        public string TelephoneContact { get; set; }
        public string PortableContact { get; set; }
        public string FaxContact { get; set; }
        public string EmailContact { get; set; }
        public string FonctionContact { get; set; }
    }
}
