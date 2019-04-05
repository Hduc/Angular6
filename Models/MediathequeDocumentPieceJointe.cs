using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class MediathequeDocumentPieceJointe
    {
        public int IddocumentPieceJointe { get; set; }
        public int IddocumentParent { get; set; }
        public int IddocumentEnfant { get; set; }
    }
}
