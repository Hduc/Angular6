using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class ImportExportSociete
    {
        public int IdimportExportSociete { get; set; }
        public int IdimportExport { get; set; }
        public int Idresultat { get; set; }
        public int Idsociete { get; set; }
        public DateTime? DateImportExportSociete { get; set; }
    }
}
