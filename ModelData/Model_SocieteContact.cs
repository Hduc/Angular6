using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PremiumcontactMaster.ModelData
{
    public class Model_SocieteContact
    {
      public int IDContactVendeur{get;set;}
      public int IDEnqueteSocieteAcheteur {get;set;}
      public int OrdreChoixVendeur{get;set;}
      public int IDPlage{get;set;}
      public int IDEnquete{get;set;}
      public string Region{get;set;}
      public string Departement{get;set;}
      public string NomSociete{get;set;}
      public string CiviliteAbrege{get;set;}
      public string NomContact{get; set;}
    }

}