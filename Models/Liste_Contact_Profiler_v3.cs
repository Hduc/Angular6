using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public class Liste_Contact_Profiler_v3
    {
        public int IDContact { get; set; }

        public int IDSociete { get; set; }

        public string CiviliteAbrege { get; set; }

        public string PrenomContact { get; set; }

        public string NomContact { get; set; }

        public string TelephoneContact { get; set; }

        public string EmailContact { get; set; }

        public string FonctiongeneriqueContact { get; set; }

        public string FonctionContact { get; set; }

        public string NomSociete { get; set; }

        public string LibelleAPE2008 { get; set; }

        public string TypeEffectif { get; set; }

        public string CodePostal { get; set; }

        public string FonctionGeneriqueAbrege { get; set; }

        public string PortableContact { get; set; }

        public int? NombreRefusEMail { get; set; }

        public byte IDStatut { get; set; }

        public bool? ListeRougeTelephoneSociete { get; set; }

    }
}
