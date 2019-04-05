using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class MediathequeDocumentLiaison
    {
        public int IdmediathequeDocumentLiaison { get; set; }
        public int IdlisteTable { get; set; }
        public int Ididtable { get; set; }
        public int Iddocument { get; set; }
    }
}
