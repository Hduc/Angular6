using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PremiumcontactMaster.ModelData
{
    public class Model_Question_Societe
    {
        public int IDEnqueteSociete { get; set; }
        public int IDQuestion { get; set; }
        public string Question { get; set; }
        public int? IDTypeStockageQuestion { get; set; }
    }
}