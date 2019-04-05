using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class EnqueteCibleImportVoirImportExportEnquete
    {
        public int IdenqueteCibleImport { get; set; }
        public short Idenquete { get; set; }
        public int IdimportExport { get; set; }
        public int Idutilisateur { get; set; }
        public DateTime Date { get; set; }
    }
}
