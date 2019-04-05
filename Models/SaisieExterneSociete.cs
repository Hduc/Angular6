using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class SaisieExterneSociete
    {
        public string NomSociete { get; set; }
        public string CodePostal { get; set; }
        public int IdlistePays { get; set; }
        public int IdlisteFormeJuridique { get; set; }
        public int IdtypeCa { get; set; }
        public int IdtypeEffectif { get; set; }
        public int? IdsocieteConfie { get; set; }
        public int Idutilisateur { get; set; }
        public int Idstatut { get; set; }
        public string CodeApe { get; set; }
        public string CodeApe2008 { get; set; }
        public string Groupe { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string Adresse3 { get; set; }
        public string Ville { get; set; }
        public string TelephoneSociete { get; set; }
        public string FaxSociete { get; set; }
        public string EmailSociete { get; set; }
        public string SiteInternet { get; set; }
        public string ActiviteSociete { get; set; }
        public string Siret { get; set; }
    }
}
