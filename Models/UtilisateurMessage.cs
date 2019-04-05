using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class UtilisateurMessage
    {
        public int IdutilisateurMessage { get; set; }
        public int IdutilisateurEmeteur { get; set; }
        public DateTime DateMessage { get; set; }
        public string Message { get; set; }
        public short? Idstatut { get; set; }
    }
}
