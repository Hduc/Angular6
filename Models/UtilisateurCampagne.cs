using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public partial class UtilisateurCampagne
    {
        public short Idcampagne { get; set; }
        public int IdlisteService { get; set; }
        public int? IdlisteSousService { get; set; }
        public int? IdutilisateurExpediteur { get; set; }
        public int IdmarketingDestinataire { get; set; }
        public bool? Acheteur { get; set; }
        public bool? Vendeur { get; set; }
        public int IdtypeMessage { get; set; }
        public int Iddocument { get; set; }
        public int? IdenqueteCoupon { get; set; }
        public string NomExpediteur { get; set; }
        public string ObjetMessage { get; set; }
        public string ApercuPartiel { get; set; }
        public DateTime? DateEnvoi { get; set; }
        public DateTime? DateFinEnvoi { get; set; }
        public int NombreEnvoye { get; set; }
        public short? NombreDesabonnement { get; set; }
        public short? NombreBadMail { get; set; }
        public short? NombreMailBloques { get; set; }
        public short? NombreNonHtml { get; set; }
        public short? NombreOuverture { get; set; }
        public short? NombreClic { get; set; }
        public short? NombreCoupon { get; set; }
        public short? NombreClient { get; set; }
        public short? NombreClientSuppose { get; set; }
        public short? NombreClientVisiteurSuppose { get; set; }
        public DateTime DateCreation { get; set; }
        public byte Idstatut { get; set; }
        public bool? UtilisationNonRestreinte { get; set; }
        public string ActionUrl { get; set; }
        public string Analyse { get; set; }
        public int? IdstatutEnvoi { get; set; }
        public string Commentaire { get; set; }
        public bool? ParametreForcerEnvoi { get; set; }
        public bool? ParametreEnvoiAncienClient { get; set; }
        public bool? ParametreEnvoiCoupon { get; set; }
        public bool? ParametreEnvoiMailDormant { get; set; }
        public bool? ParametreEnvoiRepNegative { get; set; }
        public bool? ParametreEnvoiChaudSousService { get; set; }
        public bool? ParametreEnvoiOkPrincipe { get; set; }
        public bool? ParametreEnvoiBdcrecu { get; set; }
        public bool? NombreErreurToleree { get; set; }
        public bool? InclureLienVisualisation { get; set; }
    }
}
