using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class SalarieAbsence
    {
        public int IdsalarieAbsence { get; set; }
        public int IdtypeAbsence { get; set; }
        public byte Idstatut { get; set; }
        public int Idcontact { get; set; }
        public int? Idutilisateur { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime? DateValidation { get; set; }
        public double? AbsenceJournee { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string Commentaire { get; set; }
        public DateTime? DateDecomptage { get; set; }
    }
}
