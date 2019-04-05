using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class Societe
    {
        public int Idsociete { get; set; }
        public string IdnomSociete { get; set; }
        public int? IdsocieteParent { get; set; }
        public int IdlistePays { get; set; }
        public int IdlisteFormeJuridique { get; set; }
        public int Idutilisateur { get; set; }
        public int? IdtypeNature { get; set; }
        public byte Idstatut { get; set; }
        public byte? IdstatutClient { get; set; }
        public string CodeApe { get; set; }
        public string LeftCodeApe3 { get; set; }
        public string LeftCodeApe2 { get; set; }
        public string CodeApe2008 { get; set; }
        public int? IdgroupeSociete { get; set; }
        public string Groupe { get; set; }
        public string NomSociete { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string Adresse3 { get; set; }
        public string CodePostal { get; set; }
        public string LeftCodePostal2 { get; set; }
        public string Ville { get; set; }
        public string TelephoneSociete { get; set; }
        public string FaxSociete { get; set; }
        public string EmailSociete { get; set; }
        public string SiteInternet { get; set; }
        public string ActiviteSociete { get; set; }
        public string Kompass { get; set; }
        public string Siret { get; set; }
        public DateTime? DateFondation { get; set; }
        public string Ca { get; set; }
        public int? IdtypeCa { get; set; }
        public int? AnneeCa { get; set; }
        public string Effectif { get; set; }
        public int? IdtypeEffectif { get; set; }
        public int? AnneeEffectif { get; set; }
        public string Capital { get; set; }
        public int? IdtypeCapital { get; set; }
        public int? AnneeCapital { get; set; }
        public int? OldIdsociete { get; set; }
        public int? IdlisteBase { get; set; }
        public DateTime? DateMajsociete { get; set; }
        public int? IdsocieteProprietaire { get; set; }
        public bool? ListeRougeTelephoneSociete { get; set; }
        public DateTime? DateMajmanuelleSociete { get; set; }
        public DateTime? DateCreationSociete { get; set; }
        public string IdnomVille { get; set; }
    }
}
