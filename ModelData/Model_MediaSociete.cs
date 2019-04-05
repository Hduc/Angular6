using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PremiumcontactMaster.ModelData
{
    public class Model_MediaSociete
    {
      public string  Extension {get; set;}
      public string  NomLogoHD {get; set;}
      public int  IDDocument {get; set;}
      public string  UrlLogo {get; set;}
      public DateTime  DateMaj {get; set;}
      public string  NomUtilisateur {get; set;}
      public string  PrenomUtilisateur {get; set;}
      public string  Officiel {get; set;}
      public string  TypeDocument {get; set;}
      public int  IDTypeDocument {get; set;}
    }
}