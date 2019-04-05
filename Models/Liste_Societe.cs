using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public class Liste_Societe
    {
        public int IDSociete { get; set; }
        public string NomSociete { get; set; }
        public string ActiviteSociete { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string Adresse3 { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string TelephoneSociete { get; set; }
        public string FaxSociete { get; set; }
        public string EmailSociete { get; set; }
        public string SiteInternet { get; set; }
        public string KOMPASS { get; set; }
        public string SIRET { get; set; }
        public int IDStatutSociete { get; set; }
        public string StatutSociete { get; set; }
        public string Groupe { get; set; }
        public string ListeBase { get; set; }
        public int IDTypeCA { get; set; }
        public string TypeCA { get; set; }
        public int IDTypeEffectif { get; set; }
        public string TypeEffectif { get; set; }
        public int IDListePays { get; set; }
        public int IDListeFormeJuridique { get; set; }
        public int IDUtilisateur { get; set; }
        public int IDTypeNature { get; set; }
        public int IDGroupeSociete { get; set; }
        public int Old_IDSociete { get; set; }
        public int IDListeBase { get; set; }
        public string CodeAPE { get; set; }
        public string LibelleAPE { get; set; }
        public string Pays { get; set; }
        public string Indicatif { get; set; }
        public string ListeFormeJuridique { get; set; }
        public string CodeAPE2008 { get; set; }
        public string LibelleAPE2008 { get; set; }
        public string LeftCodeAPE3 { get; set; }
        public string LeftCodeAPE2 { get; set; }
        public string LeftCodePostal2 { get; set; }
        public string Region { get; set; }
        public string Departement { get; set; }
        public int IDStatutClient { get; set; }
        public DateTime DateMAJSociete { get; set; }
        public DateTime DateMAJManuelleSociete { get; set; }
        public DateTime DateCreationSociete { get; set; }
        public string ListeRougeTelephoneSociete { get; set; }
    }
}