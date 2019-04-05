using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class BibliothequeFonctionContact
    {
        public int IdbiblioFonctionContact { get; set; }
        public string FonctionContactBrute { get; set; }
        public int? IdlisteFonction { get; set; }
        public int? IdbiblioFonctionContactParent { get; set; }
        public string IdfonctionContactBrute { get; set; }
        public int? Idcivilite { get; set; }
        public int? Nombre { get; set; }
    }
}
