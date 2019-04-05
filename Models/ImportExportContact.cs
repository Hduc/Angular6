using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class ImportExportContact
    {
        public int IdimportExportContact { get; set; }
        public int IdimportExport { get; set; }
        public int Idcontact { get; set; }
        public int? Idresultat { get; set; }
        public DateTime? DateImportExportContact { get; set; }
    }
}
