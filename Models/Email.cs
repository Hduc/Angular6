using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class Email
    {
        public int Idemail { get; set; }
        public int Idstatut { get; set; }
        public string Email1 { get; set; }
        public DateTime DateCreation { get; set; }
        public int? Idorigine { get; set; }
        public int? IdimportExport { get; set; }
        public int? NombreErreur { get; set; }
        public int? NombreReaction { get; set; }
        public int? NombreUtilisation { get; set; }
        public DateTime? DateDerniereErreur { get; set; }
        public DateTime? DateDerniereReaction { get; set; }
        public DateTime? DateDerniereUtilisation { get; set; }
        public int? IdregleNommage { get; set; }
        public string NomdeDomaine { get; set; }
        public int? SessionId { get; set; }
    }
}
