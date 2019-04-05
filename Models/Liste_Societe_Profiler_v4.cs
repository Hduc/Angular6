using System;
using System.Collections.Generic;

namespace PremiumcontactMaster.Models
{
    public class Liste_Societe_Profiler_v4
{
    public int IDSociete { get; set; }

    public string NomSociete { get; set; }

    public string Localisation { get; set; }

    public string LibelleAPE2008 { get; set; }

    public string CodeAPE2008 { get; set; }

    public string TypeEffectifAbrege { get; set; }

    public string IDNomSociete { get; set; }

    public string TypeNature { get; set; }

    public string IcoNature { get; set; }

    public byte IDStatut { get; set; }

    public int IDListePays { get; set; }

    public string LeftCodePostal2 { get; set; }

    public int? IDTypeEffectif { get; set; }

    public string Groupe { get; set; }

    public string CodePostal { get; set; }

    public string TelephoneSociete { get; set; }

    public string Adresse1 { get; set; }

    public string ActiviteSociete { get; set; }

    public string Adresse2 { get; set; }

    public string Ville { get; set; }

    public int? AnneeCapital { get; set; }

    public string SIRET { get; set; }

    public string SiteInternet { get; set; }

    public bool? ListeRougeTelephoneSociete { get; set; }

    public string Indicatif { get; set; }

}
}