using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class SalariePaie
    {
        public int IdsalariePaie { get; set; }
        public int Idcontact { get; set; }
        public DateTime Mois { get; set; }
        public byte Idstatut { get; set; }
        public int IdstatutSalarie { get; set; }
        public string PrenomContact { get; set; }
        public string NomContact { get; set; }
        public string FonctionContact { get; set; }
        public DateTime DateEntree { get; set; }
        public DateTime? DateSortie { get; set; }
        public int IdlistePosition { get; set; }
        public int IdlisteCoefficient { get; set; }
        public int IdtypeContrat { get; set; }
        public decimal SalaireBrut { get; set; }
        public decimal CommissionAuto { get; set; }
        public decimal CommissionAjustement { get; set; }
        public decimal Prime { get; set; }
        public decimal? FraisTransport { get; set; }
        public string Absence { get; set; }
        public string AbsenceCp { get; set; }
        public string AbsenceCss { get; set; }
        public string AbsenceAm { get; set; }
        public string Commentaire { get; set; }
    }
}
