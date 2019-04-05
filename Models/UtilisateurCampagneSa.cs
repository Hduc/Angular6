using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class UtilisateurCampagneSa
    {
        public int IdcampagneSa { get; set; }
        public int Idcontact { get; set; }
        public bool Envoye { get; set; }
        public int? IdcasMailing { get; set; }
        public int ContenuGenere { get; set; }
        public int? Idsociete { get; set; }
        public string PrenomContact { get; set; }
        public string NomContact { get; set; }
        public string Civilite { get; set; }
        public string EmailContact { get; set; }
        public int? IdenqueteSociete { get; set; }
        public int? DejaEnvoye { get; set; }
        public int? Periode { get; set; }
        public string CiviliteAbrege { get; set; }
        public bool? NePasEnvoyer { get; set; }
    }
}
