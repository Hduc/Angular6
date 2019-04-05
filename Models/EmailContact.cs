using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class EmailContact
    {
        public int IdemailContact { get; set; }
        public int Idemail { get; set; }
        public string NomContact { get; set; }
        public string PrenomContact { get; set; }
        public string MotdePasse { get; set; }
        public byte? Idstatut { get; set; }
        public string IdnomContact { get; set; }
        public string IdprenomContact { get; set; }
    }
}
