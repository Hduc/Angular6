using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PremiumcontactMaster.ModelData
{
    public class Model_Liste_Fonction
    {
        public string IDTypeFonction { get; set; }

        public string TypeFonction { get; set; }

        public int IDListeFonction { get; set; }

        public string FonctionGenerique { get; set; }

        public int? ImportanceListeFonction { get; set; }

        public string FonctionGeneriqueAbrege { get; set; }

    }
}