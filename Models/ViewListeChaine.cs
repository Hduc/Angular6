using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class ViewListeChaine
    {
        public int Idchaine { get; set; }
        public string Chaine { get; set; }
        public int? IdchaineLight { get; set; }
        public string UtilisationChaine { get; set; }
        public string VendeurChaine { get; set; }
        public string AcheteurChaine { get; set; }
        public int? Idutilisateur { get; set; }
    }
}
