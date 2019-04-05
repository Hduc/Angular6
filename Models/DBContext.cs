using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PremiumcontactMaster.Models
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<_123industriesAjoutRapide> _123industriesAjoutRapide { get; set; }
        public virtual DbSet<Abonnement> Abonnement { get; set; }
        public virtual DbSet<AbonnementContact> AbonnementContact { get; set; }
        public virtual DbSet<AbonnementContactCg> AbonnementContactCg { get; set; }
        public virtual DbSet<AbonnementContactStats> AbonnementContactStats { get; set; }
        public virtual DbSet<AbonnementEnquete> AbonnementEnquete { get; set; }
        public virtual DbSet<Aide> Aide { get; set; }
        public virtual DbSet<BibliothequeApe2008> BibliothequeApe2008 { get; set; }
        public virtual DbSet<BibliothequeApe2008Correspondance> BibliothequeApe2008Correspondance { get; set; }
        public virtual DbSet<BibliothequeApe2008Section> BibliothequeApe2008Section { get; set; }
        public virtual DbSet<BibliothequeApe2008SectionLiaison> BibliothequeApe2008SectionLiaison { get; set; }
        public virtual DbSet<BibliothequeCodeComptable> BibliothequeCodeComptable { get; set; }
        public virtual DbSet<BibliothequeDate> BibliothequeDate { get; set; }
        public virtual DbSet<BibliothequeFonctionContact> BibliothequeFonctionContact { get; set; }
        public virtual DbSet<BibliothequeNiv1> BibliothequeNiv1 { get; set; }
        public virtual DbSet<BibliothequeNiv2> BibliothequeNiv2 { get; set; }
        public virtual DbSet<BibliothequeNiv3> BibliothequeNiv3 { get; set; }
        public virtual DbSet<BibliothequePrenom> BibliothequePrenom { get; set; }
        public virtual DbSet<BibliothequeSelection> BibliothequeSelection { get; set; }
        public virtual DbSet<BugLog> BugLog { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<ContactBlackliste> ContactBlackliste { get; set; }
        public virtual DbSet<ContactBlacklisteV2> ContactBlacklisteV2 { get; set; }
        public virtual DbSet<ContactCardex> ContactCardex { get; set; }
        public virtual DbSet<ContactCivilite> ContactCivilite { get; set; }
        public virtual DbSet<ContactCoeurDeCible> ContactCoeurDeCible { get; set; }
        public virtual DbSet<ContactConnecte> ContactConnecte { get; set; }
        public virtual DbSet<ContactEmailDestinaire> ContactEmailDestinaire { get; set; }
        public virtual DbSet<ContactHistorique> ContactHistorique { get; set; }
        public virtual DbSet<ContactHistoriqueArchive> ContactHistoriqueArchive { get; set; }
        public virtual DbSet<ContactHistoriqueMorte> ContactHistoriqueMorte { get; set; }
        public virtual DbSet<ContactPseudo> ContactPseudo { get; set; }
        public virtual DbSet<Email> Email { get; set; }
        public virtual DbSet<EmailContact> EmailContact { get; set; }
        public virtual DbSet<EmailDemande> EmailDemande { get; set; }
        public virtual DbSet<Enquete> Enquete { get; set; }
        public virtual DbSet<EnqueteCibleAnalytics> EnqueteCibleAnalytics { get; set; }
        public virtual DbSet<EnqueteCibleApe> EnqueteCibleApe { get; set; }
        public virtual DbSet<EnqueteCibleDepartement> EnqueteCibleDepartement { get; set; }
        public virtual DbSet<EnqueteCibleFonction> EnqueteCibleFonction { get; set; }
        public virtual DbSet<EnqueteCibleImportVoirImportExportEnquete> EnqueteCibleImportVoirImportExportEnquete { get; set; }
        public virtual DbSet<EnqueteCibleSocieteSelection> EnqueteCibleSocieteSelection { get; set; }
        public virtual DbSet<EnqueteQuestion> EnqueteQuestion { get; set; }
        public virtual DbSet<EnqueteQuestionHeritage> EnqueteQuestionHeritage { get; set; }
        public virtual DbSet<EnqueteQuestionImpression> EnqueteQuestionImpression { get; set; }
        public virtual DbSet<EnqueteQuestionType> EnqueteQuestionType { get; set; }
        public virtual DbSet<EnqueteReponse> EnqueteReponse { get; set; }
        public virtual DbSet<EnqueteSelectionEnqueteSociete> EnqueteSelectionEnqueteSociete { get; set; }
        public virtual DbSet<EnqueteSelectionEnqueteSocieteMutualise> EnqueteSelectionEnqueteSocieteMutualise { get; set; }
        public virtual DbSet<EnqueteSelectionSociete> EnqueteSelectionSociete { get; set; }
        public virtual DbSet<EnqueteSelectionSocieteMutualise> EnqueteSelectionSocieteMutualise { get; set; }
        public virtual DbSet<EnqueteSociete> EnqueteSociete { get; set; }
        public virtual DbSet<EnqueteSocieteStatut> EnqueteSocieteStatut { get; set; }
        public virtual DbSet<EnqueteSocieteVisite> EnqueteSocieteVisite { get; set; }
        public virtual DbSet<Facture> Facture { get; set; }
        public virtual DbSet<FactureDetail> FactureDetail { get; set; }
        public virtual DbSet<FactureEcheance> FactureEcheance { get; set; }
        public virtual DbSet<FactureEncaissement> FactureEncaissement { get; set; }
        public virtual DbSet<FactureFamillePrestation> FactureFamillePrestation { get; set; }
        public virtual DbSet<FactureFournisseur> FactureFournisseur { get; set; }
        public virtual DbSet<FactureFournisseurEcheance> FactureFournisseurEcheance { get; set; }
        public virtual DbSet<FactureFournisseurPaiement> FactureFournisseurPaiement { get; set; }
        public virtual DbSet<FactureFournisseurSociete> FactureFournisseurSociete { get; set; }
        public virtual DbSet<FactureRelance> FactureRelance { get; set; }
        public virtual DbSet<IdnavigationV2Autorisation> IdnavigationV2Autorisation { get; set; }
        public virtual DbSet<ImportExport> ImportExport { get; set; }
        public virtual DbSet<ImportExportContact> ImportExportContact { get; set; }
        public virtual DbSet<ImportExportDiscussion> ImportExportDiscussion { get; set; }
        public virtual DbSet<ImportExportEnquete> ImportExportEnquete { get; set; }
        public virtual DbSet<ImportExportSociete> ImportExportSociete { get; set; }
        public virtual DbSet<Intermediation> Intermediation { get; set; }
        public virtual DbSet<IntermediationContact> IntermediationContact { get; set; }
        public virtual DbSet<IntermediationIndisponibilite> IntermediationIndisponibilite { get; set; }
        public virtual DbSet<IntermediationLog> IntermediationLog { get; set; }
        public virtual DbSet<Ipbannie> Ipbannie { get; set; }
        public virtual DbSet<ListeFournisseur> ListeFournisseur { get; set; }
        public virtual DbSet<MediathequeDocument> MediathequeDocument { get; set; }
        public virtual DbSet<MediathequeDocumentLiaison> MediathequeDocumentLiaison { get; set; }
        public virtual DbSet<MediathequeDocumentPieceJointe> MediathequeDocumentPieceJointe { get; set; }
        public virtual DbSet<Mission> Mission { get; set; }
        public virtual DbSet<MissionMarketing> MissionMarketing { get; set; }
        public virtual DbSet<MissionTypeResultat> MissionTypeResultat { get; set; }
        public virtual DbSet<MotsCles> MotsCles { get; set; }
        public virtual DbSet<NavigationNiv1> NavigationNiv1 { get; set; }
        public virtual DbSet<NavigationNiv2> NavigationNiv2 { get; set; }
        public virtual DbSet<NavigationNiv3> NavigationNiv3 { get; set; }
        public virtual DbSet<NavigationV2> NavigationV2 { get; set; }
        public virtual DbSet<NavigationV2Abonnement> NavigationV2Abonnement { get; set; }
        public virtual DbSet<Nomenclature> Nomenclature { get; set; }
        public virtual DbSet<NomenclatureCodeApe> NomenclatureCodeApe { get; set; }
        public virtual DbSet<NomenclatureGhost> NomenclatureGhost { get; set; }
        public virtual DbSet<NomenclatureSelection> NomenclatureSelection { get; set; }
        public virtual DbSet<ParametresService> ParametresService { get; set; }
        public virtual DbSet<ParametresSousService> ParametresSousService { get; set; }
        public virtual DbSet<RequeteAoptimiser> RequeteAoptimiser { get; set; }
        public virtual DbSet<SaisieExterneCommentaire> SaisieExterneCommentaire { get; set; }
        public virtual DbSet<SaisieExterneContact> SaisieExterneContact { get; set; }
        public virtual DbSet<SaisieExterneInformation> SaisieExterneInformation { get; set; }
        public virtual DbSet<SaisieExterneSociete> SaisieExterneSociete { get; set; }
        public virtual DbSet<Salarie> Salarie { get; set; }
        public virtual DbSet<SalarieAbsence> SalarieAbsence { get; set; }
        public virtual DbSet<SalariePaie> SalariePaie { get; set; }
        public virtual DbSet<Societe> Societe { get; set; }
        public virtual DbSet<SocieteDateDernierAppel> SocieteDateDernierAppel { get; set; }
        public virtual DbSet<SocieteDisponibleDci> SocieteDisponibleDci { get; set; }
        public virtual DbSet<SocieteDisponibleFicDetails> SocieteDisponibleFicDetails { get; set; }
        public virtual DbSet<SocieteDistance> SocieteDistance { get; set; }
        public virtual DbSet<SocieteFormatEmail> SocieteFormatEmail { get; set; }
        public virtual DbSet<SocieteIp> SocieteIp { get; set; }
        public virtual DbSet<SocieteIpVisite> SocieteIpVisite { get; set; }
        public virtual DbSet<SocieteNomenclature> SocieteNomenclature { get; set; }
        public virtual DbSet<SocieteSelectionAbonnement> SocieteSelectionAbonnement { get; set; }
        public virtual DbSet<Statistiques> Statistiques { get; set; }
        public virtual DbSet<Statut> Statut { get; set; }
        public virtual DbSet<TutorialHeadline> TutorialHeadline { get; set; }
        public virtual DbSet<TutorialImport> TutorialImport { get; set; }
        public virtual DbSet<UtilisateurCampagne> UtilisateurCampagne { get; set; }
        public virtual DbSet<UtilisateurCampagneAutomatique> UtilisateurCampagneAutomatique { get; set; }
        public virtual DbSet<UtilisateurCampagneBaseEnvoi> UtilisateurCampagneBaseEnvoi { get; set; }
        public virtual DbSet<UtilisateurCampagneLien> UtilisateurCampagneLien { get; set; }
        public virtual DbSet<UtilisateurCampagneSa> UtilisateurCampagneSa { get; set; }
        public virtual DbSet<UtilisateurMarketing> UtilisateurMarketing { get; set; }
        public virtual DbSet<UtilisateurMarketingTmp> UtilisateurMarketingTmp { get; set; }
        public virtual DbSet<UtilisateurMarketingUtilisateur> UtilisateurMarketingUtilisateur { get; set; }
        public virtual DbSet<UtilisateurMessage> UtilisateurMessage { get; set; }
        public virtual DbSet<UtilisateurObjectif> UtilisateurObjectif { get; set; }
        public virtual DbSet<UtilisateurPanier> UtilisateurPanier { get; set; }
        public virtual DbSet<UtilisateurParametre> UtilisateurParametre { get; set; }
        public virtual DbSet<UtilisateurRecherche> UtilisateurRecherche { get; set; }
        public virtual DbSet<UtilisateurRechercheDetails> UtilisateurRechercheDetails { get; set; }
        public virtual DbSet<UtilisateurResultat> UtilisateurResultat { get; set; }
        public virtual DbSet<UtilisateurTache> UtilisateurTache { get; set; }
        public virtual DbSet<UtilisateurTacheAutomatique> UtilisateurTacheAutomatique { get; set; }
        public virtual DbSet<UtilisateurTacheAutomatiqueLogs> UtilisateurTacheAutomatiqueLogs { get; set; }
        public virtual DbSet<UtilisateurTacheInfo> UtilisateurTacheInfo { get; set; }
        public virtual DbSet<ViewListeChaine> ViewListeChaine { get; set; }
        public virtual DbSet<ViewListeLocalisation> ViewListeLocalisation { get; set; }
        public virtual DbSet<ViewListeLocalisationRegion> ViewListeLocalisationRegion { get; set; }
        public virtual DbSet<ViewTypeSociete> ViewTypeSociete { get; set; }
        public virtual DbSet<Liste_Utilisateur> Liste_Utilisateur { get; set; }
        public virtual DbSet<view_Liste_Societe_Logo> view_Liste_Societe_Logo { get; set; }
        public virtual DbSet<Liste_Enquete_Contact> Liste_Enquete_Contact { get; set; }
        public virtual DbSet<Liste_Fonction> Liste_Fonction { get; set; }
        public virtual DbSet<Type_CA> Type_CA { get; set; }
        public virtual DbSet<Type_Effectif> Type_Effectif { get; set; }
        public virtual DbSet<Enquete_Contact_Ex> Enquete_Contact_Ex { get; set; }
        public virtual DbSet<Liste_Sous_Service> Liste_Sous_Service { get; set; }
        public virtual DbSet<Liste_Societe> Liste_Societe { get; set; }
        public virtual DbSet<Liste_Pays> Liste_Pays { get; set; }
        public virtual DbSet<Type_Nature_Societe> Type_Nature_Societe { get; set; }
        public virtual DbSet<Liste_Societe_Profiler_v4> Liste_Societe_Profiler_v4 { get; set; }
        public virtual DbSet<Liste_Contact_Profiler_v3> Liste_Contact_Profiler_v3 { get; set; }
        public virtual DbSet<Liste_Contact_PhotoID> Liste_Contact_PhotoID { get; set; }
        public virtual DbSet<liste_Contact_Erreur> liste_Contact_Erreur { get; set; }
        public virtual DbSet<Contact_ReseauSocial> Contact_ReseauSocial { get; set; }
        public virtual DbSet<Type_ReseauSocial> Type_ReseauSocial { get; set; }
        public virtual DbSet<Liste_Parametres_Service> Liste_Parametres_Service { get; set; }
        public virtual DbSet<Parametres_ServicePrograme> Parametres_ServicePrograme { get; set; }





        // Unable to generate entity type for table 'dbo.Contact_ReseauSocial'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Contact_Telephone'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.view_Liste_Localisation_Departement_Limitrophe'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Enquete_Famille'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Enquete_Parent'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Enquete_Question_SuggestionListeItem'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Enquete_Question_SuggestionListeItemBanni'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Enquete_Contact'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Contact_Selection'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Societe_Selection'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Facture_Fournisseur_Service_Ventilation'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Facture_Intermediation_Contact'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Facture_Service'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Intermediation_Chaine'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Mediatheque_ExtensionStyle'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Mission_Marketing_BKP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Nomenclature_Famille'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Enquete_SousService'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Utilisateur_Campagne_Lien_Tracke'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Societe_IDSocieteSupprime'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Societe_Nomenclature_TMP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Societe_Type'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Statistique_Heure'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Utilisateur_Campagne_BaseEnvoi_Final'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Utilisateur_Campagne_Lien_Tracke_Archive'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Utilisateur_Campagne_Statistiques_Details'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Utilisateur_Marketing_Confiee'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.view_Liste_Societe_Logo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Utilisateur_Message_DerniereVisite'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo._______TMP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo._______TMP2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Utilisateur_Resultat_Archive'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Utilisateur_SocieteEncours'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo._123Industries_info_apercu'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Societe_Disponible_DCI_Nomenclature'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo._Aide_Tmp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo._bkp_enquetequestion'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo._Bot_Visite'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.view_Liste_Contact_Reaction_Service'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.view_Liste_Societe_Doublon'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.view_Liste_Utilisateur_Resultat_UNION_IDSociete'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo._outils_correspondance'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Bibliotheque_Ville'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo._Statut_Double'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Abonnement_Contact_IDChaine'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Contact_EmailContact_Invente'. Please see the warning messages.


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<_123industriesAjoutRapide>(entity =>
            {
                entity.HasKey(e => e.IdajoutRapide);

                entity.ToTable("_123industries_Ajout_Rapide");

                entity.Property(e => e.IdajoutRapide).HasColumnName("IDAjoutRapide");

                entity.Property(e => e.Apercu).HasColumnType("text");

                entity.Property(e => e.DateAjout).HasColumnType("datetime");

                entity.Property(e => e.Idchaine).HasColumnName("IDChaine");

                entity.Property(e => e.Idenquete).HasColumnName("IDEnquete");

                entity.Property(e => e.MotsCles)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.Titre)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Abonnement>(entity =>
            {
                entity.HasKey(e => e.Idabonnement);

                entity.Property(e => e.Idabonnement).HasColumnName("IDAbonnement");

                entity.Property(e => e.Abonnement1)
                    .IsRequired()
                    .HasColumnName("Abonnement")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Aide).HasColumnType("text");

                entity.Property(e => e.AncienIdabonnement).HasColumnName("AncienIDAbonnement");

                entity.Property(e => e.IdlisteFiltreApe).HasColumnName("IDListeFiltreAPE");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.Idtable).HasColumnName("IDTable");

                entity.Property(e => e.IdtypeAbonnement).HasColumnName("IDTypeAbonnement");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");
            });

            modelBuilder.Entity<AbonnementContact>(entity =>
            {
                entity.HasKey(e => e.IdabonnementContact);

                entity.ToTable("Abonnement_Contact");

                entity.Property(e => e.IdabonnementContact).HasColumnName("IDAbonnementContact");

                entity.Property(e => e.Commentaire)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.DateDebutAcces).HasColumnType("datetime");

                entity.Property(e => e.DateDebutAdhesion).HasColumnType("datetime");

                entity.Property(e => e.DateFinAcces).HasColumnType("datetime");

                entity.Property(e => e.DateFinAdhesion).HasColumnType("datetime");

                entity.Property(e => e.Idabonnement).HasColumnName("IDAbonnement");

                entity.Property(e => e.Idcontact).HasColumnName("IDContact");

                entity.Property(e => e.Ididtable).HasColumnName("IDIDTable");

                entity.Property(e => e.Idsociete).HasColumnName("IDSociete");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");

                entity.Property(e => e.Limite).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.LimiteAjout).HasColumnType("numeric(10, 0)");
            });

            modelBuilder.Entity<AbonnementContactCg>(entity =>
            {
                entity.HasKey(e => e.IdabonnementContactCgu);

                entity.ToTable("Abonnement_Contact_CG");

                entity.Property(e => e.IdabonnementContactCgu).HasColumnName("IDAbonnementContactCGU");

                entity.Property(e => e.DateCg)
                    .HasColumnName("DateCG")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdabonnementContact).HasColumnName("IDAbonnementContact");

                entity.Property(e => e.Idcontact).HasColumnName("IDContact");
            });

            modelBuilder.Entity<AbonnementContactStats>(entity =>
            {
                entity.HasKey(e => e.IdabonnementContact);

                entity.ToTable("Abonnement_Contact_Stats");

                entity.Property(e => e.IdabonnementContact)
                    .HasColumnName("IDAbonnementContact")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<AbonnementEnquete>(entity =>
            {
                entity.HasKey(e => e.IdabonnementEnquete);

                entity.ToTable("Abonnement_Enquete");

                entity.Property(e => e.IdabonnementEnquete).HasColumnName("IDAbonnementEnquete");

                entity.Property(e => e.Idabonnement).HasColumnName("IDAbonnement");

                entity.Property(e => e.Idenquete).HasColumnName("IDEnquete");

                entity.Property(e => e.IdtypeAbonnementEnquete).HasColumnName("IDTypeAbonnementEnquete");
            });

            modelBuilder.Entity<Aide>(entity =>
            {
                entity.HasKey(e => e.Idaide);

                entity.ToTable("_Aide");

                entity.Property(e => e.Idaide).HasColumnName("IDAide");

                entity.Property(e => e.DateMajaide)
                    .HasColumnName("DateMAJAide")
                    .HasColumnType("datetime");

                entity.Property(e => e.Htmlaide)
                    .HasColumnName("HTMLAide")
                    .HasColumnType("text");

                entity.Property(e => e.IdaideParent).HasColumnName("IDAideParent");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");

                entity.Property(e => e.Note)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Resume)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TitreAide)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BibliothequeApe2008>(entity =>
            {
                entity.HasKey(e => e.Idape2008);

                entity.ToTable("Bibliotheque_APE_2008");

                entity.Property(e => e.Idape2008)
                    .HasColumnName("IDAPE2008")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CodeApe2003pardefaut)
                    .HasColumnName("CodeAPE2003pardefaut")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdlibelleApe2008)
                    .HasColumnName("IDLibelleAPE2008")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Idniveau).HasColumnName("IDNiveau");

                entity.Property(e => e.IdnomenclatureEquivalente).HasColumnName("IDNomenclatureEquivalente");

                entity.Property(e => e.LeftIdape20082)
                    .HasColumnName("leftIDAPE20082")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LeftIdape20083)
                    .HasColumnName("leftIDAPE20083")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.LeftIdape20084)
                    .HasColumnName("leftIDAPE20084")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LeftIdape20085)
                    .HasColumnName("leftIDAPE20085")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LibelleApe2008)
                    .IsRequired()
                    .HasColumnName("LibelleAPE2008")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LibelleApe2008abrege)
                    .HasColumnName("LibelleAPE2008Abrege")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BibliothequeApe2008Correspondance>(entity =>
            {
                entity.HasKey(e => e.Numéro);

                entity.ToTable("Bibliotheque_APE_2008_Correspondance");

                entity.Property(e => e.Numéro).ValueGeneratedNever();

                entity.Property(e => e.Champ9).HasMaxLength(255);

                entity.Property(e => e.CodeApe)
                    .HasColumnName("CodeAPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodeApe2008)
                    .HasColumnName("CodeAPE2008")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Commentaires).HasMaxLength(255);

                entity.Property(e => e.DateModiff).HasColumnType("smalldatetime");

                entity.Property(e => e.DateValidation).HasColumnType("datetime");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");

                entity.Property(e => e.Naf1RangLien).HasColumnName("NAF 1 rang lien");

                entity.Property(e => e.Naf2000)
                    .HasColumnName("naf2000")
                    .HasMaxLength(255);

                entity.Property(e => e.Naf2000Libelle)
                    .HasColumnName("naf2000_Libelle")
                    .HasMaxLength(255);

                entity.Property(e => e.Naf2008)
                    .HasColumnName("naf2008")
                    .HasMaxLength(255);

                entity.Property(e => e.Naf2008Libelle)
                    .HasColumnName("naf2008_Libelle")
                    .HasMaxLength(255);

                entity.Property(e => e.Naf2RangLien).HasColumnName("NAF 2 rang lien");

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e._0).HasColumnName("0");
            });

            modelBuilder.Entity<BibliothequeApe2008Section>(entity =>
            {
                entity.HasKey(e => e.Idsection);

                entity.ToTable("Bibliotheque_APE_2008_Section");

                entity.Property(e => e.Idsection).HasColumnName("IDSection");

                entity.Property(e => e.CodeSection)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Section)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BibliothequeApe2008SectionLiaison>(entity =>
            {
                entity.HasKey(e => e.IdsectionLiaison);

                entity.ToTable("Bibliotheque_APE_2008_Section_Liaison");

                entity.Property(e => e.IdsectionLiaison).HasColumnName("IDSectionLiaison");

                entity.Property(e => e.CodeSection)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LeftIdape20082)
                    .IsRequired()
                    .HasColumnName("leftIDAPE20082")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BibliothequeCodeComptable>(entity =>
            {
                entity.HasKey(e => e.IdbiblioCodeComptable);

                entity.ToTable("Bibliotheque_CodeComptable");

                entity.Property(e => e.IdbiblioCodeComptable).HasColumnName("IDBiblio_CodeComptable");

                entity.Property(e => e.CodeComptable)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ididtable).HasColumnName("IDIDTable");

                entity.Property(e => e.IdtypeCodeComptable).HasColumnName("IDTypeCodeComptable");
            });

            modelBuilder.Entity<BibliothequeDate>(entity =>
            {
                entity.HasKey(e => e.IdbibliothequeDate);

                entity.ToTable("Bibliotheque_Date");

                entity.Property(e => e.IdbibliothequeDate).HasColumnName("IDBibliotheque_Date");

                entity.Property(e => e.BibliothequeDate1)
                    .HasColumnName("Bibliotheque_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.LibelleDate)
                    .IsRequired()
                    .HasColumnName("Libelle_Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BibliothequeFonctionContact>(entity =>
            {
                entity.HasKey(e => e.IdbiblioFonctionContact);

                entity.ToTable("Bibliotheque_FonctionContact");

                entity.Property(e => e.IdbiblioFonctionContact).HasColumnName("IDBiblioFonctionContact");

                entity.Property(e => e.FonctionContactBrute)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IdbiblioFonctionContactParent).HasColumnName("IDBiblioFonctionContactParent");

                entity.Property(e => e.Idcivilite).HasColumnName("IDCivilite");

                entity.Property(e => e.IdfonctionContactBrute)
                    .HasColumnName("IDFonctionContactBrute")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IdlisteFonction).HasColumnName("IDListeFonction");
            });

            modelBuilder.Entity<BibliothequeNiv1>(entity =>
            {
                entity.HasKey(e => e.IdbiblioNiv1);

                entity.ToTable("Bibliotheque_Niv1");

                entity.Property(e => e.IdbiblioNiv1)
                    .HasColumnName("IDBiblioNiv1")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BiblioNiv1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BibliothequeNiv2>(entity =>
            {
                entity.HasKey(e => e.IdbiblioNiv2);

                entity.ToTable("Bibliotheque_Niv2");

                entity.Property(e => e.IdbiblioNiv2).HasColumnName("IDBiblioNiv2");

                entity.Property(e => e.BiblioNiv2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailBiblioNiv)
                    .HasColumnName("DetailBiblio_Niv")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdbiblioNiv1).HasColumnName("IDBiblioNiv1");

                entity.Property(e => e.OrdreNiv2).HasColumnName("Ordre_Niv2");
            });

            modelBuilder.Entity<BibliothequeNiv3>(entity =>
            {
                entity.HasKey(e => e.IdbiblioNiv3);

                entity.ToTable("Bibliotheque_Niv3");

                entity.Property(e => e.IdbiblioNiv3).HasColumnName("IDBiblio_Niv3");

                entity.Property(e => e.AutreBiblio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BiblioNiv3)
                    .IsRequired()
                    .HasColumnName("Biblio_Niv3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BiblioNiv3de)
                    .HasColumnName("Biblio_Niv3de")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BiblioNiv3en)
                    .HasColumnName("Biblio_Niv3en")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BiblioNiv3es)
                    .HasColumnName("Biblio_Niv3es")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DetailBiblio)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IdbiblioNiv2).HasColumnName("IDBiblio_Niv2");

                entity.Property(e => e.IdnomBiblioNiv3)
                    .HasColumnName("IDNomBiblio_Niv3")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IdstatutBiblioNiv3).HasColumnName("IDStatut_Biblio_Niv3");

                entity.Property(e => e.IdutilisateurBiblioNiv3).HasColumnName("IDUtilisateurBiblio_Niv3");

                entity.Property(e => e.OldId).HasColumnName("OLD_ID");

                entity.Property(e => e.OrdreNiv3)
                    .HasColumnName("Ordre_Niv3")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BibliothequePrenom>(entity =>
            {
                entity.HasKey(e => e.IdbibliothequePrenom);

                entity.ToTable("Bibliotheque_Prenom");

                entity.Property(e => e.IdbibliothequePrenom).HasColumnName("IDBibliothequePrenom");

                entity.Property(e => e.Idprenom)
                    .HasColumnName("IDPrenom")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Prenom)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BibliothequeSelection>(entity =>
            {
                entity.HasKey(e => new { e.IdbiblioSelection, e.IdbiblioNiv3, e.Idstatut });

                entity.ToTable("Bibliotheque_Selection");

                entity.Property(e => e.IdbiblioSelection).HasColumnName("IDBiblioSelection");

                entity.Property(e => e.IdbiblioNiv3).HasColumnName("IDBiblio_Niv3");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");
            });

            modelBuilder.Entity<BugLog>(entity =>
            {
                entity.HasKey(e => e.Idbug);

                entity.ToTable("_BUG_Log");

                entity.Property(e => e.Idbug).HasColumnName("IDBug");

                entity.Property(e => e.Bug)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BugDate).HasColumnType("datetime");

                entity.Property(e => e.Commentaire).HasColumnType("text");

                entity.Property(e => e.IdtypeBug).HasColumnName("IDTypeBug");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasKey(e => e.Idcontact);

                entity.Property(e => e.Idcontact).HasColumnName("IDContact");

                entity.Property(e => e.DateCreationContact).HasColumnType("datetime");

                entity.Property(e => e.DateMajcontact)
                    .HasColumnName("DateMAJContact")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateMajmanuelleContact)
                    .HasColumnName("DateMAJManuelleContact")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmailContact)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmailContact2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FaxContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FonctionContact)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Idcivilite).HasColumnName("IDCivilite");

                entity.Property(e => e.IdlisteBase).HasColumnName("IDListeBase");

                entity.Property(e => e.IdlisteFonction).HasColumnName("IDListeFonction");

                entity.Property(e => e.IdnomContact)
                    .HasColumnName("IDNomContact")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Idsociete).HasColumnName("IDSociete");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.IdtypeUtilisateur).HasColumnName("IDTypeUtilisateur");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");

                entity.Property(e => e.IdutilisateurCreateur).HasColumnName("IDUtilisateurCreateur");

                entity.Property(e => e.ImportanceContact).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Login)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MotdePasse)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreRefusEmail).HasColumnName("NombreRefusEMail");

                entity.Property(e => e.OldIdcontact).HasColumnName("Old_IDContact");

                entity.Property(e => e.PortableContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrenomContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelephoneContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContactBlackliste>(entity =>
            {
                entity.HasKey(e => e.IdcontactBlackliste);

                entity.ToTable("Contact_Blackliste");

                entity.Property(e => e.IdcontactBlackliste).HasColumnName("IDContactBlackliste");

                entity.Property(e => e.DateDesabonnement).HasColumnType("datetime");

                entity.Property(e => e.EmailContact)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Idcampagne).HasColumnName("IDCampagne");

                entity.Property(e => e.IdlisteService).HasColumnName("IDListeService");
            });

            modelBuilder.Entity<ContactBlacklisteV2>(entity =>
            {
                entity.HasKey(e => e.IdcontactBlackliste);

                entity.ToTable("Contact_Blackliste_V2");

                entity.Property(e => e.IdcontactBlackliste)
                    .HasColumnName("IDContactBlackliste")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateDesabonnement).HasColumnType("datetime");

                entity.Property(e => e.DateExpirationDesabonnement).HasColumnType("datetime");

                entity.Property(e => e.EmailContact)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Idcampagne).HasColumnName("IDCampagne");

                entity.Property(e => e.IdlisteService).HasColumnName("IDListeService");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");
            });

            modelBuilder.Entity<ContactCardex>(entity =>
            {
                entity.HasKey(e => e.IdcontactCardex);

                entity.ToTable("Contact_Cardex");

                entity.Property(e => e.IdcontactCardex).HasColumnName("IDContactCardex");

                entity.Property(e => e.Cardex).HasColumnType("text");

                entity.Property(e => e.Idcontact).HasColumnName("IDContact");
            });

            modelBuilder.Entity<ContactCivilite>(entity =>
            {
                entity.HasKey(e => e.Idcivilite);

                entity.ToTable("Contact_Civilite");

                entity.Property(e => e.Idcivilite)
                    .HasColumnName("IDCivilite")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Civilite)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CiviliteAbrege)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CiviliteUk)
                    .HasColumnName("CiviliteUK")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Conjugaison)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FormuleCherChere)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContactCoeurDeCible>(entity =>
            {
                entity.HasKey(e => e.IdcontactCoeurdeCible);

                entity.ToTable("Contact_Coeur_de_Cible");

                entity.Property(e => e.IdcontactCoeurdeCible).HasColumnName("IDContactCoeurdeCible");

                entity.Property(e => e.DateCoeurdeCible).HasColumnType("datetime");

                entity.Property(e => e.Idcontact).HasColumnName("IDContact");

                entity.Property(e => e.Idenquete).HasColumnName("IDEnquete");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");
            });

            modelBuilder.Entity<ContactConnecte>(entity =>
            {
                entity.HasKey(e => e.IdcontactConnecte);

                entity.ToTable("Contact_Connecte");

                entity.Property(e => e.IdcontactConnecte).HasColumnName("IDContactConnecte");

                entity.Property(e => e.DateConnection).HasColumnType("datetime");

                entity.Property(e => e.Idcontact).HasColumnName("IDContact");
            });

            modelBuilder.Entity<ContactEmailDestinaire>(entity =>
            {
                entity.HasKey(e => e.IdcontactEmailDestinataire);

                entity.ToTable("Contact_Email_Destinaire");

                entity.Property(e => e.IdcontactEmailDestinataire).HasColumnName("IDContactEmailDestinataire");

                entity.Property(e => e.EmailContact)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Iddocument).HasColumnName("IDDocument");

                entity.Property(e => e.IdtypeDestinataire).HasColumnName("IDTypeDestinataire");

                entity.Property(e => e.SmtpUtilise)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContactHistorique>(entity =>
            {
                entity.HasKey(e => e.Idhistorique);

                entity.ToTable("Contact_Historique");

                entity.Property(e => e.Idhistorique).HasColumnName("IDHistorique");

                entity.Property(e => e.DateHisto).HasColumnType("datetime");

                entity.Property(e => e.Historique).HasColumnType("text");

                entity.Property(e => e.Idcontact).HasColumnName("IDContact");

                entity.Property(e => e.IdenqueteSociete).HasColumnName("IDEnqueteSociete");

                entity.Property(e => e.Ididtable).HasColumnName("IDIDTable");

                entity.Property(e => e.IdlisteService).HasColumnName("IDListeService");

                entity.Property(e => e.IdlisteSousService).HasColumnName("IDListeSousService");

                entity.Property(e => e.IdlisteTable).HasColumnName("IDListeTable");

                entity.Property(e => e.Idmediatheque).HasColumnName("IDMediatheque");

                entity.Property(e => e.IdmissionMarketing).HasColumnName("IDMissionMarketing");

                entity.Property(e => e.IdnomenclatureNiv1).HasColumnName("IDNomenclatureNiv1");

                entity.Property(e => e.Idsociete).HasColumnName("IDSociete");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.IdtypeHistorique).HasColumnName("IDTypeHistorique");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");
            });

            modelBuilder.Entity<ContactHistoriqueArchive>(entity =>
            {
                entity.HasKey(e => e.Idhistorique);

                entity.ToTable("Contact_Historique_Archive");

                entity.Property(e => e.Idhistorique)
                    .HasColumnName("IDHistorique")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateHisto).HasColumnType("datetime");

                entity.Property(e => e.Historique).HasColumnType("text");

                entity.Property(e => e.Idcontact).HasColumnName("IDContact");

                entity.Property(e => e.IdenqueteSociete).HasColumnName("IDEnqueteSociete");

                entity.Property(e => e.Ididtable).HasColumnName("IDIDTable");

                entity.Property(e => e.IdlisteService).HasColumnName("IDListeService");

                entity.Property(e => e.IdlisteSousService).HasColumnName("IDListeSousService");

                entity.Property(e => e.IdlisteTable).HasColumnName("IDListeTable");

                entity.Property(e => e.Idmediatheque).HasColumnName("IDMediatheque");

                entity.Property(e => e.IdmissionMarketing).HasColumnName("IDMissionMarketing");

                entity.Property(e => e.IdnomenclatureNiv1).HasColumnName("IDNomenclatureNiv1");

                entity.Property(e => e.Idsociete).HasColumnName("IDSociete");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.IdtypeHistorique).HasColumnName("IDTypeHistorique");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");
            });

            modelBuilder.Entity<ContactHistoriqueMorte>(entity =>
            {
                entity.HasKey(e => e.Idhistorique);

                entity.ToTable("Contact_Historique_Morte");

                entity.Property(e => e.Idhistorique)
                    .HasColumnName("IDHistorique")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateHisto).HasColumnType("datetime");

                entity.Property(e => e.Historique).HasColumnType("text");

                entity.Property(e => e.Idcontact).HasColumnName("IDContact");

                entity.Property(e => e.Ididtable).HasColumnName("IDIDTable");

                entity.Property(e => e.IdlisteService).HasColumnName("IDListeService");

                entity.Property(e => e.IdlisteSousService).HasColumnName("IDListeSousService");

                entity.Property(e => e.IdlisteTable).HasColumnName("IDListeTable");

                entity.Property(e => e.Idmediatheque).HasColumnName("IDMediatheque");

                entity.Property(e => e.IdmissionMarketing).HasColumnName("IDMissionMarketing");

                entity.Property(e => e.IdnomenclatureNiv1).HasColumnName("IDNomenclatureNiv1");

                entity.Property(e => e.Idsociete).HasColumnName("IDSociete");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.IdtypeHistorique).HasColumnName("IDTypeHistorique");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");
            });

            modelBuilder.Entity<ContactPseudo>(entity =>
            {
                entity.HasKey(e => e.Idpseudo);

                entity.ToTable("Contact_Pseudo");

                entity.Property(e => e.Idpseudo).HasColumnName("IDPseudo");

                entity.Property(e => e.Idcontact).HasColumnName("IDContact");

                entity.Property(e => e.Pseudo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Email>(entity =>
            {
                entity.HasKey(e => e.Idemail);

                entity.Property(e => e.Idemail).HasColumnName("IDEmail");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.DateDerniereErreur).HasColumnType("smalldatetime");

                entity.Property(e => e.DateDerniereReaction).HasColumnType("smalldatetime");

                entity.Property(e => e.DateDerniereUtilisation).HasColumnType("smalldatetime");

                entity.Property(e => e.Email1)
                    .IsRequired()
                    .HasColumnName("Email")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdimportExport).HasColumnName("IDImportExport");

                entity.Property(e => e.Idorigine).HasColumnName("IDOrigine");

                entity.Property(e => e.IdregleNommage).HasColumnName("IDRegleNommage");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.NomdeDomaine)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");
            });

            modelBuilder.Entity<EmailContact>(entity =>
            {
                entity.HasKey(e => e.IdemailContact);

                entity.ToTable("Email_Contact");

                entity.Property(e => e.IdemailContact).HasColumnName("IDEmailContact");

                entity.Property(e => e.Idemail).HasColumnName("IDEmail");

                entity.Property(e => e.IdnomContact)
                    .HasColumnName("IDNomContact")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdprenomContact)
                    .HasColumnName("IDPrenomContact")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.MotdePasse)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrenomContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmailDemande>(entity =>
            {
                entity.HasKey(e => e.IdemailDemande);

                entity.ToTable("Email_Demande");

                entity.Property(e => e.IdemailDemande).HasColumnName("IDEmailDemande");

                entity.Property(e => e.DateDemande).HasColumnType("datetime");

                entity.Property(e => e.Idemail).HasColumnName("IDEmail");

                entity.Property(e => e.IdlisteService).HasColumnName("IDListeService");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.IdtypeDemande).HasColumnName("IDTypeDemande");
            });

            modelBuilder.Entity<Enquete>(entity =>
            {
                entity.HasKey(e => e.Idenquete);

                entity.Property(e => e.Idenquete).HasColumnName("IDEnquete");

                entity.Property(e => e.DateDebutEnquete).HasColumnType("datetime");

                entity.Property(e => e.DateFinEnquete).HasColumnType("datetime");

                entity.Property(e => e.Enquete1)
                    .IsRequired()
                    .HasColumnName("Enquete")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Idcontact).HasColumnName("IDContact");

                entity.Property(e => e.Iddocument).HasColumnName("IDDocument");

                entity.Property(e => e.IddocumentSelection).HasColumnName("IDDocumentSelection");

                entity.Property(e => e.Idlangue).HasColumnName("IDLangue");

                entity.Property(e => e.IdlisteService).HasColumnName("IDListeService");

                entity.Property(e => e.IdlisteSousService).HasColumnName("IDListeSousService");

                entity.Property(e => e.IdlisteTypeAutreContact).HasColumnName("IDListeTypeAutreContact");

                entity.Property(e => e.IdnomenclatureSelection).HasColumnName("IDNomenclatureSelection");

                entity.Property(e => e.IdnomenclatureSelectionAttributionAutomatique).HasColumnName("IDNomenclatureSelectionAttributionAutomatique");

                entity.Property(e => e.IdquestionPardefaut).HasColumnName("IDQuestionPardefaut");

                entity.Property(e => e.IdsousTypeNomenclature).HasColumnName("IDSousTypeNomenclature");

                entity.Property(e => e.IdtypeEnquete).HasColumnName("IDTypeEnquete");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");

                entity.Property(e => e.TitreNomenclature)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EnqueteCibleAnalytics>(entity =>
            {
                entity.HasKey(e => e.IdenqueteCibleAnalytics);

                entity.ToTable("Enquete_Cible_Analytics");

                entity.Property(e => e.IdenqueteCibleAnalytics).HasColumnName("IDEnqueteCibleAnalytics");

                entity.Property(e => e.DateMiseAjour)
                    .HasColumnName("DateMiseAJour")
                    .HasColumnType("datetime");

                entity.Property(e => e.Idcontact).HasColumnName("IDContact");

                entity.Property(e => e.Idenquete).HasColumnName("IDEnquete");

                entity.Property(e => e.Idsociete).HasColumnName("IDSociete");
            });

            modelBuilder.Entity<EnqueteCibleApe>(entity =>
            {
                entity.HasKey(e => e.IdenqueteCibleApe);

                entity.ToTable("Enquete_Cible_APE");

                entity.Property(e => e.IdenqueteCibleApe).HasColumnName("IDEnqueteCibleAPE");

                entity.Property(e => e.Ape)
                    .IsRequired()
                    .HasColumnName("APE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Idenquete).HasColumnName("IDEnquete");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");
            });

            modelBuilder.Entity<EnqueteCibleDepartement>(entity =>
            {
                entity.HasKey(e => e.IdenqueteCibleDepartement);

                entity.ToTable("Enquete_Cible_Departement");

                entity.Property(e => e.IdenqueteCibleDepartement).HasColumnName("IDEnqueteCibleDepartement");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Iddepartement)
                    .IsRequired()
                    .HasColumnName("IDDepartement")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Idenquete).HasColumnName("IDEnquete");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");
            });

            modelBuilder.Entity<EnqueteCibleFonction>(entity =>
            {
                entity.HasKey(e => e.IdenqueteCibleFonction);

                entity.ToTable("Enquete_Cible_Fonction");

                entity.Property(e => e.IdenqueteCibleFonction).HasColumnName("IDEnqueteCibleFonction");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Idenquete).HasColumnName("IDEnquete");

                entity.Property(e => e.Idfonction).HasColumnName("IDFonction");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");
            });

            modelBuilder.Entity<EnqueteCibleImportVoirImportExportEnquete>(entity =>
            {
                entity.HasKey(e => e.IdenqueteCibleImport);

                entity.ToTable("Enquete_Cible_Import_Voir_Import_Export_Enquete");

                entity.Property(e => e.IdenqueteCibleImport).HasColumnName("IDEnqueteCibleImport");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Idenquete).HasColumnName("IDEnquete");

                entity.Property(e => e.IdimportExport).HasColumnName("IDImportExport");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");
            });

            modelBuilder.Entity<EnqueteCibleSocieteSelection>(entity =>
            {
                entity.HasKey(e => e.IdenqueteCibleSocieteSelection);

                entity.ToTable("Enquete_Cible_Societe_Selection");

                entity.Property(e => e.IdenqueteCibleSocieteSelection).HasColumnName("IDEnqueteCibleSocieteSelection");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Idenquete).HasColumnName("IDEnquete");

                entity.Property(e => e.IdsocieteSelection).HasColumnName("IDSocieteSelection");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");
            });

            modelBuilder.Entity<EnqueteQuestion>(entity =>
            {
                entity.HasKey(e => e.Idquestion);

                entity.ToTable("Enquete_Question");

                entity.Property(e => e.Idquestion).HasColumnName("IDQuestion");

                entity.Property(e => e.AutreIdtypeEnquete).HasColumnName("AutreIDTypeEnquete");

                entity.Property(e => e.ComportementQuestion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Idenquete).HasColumnName("IDEnquete");

                entity.Property(e => e.IdlisteValeurQuestion).HasColumnName("IDListeValeurQuestion");

                entity.Property(e => e.IdquestionParent).HasColumnName("IDQuestionParent");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.IdtypeAffichageQuestion).HasColumnName("IDTypeAffichageQuestion");

                entity.Property(e => e.IdtypeStockageQuestion).HasColumnName("IDTypeStockageQuestion");

                entity.Property(e => e.IdtypeValeurQuestion).HasColumnName("IDTypeValeurQuestion");

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionAide).HasColumnType("text");

                entity.Property(e => e.Questionnaire)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.TitreQuestion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ValeurParDefaut).HasColumnType("ntext");
            });

            modelBuilder.Entity<EnqueteQuestionHeritage>(entity =>
            {
                entity.HasKey(e => e.IdquestionHeritage);

                entity.ToTable("Enquete_Question_Heritage");

                entity.Property(e => e.IdquestionHeritage).HasColumnName("IDQuestionHeritage");

                entity.Property(e => e.IdquestionEnfant).HasColumnName("IDQuestionEnfant");

                entity.Property(e => e.IdquestionParent).HasColumnName("IDQuestionParent");
            });

            modelBuilder.Entity<EnqueteQuestionImpression>(entity =>
            {
                entity.HasKey(e => e.IdenqueteQuestionImpression);

                entity.ToTable("Enquete_Question_Impression");

                entity.Property(e => e.IdenqueteQuestionImpression).HasColumnName("IDEnqueteQuestionImpression");

                entity.Property(e => e.EnqueteQuestion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EnqueteQuestionImpression1)
                    .IsRequired()
                    .HasColumnName("EnqueteQuestionImpression")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EnqueteQuestionType>(entity =>
            {
                entity.HasKey(e => e.IdenqueteQuestion);

                entity.ToTable("Enquete_Question_Type");

                entity.Property(e => e.IdenqueteQuestion).HasColumnName("IDEnqueteQuestion");

                entity.Property(e => e.Idquestion).HasColumnName("IDQuestion");

                entity.Property(e => e.IdtypeQuestion).HasColumnName("IDTypeQuestion");
            });

            modelBuilder.Entity<EnqueteReponse>(entity =>
            {
                entity.HasKey(e => e.Idreponse);

                entity.ToTable("Enquete_Reponse");

                entity.Property(e => e.Idreponse).HasColumnName("IDReponse");

                entity.Property(e => e.IdenqueteSociete).HasColumnName("IDEnqueteSociete");

                entity.Property(e => e.Idquestion).HasColumnName("IDQuestion");

                entity.Property(e => e.ReponseDate).HasColumnType("datetime");

                entity.Property(e => e.ReponseMemo).HasColumnType("text");

                entity.Property(e => e.ReponseTexte)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EnqueteSelectionEnqueteSociete>(entity =>
            {
                entity.HasKey(e => e.IdselectionEnqueteSociete);

                entity.ToTable("Enquete_Selection_Enquete_Societe");

                entity.Property(e => e.IdselectionEnqueteSociete).HasColumnName("IDSelectionEnqueteSociete");

                entity.Property(e => e.DatePanier).HasColumnType("smalldatetime");

                entity.Property(e => e.DateValidation).HasColumnType("smalldatetime");

                entity.Property(e => e.IdabonnementContact).HasColumnName("IDAbonnementContact");

                entity.Property(e => e.IdcontactPrincipal).HasColumnName("IDContactPrincipal");

                entity.Property(e => e.IdenqueteSociete).HasColumnName("IDEnqueteSociete");

                entity.Property(e => e.Idpanier).HasColumnName("IDPanier");

                entity.Property(e => e.Idsociete).HasColumnName("IDSociete");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.IdtypeSelectionEnqueteSociete).HasColumnName("IDTypeSelectionEnqueteSociete");
            });

            modelBuilder.Entity<EnqueteSelectionEnqueteSocieteMutualise>(entity =>
            {
                entity.HasKey(e => e.IdselectionEnqueteSocieteMutualise);

                entity.ToTable("Enquete_Selection_Enquete_Societe_Mutualise");

                entity.Property(e => e.IdselectionEnqueteSocieteMutualise).HasColumnName("IDSelectionEnqueteSocieteMutualise");

                entity.Property(e => e.IdenqueteSociete).HasColumnName("IDEnqueteSociete");

                entity.Property(e => e.IdselectionSocieteMutualise).HasColumnName("IDSelectionSocieteMutualise");
            });

            modelBuilder.Entity<EnqueteSelectionSociete>(entity =>
            {
                entity.HasKey(e => e.Idenquete);

                entity.ToTable("Enquete_Selection_Societe");

                entity.Property(e => e.Idenquete).HasColumnName("IDEnquete");

                entity.Property(e => e.DatePanier).HasColumnType("datetime");

                entity.Property(e => e.Idsociete).HasColumnName("IDSociete");

                entity.Property(e => e.IdtypePanier).HasColumnName("IDTypePanier");
            });

            modelBuilder.Entity<EnqueteSelectionSocieteMutualise>(entity =>
            {
                entity.HasKey(e => e.IdselectionSocieteMutualise);

                entity.ToTable("Enquete_Selection_Societe_Mutualise");

                entity.Property(e => e.IdselectionSocieteMutualise).HasColumnName("IDSelectionSocieteMutualise");

                entity.Property(e => e.DateValidation).HasColumnType("smalldatetime");

                entity.Property(e => e.Idchaine).HasColumnName("IDChaine");

                entity.Property(e => e.Idsociete).HasColumnName("IDSociete");
            });

            modelBuilder.Entity<EnqueteSociete>(entity =>
            {
                entity.HasKey(e => e.IdenqueteSociete);

                entity.ToTable("Enquete_Societe");

                entity.Property(e => e.IdenqueteSociete).HasColumnName("IDEnqueteSociete");

                entity.Property(e => e.AncienId).HasColumnName("AncienID");

                entity.Property(e => e.DateEnqueteSociete).HasColumnType("datetime");

                entity.Property(e => e.DateMajenqueteSociete)
                    .HasColumnName("DateMAJEnqueteSociete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateValidation).HasColumnType("datetime");

                entity.Property(e => e.Idcontact).HasColumnName("IDContact");

                entity.Property(e => e.Idenquete).HasColumnName("IDEnquete");

                entity.Property(e => e.IdenqueteSocieteParent).HasColumnName("IDEnqueteSocieteParent");

                entity.Property(e => e.Idsociete).HasColumnName("IDSociete");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.IdstatutClient).HasColumnName("IDStatutClient");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");

                entity.Property(e => e.IdutilisateurCreateur).HasColumnName("IDUtilisateurCreateur");
            });

            modelBuilder.Entity<EnqueteSocieteStatut>(entity =>
            {
                entity.HasKey(e => e.IdenqueteSocieteStatut);

                entity.ToTable("Enquete_Societe_Statut");

                entity.Property(e => e.IdenqueteSocieteStatut).HasColumnName("IDEnqueteSocieteStatut");

                entity.Property(e => e.DateMajStatut).HasColumnType("datetime");

                entity.Property(e => e.IdenqueteSociete).HasColumnName("IDEnqueteSociete");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.IdstatutClient).HasColumnName("IDStatutClient");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");
            });

            modelBuilder.Entity<EnqueteSocieteVisite>(entity =>
            {
                entity.HasKey(e => e.IdenqueteSocieteVisite);

                entity.ToTable("Enquete_Societe_Visite");

                entity.Property(e => e.IdenqueteSocieteVisite).HasColumnName("IDEnqueteSocieteVisite");

                entity.Property(e => e.DateVisite).HasColumnType("smalldatetime");

                entity.Property(e => e.Idcompte).HasColumnName("IDCompte");

                entity.Property(e => e.IdenqueteSociete).HasColumnName("IDEnqueteSociete");

                entity.Property(e => e.Idsite).HasColumnName("IDSite");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("IP")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Facture>(entity =>
            {
                entity.HasKey(e => e.Idfacture);

                entity.Property(e => e.Idfacture).HasColumnName("IDFacture");

                entity.Property(e => e.AcompteTtc)
                    .HasColumnName("AcompteTTC")
                    .HasColumnType("money");

                entity.Property(e => e.Adresse1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Adresse2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Adresse3)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Civilite)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Commentaire).HasColumnType("text");

                entity.Property(e => e.CommentaireInterne).HasColumnType("text");

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateContrat).HasColumnType("datetime");

                entity.Property(e => e.DateCreation).HasColumnType("date");

                entity.Property(e => e.DateDebutAbonnement).HasColumnType("datetime");

                entity.Property(e => e.DateDedonciationTacite).HasColumnType("datetime");

                entity.Property(e => e.DateFacture).HasColumnType("smalldatetime");

                entity.Property(e => e.DateFinAbonnement).HasColumnType("datetime");

                entity.Property(e => e.DateReglement).HasColumnType("smalldatetime");

                entity.Property(e => e.DeclarationSfac).HasColumnName("DeclarationSFAC");

                entity.Property(e => e.DeclarationSfacdate)
                    .HasColumnName("DeclarationSFACDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DemandeSfac).HasColumnName("DemandeSFAC");

                entity.Property(e => e.DemandeSfacdate)
                    .HasColumnName("DemandeSFACDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idabonnement).HasColumnName("IDAbonnement");

                entity.Property(e => e.Idcontact).HasColumnName("IDContact");

                entity.Property(e => e.IdlistePays).HasColumnName("IDListePays");

                entity.Property(e => e.Idmediatheque).HasColumnName("IDMediatheque");

                entity.Property(e => e.Idsociete).HasColumnName("IDSociete");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.IdstatutTacite).HasColumnName("IDStatutTacite");

                entity.Property(e => e.IdtransactionCyberPlus).HasColumnName("IDTransaction_CyberPlus");

                entity.Property(e => e.IdtypeFacture).HasColumnName("IDTypeFacture");

                entity.Property(e => e.IdtypeTacite).HasColumnName("IDTypeTacite");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");

                entity.Property(e => e.MontantHt)
                    .HasColumnName("MontantHT")
                    .HasColumnType("money");

                entity.Property(e => e.Nom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomSociete)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumCommande)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prenom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceClient)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceFacture)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceFactureParent)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Remise).HasColumnType("money");

                entity.Property(e => e.Tel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tva)
                    .HasColumnName("TVA")
                    .HasColumnType("money");

                entity.Property(e => e.TvaBkp).HasColumnName("TVA_BKP");

                entity.Property(e => e.TvanumIntracommunautaire)
                    .HasColumnName("TVANumIntracommunautaire")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Ville)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FactureDetail>(entity =>
            {
                entity.HasKey(e => e.IdfactureDetail);

                entity.ToTable("Facture_Detail");

                entity.Property(e => e.IdfactureDetail).HasColumnName("IDFactureDetail");

                entity.Property(e => e.Designation)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.GestionTva).HasColumnName("GestionTVA");

                entity.Property(e => e.Idabonnement).HasColumnName("IDAbonnement");

                entity.Property(e => e.Idfacture).HasColumnName("IDFacture");

                entity.Property(e => e.IdfamillePrestation).HasColumnName("IDFamillePrestation");

                entity.Property(e => e.MontantHt)
                    .HasColumnName("MontantHT")
                    .HasColumnType("money");

                entity.Property(e => e.Remise).HasColumnType("money");

                entity.Property(e => e.TauxTva)
                    .HasColumnName("TauxTVA")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<FactureEcheance>(entity =>
            {
                entity.HasKey(e => e.Idecheance);

                entity.ToTable("Facture_Echeance");

                entity.Property(e => e.Idecheance).HasColumnName("IDEcheance");

                entity.Property(e => e.Echeance).HasColumnType("smalldatetime");

                entity.Property(e => e.Idfacture).HasColumnName("IDFacture");

                entity.Property(e => e.IdmodePaiement).HasColumnName("IDModePaiement");

                entity.Property(e => e.IdstatutEcheance).HasColumnName("IDStatutEcheance");

                entity.Property(e => e.MontantEcheance).HasColumnType("money");

                entity.Property(e => e.RecuEcheance).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<FactureEncaissement>(entity =>
            {
                entity.HasKey(e => e.Idencaissement);

                entity.ToTable("Facture_Encaissement");

                entity.Property(e => e.Idencaissement).HasColumnName("IDEncaissement");

                entity.Property(e => e.DateCommission).HasColumnType("date");

                entity.Property(e => e.DateEncaissement).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTraitementEncaissement).HasColumnType("datetime");

                entity.Property(e => e.Idecheance).HasColumnName("IDEcheance");

                entity.Property(e => e.Idfacture).HasColumnName("IDFacture");

                entity.Property(e => e.IdmoisSalaireXxx).HasColumnName("IDMoisSalaireXXX");

                entity.Property(e => e.IdtypeModePaiement).HasColumnName("IDTypeModePaiement");

                entity.Property(e => e.MontantEncaissement).HasColumnType("money");
            });

            modelBuilder.Entity<FactureFamillePrestation>(entity =>
            {
                entity.HasKey(e => e.IdfactureFamille);

                entity.ToTable("Facture_Famille_Prestation");

                entity.Property(e => e.IdfactureFamille).HasColumnName("IDFactureFamille");

                entity.Property(e => e.AxeAnalytique)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CodeComptable)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateSpecifique).HasColumnType("date");

                entity.Property(e => e.Designation)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Idservice).HasColumnName("IDService");

                entity.Property(e => e.IdsousService).HasColumnName("IDSousService");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.IdtypeAbonnement).HasColumnName("IDTypeAbonnement");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FactureFournisseur>(entity =>
            {
                entity.HasKey(e => e.IdfactureFournisseur);

                entity.ToTable("Facture_Fournisseur");

                entity.Property(e => e.IdfactureFournisseur).HasColumnName("IDFactureFournisseur");

                entity.Property(e => e.Commentaire).HasColumnType("text");

                entity.Property(e => e.DateFacture).HasColumnType("datetime");

                entity.Property(e => e.IdenqueteSociete).HasColumnName("IDEnqueteSociete");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.IdtypeFactureFournisseur).HasColumnName("IDTypeFactureFournisseur");

                entity.Property(e => e.ReferenceFournisseur)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceInterne)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TotalHt)
                    .HasColumnName("TotalHT")
                    .HasColumnType("money");

                entity.Property(e => e.TotalTtc)
                    .HasColumnName("TotalTTC")
                    .HasColumnType("money");

                entity.Property(e => e.TotalTva)
                    .HasColumnName("TotalTVA")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<FactureFournisseurEcheance>(entity =>
            {
                entity.HasKey(e => e.IdfactureFournisseurEcheance);

                entity.ToTable("Facture_Fournisseur_Echeance");

                entity.Property(e => e.IdfactureFournisseurEcheance).HasColumnName("IDFactureFournisseurEcheance");

                entity.Property(e => e.DateEcheance).HasColumnType("date");

                entity.Property(e => e.DateReglementEcheance).HasColumnType("date");

                entity.Property(e => e.IdfactureFournisseur).HasColumnName("IDFactureFournisseur");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.Montant).HasColumnType("money");
            });

            modelBuilder.Entity<FactureFournisseurPaiement>(entity =>
            {
                entity.HasKey(e => e.IdfactureFournisseurPaiement);

                entity.ToTable("Facture_Fournisseur_Paiement");

                entity.Property(e => e.IdfactureFournisseurPaiement).HasColumnName("IDFactureFournisseurPaiement");

                entity.Property(e => e.DateExpedition).HasColumnType("date");

                entity.Property(e => e.DateReglement).HasColumnType("date");

                entity.Property(e => e.DetailsModePaiement)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdfactureFournisseur).HasColumnName("IDFactureFournisseur");

                entity.Property(e => e.MontantPaye).HasColumnType("money");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FactureFournisseurSociete>(entity =>
            {
                entity.HasKey(e => e.IdfactureFournisseurSociete);

                entity.ToTable("Facture_Fournisseur_Societe");

                entity.Property(e => e.IdfactureFournisseurSociete).HasColumnName("IDFactureFournisseurSociete");

                entity.Property(e => e.Idsociete).HasColumnName("IDSociete");

                entity.Property(e => e.IdtypeFournisseur).HasColumnName("IDTypeFournisseur");

                entity.Property(e => e.NomFournisseur)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FactureRelance>(entity =>
            {
                entity.HasKey(e => e.Idrelance);

                entity.ToTable("Facture_Relance");

                entity.Property(e => e.Idrelance).HasColumnName("IDRelance");

                entity.Property(e => e.DateExecutionRelance).HasColumnType("datetime");

                entity.Property(e => e.DateRelance).HasColumnType("datetime");

                entity.Property(e => e.Details).HasColumnType("text");

                entity.Property(e => e.Idecheance).HasColumnName("IDEcheance");

                entity.Property(e => e.Idmediatheque).HasColumnName("IDMediatheque");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.IdtypeRelance).HasColumnName("IDTypeRelance");
            });

            modelBuilder.Entity<IdnavigationV2Autorisation>(entity =>
            {
                entity.HasKey(e => e.IdnavigationV2Autorisation1);

                entity.ToTable("IDNavigation_v2_Autorisation");

                entity.Property(e => e.IdnavigationV2Autorisation1).HasColumnName("IDNavigation_v2_Autorisation");

                entity.Property(e => e.IdnavigationV2).HasColumnName("IDNavigation_v2");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");
            });

            modelBuilder.Entity<ImportExport>(entity =>
            {
                entity.HasKey(e => e.IdimportExport);

                entity.Property(e => e.IdimportExport).HasColumnName("IDImportExport");

                entity.Property(e => e.DateImportExport).HasColumnType("datetime");

                entity.Property(e => e.Idcontact).HasColumnName("IDContact");

                entity.Property(e => e.IdlisteFonctionParDefaut).HasColumnName("IDListeFonctionParDefaut");

                entity.Property(e => e.Idsource).HasColumnName("IDSource");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.IdtypeImportExport).HasColumnName("IDTypeImportExport");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");

                entity.Property(e => e.Instruction).HasColumnType("text");

                entity.Property(e => e.NomFichier)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RequeteSql)
                    .HasColumnName("RequeteSQL")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<ImportExportContact>(entity =>
            {
                entity.HasKey(e => e.IdimportExportContact);

                entity.ToTable("ImportExport_Contact");

                entity.Property(e => e.IdimportExportContact).HasColumnName("IDImportExportContact");

                entity.Property(e => e.DateImportExportContact).HasColumnType("datetime");

                entity.Property(e => e.Idcontact).HasColumnName("IDContact");

                entity.Property(e => e.IdimportExport).HasColumnName("IDImportExport");

                entity.Property(e => e.Idresultat).HasColumnName("IDResultat");
            });

            modelBuilder.Entity<ImportExportDiscussion>(entity =>
            {
                entity.HasKey(e => e.IdimportExportDiscussion);

                entity.ToTable("ImportExport_Discussion");

                entity.Property(e => e.IdimportExportDiscussion).HasColumnName("IDImportExportDiscussion");

                entity.Property(e => e.Iddocument).HasColumnName("IDDocument");

                entity.Property(e => e.IdimportExport).HasColumnName("IDImportExport");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<ImportExportEnquete>(entity =>
            {
                entity.HasKey(e => e.IdimportExportEnquete);

                entity.ToTable("ImportExport_Enquete");

                entity.Property(e => e.IdimportExportEnquete).HasColumnName("IDImportExportEnquete");

                entity.Property(e => e.Idenquete).HasColumnName("IDEnquete");

                entity.Property(e => e.IdimportExport).HasColumnName("IDImportExport");
            });

            modelBuilder.Entity<ImportExportSociete>(entity =>
            {
                entity.HasKey(e => e.IdimportExportSociete);

                entity.ToTable("ImportExport_Societe");

                entity.Property(e => e.IdimportExportSociete).HasColumnName("IDImportExportSociete");

                entity.Property(e => e.DateImportExportSociete).HasColumnType("datetime");

                entity.Property(e => e.IdimportExport).HasColumnName("IDImportExport");

                entity.Property(e => e.Idresultat).HasColumnName("IDResultat");

                entity.Property(e => e.Idsociete).HasColumnName("IDSociete");
            });

            modelBuilder.Entity<Intermediation>(entity =>
            {
                entity.HasKey(e => e.Idintermediation);

                entity.Property(e => e.Idintermediation).HasColumnName("IDIntermediation");

                entity.Property(e => e.ChoixdeRdv).HasColumnName("ChoixdeRDV");

                entity.Property(e => e.DateIntermediation).HasColumnType("smalldatetime");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.FermetureDateChoix).HasColumnType("date");

                entity.Property(e => e.FermetureHeureChoix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FermetureTheoriqueDateChoix).HasColumnType("date");

                entity.Property(e => e.FermetureTheoriqueHeureChoix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdabonnementAcheteur).HasColumnName("IDAbonnementAcheteur");

                entity.Property(e => e.IdabonnementVendeur).HasColumnName("IDAbonnementVendeur");

                entity.Property(e => e.Iddocument).HasColumnName("IDDocument");

                entity.Property(e => e.IdenqueteAcheteur).HasColumnName("IDEnqueteAcheteur");

                entity.Property(e => e.IdenqueteAcheteurBesoin).HasColumnName("IDEnqueteAcheteurBesoin");

                entity.Property(e => e.IdenquetePageWeb).HasColumnName("IDEnquetePageWeb");

                entity.Property(e => e.IdenqueteVendeur).HasColumnName("IDEnqueteVendeur");

                entity.Property(e => e.IdlisteService).HasColumnName("IDListeService");

                entity.Property(e => e.IdlisteSousService).HasColumnName("IDListeSousService");

                entity.Property(e => e.IdselectionIntermediation).HasColumnName("IDSelectionIntermediation");

                entity.Property(e => e.IdselectionListeIndisponibilite).HasColumnName("IDSelectionListeIndisponibilite");

                entity.Property(e => e.IdselectionListePlage).HasColumnName("IDSelectionListePlage");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.IdutilisateurAcheteur).HasColumnName("IDUtilisateurAcheteur");

                entity.Property(e => e.IdutilisateurVendeur).HasColumnName("IDUtilisateurVendeur");

                entity.Property(e => e.Intermediation1)
                    .HasColumnName("Intermediation")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IntermediationParametres)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IntituleTypeAcheteur)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IntituleTypeVendeur)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Lieu)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OuvertureDateChoix).HasColumnType("date");

                entity.Property(e => e.OuvertureHeureChoix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SiteWebIntermediation)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IntermediationContact>(entity =>
            {
                entity.HasKey(e => e.IdintermediationContact);

                entity.ToTable("Intermediation_Contact");

                entity.Property(e => e.IdintermediationContact).HasColumnName("IDIntermediationContact");

                entity.Property(e => e.Commentaire)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DateIntermediation).HasColumnType("datetime");

                entity.Property(e => e.DateRecapitulatifAcheteur).HasColumnType("datetime");

                entity.Property(e => e.DateRecapitulatifVendeur).HasColumnType("datetime");

                entity.Property(e => e.IdcontactAcheteur).HasColumnName("IDContactAcheteur");

                entity.Property(e => e.IdcontactVendeur).HasColumnName("IDContactVendeur");

                entity.Property(e => e.IddocumentVendeur).HasColumnName("IDDocumentVendeur");

                entity.Property(e => e.IdenqueteSocieteAcheteur).HasColumnName("IDEnqueteSocieteAcheteur");

                entity.Property(e => e.IdenqueteSocieteVendeur).HasColumnName("IDEnqueteSocieteVendeur");

                entity.Property(e => e.Idintermediation).HasColumnName("IDIntermediation");

                entity.Property(e => e.Idplage).HasColumnName("IDPlage");

                entity.Property(e => e.IdsocieteAcheteur).HasColumnName("IDSocieteAcheteur");

                entity.Property(e => e.IdsocieteVendeur).HasColumnName("IDSocieteVendeur");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.IdtypeIntermediation).HasColumnName("IDTypeIntermediation");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");

                entity.Property(e => e.Ipacheteur)
                    .HasColumnName("IPAcheteur")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ipvendeur)
                    .HasColumnName("IPVendeur")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SessionIdacheteur).HasColumnName("SessionIDAcheteur");

                entity.Property(e => e.SessionIdvendeur).HasColumnName("SessionIDVendeur");
            });

            modelBuilder.Entity<IntermediationIndisponibilite>(entity =>
            {
                entity.HasKey(e => new { e.Idparticipant, e.Idplage });

                entity.ToTable("Intermediation_Indisponibilite");

                entity.Property(e => e.Idparticipant).HasColumnName("IDParticipant");

                entity.Property(e => e.Idplage).HasColumnName("IDPlage");

                entity.Property(e => e.IdtypeIndispo).HasColumnName("IDTypeIndispo");

                entity.Property(e => e.Indisponibilite)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IntermediationLog>(entity =>
            {
                entity.HasKey(e => e.Idlog);

                entity.ToTable("Intermediation_Log");

                entity.Property(e => e.Idlog).HasColumnName("IDLog");

                entity.Property(e => e.HeureLog).HasColumnType("datetime");

                entity.Property(e => e.Idcontact).HasColumnName("IDContact");

                entity.Property(e => e.Ididtable).HasColumnName("IDIDTable");

                entity.Property(e => e.Idintermediation).HasColumnName("IDIntermediation");

                entity.Property(e => e.IdlisteTable).HasColumnName("IDListeTable");

                entity.Property(e => e.Idresultat).HasColumnName("IDResultat");

                entity.Property(e => e.IdtypeLog).HasColumnName("IDTypeLog");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");
            });

            modelBuilder.Entity<Ipbannie>(entity =>
            {
                entity.HasKey(e => new { e.Idipbannie, e.Ip });

                entity.ToTable("_IPBannie");

                entity.Property(e => e.Idipbannie)
                    .HasColumnName("IDIPBannie")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Commentaires).HasColumnType("text");

                entity.Property(e => e.DateInjectionSql)
                    .HasColumnName("DateInjectionSQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.Motivation).HasColumnType("text");
            });

            modelBuilder.Entity<ListeFournisseur>(entity =>
            {
                entity.ToTable("_Liste_Fournisseur");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NomSociete)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MediathequeDocument>(entity =>
            {
                entity.HasKey(e => e.Iddocument);

                entity.ToTable("Mediatheque_Document");

                entity.Property(e => e.Iddocument).HasColumnName("IDDocument");

                entity.Property(e => e.Commentaire).HasColumnType("text");

                entity.Property(e => e.DateCreation).HasColumnType("smalldatetime");

                entity.Property(e => e.DateMaj).HasColumnType("smalldatetime");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IddocumentParent).HasColumnName("IDDocumentParent");

                entity.Property(e => e.IdenqueteSociete).HasColumnName("IDEnqueteSociete");

                entity.Property(e => e.IdlisteService).HasColumnName("IDListeService");

                entity.Property(e => e.IdlisteSousService).HasColumnName("IDListeSousService");

                entity.Property(e => e.Idsociete).HasColumnName("IDSociete");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.IdtypeDocument).HasColumnName("IDTypeDocument");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");

                entity.Property(e => e.NomDocument)
                    .IsRequired()
                    .HasMaxLength(214)
                    .IsUnicode(false);

                entity.Property(e => e.SecuritePublic).HasColumnName("Securite_Public");
            });

            modelBuilder.Entity<MediathequeDocumentLiaison>(entity =>
            {
                entity.HasKey(e => e.IdmediathequeDocumentLiaison);

                entity.ToTable("Mediatheque_Document_Liaison");

                entity.Property(e => e.IdmediathequeDocumentLiaison).HasColumnName("IDMediathequeDocumentLiaison");

                entity.Property(e => e.Iddocument).HasColumnName("IDDocument");

                entity.Property(e => e.Ididtable).HasColumnName("IDIDTable");

                entity.Property(e => e.IdlisteTable).HasColumnName("IDListeTable");
            });

            modelBuilder.Entity<MediathequeDocumentPieceJointe>(entity =>
            {
                entity.HasKey(e => e.IddocumentPieceJointe);

                entity.ToTable("Mediatheque_Document_Piece_Jointe");

                entity.Property(e => e.IddocumentPieceJointe).HasColumnName("IDDocumentPieceJointe");

                entity.Property(e => e.IddocumentEnfant).HasColumnName("IDDocumentEnfant");

                entity.Property(e => e.IddocumentParent).HasColumnName("IDDocumentParent");
            });

            modelBuilder.Entity<Mission>(entity =>
            {
                entity.HasKey(e => e.Idmission);

                entity.Property(e => e.Idmission).HasColumnName("IDMission");

                entity.Property(e => e.DateDebutMission).HasColumnType("date");

                entity.Property(e => e.DateFinMission).HasColumnType("date");

                entity.Property(e => e.Idcontact).HasColumnName("IDContact");

                entity.Property(e => e.Idenquete).HasColumnName("IDEnquete");

                entity.Property(e => e.IdlisteSousService).HasColumnName("IDListeSousService");

                entity.Property(e => e.Idmarketing).HasColumnName("IDMarketing");

                entity.Property(e => e.IdstatutMission).HasColumnName("IDStatutMission");

                entity.Property(e => e.IdtypeMission).HasColumnName("IDTypeMission");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");

                entity.Property(e => e.Mission1)
                    .HasColumnName("Mission")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MissionMarketing>(entity =>
            {
                entity.HasKey(e => e.IdmissionMarketing);

                entity.ToTable("Mission_Marketing");

                entity.Property(e => e.IdmissionMarketing).HasColumnName("IDMissionMarketing");

                entity.Property(e => e.DateMiseAdisposition)
                    .HasColumnName("DateMiseADisposition")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateResultat).HasColumnType("datetime");

                entity.Property(e => e.Idcontact).HasColumnName("IDContact");

                entity.Property(e => e.Idmission).HasColumnName("IDMission");

                entity.Property(e => e.Idoperateur).HasColumnName("IDOperateur");

                entity.Property(e => e.Idsociete).HasColumnName("IDSociete");

                entity.Property(e => e.IdtypeResultat).HasColumnName("IDTypeResultat");
            });

            modelBuilder.Entity<MissionTypeResultat>(entity =>
            {
                entity.HasKey(e => e.IdmissionTypeResultat);

                entity.ToTable("Mission_Type_Resultat");

                entity.Property(e => e.IdmissionTypeResultat).HasColumnName("IDMissionTypeResultat");

                entity.Property(e => e.ClassCss)
                    .HasColumnName("ClassCSS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdmissionTypeResultatParent).HasColumnName("IDMissionTypeResultatParent");

                entity.Property(e => e.TypeResultat)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MotsCles>(entity =>
            {
                entity.HasKey(e => e.IdmotCles);

                entity.ToTable("_MotsCles");

                entity.Property(e => e.IdmotCles).HasColumnName("IDMotCles");

                entity.Property(e => e.DateMotCles).HasColumnType("datetime");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");

                entity.Property(e => e.MotCles)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NavigationNiv1>(entity =>
            {
                entity.HasKey(e => e.Idnavigation1);

                entity.ToTable("Navigation_Niv1");

                entity.Property(e => e.Idnavigation1)
                    .HasColumnName("IDNavigation1")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IconeNavigation1)
                    .HasColumnName("iconeNavigation1")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.IdtypeNavigation).HasColumnName("IDTypeNavigation");

                entity.Property(e => e.Navigation1)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NavigationNiv2>(entity =>
            {
                entity.HasKey(e => e.Idnavigation2);

                entity.ToTable("Navigation_Niv2");

                entity.Property(e => e.Idnavigation2).HasColumnName("IDNavigation2");

                entity.Property(e => e.IconeNavigation2)
                    .HasColumnName("iconeNavigation2")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Idnavigation1).HasColumnName("IDNavigation1");

                entity.Property(e => e.Navigation2).HasColumnType("text");

                entity.Property(e => e.SourceNavigation2).HasColumnType("text");
            });

            modelBuilder.Entity<NavigationNiv3>(entity =>
            {
                entity.HasKey(e => e.Idnavigation3);

                entity.ToTable("Navigation_Niv3");

                entity.Property(e => e.Idnavigation3).HasColumnName("IDNavigation3");

                entity.Property(e => e.Idnavigation2).HasColumnName("IDNavigation2");

                entity.Property(e => e.Navigation3)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SourceNavigation3).HasColumnType("text");
            });

            modelBuilder.Entity<NavigationV2>(entity =>
            {
                entity.HasKey(e => e.Idnavigation);

                entity.ToTable("Navigation_v2");

                entity.Property(e => e.Idnavigation).HasColumnName("IDNavigation");

                entity.Property(e => e.IdnavigationParent).HasColumnName("IDNavigation_Parent");

                entity.Property(e => e.Navigation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NavigationV2Abonnement>(entity =>
            {
                entity.HasKey(e => e.IdnavigationAbonnement);

                entity.ToTable("Navigation_V2_Abonnement");

                entity.Property(e => e.IdnavigationAbonnement).HasColumnName("IDNavigationAbonnement");

                entity.Property(e => e.Idnavigation).HasColumnName("IDNavigation");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");
            });

            modelBuilder.Entity<Nomenclature>(entity =>
            {
                entity.HasKey(e => e.Idnomenclature);

                entity.Property(e => e.Idnomenclature).HasColumnName("IDNomenclature");

                entity.Property(e => e.Commentaire).HasColumnType("text");

                entity.Property(e => e.Commentaire123industries).HasColumnType("text");

                entity.Property(e => e.IdappartenanceA).HasColumnName("IDAppartenanceA");

                entity.Property(e => e.IdappartenanceB).HasColumnName("IDAppartenanceB");

                entity.Property(e => e.IdappartenanceC).HasColumnName("IDAppartenanceC");

                entity.Property(e => e.IdnomNomenclature)
                    .IsRequired()
                    .HasColumnName("IDNomNomenclature")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Idstatut).HasColumnName("IDstatut");

                entity.Property(e => e.Nomenclature1)
                    .IsRequired()
                    .HasColumnName("Nomenclature")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NomenclatureMotsCles)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NomenclatureCodeApe>(entity =>
            {
                entity.HasKey(e => e.IdnomenclatureCodeApe);

                entity.ToTable("Nomenclature_CodeAPE");

                entity.Property(e => e.IdnomenclatureCodeApe).HasColumnName("IDNomenclatureCodeAPE");

                entity.Property(e => e.CodeApe)
                    .IsRequired()
                    .HasColumnName("CodeAPE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Idnomenclature).HasColumnName("IDNomenclature");
            });

            modelBuilder.Entity<NomenclatureGhost>(entity =>
            {
                entity.HasKey(e => e.IdnomenclatureGhost);

                entity.ToTable("Nomenclature_Ghost");

                entity.Property(e => e.IdnomenclatureGhost).HasColumnName("IDNomenclatureGhost");

                entity.Property(e => e.Idnomenclature).HasColumnName("IDNomenclature");

                entity.Property(e => e.IdnomenclatureParent).HasColumnName("IDNomenclatureParent");
            });

            modelBuilder.Entity<NomenclatureSelection>(entity =>
            {
                entity.HasKey(e => e.IdnomenclatureListeSelection);

                entity.ToTable("Nomenclature_Selection");

                entity.Property(e => e.IdnomenclatureListeSelection).HasColumnName("IDNomenclatureListeSelection");

                entity.Property(e => e.IdlisteSelection).HasColumnName("IDListeSelection");

                entity.Property(e => e.Idnomenclature).HasColumnName("IDNomenclature");
            });

            modelBuilder.Entity<ParametresService>(entity =>
            {
                entity.HasKey(e => e.IdparametreService);

                entity.ToTable("Parametres_Service");

                entity.Property(e => e.IdparametreService).HasColumnName("IDParametreService");

                entity.Property(e => e.BackgroundColor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BaseLine)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CallToAction)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CodeSiteGoogleAnalytics)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultFolder)
                    .HasColumnName("Default_Folder")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FonctionAchCible)
                    .HasColumnName("Fonction_ACH_Cible")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdadminCommunaute)
                    .IsRequired()
                    .HasColumnName("IDAdminCommunaute")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdlisteService).HasColumnName("IDListeService");

                entity.Property(e => e.IdresponsableVendeur).HasColumnName("IDResponsableVendeur");

                entity.Property(e => e.IdsiteEvenement).HasColumnName("IDSiteEvenement");

                entity.Property(e => e.IdutilisateurVendeur)
                    .IsRequired()
                    .HasColumnName("IDUtilisateurVendeur")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LienFacebook)
                    .HasColumnName("Lien_Facebook")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LienLinkedin)
                    .HasColumnName("Lien_Linkedin")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LienTweet)
                    .HasColumnName("Lien_Tweet")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LienViadeoAsupprimer)
                    .HasColumnName("Lien_Viadeo_asupprimer")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TypeEvenement)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.ISActivePUB);
                entity.Property(e => e.ISActiveAterlie);
                entity.Property(e => e.ODCDate).HasColumnName("ODC_Date");
                entity.Property(e => e.FDCDate).HasColumnName("FDC_Date");
                entity.Property(e => e.PUBFileExtend).HasColumnName("PUB_FileExtend");
                entity.Property(e => e.PUBFilePath).HasColumnName("PUB_FilePath").HasMaxLength(256).IsUnicode(false);
                entity.Property(e => e.PUBFileName).HasColumnName("PUB_FileName").HasMaxLength(100).IsUnicode(false);
                entity.Property(e => e.MapLink);
                entity.Property(e => e.MapBus);
                entity.Property(e => e.MapCar);
                entity.Property(e => e.MapPlane);
                

            });

            modelBuilder.Entity<ParametresSousService>(entity =>
            {
                entity.HasKey(e => e.IdparametreSousService);

                entity.ToTable("Parametres_SousService");

                entity.Property(e => e.IdparametreSousService).HasColumnName("IDParametreSousService");

                entity.Property(e => e.Idlieu).HasColumnName("IDLieu");

                entity.Property(e => e.IdlisteSousService).HasColumnName("IDListeSousService");

                entity.Property(e => e.IdresponsableAcheteur).HasColumnName("IDResponsableAcheteur");

                entity.Property(e => e.IdutilisateurAcheteur)
                    .HasColumnName("IDUtilisateurAcheteur")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RequeteAoptimiser>(entity =>
            {
                entity.HasKey(e => e.Idrequete);

                entity.ToTable("_RequeteAOptimiser");

                entity.Property(e => e.Idrequete).HasColumnName("IDRequete");

                entity.Property(e => e.Idmarketing).HasColumnName("IDMarketing");

                entity.Property(e => e.IdorigineRequete).HasColumnName("IDOrigineRequete");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");

                entity.Property(e => e.Requete)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.RequeteHeure).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaisieExterneCommentaire>(entity =>
            {
                entity.HasKey(e => new { e.NomSociete, e.CodePostal, e.PrenomContact, e.NomContact });

                entity.ToTable("SaisieExterne_Commentaire");

                entity.Property(e => e.NomSociete)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodePostal)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PrenomContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Commentaire)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.DateCommentaire).HasColumnType("datetime");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");
            });

            modelBuilder.Entity<SaisieExterneContact>(entity =>
            {
                entity.HasKey(e => new { e.NomSociete, e.CodePostal, e.PrenomContact, e.NomContact });

                entity.ToTable("SaisieExterne_Contact");

                entity.Property(e => e.NomSociete)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodePostal)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PrenomContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailContact)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FaxContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FonctionContact)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IdlisteFonction).HasColumnName("IDListeFonction");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");

                entity.Property(e => e.PortableContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelephoneContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SaisieExterneInformation>(entity =>
            {
                entity.HasKey(e => new { e.NomSociete, e.CodePostal, e.PrenomContact, e.NomContact });

                entity.ToTable("SaisieExterne_Information");

                entity.Property(e => e.NomSociete)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodePostal)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PrenomContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idenquete).HasColumnName("IDEnquete");

                entity.Property(e => e.IdquestionType)
                    .HasColumnName("IDQuestion+Type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdquestionType1).HasColumnName("IDQuestion+Type1");

                entity.Property(e => e.IdquestionType2)
                    .HasColumnName("IDQuestion+Type2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdquestionType3)
                    .HasColumnName("IDQuestion+Type3")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdquestionType4)
                    .HasColumnName("IDQuestion+Type4")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SaisieExterneSociete>(entity =>
            {
                entity.HasKey(e => new { e.NomSociete, e.CodePostal });

                entity.ToTable("SaisieExterne_Societe");

                entity.Property(e => e.NomSociete)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodePostal)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ActiviteSociete)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Adresse1)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Adresse2)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Adresse3)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodeApe)
                    .HasColumnName("CodeAPE")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeApe2008)
                    .HasColumnName("CodeAPE2008")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.EmailSociete)
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.FaxSociete)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Groupe)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdlisteFormeJuridique).HasColumnName("IDListeFormeJuridique");

                entity.Property(e => e.IdlistePays).HasColumnName("IDListePays");

                entity.Property(e => e.IdsocieteConfie).HasColumnName("IDSocieteConfie");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.IdtypeCa).HasColumnName("IDTypeCA");

                entity.Property(e => e.IdtypeEffectif).HasColumnName("IDTypeEffectif");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");

                entity.Property(e => e.Siret)
                    .HasColumnName("SIRET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteInternet)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.TelephoneSociete)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ville)
                    .HasMaxLength(41)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Salarie>(entity =>
            {
                entity.HasKey(e => e.Idcontact);

                entity.Property(e => e.Idcontact)
                    .HasColumnName("IDContact")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateNaissance).HasColumnType("date");
            });

            modelBuilder.Entity<SalarieAbsence>(entity =>
            {
                entity.HasKey(e => e.IdsalarieAbsence);

                entity.ToTable("Salarie_Absence");

                entity.Property(e => e.IdsalarieAbsence).HasColumnName("IDSalarieAbsence");

                entity.Property(e => e.Commentaire).HasColumnType("text");

                entity.Property(e => e.DateCreation).HasColumnType("smalldatetime");

                entity.Property(e => e.DateDebut).HasColumnType("smalldatetime");

                entity.Property(e => e.DateDecomptage).HasColumnType("date");

                entity.Property(e => e.DateFin).HasColumnType("smalldatetime");

                entity.Property(e => e.DateValidation).HasColumnType("smalldatetime");

                entity.Property(e => e.Idcontact).HasColumnName("IDContact");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.IdtypeAbsence).HasColumnName("IDTypeAbsence");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");
            });

            modelBuilder.Entity<SalariePaie>(entity =>
            {
                entity.HasKey(e => e.IdsalariePaie);

                entity.ToTable("Salarie_Paie");

                entity.Property(e => e.IdsalariePaie).HasColumnName("IDSalariePaie");

                entity.Property(e => e.Absence).HasColumnType("text");

                entity.Property(e => e.AbsenceAm)
                    .HasColumnName("AbsenceAM")
                    .HasColumnType("text");

                entity.Property(e => e.AbsenceCp)
                    .HasColumnName("AbsenceCP")
                    .HasColumnType("text");

                entity.Property(e => e.AbsenceCss)
                    .HasColumnName("AbsenceCSS")
                    .HasColumnType("text");

                entity.Property(e => e.Commentaire).HasColumnType("text");

                entity.Property(e => e.CommissionAjustement).HasColumnType("money");

                entity.Property(e => e.CommissionAuto).HasColumnType("money");

                entity.Property(e => e.DateEntree).HasColumnType("date");

                entity.Property(e => e.DateSortie).HasColumnType("date");

                entity.Property(e => e.FonctionContact)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FraisTransport).HasColumnType("money");

                entity.Property(e => e.Idcontact).HasColumnName("IDContact");

                entity.Property(e => e.IdlisteCoefficient).HasColumnName("IDListeCoefficient");

                entity.Property(e => e.IdlistePosition).HasColumnName("IDListePosition");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.IdstatutSalarie).HasColumnName("IDStatutSalarie");

                entity.Property(e => e.IdtypeContrat).HasColumnName("IDTypeContrat");

                entity.Property(e => e.Mois).HasColumnType("date");

                entity.Property(e => e.NomContact)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrenomContact)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prime).HasColumnType("money");

                entity.Property(e => e.SalaireBrut).HasColumnType("money");
            });

            modelBuilder.Entity<Societe>(entity =>
            {
                entity.HasKey(e => e.Idsociete);

                entity.Property(e => e.Idsociete).HasColumnName("IDSociete");

                entity.Property(e => e.ActiviteSociete)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Adresse1)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Adresse2)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Adresse3)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AnneeCa).HasColumnName("AnneeCA");

                entity.Property(e => e.Ca)
                    .HasColumnName("CA")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Capital)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CodeApe)
                    .HasColumnName("CodeAPE")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodeApe2008)
                    .HasColumnName("CodeAPE2008")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodePostal)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreationSociete).HasColumnType("datetime");

                entity.Property(e => e.DateFondation).HasColumnType("datetime");

                entity.Property(e => e.DateMajmanuelleSociete)
                    .HasColumnName("DateMAJManuelleSociete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateMajsociete)
                    .HasColumnName("DateMAJSociete")
                    .HasColumnType("datetime");

                entity.Property(e => e.Effectif)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EmailSociete)
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.FaxSociete)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Groupe)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdgroupeSociete).HasColumnName("IDGroupeSociete");

                entity.Property(e => e.IdlisteBase).HasColumnName("IDListeBase");

                entity.Property(e => e.IdlisteFormeJuridique).HasColumnName("IDListeFormeJuridique");

                entity.Property(e => e.IdlistePays).HasColumnName("IDListePays");

                entity.Property(e => e.IdnomSociete)
                    .HasColumnName("IDNomSociete")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdnomVille)
                    .HasColumnName("IDNomVille")
                    .HasMaxLength(41)
                    .IsUnicode(false);

                entity.Property(e => e.IdsocieteParent).HasColumnName("IDSocieteParent");

                entity.Property(e => e.IdsocieteProprietaire).HasColumnName("IDSocieteProprietaire");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.IdstatutClient).HasColumnName("IDStatutClient");

                entity.Property(e => e.IdtypeCa).HasColumnName("IDTypeCA");

                entity.Property(e => e.IdtypeCapital).HasColumnName("IDTypeCapital");

                entity.Property(e => e.IdtypeEffectif).HasColumnName("IDTypeEffectif");

                entity.Property(e => e.IdtypeNature).HasColumnName("IDTypeNature");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");

                entity.Property(e => e.Kompass)
                    .HasColumnName("KOMPASS")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.LeftCodeApe2)
                    .HasColumnName("LeftCodeAPE2")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LeftCodeApe3)
                    .HasColumnName("LeftCodeAPE3")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.LeftCodePostal2)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NomSociete)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OldIdsociete).HasColumnName("Old_IDSociete");

                entity.Property(e => e.Siret)
                    .HasColumnName("SIRET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteInternet)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.TelephoneSociete)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ville)
                    .HasMaxLength(41)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SocieteDateDernierAppel>(entity =>
            {
                entity.HasKey(e => e.Idsociete);

                entity.ToTable("Societe_Date_Dernier_Appel");

                entity.Property(e => e.Idsociete)
                    .HasColumnName("IDSociete")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateDernierAppel).HasColumnType("smalldatetime");

                entity.Property(e => e.Idcontact).HasColumnName("IDContact");

                entity.Property(e => e.Idhistorique)
                    .IsRequired()
                    .HasColumnName("IDHistorique")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");

                entity.Property(e => e.NomUtilisateur)
                    .IsRequired()
                    .HasMaxLength(105)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SocieteDisponibleDci>(entity =>
            {
                entity.HasKey(e => e.IdenqueteSociete);

                entity.ToTable("Societe_Disponible_DCI");

                entity.Property(e => e.IdenqueteSociete)
                    .HasColumnName("IDEnqueteSociete")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateValidation).HasColumnType("smalldatetime");

                entity.Property(e => e.Idchaine).HasColumnName("IDChaine");

                entity.Property(e => e.Idregion).HasColumnName("IDRegion");

                entity.Property(e => e.Redaction).HasColumnType("text");

                entity.Property(e => e.RedactionBrute).HasColumnType("text");
            });

            modelBuilder.Entity<SocieteDisponibleFicDetails>(entity =>
            {
                entity.HasKey(e => e.IddisponibleFicdetails);

                entity.ToTable("Societe_DisponibleFIC_Details");

                entity.Property(e => e.IddisponibleFicdetails).HasColumnName("IDDisponibleFICDetails");

                entity.Property(e => e.DateDerniereMaj)
                    .HasColumnName("DateDerniereMAJ")
                    .HasColumnType("datetime");

                entity.Property(e => e.Idchaine).HasColumnName("IDChaine");

                entity.Property(e => e.Idcontact).HasColumnName("IDContact");

                entity.Property(e => e.IdenqueteSocieteProjet).HasColumnName("IDEnqueteSocieteProjet");

                entity.Property(e => e.Idsociete).HasColumnName("IDSociete");

                entity.Property(e => e.Redaction).HasColumnType("text");
            });

            modelBuilder.Entity<SocieteDistance>(entity =>
            {
                entity.HasKey(e => e.IdsocieteDistance);

                entity.ToTable("Societe_Distance");

                entity.Property(e => e.IdsocieteDistance).HasColumnName("IDSocieteDistance");

                entity.Property(e => e.IdsocieteArrivee).HasColumnName("IDSocieteArrivee");

                entity.Property(e => e.IdsocieteDepart).HasColumnName("IDSocieteDepart");
            });

            modelBuilder.Entity<SocieteFormatEmail>(entity =>
            {
                entity.HasKey(e => e.IdsocieteFormatEmail);

                entity.ToTable("Societe_FormatEmail");

                entity.Property(e => e.IdsocieteFormatEmail).HasColumnName("IDSocieteFormatEmail");

                entity.Property(e => e.Idsociete).HasColumnName("IDSociete");

                entity.Property(e => e.IdtypeFormatEmail).HasColumnName("IDTypeFormatEmail");
            });

            modelBuilder.Entity<SocieteIp>(entity =>
            {
                entity.HasKey(e => e.SocieteIp1);

                entity.ToTable("Societe_IP");

                entity.Property(e => e.SocieteIp1).HasColumnName("SocieteIP");

                entity.Property(e => e.DoublonSteSurIp).HasColumnName("DoublonSteSurIP");

                entity.Property(e => e.Idcontact).HasColumnName("IDContact");

                entity.Property(e => e.Iddepartement)
                    .HasColumnName("IDDepartement")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Idsociete).HasColumnName("IDSociete");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("IP")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Navigateur)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SocieteIpVisite>(entity =>
            {
                entity.HasKey(e => e.IdsocieteIpVisite);

                entity.ToTable("Societe_IP_Visite");

                entity.Property(e => e.IdsocieteIpVisite).HasColumnName("IDSociete_IP_Visite");

                entity.Property(e => e.DateVisite).HasColumnType("smalldatetime");

                entity.Property(e => e.IdlisteSousService).HasColumnName("IDListeSousService");

                entity.Property(e => e.Idsite).HasColumnName("IDSite");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("IP")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ordinateur)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Origine)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PageVisitee)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SocieteNomenclature>(entity =>
            {
                entity.HasKey(e => e.Idnomenclature);

                entity.ToTable("Societe_Nomenclature");

                entity.Property(e => e.Idnomenclature).HasColumnName("IDNomenclature");

                entity.Property(e => e.IdabonnementContact).HasColumnName("IDAbonnementContact");

                entity.Property(e => e.Idcontact).HasColumnName("IDContact");

                entity.Property(e => e.IdenqueteSociete).HasColumnName("IDEnqueteSociete");

                entity.Property(e => e.IdnomenclatureSelectionne).HasColumnName("IDNomenclatureSelectionne");

                entity.Property(e => e.Idsociete).HasColumnName("IDSociete");

                entity.Property(e => e.IdtypeNomenclature).HasColumnName("IDTypeNomenclature");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");
            });

            modelBuilder.Entity<SocieteSelectionAbonnement>(entity =>
            {
                entity.HasKey(e => e.IdsocieteSelectionAbonnement);

                entity.ToTable("Societe_Selection_Abonnement");

                entity.Property(e => e.IdsocieteSelectionAbonnement).HasColumnName("IDSociete_Selection_Abonnement");

                entity.Property(e => e.IdabonnementContact).HasColumnName("IDAbonnementContact");

                entity.Property(e => e.Idpanier).HasColumnName("IDPanier");

                entity.Property(e => e.Idsociete).HasColumnName("IDSociete");
            });

            modelBuilder.Entity<Statistiques>(entity =>
            {
                entity.HasKey(e => e.Idstatistique);

                entity.Property(e => e.Idstatistique).HasColumnName("IDStatistique");

                entity.Property(e => e.DateStatistique).HasColumnType("datetime");

                entity.Property(e => e.IdtypeStatistique).HasColumnName("IDTypeStatistique");
            });

            modelBuilder.Entity<Statut>(entity =>
            {
                entity.HasKey(e => e.Idstatut);

                entity.ToTable("_Statut");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.Mission)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Profil)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Statut1)
                    .HasColumnName("Statut")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tacite)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TutorialHeadline>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .IsUnicode(false);

                entity.Property(e => e.ImportDate)
                    .HasColumnName("import_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Linkurl)
                    .IsRequired()
                    .HasColumnName("linkurl")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MergeHash)
                    .HasColumnName("merge_hash")
                    .HasMaxLength(16);

                entity.Property(e => e.Publisher)
                    .HasColumnName("publisher")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TutorialImport>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .IsUnicode(false);

                entity.Property(e => e.ImportDate)
                    .HasColumnName("import_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Linkurl)
                    .IsRequired()
                    .HasColumnName("linkurl")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MergeHash)
                    .HasColumnName("merge_hash")
                    .HasMaxLength(16);

                entity.Property(e => e.Publisher)
                    .HasColumnName("publisher")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UtilisateurCampagne>(entity =>
            {
                entity.HasKey(e => e.Idcampagne);

                entity.ToTable("Utilisateur_Campagne");

                entity.Property(e => e.Idcampagne).HasColumnName("IDCampagne");

                entity.Property(e => e.ActionUrl)
                    .HasColumnName("ActionURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Analyse).HasColumnType("text");

                entity.Property(e => e.ApercuPartiel).HasColumnType("text");

                entity.Property(e => e.Commentaire).HasColumnType("text");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.DateEnvoi).HasColumnType("datetime");

                entity.Property(e => e.DateFinEnvoi).HasColumnType("datetime");

                entity.Property(e => e.Iddocument).HasColumnName("IDDocument");

                entity.Property(e => e.IdenqueteCoupon).HasColumnName("IDEnqueteCoupon");

                entity.Property(e => e.IdlisteService).HasColumnName("IDListeService");

                entity.Property(e => e.IdlisteSousService).HasColumnName("IDListeSousService");

                entity.Property(e => e.IdmarketingDestinataire).HasColumnName("IDMarketingDestinataire");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.IdstatutEnvoi).HasColumnName("IDStatutEnvoi");

                entity.Property(e => e.IdtypeMessage).HasColumnName("IDTypeMessage");

                entity.Property(e => e.IdutilisateurExpediteur).HasColumnName("IDUtilisateurExpediteur");

                entity.Property(e => e.NomExpediteur)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreNonHtml).HasColumnName("NombreNonHTML");

                entity.Property(e => e.ObjetMessage)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ParametreEnvoiAncienClient).HasColumnName("Parametre_EnvoiAncienClient");

                entity.Property(e => e.ParametreEnvoiBdcrecu).HasColumnName("Parametre_EnvoiBDCRecu");

                entity.Property(e => e.ParametreEnvoiChaudSousService).HasColumnName("Parametre_EnvoiChaudSousService");

                entity.Property(e => e.ParametreEnvoiCoupon).HasColumnName("Parametre_EnvoiCoupon");

                entity.Property(e => e.ParametreEnvoiMailDormant).HasColumnName("Parametre_EnvoiMailDormant");

                entity.Property(e => e.ParametreEnvoiOkPrincipe).HasColumnName("Parametre_EnvoiOkPrincipe");

                entity.Property(e => e.ParametreEnvoiRepNegative).HasColumnName("Parametre_EnvoiRepNegative");

                entity.Property(e => e.ParametreForcerEnvoi).HasColumnName("Parametre_ForcerEnvoi");
            });

            modelBuilder.Entity<UtilisateurCampagneAutomatique>(entity =>
            {
                entity.HasKey(e => e.IdutilisateurCampagneAutomatique);

                entity.ToTable("Utilisateur_Campagne_Automatique");

                entity.Property(e => e.IdutilisateurCampagneAutomatique).HasColumnName("IDUtilisateurCampagneAutomatique");

                entity.Property(e => e.Idcampagne).HasColumnName("IDCampagne");

                entity.Property(e => e.IdutilisateurTacheAutomatique).HasColumnName("IDUtilisateurTacheAutomatique");
            });

            modelBuilder.Entity<UtilisateurCampagneBaseEnvoi>(entity =>
            {
                entity.HasKey(e => e.IdutilisateurCampagneBaseEnvoi);

                entity.ToTable("Utilisateur_Campagne_BaseEnvoi");

                entity.Property(e => e.IdutilisateurCampagneBaseEnvoi).HasColumnName("IDUtilisateurCampagneBaseEnvoi");

                entity.Property(e => e.Idcampagne).HasColumnName("IDCampagne");

                entity.Property(e => e.Idmarketing).HasColumnName("IDMarketing");
            });

            modelBuilder.Entity<UtilisateurCampagneLien>(entity =>
            {
                entity.HasKey(e => e.IdcampagneLien);

                entity.ToTable("Utilisateur_Campagne_Lien");

                entity.Property(e => e.IdcampagneLien).HasColumnName("IDCampagneLien");

                entity.Property(e => e.Idcampagne).HasColumnName("IDCampagne");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.Lien)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UtilisateurCampagneSa>(entity =>
            {
                entity.HasKey(e => e.IdcampagneSa);

                entity.ToTable("Utilisateur_Campagne_SA");

                entity.Property(e => e.IdcampagneSa).HasColumnName("IDCampagneSA");

                entity.Property(e => e.Civilite)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CiviliteAbrege)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailContact)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdcasMailing).HasColumnName("IDCasMailing");

                entity.Property(e => e.Idcontact).HasColumnName("IDContact");

                entity.Property(e => e.IdenqueteSociete).HasColumnName("IDEnqueteSociete");

                entity.Property(e => e.Idsociete).HasColumnName("IDSociete");

                entity.Property(e => e.NomContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrenomContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UtilisateurMarketing>(entity =>
            {
                entity.HasKey(e => e.Idmarketing);

                entity.ToTable("Utilisateur_Marketing");

                entity.Property(e => e.Idmarketing).HasColumnName("IDMarketing");

                entity.Property(e => e.CommentaireMarketing).HasColumnType("text");

                entity.Property(e => e.DateDerniereUtilisation).HasColumnType("datetime");

                entity.Property(e => e.DateMajutilisateurMarketing)
                    .HasColumnName("DateMAJUtilisateur_Marketing")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUtilisateurMarketing).HasColumnType("smalldatetime");

                entity.Property(e => e.IdgroupeMarketing).HasColumnName("IDGroupeMarketing");

                entity.Property(e => e.IdlisteService).HasColumnName("IDListeService");

                entity.Property(e => e.IdlisteSousService).HasColumnName("IDListeSousService");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.IdtypeEnquete).HasColumnName("IDTypeEnquete");

                entity.Property(e => e.IdutilisateurCreateur).HasColumnName("IDUtilisateurCreateur");

                entity.Property(e => e.NomRequete)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Requete).HasColumnType("text");

                entity.Property(e => e.UtilisationCampagne).HasColumnName("Utilisation_Campagne");

                entity.Property(e => e.UtilisationListe).HasColumnName("Utilisation_Liste");

                entity.Property(e => e.UtilisationRecherche).HasColumnName("Utilisation_Recherche");

                entity.Property(e => e.UtilisationXls).HasColumnName("Utilisation_XLS");
            });

            modelBuilder.Entity<UtilisateurMarketingTmp>(entity =>
            {
                entity.HasKey(e => e.SessionId);

                entity.ToTable("Utilisateur_Marketing_TMP");

                entity.Property(e => e.SessionId)
                    .HasColumnName("SessionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateMarketing).HasColumnType("datetime");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");

                entity.Property(e => e.MoteurHtml)
                    .HasColumnName("MoteurHTML")
                    .HasColumnType("text");

                entity.Property(e => e.NomMarketing)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NomPageListe)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RequeteMarketing)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<UtilisateurMarketingUtilisateur>(entity =>
            {
                entity.HasKey(e => e.IdutilisateurMarketingUtilisateur);

                entity.ToTable("Utilisateur_Marketing_Utilisateur");

                entity.Property(e => e.IdutilisateurMarketingUtilisateur).HasColumnName("IDUtilisateurMarketingUtilisateur");

                entity.Property(e => e.Idmarketing).HasColumnName("IDMarketing");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");
            });

            modelBuilder.Entity<UtilisateurMessage>(entity =>
            {
                entity.HasKey(e => e.IdutilisateurMessage);

                entity.ToTable("Utilisateur_Message");

                entity.Property(e => e.IdutilisateurMessage).HasColumnName("IDUtilisateurMessage");

                entity.Property(e => e.DateMessage).HasColumnType("datetime");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.IdutilisateurEmeteur).HasColumnName("IDUtilisateurEmeteur");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<UtilisateurObjectif>(entity =>
            {
                entity.HasKey(e => e.Idobjectif);

                entity.ToTable("Utilisateur_Objectif");

                entity.Property(e => e.Idobjectif).HasColumnName("IDObjectif");

                entity.Property(e => e.DateDebutObjectif).HasColumnType("smalldatetime");

                entity.Property(e => e.DateFinObjectif).HasColumnType("smalldatetime");

                entity.Property(e => e.IdfactureFamille).HasColumnName("IDFactureFamille");

                entity.Property(e => e.IdtypeEnqueteCible).HasColumnName("IDTypeEnqueteCible");

                entity.Property(e => e.IdtypeObjectif).HasColumnName("IDTypeObjectif");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");
            });

            modelBuilder.Entity<UtilisateurPanier>(entity =>
            {
                entity.HasKey(e => e.Idpanier);

                entity.ToTable("Utilisateur_Panier");

                entity.Property(e => e.Idpanier).HasColumnName("IDPanier");

                entity.Property(e => e.Idicone).HasColumnName("IDIcone");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");

                entity.Property(e => e.NomPanier)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UtilisateurParametre>(entity =>
            {
                entity.HasKey(e => e.IdutilisateurParametre);

                entity.ToTable("Utilisateur_Parametre");

                entity.Property(e => e.IdutilisateurParametre).HasColumnName("IDUtilisateurParametre");

                entity.Property(e => e.Ididtable).HasColumnName("IDIDTable");

                entity.Property(e => e.IdtypeUtilisateur).HasColumnName("IDTypeUtilisateur");

                entity.Property(e => e.IdtypeUtilisateurParametre).HasColumnName("IDTypeUtilisateurParametre");
            });

            modelBuilder.Entity<UtilisateurRecherche>(entity =>
            {
                entity.HasKey(e => e.IdutilisateurRecherche);

                entity.ToTable("Utilisateur_Recherche");

                entity.Property(e => e.IdutilisateurRecherche).HasColumnName("IDUtilisateurRecherche");

                entity.Property(e => e.DateRecherche).HasColumnType("datetime");

                entity.Property(e => e.IdabonnementContact).HasColumnName("IDAbonnementContact");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.NomRecherche)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UtilisateurRechercheDetails>(entity =>
            {
                entity.HasKey(e => e.IdutilisateurRechercheDetails);

                entity.ToTable("Utilisateur_Recherche_Details");

                entity.Property(e => e.IdutilisateurRechercheDetails).HasColumnName("IDUtilisateurRechercheDetails");

                entity.Property(e => e.IdutilisateurRecherche).HasColumnName("IDUtilisateurRecherche");

                entity.Property(e => e.RechercheName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RechercheValue)
                    .HasMaxLength(5000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UtilisateurResultat>(entity =>
            {
                entity.HasKey(e => e.Idresultat);

                entity.ToTable("Utilisateur_Resultat");

                entity.Property(e => e.Idresultat).HasColumnName("IDResultat");

                entity.Property(e => e.DateMajresultat)
                    .HasColumnName("DateMAJResultat")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateResultat).HasColumnType("datetime");

                entity.Property(e => e.Idcontact).HasColumnName("IDContact");

                entity.Property(e => e.IdenqueteSociete).HasColumnName("IDEnqueteSociete");

                entity.Property(e => e.IdlisteSousService).HasColumnName("IDListeSousService");

                entity.Property(e => e.Idmarketing).HasColumnName("IDMarketing");

                entity.Property(e => e.Idorigine).HasColumnName("IDOrigine");

                entity.Property(e => e.Idsociete).HasColumnName("IDSociete");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.IdtypeResultat).HasColumnName("IDTypeResultat");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");
            });

            modelBuilder.Entity<UtilisateurTache>(entity =>
            {
                entity.HasKey(e => e.Idtache);

                entity.ToTable("Utilisateur_Tache");

                entity.Property(e => e.Idtache).HasColumnName("IDTache");

                entity.Property(e => e.DateCreation).HasColumnType("smalldatetime");

                entity.Property(e => e.DateExecution).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTache).HasColumnType("datetime");

                entity.Property(e => e.Idcontact).HasColumnName("IDContact");

                entity.Property(e => e.Idenquete).HasColumnName("IDEnquete");

                entity.Property(e => e.IdlisteSousService).HasColumnName("IDListeSousService");

                entity.Property(e => e.Idmediatheque).HasColumnName("IDMediatheque");

                entity.Property(e => e.Idmission).HasColumnName("IDMission");

                entity.Property(e => e.Idsociete).HasColumnName("IDSociete");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.IdtypeTache).HasColumnName("IDTypeTache");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");

                entity.Property(e => e.IdutilisateurCreateur).HasColumnName("IDUtilisateurCreateur");

                entity.Property(e => e.LibelleTache)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UtilisateurTacheAutomatique>(entity =>
            {
                entity.HasKey(e => e.IdutilisateurTacheAutomatique);

                entity.ToTable("Utilisateur_Tache_Automatique");

                entity.Property(e => e.IdutilisateurTacheAutomatique).HasColumnName("IDUtilisateurTacheAutomatique");

                entity.Property(e => e.ActionTache)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateDebut).HasColumnType("datetime");

                entity.Property(e => e.DateFin).HasColumnType("datetime");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.NomTache)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UtilisateurTacheAutomatiqueLogs>(entity =>
            {
                entity.HasKey(e => e.IdutilisateurTacheAutomatiqueLogs);

                entity.ToTable("Utilisateur_Tache_Automatique_Logs");

                entity.Property(e => e.IdutilisateurTacheAutomatiqueLogs).HasColumnName("IDUtilisateurTacheAutomatiqueLogs");

                entity.Property(e => e.DateHeureDebutExecution).HasColumnType("datetime");

                entity.Property(e => e.DateHeureFinExecution).HasColumnType("datetime");

                entity.Property(e => e.IdstatutExecution).HasColumnName("IDStatutExecution");

                entity.Property(e => e.IdutilisateurTacheAutomatique).HasColumnName("IDUtilisateurTacheAutomatique");
            });

            modelBuilder.Entity<UtilisateurTacheInfo>(entity =>
            {
                entity.HasKey(e => e.IdtacheInfo);

                entity.ToTable("Utilisateur_Tache_INFO");

                entity.Property(e => e.IdtacheInfo).HasColumnName("IDTacheInfo");

                entity.Property(e => e.DateCreation).HasColumnType("smalldatetime");

                entity.Property(e => e.DateExecution).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTache).HasColumnType("datetime");

                entity.Property(e => e.DetailTache).HasColumnType("text");

                entity.Property(e => e.Idcontact).HasColumnName("IDContact");

                entity.Property(e => e.Idrubrique).HasColumnName("IDRubrique");

                entity.Property(e => e.Idservice).HasColumnName("IDService");

                entity.Property(e => e.Idstatut).HasColumnName("IDStatut");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");

                entity.Property(e => e.LibelleTache)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewListeChaine>(entity =>
            {
                entity.HasKey(e => e.Idchaine);

                entity.ToTable("view_Liste_Chaine");

                entity.Property(e => e.Idchaine)
                    .HasColumnName("IDChaine")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcheteurChaine)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Chaine)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdchaineLight).HasColumnName("IDChaineLight");

                entity.Property(e => e.Idutilisateur).HasColumnName("IDUtilisateur");

                entity.Property(e => e.UtilisationChaine)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendeurChaine)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewListeLocalisation>(entity =>
            {
                entity.HasKey(e => e.Iddepartement);

                entity.ToTable("view_Liste_Localisation");

                entity.Property(e => e.Iddepartement)
                    .HasColumnName("IDDepartement")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Departement)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Idregion).HasColumnName("IDRegion");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RegionAbrege)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewListeLocalisationRegion>(entity =>
            {
                entity.HasKey(e => e.Idregion);

                entity.ToTable("view_Liste_Localisation_Region");

                entity.Property(e => e.Idregion)
                    .HasColumnName("IDRegion")
                    .ValueGeneratedNever();

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RegionAbrege)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewTypeSociete>(entity =>
            {
                entity.HasKey(e => e.IdtypeSociete);

                entity.ToTable("view_Type_Societe");

                entity.Property(e => e.IdtypeSociete)
                    .HasColumnName("IDTypeSociete")
                    .ValueGeneratedNever();

                entity.Property(e => e.TypeSociete)
                    .IsRequired()
                    .HasMaxLength(22)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Liste_Utilisateur>(entity =>
           {
               entity.HasKey(e => e.IDUtilisateur);

               entity.Property(e => e.IDSocieteUtilisateur);

               entity.Property(e => e.CiviliteAbregeUtilisateur);

               entity.Property(e => e.PrenomUtilisateur);
               entity.Property(e => e.NomUtilisateur);
               entity.Property(e => e.LoginUtilisateur);
               entity.Property(e => e.MotdePasseUtilisateur);
               entity.Property(e => e.EmailUtilisateur);
               entity.Property(e => e.TelephoneUtilisateur);
               entity.Property(e => e.IDTypeUtilisateur);
               entity.Property(e => e.TypeUtilisateur);
               entity.Property(e => e.IDStatutUtilisateur);
               entity.Property(e => e.FonctionGeneriqueUtilisateur);
               entity.Property(e => e.IDResponsable);
               entity.Property(e => e.StatutUtilisateur);
               entity.Property(e => e.FonctionUtilisateur);
               entity.Property(e => e.ImportanceTypeUtilisateur);
               entity.Property(e => e.CiviliteUtilisateur);
               entity.Property(e => e.PortableUtilisateur);
               entity.Property(e => e.Priorite);

           });
            modelBuilder.Entity<Liste_Enquete_Contact>(entity =>
            {
                entity.HasKey(e => e.IDEnqueteSociete);

                entity.Property(e => e.IDEnquete);

                entity.Property(e => e.IDSociete);

                entity.Property(e => e.IDContact);
                entity.Property(e => e.IDStatut);
                entity.Property(e => e.IDStatutClient);
                entity.Property(e => e.ContactPrincipal);
                entity.Property(e => e.IDTypeEnquete);
                entity.Property(e => e.IDListeService);
                entity.Property(e => e.Vendeur);
                entity.Property(e => e.Acheteur);
                entity.Property(e => e.DateFinEnquete);
            });
            modelBuilder.Entity<view_Liste_Societe_Logo>(entity =>
            {
                entity.Property(e => e.UrlLogo);
                entity.Property(e => e.IDTypeDocument);
                entity.HasKey(e => e.IDSociete);
                entity.Property(e => e.Officiel);
                entity.Property(e => e.IDDocument);
            });
            modelBuilder.Entity<Liste_Pays>(entity =>
            {
                entity.HasKey(e => e.IDListePays);
                entity.Property(e => e.Pays);
                entity.Property(e => e.ParDefaut);
                entity.Property(e => e.Indicatif);
                entity.Property(e => e.AbreviationPays);
            });
            modelBuilder.Entity<Type_Nature_Societe>(entity =>
           {
               entity.HasKey(e => e.IDTypeNature);
               entity.Property(e => e.TypeNature);
               entity.Property(e => e.IDBiblio_Niv2);
               entity.Property(e => e.IcoNature);
           });
            modelBuilder.Entity<Liste_Fonction>(entity =>
           {
               entity.HasKey(e => e.IDTypeFonction);

               entity.Property(e => e.TypeFonction);

               entity.Property(e => e.IDListeFonction);

               entity.Property(e => e.FonctionGenerique);
               entity.Property(e => e.ImportanceListeFonction);
               entity.Property(e => e.FonctionGeneriqueAbrege);
           });
            modelBuilder.Entity<Type_CA>(entity =>
         {
             entity.HasKey(e => e.IDTypeCA);

             entity.Property(e => e.TypeCA);

             entity.Property(e => e.IDBiblio_Niv2);

             entity.Property(e => e.ParDefaut);
             entity.Property(e => e.TypeCAAbrege);
         });
            modelBuilder.Entity<Type_Effectif>(entity =>
            {
                entity.HasKey(e => e.IDTypeEffectif);

                entity.Property(e => e.TypeEffectif);

                entity.Property(e => e.IDBiblio_Niv2);

                entity.Property(e => e.ParDefaut);
                entity.Property(e => e.TypeEffectifAbrege);
            });
            modelBuilder.Entity<Enquete_Contact_Ex>(entity =>
            {
                entity.HasKey(e => e.ID);

                entity.Property(e => e.IDIDEnquete);

                entity.Property(e => e.IDEnqueteSociete);

                entity.Property(e => e.OrderLevel);
            });
            modelBuilder.Entity<Liste_Sous_Service>(entity =>
          {
              entity.HasKey(e => e.IDListeSousService);

              entity.Property(e => e.IDListeSousServiceParent);

              entity.Property(e => e.SousService);

              entity.Property(e => e.IDListeService);

              entity.Property(e => e.IDStatut_Biblio_Niv3);

              entity.Property(e => e.ParDefaut);

              entity.Property(e => e.RepertoireSousService);

              entity.Property(e => e.Lieu);

              entity.Property(e => e.IDServiceLieu);

              entity.Property(e => e.IDNomenclature);

              entity.Property(e => e.Dictionnaire);

              entity.Property(e => e.IDBiblio_Niv2);
          });
            modelBuilder.Entity<Liste_Societe>(entity =>
           {
               entity.HasKey(e => e.IDSociete);

               entity.Property(e => e.NomSociete);

               entity.Property(e => e.ActiviteSociete);

               entity.Property(e => e.Adresse1);

               entity.Property(e => e.Adresse2);

               entity.Property(e => e.Adresse3);

               entity.Property(e => e.CodePostal);

               entity.Property(e => e.Ville);

               entity.Property(e => e.TelephoneSociete);

               entity.Property(e => e.FaxSociete);

               entity.Property(e => e.EmailSociete);

               entity.Property(e => e.SiteInternet);

               entity.Property(e => e.KOMPASS);

               entity.Property(e => e.SIRET);

               entity.Property(e => e.IDStatutSociete);

               entity.Property(e => e.StatutSociete);

               entity.Property(e => e.Groupe);

               entity.Property(e => e.ListeBase);

               entity.Property(e => e.IDTypeCA);

               entity.Property(e => e.TypeCA);

               entity.Property(e => e.IDTypeEffectif);

               entity.Property(e => e.TypeEffectif);

               entity.Property(e => e.IDListePays);

               entity.Property(e => e.IDListeFormeJuridique);

               entity.Property(e => e.IDUtilisateur);

               entity.Property(e => e.IDTypeNature);

               entity.Property(e => e.IDGroupeSociete);

               entity.Property(e => e.Old_IDSociete);

               entity.Property(e => e.IDListeBase);

               entity.Property(e => e.CodeAPE);

               entity.Property(e => e.LibelleAPE);

               entity.Property(e => e.Pays);

               entity.Property(e => e.Indicatif);

               entity.Property(e => e.ListeFormeJuridique);

               entity.Property(e => e.CodeAPE2008);

               entity.Property(e => e.LibelleAPE2008);

               entity.Property(e => e.LeftCodeAPE3);

               entity.Property(e => e.LeftCodeAPE2);

               entity.Property(e => e.LeftCodePostal2);

               entity.Property(e => e.Region);

               entity.Property(e => e.Departement);

               entity.Property(e => e.IDStatutClient);

               entity.Property(e => e.DateMAJSociete);

               entity.Property(e => e.DateMAJManuelleSociete);

               entity.Property(e => e.DateCreationSociete);

               entity.Property(e => e.ListeRougeTelephoneSociete);

           });
            modelBuilder.Entity<Liste_Societe_Profiler_v4>(entity =>
          {
              entity.HasKey(e => e.IDSociete);

              entity.Property(e => e.NomSociete);

              entity.Property(e => e.Localisation);

              entity.Property(e => e.LibelleAPE2008);

              entity.Property(e => e.CodeAPE2008);

              entity.Property(e => e.TypeEffectifAbrege);

              entity.Property(e => e.IDNomSociete);

              entity.Property(e => e.TypeNature);

              entity.Property(e => e.IcoNature);

              entity.Property(e => e.IDStatut);

              entity.Property(e => e.IDListePays);

              entity.Property(e => e.LeftCodePostal2);

              entity.Property(e => e.IDTypeEffectif);

              entity.Property(e => e.Groupe);

              entity.Property(e => e.CodePostal);

              entity.Property(e => e.TelephoneSociete);

              entity.Property(e => e.Adresse1);

              entity.Property(e => e.ActiviteSociete);

              entity.Property(e => e.Adresse2);

              entity.Property(e => e.Ville);

              entity.Property(e => e.AnneeCapital);

              entity.Property(e => e.SIRET);

              entity.Property(e => e.SiteInternet);

              entity.Property(e => e.ListeRougeTelephoneSociete);

              entity.Property(e => e.Indicatif);

          });
            modelBuilder.Entity<Liste_Contact_Profiler_v3>(entity =>
          {
              entity.HasKey(e => e.IDContact);

              entity.Property(e => e.IDSociete);

              entity.Property(e => e.CiviliteAbrege);

              entity.Property(e => e.PrenomContact);

              entity.Property(e => e.NomContact);

              entity.Property(e => e.TelephoneContact);

              entity.Property(e => e.EmailContact);

              entity.Property(e => e.FonctiongeneriqueContact);

              entity.Property(e => e.FonctionContact);

              entity.Property(e => e.NomSociete);

              entity.Property(e => e.LibelleAPE2008);

              entity.Property(e => e.TypeEffectif);

              entity.Property(e => e.CodePostal);

              entity.Property(e => e.FonctionGeneriqueAbrege);

              entity.Property(e => e.PortableContact);

              entity.Property(e => e.NombreRefusEMail);

              entity.Property(e => e.IDStatut);

              entity.Property(e => e.ListeRougeTelephoneSociete);
          });
            modelBuilder.Entity<Liste_Contact_PhotoID>(entity =>
            {
                entity.HasKey(e => e.IDDocument);

                entity.Property(e => e.IDContact);

                entity.Property(e => e.UrlPhoto);
            });
            modelBuilder.Entity<liste_Contact_Erreur>(entity =>
         {
             entity.HasKey(e => e.IDContact);

             entity.Property(e => e.motivation);
         });
            modelBuilder.Entity<Contact_ReseauSocial>(entity =>
                 {
                     entity.HasKey(e => e.IDContactReseauSocial);
                     entity.Property(e => e.IDContact);
                     entity.Property(e => e.IDTypeReseauSocial);
                     entity.Property(e => e.URLReseauSocial);
                 });
            modelBuilder.Entity<Type_ReseauSocial>(entity =>
      {
          entity.HasKey(e => e.IDTypeReseauSocial);
          entity.Property(e => e.TypeReseauSocial);
          entity.Property(e => e.Icon_ReseauSocial);
      });
            modelBuilder.Entity<Liste_Parametres_Service>(entity =>
         {
             entity.HasKey(e => e.IDListeService);
             entity.Property(e => e.Service);
             entity.Property(e => e.ServiceAbrege);
             entity.Property(e => e.Couleur);
             entity.Property(e => e.IDChaine);
             entity.Property(e => e.CodeSiteGoogleAnalytics);
             entity.Property(e => e.IDUtilisateurVendeur);
             entity.Property(e => e.IDAdminCommunaute);
             entity.Property(e => e.IDSiteEvenement);
             entity.Property(e => e.CallToAction);
             entity.Property(e => e.Fonction_ACH_Cible);
             entity.Property(e => e.BackgroundColor);
             entity.Property(e => e.TypeEvenement);
             entity.Property(e => e.Default_Folder);
             entity.Property(e => e.PrenomResponsable);
             entity.Property(e => e.NomResponsable);
             entity.Property(e => e.TelephoneResponsable);
             entity.Property(e => e.Lien_Tweet);
             entity.Property(e => e.EmailResponsable);
             entity.Property(e => e.PortableResponsable);
             entity.Property(e => e.NomDomaine);
             entity.Property(e => e.FonctionResponsable);
             entity.Property(e => e.Lien_Linkedin);
             entity.Property(e => e.Lien_Facebook);
             entity.Property(e => e.ISActivePUB);
             entity.Property(e => e.ISActiveAterlie);
             entity.Property(e => e.ODC_Date);
             entity.Property(e => e.FDC_Date);
             entity.Property(e => e.PUB_FilePath);
             entity.Property(e => e.PUB_FileName);
             entity.Property(e => e.PUB_FileExtend);
         });
            modelBuilder.Entity<Parametres_ServicePrograme>(entity =>
         {
             entity.HasKey(e => e.IDParametreServicePrograme);
             entity.Property(e => e.IDListeService);
             entity.Property(e => e.Temps);
             entity.Property(e => e.Titres);
             entity.Property(e => e.Contenu);
         });
        }
    }
}
