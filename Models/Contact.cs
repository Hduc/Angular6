using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PremiumcontactMaster.Models
{
    public partial class Contact
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Idcontact { get; set; }
        public string IdnomContact { get; set; }
        public int Idsociete { get; set; }
        public int Idutilisateur { get; set; }
        public int? IdutilisateurCreateur { get; set; }
        public int IdtypeUtilisateur { get; set; }
        public int IdlisteFonction { get; set; }
        public byte Idcivilite { get; set; }
        public byte Idstatut { get; set; }
        public string PrenomContact { get; set; }
        public string NomContact { get; set; }
        public string TelephoneContact { get; set; }
        public string PortableContact { get; set; }
        public string FaxContact { get; set; }
        public string EmailContact { get; set; }
        public string EmailContact2 { get; set; }
        public int? NombreRefusEmail { get; set; }
        public string FonctionContact { get; set; }
        public string Login { get; set; }
        public string MotdePasse { get; set; }
        public bool? Acheteur { get; set; }
        public bool? Vendeur { get; set; }
        public bool? ListeRougeMail { get; set; }
        public bool? ListeRougeFax { get; set; }
        public bool? ListeRougeTelephone { get; set; }
        public decimal? ImportanceContact { get; set; }
        public int? OldIdcontact { get; set; }
        public int? IdlisteBase { get; set; }
        public DateTime? DateMajcontact { get; set; }
        public DateTime? DateMajmanuelleContact { get; set; }
        public DateTime? DateCreationContact { get; set; }
        public bool? MailCorrect { get; set; }
        public bool? ListeRougePortable { get; set; }
    }
}
