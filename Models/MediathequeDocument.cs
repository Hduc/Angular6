using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class MediathequeDocument
    {
        public int Iddocument { get; set; }
        public int? IddocumentParent { get; set; }
        public int IdtypeDocument { get; set; }
        public int IdlisteService { get; set; }
        public int? IdlisteSousService { get; set; }
        public int Idsociete { get; set; }
        public int? IdenqueteSociete { get; set; }
        public string NomDocument { get; set; }
        public string Extension { get; set; }
        public int Taille { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateMaj { get; set; }
        public byte Idstatut { get; set; }
        public int Idutilisateur { get; set; }
        public string Commentaire { get; set; }
        public bool? Securise { get; set; }
        public bool? SecuritePublic { get; set; }
        public bool? PourAcheteur { get; set; }
        public bool? PourVendeur { get; set; }
    }
}
