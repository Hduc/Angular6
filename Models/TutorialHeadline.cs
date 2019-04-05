using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class TutorialHeadline
    {
        public int Id { get; set; }
        public string Publisher { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime? ImportDate { get; set; }
        public string Linkurl { get; set; }
        public byte[] MergeHash { get; set; }
    }
}
