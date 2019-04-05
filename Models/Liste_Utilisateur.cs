using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public class Liste_Utilisateur
    {
        public int IDUtilisateur { get; set; }
        public int IDSocieteUtilisateur { get; set; }
        public string CiviliteAbregeUtilisateur { get; set; }
        public string PrenomUtilisateur { get; set; }
        public string NomUtilisateur { get; set; }
        public string LoginUtilisateur { get; set; }
        public string MotdePasseUtilisateur { get; set; }
        public string EmailUtilisateur { get; set; }
        public string TelephoneUtilisateur { get; set; }
        public int IDTypeUtilisateur { get; set; }
        public string TypeUtilisateur { get; set; }
        public byte IDStatutUtilisateur { get; set; }
        public string FonctionGeneriqueUtilisateur { get; set; }
        public int IDResponsable { get; set; }
        public string StatutUtilisateur { get; set; }
        public string FonctionUtilisateur { get; set; }
        public int? ImportanceTypeUtilisateur { get; set; }
        public string CiviliteUtilisateur { get; set; }
        public string PortableUtilisateur { get; set; }
        public string Priorite { get; set; }
    }
}
