using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public class Parametres_ServicePrograme
    {
        public int IDParametreServicePrograme { get; set; }
        public int IDListeService { get; set; }
        public string Temps { get; set; }
        public string Titres { get; set; }
        public string Contenu { get; set; }
    }
}
