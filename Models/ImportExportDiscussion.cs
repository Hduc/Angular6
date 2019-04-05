using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class ImportExportDiscussion
    {
        public int IdimportExportDiscussion { get; set; }
        public int IdimportExport { get; set; }
        public string Notes { get; set; }
        public int DateImportExportDiscussion { get; set; }
        public int Idutilisateur { get; set; }
        public int? Iddocument { get; set; }
    }
}
