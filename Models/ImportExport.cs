using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class ImportExport
    {
        public int IdimportExport { get; set; }
        public int IdtypeImportExport { get; set; }
        public int Idstatut { get; set; }
        public int Idcontact { get; set; }
        public int Idutilisateur { get; set; }
        public int Idsource { get; set; }
        public DateTime DateImportExport { get; set; }
        public int NbreSocieteDepart { get; set; }
        public int NbreContactDepart { get; set; }
        public int NbreProfilDepart { get; set; }
        public int NbreEmailDepart { get; set; }
        public string NomFichier { get; set; }
        public string Instruction { get; set; }
        public string RequeteSql { get; set; }
        public int? IdlisteFonctionParDefaut { get; set; }
    }
}
