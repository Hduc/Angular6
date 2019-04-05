using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class ContactEmailDestinaire
    {
        public int IdcontactEmailDestinataire { get; set; }
        public int IdtypeDestinataire { get; set; }
        public string EmailContact { get; set; }
        public int Iddocument { get; set; }
        public string SmtpUtilise { get; set; }
        public int AlerteOuverture { get; set; }
    }
}
