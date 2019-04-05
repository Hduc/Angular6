using System;
using System.Linq;
using db = PremiumcontactMaster.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PremiumcontactMaster.ModelData;
using System.Globalization;
using System.ComponentModel;

namespace PremiumcontactMaster.PremiumContactDA
{
    public class Enquete_SocieteDA
    {
        public db.DBContext _context;
        public Enquete_SocieteDA(db.DBContext context)
        {
            _context = context;
        }
        public async Task<List<Model_EnqueteSociete>> EventWidthCount(int count)
        {
            var lstEnqueteSocietelst = new List<Model_EnqueteSociete>();
            lstEnqueteSocietelst = await (from a in _context.EnqueteSociete
                                          join b in _context.Intermediation on a.Idenquete equals b.IdenqueteVendeur
                                          where b.Idstatut == 2 && (b.DateIntermediation > DateTime.Now)
                                          orderby b.DateIntermediation
                                          select new Model_EnqueteSociete()
                                          {
                                              Idintermediation = b.Idintermediation,
                                              Intermediation = b.Intermediation1,
                                              IDSociete = a.Idsociete,
                                              Lieu = b.Lieu,
                                              DateIntermediation = (b.DateIntermediation),
                                              IdListeService = Convert.ToInt32(b.IdlisteService),
                                              SiteWebIntermediation = b.SiteWebIntermediation
                                          }).Take(count).ToListAsync();
            return lstEnqueteSocietelst;
        }
        #region Load Event
        // Load data envent by Id User login > Now
        #region sql Load Event
        // event of BO
        // SELECT DISTINCT  dbo.Intermediation.IDIntermediation,dbo.Intermediation.SiteWebIntermediation,dbo.Intermediation.DateIntermediation, dbo.Intermediation.Lieu,dbo.Liste_Sous_Service.SousService, dbo.Liste_Sous_Service.IDListeSousService,   dbo.Liste_Sous_Service.IDListeService ,dbo.Utilisateur_Objectif.IDUtilisateur
        // FROM  dbo.Facture_Famille_Prestation 
        // INNER JOIN dbo.Utilisateur_Objectif ON dbo.Facture_Famille_Prestation.IDFactureFamille = dbo.Utilisateur_Objectif.IDFactureFamille 
        // INNER JOIN  dbo.Intermediation 
        // INNER JOIN  dbo.Liste_Sous_Service ON dbo.Intermediation.IDListeSousService = dbo.Liste_Sous_Service.IDListeSousService ON  dbo.Facture_Famille_Prestation.IDSousService = dbo.Intermediation.IDListeSousService 
        // WHERE (dbo.Intermediation.IDStatut < 3) AND (dbo.Utilisateur_Objectif.IDUtilisateur = 263920) and dbo.Intermediation.DateIntermediation< GETDATE()

        // envent of Client
        // SELECT dbo.Intermediation.IDIntermediation, dbo.Intermediation.Intermediation, dbo.Enquete_Societe.IDSociete, dbo.Intermediation.Lieu, dbo.Intermediation.DateIntermediation, dbo.Intermediation.IDListeService
        // FROM  dbo.Enquete_Societe 
        // INNER join dbo.Intermediation ON dbo.Enquete_Societe.IDEnquete = dbo.Intermediation.IDEnqueteVendeur
        // WHERE (dbo.Enquete_Societe.IDStatut > 0 AND dbo.Enquete_Societe.IDStatut < 3) AND (dbo.Enquete_Societe.IDStatutClient < 3) AND (dbo.Enquete_Societe.IDSociete = 236690)  AND  (dbo.Intermediation.DateIntermediation > GETDATE())
        #endregion
        public async Task<List<Model_EnqueteSociete>> LoadEvent(int idUser, int idsociete, string lieu = "", string intermediation1 = "")
        {
            if (lieu == null) lieu = "";
            if (intermediation1 == null) intermediation1 = "";
            var lst = new List<Model_EnqueteSociete>();

            // if societe == 23 ? Premium-contact : client
            if (idsociete == 23)
            {
                lst = await (from facture_Famille_Prestation in _context.FactureFamillePrestation
                             join utilisateurObjectif in _context.UtilisateurObjectif on facture_Famille_Prestation.IdfactureFamille equals utilisateurObjectif.IdfactureFamille
                             join intermediation in (
                                 from intermediation in _context.Intermediation
                                 join liste_Sous_Service in _context.Liste_Sous_Service on intermediation.IdlisteSousService equals liste_Sous_Service.IDListeSousService
                                 select intermediation
                             ) on facture_Famille_Prestation.IdsousService equals intermediation.IdlisteSousService into _intermediation
                             from intermediation in _intermediation.DefaultIfEmpty()
                             where intermediation.Idstatut < 3 && utilisateurObjectif.Idutilisateur == idUser
                             && intermediation.Lieu.Contains(lieu.Trim())
                             && intermediation.Intermediation1.Contains(intermediation1.Trim())
                             // && intermediation.DateIntermediation >= DateTime.Now
                             select new Model_EnqueteSociete()
                             {
                                 Idintermediation = intermediation.Idintermediation,
                                 Intermediation = intermediation.Intermediation1,
                                 SiteWebIntermediation = (intermediation.SiteWebIntermediation).IndexOf("www.") == -1 ? "www." + intermediation.SiteWebIntermediation : intermediation.SiteWebIntermediation,
                                 DateIntermediation = intermediation.DateIntermediation,
                                 Lieu = intermediation.Lieu,
                                 //  SousService = liste_Sous_Service.SousService,
                                 IDListeSousService = intermediation.IdlisteService,
                                 IdListeService = intermediation.IdlisteService,
                                 IDUtilisateur = utilisateurObjectif.Idutilisateur,
                                 IsEventHistory = intermediation.DateIntermediation > DateTime.Now ? 0 : 1,
                             }
               ).Distinct().OrderByDescending(x => x.DateIntermediation).ToListAsync();
            }
            else
            {

                lst = await (from enqueteSociete in _context.EnqueteSociete
                             join intermediation in _context.Intermediation on enqueteSociete.Idenquete equals intermediation.IdenqueteVendeur
                             where (enqueteSociete.Idstatut > 0 && enqueteSociete.Idstatut < 3 && enqueteSociete.IdstatutClient < 3)
                             && enqueteSociete.Idsociete == idsociete
                             && intermediation.Lieu.Contains(lieu.Trim())
                             && intermediation.Intermediation1.Contains(intermediation1.Trim())
                             //  && (intermediation.DateIntermediation >= DateTime.Now)
                             select new Model_EnqueteSociete()
                             {
                                 Idintermediation = intermediation.Idintermediation,
                                 Intermediation = intermediation.Intermediation1,
                                 IDSociete = enqueteSociete.Idsociete,
                                 Lieu = intermediation.Lieu,
                                 DateIntermediation = (intermediation.DateIntermediation),
                                 SiteWebIntermediation = intermediation.SiteWebIntermediation,
                                 IdListeService = intermediation.IdlisteService,
                                 IsEventHistory = intermediation.DateIntermediation > DateTime.Now ? 0 : 1
                             }).Distinct().OrderByDescending(x => x.DateIntermediation).ToListAsync();
                return lst;
            }

            return lst;
        }
        //  Load data envent by Id User login < Now
        // Delete
        public async Task<List<Model_EnqueteSociete>> LoadEvent_CbbHistory(int idUser, int idsociete)
        {
            var lst = new List<Model_EnqueteSociete>();
            // if societe == 23 ? Premium-contact : client
            if (idsociete == 23)
            {
                lst = await (from facture_Famille_Prestation in _context.FactureFamillePrestation
                             join utilisateurObjectif in _context.UtilisateurObjectif on facture_Famille_Prestation.IdfactureFamille equals utilisateurObjectif.IdfactureFamille
                             join intermediation in (
                                 from intermediation in _context.Intermediation
                                 join liste_Sous_Service in _context.Liste_Sous_Service on intermediation.IdlisteSousService equals liste_Sous_Service.IDListeSousService
                                 select intermediation
                             ) on facture_Famille_Prestation.IdsousService equals intermediation.IdlisteSousService into _intermediation
                             from intermediation in _intermediation.DefaultIfEmpty()
                             where intermediation.Idstatut < 3
                                && utilisateurObjectif.Idutilisateur == idUser
                                && intermediation.DateIntermediation < DateTime.Now
                             select new Model_EnqueteSociete()
                             {
                                 Idintermediation = intermediation.Idintermediation,
                                 Intermediation = intermediation.Intermediation1,
                                 SiteWebIntermediation = (intermediation.SiteWebIntermediation).IndexOf("www.") == -1 ? "www." + intermediation.SiteWebIntermediation : intermediation.SiteWebIntermediation,
                                 DateIntermediation = intermediation.DateIntermediation,
                                 Lieu = intermediation.Lieu,
                                 //  SousService = liste_Sous_Service.SousService,
                                 //  IDListeSousService = liste_Sous_Service.IDListeSousService,
                                 //  IdListeService = liste_Sous_Service.IdListeService,
                                 IDUtilisateur = utilisateurObjectif.Idutilisateur
                             }
                        ).Distinct().OrderBy(x => x.DateIntermediation).ToListAsync();
            }
            else
            {

                lst = await (from enqueteSociete in _context.EnqueteSociete
                             join intermediation in _context.Intermediation on enqueteSociete.Idenquete equals intermediation.IdenqueteVendeur
                             where (enqueteSociete.Idstatut > 0 && enqueteSociete.Idstatut < 3)
                             && (enqueteSociete.IdstatutClient < 3)
                             && (enqueteSociete.Idsociete == idsociete)
                             && (intermediation.DateIntermediation < DateTime.Now)
                             select new Model_EnqueteSociete()
                             {
                                 Idintermediation = intermediation.Idintermediation,
                                 Intermediation = intermediation.Intermediation1,
                                 IDSociete = enqueteSociete.Idsociete,
                                 Lieu = intermediation.Lieu,
                                 DateIntermediation = (intermediation.DateIntermediation),
                                 SiteWebIntermediation = intermediation.SiteWebIntermediation,
                                 IdListeService = intermediation.IdlisteService
                             }).Distinct().OrderBy(x => x.DateIntermediation).ToListAsync();
            }
            return lst;
        }
        #endregion

        public async Task<db.Intermediation> LoadSociete_byID(int id)
        {
            var obj = await _context.Intermediation.FirstOrDefaultAsync(x => x.Idintermediation == id);
            return obj;
        }
        // Load data company by Id
        public async Task<db.Societe> LoadSociete(int ID)
        {
            var obj = await _context.Societe.FirstOrDefaultAsync(x => x.Idsociete == ID);
            return obj;
        }
        // //update Societe
        public async Task<string> Update_Societe(db.Societe Societe)
        {
            var obj_Societe = new db.Societe();
            try
            {
                var idSociete = Societe.Idsociete;
                obj_Societe = await _context.Societe.FirstOrDefaultAsync(x => x.Idsociete == idSociete);
                if (obj_Societe.Idsociete > 0)
                {
                    obj_Societe.IdlisteFormeJuridique = Societe.IdlisteFormeJuridique;
                    obj_Societe.IdtypeNature = Societe.IdtypeNature;
                    obj_Societe.CodeApe2008 = Societe.CodeApe2008;
                    obj_Societe.Groupe = Societe.Groupe;
                    obj_Societe.Adresse1 = Societe.Adresse1;
                    obj_Societe.Adresse2 = Societe.Adresse2;
                    obj_Societe.CodePostal = Societe.CodePostal;
                    obj_Societe.Ville = Societe.Ville;
                    obj_Societe.TelephoneSociete = Societe.TelephoneSociete;
                    obj_Societe.FaxSociete = Societe.FaxSociete;
                    obj_Societe.EmailSociete = Societe.EmailSociete;
                    obj_Societe.SiteInternet = Societe.SiteInternet;
                    obj_Societe.ActiviteSociete = Societe.ActiviteSociete;
                    obj_Societe.Siret = Societe.Siret;
                    obj_Societe.IdtypeEffectif = Societe.IdtypeEffectif;
                    // obj_Societe.Effectif=Societe.Effectif;
                    obj_Societe.IdtypeCa = Societe.IdtypeCa;
                    // obj_Societe.Ca=Societe.Ca;
                    obj_Societe.IdlistePays = Societe.IdlistePays;
                    // update societe
                    await _context.SaveChangesAsync();
                    return "update to success";
                }
                else
                {
                    return "update to error";
                }
            }
            catch (System.Exception error)
            {
                return error.ToString();
            }
        }
        // Load logo company
        public async Task<db.view_Liste_Societe_Logo> LoadSocieteLogo(int ID)
        {
            db.view_Liste_Societe_Logo lst = new db.view_Liste_Societe_Logo();
            lst = await (from a in _context.view_Liste_Societe_Logo
                         where a.IDSociete == ID && a.Officiel == true
                         select a).FirstOrDefaultAsync();
            return lst;
        }
        #region Speed Meeting
        #region SQL

        // SELECT
        //   DISTINCT dbo.Enquete_Societe.IDEnquete
        // , dbo.Societe.CodeAPE2008
        // , ( SELECT TOP 1 IDIntermediationContact FROM dbo.Intermediation_Contact WHERE( IDContactVendeur = 263920 ) AND( IDEnqueteSocieteAcheteur = dbo.Enquete_Societe.IDEnqueteSociete ) ) as dejaselectionne
        // , dbo.Enquete_Societe.IDEnqueteSociete
        // , dbo.Contact_Civilite.CiviliteAbrege
        // , dbo.Contact.NomContact
        // , dbo.Contact.FonctionContact
        // , dbo.Liste_Fonction.FonctionGenerique
        // , dbo.Societe.Groupe
        // , dbo.Societe.NomSociete
        // , dbo.Societe.ActiviteSociete
        // , dbo.view_Liste_Localisation.Departement
        // , dbo.view_Liste_Localisation.Region
        // , dbo.Type_Effectif.TypeEffectif
        // , dbo.Type_CA.TypeCA
        // FROM dbo.Societe
        // JOIN dbo.Contact
        // JOIN dbo.Enquete_Societe
        //  ON dbo.Contact.IDContact = dbo.Enquete_Societe.IDContact
        // JOIN dbo.Contact_Civilite
        //  ON dbo.Contact.IDCivilite = dbo.Contact_Civilite.IDCivilite
        // JOIN dbo.Liste_Fonction
        //  ON dbo.Contact.IDListeFonction = dbo.Liste_Fonction.IDListeFonction ON dbo.Societe.IDSociete = dbo.Contact.IDSociete
        // JOIN dbo.Type_Effectif
        //  ON dbo.Societe.IDTypeEffectif = dbo.Type_Effectif.IDTypeEffectif
        // JOIN dbo.Type_CA
        //  ON dbo.Societe.IDTypeCA = dbo.Type_CA.IDTypeCA
        // LEFT JOIN dbo.view_Liste_Localisation
        //  ON dbo.Societe.LeftCodePostal2 = dbo.view_Liste_Localisation.IDDepartement
        // LEFT JOIN dbo.Societe_Nomenclature
        //  ON dbo.Enquete_Societe.IDEnqueteSociete = dbo.Societe_Nomenclature.IDEnqueteSociete
        // WHERE ( dbo.Enquete_Societe.IDStatutClient = 2 )
        // AND ( dbo.Enquete_Societe.IDEnquete = 202)
        #endregion
        //load data speed meeting
        public async Task<List<Model_SpeedMeeting>> LoadData_SpeedMeeting(int IDIntermediation, int IDUser, string nomSociete = "")
        {
            var lstrs_meeting = new List<Model_SpeedMeeting>();
            var lst = new List<Model_SpeedMeeting>();
            var lst_chosenVendeur = new List<db.Enquete_Contact_Ex>();
            var objEnquete_Contact_Ex = new List<db.Enquete_Contact_Ex>();
            // load data speed meeting
            lst = await (from societe in _context.Societe
                         join contact in _context.Contact on societe.Idsociete equals contact.Idsociete
                         join enquete_societe in _context.EnqueteSociete on contact.Idcontact equals enquete_societe.Idcontact
                         join contact_civilite in _context.ContactCivilite on contact.Idcivilite equals contact_civilite.Idcivilite
                         join liste_fonction in _context.Liste_Fonction on contact.IdlisteFonction equals liste_fonction.IDListeFonction
                         join type_effectif in _context.Type_Effectif on societe.IdtypeEffectif equals type_effectif.IDTypeEffectif
                         join type_CA in _context.Type_CA on societe.IdtypeCa equals type_CA.IDTypeCA
                         join view_liste_localisation in _context.ViewListeLocalisation on societe.LeftCodePostal2 equals view_liste_localisation.Iddepartement into view_localisationGroup
                         from left_localisation in view_localisationGroup.DefaultIfEmpty()
                         join societe_nomenclature in _context.SocieteNomenclature on enquete_societe.IdenqueteSociete equals societe_nomenclature.IdenqueteSociete into societe_nomenclatureGroup
                         from left_nomenclature in societe_nomenclatureGroup.DefaultIfEmpty()
                         where (string.IsNullOrEmpty(nomSociete) || societe.NomSociete.ToLower().Contains(nomSociete.ToLower()))
                                && (enquete_societe.IdstatutClient == 2 && enquete_societe.Idenquete == IDIntermediation)
                         select new Model_SpeedMeeting()
                         {
                             IDEnquete = enquete_societe.Idenquete,
                             CodeAPE2008 = societe.CodeApe2008,
                             DateCreationSociete = enquete_societe.DateEnqueteSociete,
                             dejaselectionne = _context.IntermediationContact.FirstOrDefault(x => x.IdcontactVendeur == IDUser && x.IdenqueteSocieteAcheteur == enquete_societe.IdenqueteSociete).IdintermediationContact.ToString(),
                             IDEnqueteSociete = enquete_societe.IdenqueteSociete,
                             CiviliteAbrege = contact_civilite.CiviliteAbrege,
                             NomContact = contact.NomContact,
                             FonctionContact = contact.FonctionContact,
                             FonctionGenerique = liste_fonction.FonctionGenerique,
                             Groupe = societe.Groupe,
                             NomSociete = societe.NomSociete,
                             ActiviteSociete = societe.ActiviteSociete,
                             Departement = left_localisation.Departement,
                             Region = left_localisation.Region,
                             TypeEffectif = type_effectif.TypeEffectif,
                             TypeCA = type_CA.TypeCA,
                             IsCheck = 0
                         }).Distinct().ToListAsync();
            // Load data Order chosen Vendeur
            lst_chosenVendeur = await _context.Enquete_Contact_Ex.Where(x => x.IDIDEnquete == IDIntermediation).ToListAsync();
            for (int i = 0; i < lst_chosenVendeur.Count(); i++)
            {
                var resultFind = lst.FindIndex(n => n.IDEnquete == Convert.ToInt32(lst_chosenVendeur[i].IDIDEnquete) && n.IDEnqueteSociete == Convert.ToInt32(lst_chosenVendeur[i].IDEnqueteSociete));
                // if chosen ? IsCheck = 1 : IsCheck = 0 
                if (resultFind != -1)
                {
                    lst[i].IsCheck = 1;
                }
                else
                {
                    lst[i].IsCheck = 0;
                }
            }
            return lst;
        }
        // Insert chosen company with table Enquete_Contact_Ex
        public async Task<db.Enquete_Contact_Ex> Insert_Orderchosen(int idEnquete, int idEnqueteSociete)
        {
            var objEnquete_Contact_Ex = new db.Enquete_Contact_Ex();
            // If exit idEnquete and idEnqueteSociete can`t insert 
            var obj = await _context.Enquete_Contact_Ex.FirstOrDefaultAsync(x => x.IDIDEnquete == idEnquete && x.IDEnqueteSociete == idEnqueteSociete);
            if (obj == null)
            {
                if (idEnquete > 0 && idEnqueteSociete > 0)
                {
                    objEnquete_Contact_Ex.IDEnqueteSociete = idEnqueteSociete;
                    objEnquete_Contact_Ex.IDIDEnquete = idEnquete;
                    objEnquete_Contact_Ex.OrderLevel = _context.Enquete_Contact_Ex.Where(x => x.IDIDEnquete == idEnquete).ToList().Count() + 1; // insert vi tri max
                    await _context.Enquete_Contact_Ex.AddAsync(objEnquete_Contact_Ex);
                    await _context.SaveChangesAsync();

                    objEnquete_Contact_Ex = await _context.Enquete_Contact_Ex.FirstOrDefaultAsync(x => x.IDIDEnquete == idEnquete && x.IDEnqueteSociete == idEnqueteSociete);
                }
            }
            return objEnquete_Contact_Ex;
        }
        // Load all data in Order chosen Vendeur
        public async Task<List<db.Enquete_Contact_Ex>> LoadDataAll_Orderchosen(int idEnquete)
        {
            var objEnquete_Contact_Ex = new List<db.Enquete_Contact_Ex>();
            objEnquete_Contact_Ex = await _context.Enquete_Contact_Ex.Where(x => x.IDIDEnquete == idEnquete).OrderBy(x => x.OrderLevel).ToListAsync();
            return objEnquete_Contact_Ex;
        }
        // Load data Order chosen Vendeur
        public async Task<List<Model_SpeedMeeting>> LoadData_OrderchosenVendeur(int idIntermediation, int IDUser, string nomSociete = "")
        {
            var lst_meeting = Task.FromResult(new List<Model_SpeedMeeting>());
            var lstrs_meeting = Task.FromResult(new List<Model_SpeedMeeting>());
            var lst_chosenVendeur = Task.FromResult(new List<db.Enquete_Contact_Ex>());
            // Load danh sach speed meeting
            lst_meeting = LoadData_SpeedMeeting(idIntermediation, IDUser, "");

            lst_chosenVendeur = LoadDataAll_Orderchosen(idIntermediation);
            await Task.WhenAll(lst_meeting, lst_chosenVendeur);
            if (lst_meeting.Result != null && lst_chosenVendeur != null)
            {
                for (int i = 0; i < lst_chosenVendeur.Result.Count(); i++)
                {
                    var resultFind = lst_meeting.Result.FindIndex(n => n.IDEnquete == Convert.ToInt32(lst_chosenVendeur.Result[i].IDIDEnquete) && n.IDEnqueteSociete == Convert.ToInt32(lst_chosenVendeur.Result[i].IDEnqueteSociete));
                    if (resultFind != -1)
                    {
                        lstrs_meeting.Result.Add(lst_meeting.Result.FirstOrDefault(x => x.IDEnquete == lst_chosenVendeur.Result[i].IDIDEnquete && x.IDEnqueteSociete == lst_chosenVendeur.Result[i].IDEnqueteSociete));
                    }
                }
            }

            return (nomSociete == "" || nomSociete == null) ? lstrs_meeting.Result : lstrs_meeting.Result.Where(x => x.NomSociete.ToLower().Contains(nomSociete.ToLower())).ToList();
        }
        // Delete data Order chosen Vendeur
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete_Orderchosen(int IDEnqueteSociete, int idEnquete)
        {
            var objEnquete_Contact_Ex = new db.Enquete_Contact_Ex();
            var obj = _context.Enquete_Contact_Ex.FirstOrDefault(x => x.IDEnqueteSociete == IDEnqueteSociete && x.IDIDEnquete == idEnquete);
            if (obj != null)
            {
                var lst = _context.Enquete_Contact_Ex.Where(x => x.IDIDEnquete == idEnquete).ToList();
                for (int i = obj.OrderLevel; i < lst.Count; i++)
                {
                    var objSearch = _context.Enquete_Contact_Ex.FirstOrDefault(x => x.IDEnqueteSociete == lst[i].IDEnqueteSociete && x.IDIDEnquete == lst[i].IDIDEnquete);
                    objSearch.OrderLevel = objSearch.OrderLevel - 1;
                }
                _context.SaveChanges();
                _context.Enquete_Contact_Ex.Remove(obj);
                _context.SaveChanges();
            }
        }
        // Update Order Index in Order chosen Vendeur
        public void Update_OrderIndex_(int idEnquete, int idEnqueteSociete_Drag, int idEnqueteSociete_Drop)
        {
            var objEnquete_Contact_Ex = new db.Enquete_Contact_Ex();
            var obj_drag = _context.Enquete_Contact_Ex.FirstOrDefault(x => x.IDEnqueteSociete == idEnqueteSociete_Drag && x.IDIDEnquete == idEnquete);
            var obj_drop = _context.Enquete_Contact_Ex.FirstOrDefault(x => x.IDEnqueteSociete == idEnqueteSociete_Drop && x.IDIDEnquete == idEnquete);
            var drag = obj_drag.OrderLevel;
            var drop = obj_drop.OrderLevel;

            if (obj_drag != null && obj_drop != null)
            {
                if (drag > drop)
                {
                    var lst_1 = _context.Enquete_Contact_Ex.Where(x => x.IDIDEnquete == idEnquete && x.OrderLevel > drop && x.OrderLevel < drag).ToList();
                    for (int i = 0; i < lst_1.Count; i++)
                    {
                        var objSearch = _context.Enquete_Contact_Ex.FirstOrDefault(x => x.IDEnqueteSociete == lst_1[i].IDEnqueteSociete && x.IDIDEnquete == idEnquete);
                        objSearch.OrderLevel = objSearch.OrderLevel + 1;
                    }
                    obj_drag.OrderLevel = obj_drop.OrderLevel;
                    obj_drop.OrderLevel = obj_drop.OrderLevel + 1;
                    _context.SaveChanges();
                }
                else
                {
                    var lst_1 = _context.Enquete_Contact_Ex.Where(x => x.IDIDEnquete == idEnquete && x.OrderLevel > drag && x.OrderLevel < drop).ToList();
                    for (int i = 0; i < lst_1.Count; i++)
                    {
                        var objSearch = _context.Enquete_Contact_Ex.FirstOrDefault(x => x.IDEnqueteSociete == lst_1[i].IDEnqueteSociete && x.IDIDEnquete == idEnquete);
                        objSearch.OrderLevel = objSearch.OrderLevel - 1;
                    }
                    obj_drag.OrderLevel = obj_drop.OrderLevel - 1;
                    obj_drop.OrderLevel = obj_drop.OrderLevel;
                    _context.SaveChanges();
                }
            }
        }
        public async Task<int> Update_OrderIndex(int idEnquete, string strIdEnqueteSociete)
        {
            var objEnquete_Contact_Ex = new db.Enquete_Contact_Ex();
            int res = 0;
            try
            {
                var arrID = strIdEnqueteSociete.Split(';');
                for (int i = 0; i < arrID.Length; i++)
                {
                    if (arrID[i] != "")
                    {
                        var obj = await _context.Enquete_Contact_Ex.FirstOrDefaultAsync(x => x.IDIDEnquete == idEnquete && x.IDEnqueteSociete == Convert.ToInt32(arrID[i]));
                        if (obj.ID > 0)
                        {
                            obj.OrderLevel = i + 1;
                            res = 1;
                        }
                        else
                        {
                            res = 0;
                        }
                    }
                }
                _context.SaveChanges();
                return res;
            }
            catch (System.Exception)
            {
                return 0;
            }

        }
        #endregion
        #region EventSociete
        #region sql LoadData_SocieteInEvent
        //    SELECT
        //   TOP 100 PERCENT dbo.Enquete_Societe.IDEnqueteSociete
        // , dbo.Enquete_Societe.IDEnquete
        // , dbo.Enquete_Societe.IDSociete
        // , dbo.Enquete_Societe.DateEnqueteSociete
        // , dbo.Liste_Societe_Profiler_v4.NomSociete
        // , dbo.Liste_Societe_Profiler_v4.Localisation
        // , dbo.Liste_Societe_Profiler_v4.LibelleAPE2008
        // , dbo.Liste_Contact_Profiler_v3.PrenomContact
        // , dbo.Liste_Contact_Profiler_v3.NomContact
        // , dbo.Enquete_Societe.IDContact
        // , dbo.Liste_Societe_Profiler_v4.CodeAPE2008
        // , dbo.Enquete_Societe.IDStatut
        // , dbo.Enquete_Societe.IDStatutClient
        // , dbo.Liste_Societe_Profiler_v4.TypeEffectifAbrege
        // , dbo.Liste_Contact_Profiler_v3.FonctionGeneriqueAbrege
        // , dbo.Intermediation.IDIntermediation
        // , dbo.Intermediation.IDListeService
        // , dbo.Intermediation.IDListeSousService
        // , 'ACH' as Apercu
        // , dbo.Liste_Societe_Profiler_v4.TypeNature
        // , Liste_Societe_Profiler_v4.IcoNature
        // FROM dbo.Intermediation
        // JOIN dbo.Enquete_Societe
        //  ON dbo.Intermediation.IDEnqueteAcheteur = dbo.Enquete_Societe.IDEnquete
        // JOIN dbo.Liste_Societe_Profiler_v4
        //  ON dbo.Enquete_Societe.IDSociete = dbo.Liste_Societe_Profiler_v4.IDSociete
        // JOIN dbo.Liste_Contact_Profiler_v3
        //  ON dbo.Enquete_Societe.IDContact = dbo.Liste_Contact_Profiler_v3.IDContact
        // WHERE ( dbo.Intermediation.IDIntermediation IN ( 53 ) )

        //     UNION
        // SELECT
        //   TOP 100 PERCENT dbo.Enquete_Societe.IDEnqueteSociete
        // , dbo.Enquete_Societe.IDEnquete
        // , dbo.Enquete_Societe.IDSociete
        // , dbo.Enquete_Societe.DateEnqueteSociete
        // , dbo.Liste_Societe_Profiler_v4.NomSociete
        // , dbo.Liste_Societe_Profiler_v4.Localisation
        // , dbo.Liste_Societe_Profiler_v4.LibelleAPE2008
        // , dbo.Liste_Contact_Profiler_v3.PrenomContact
        // , dbo.Liste_Contact_Profiler_v3.NomContact
        // , dbo.Enquete_Societe.IDContact
        // , dbo.Liste_Societe_Profiler_v4.CodeAPE2008
        // , dbo.Enquete_Societe.IDStatut
        // , dbo.Enquete_Societe.IDStatutClient
        // , dbo.Liste_Societe_Profiler_v4.TypeEffectifAbrege
        // , dbo.Liste_Contact_Profiler_v3.FonctionGeneriqueAbrege
        // , dbo.Intermediation.IDIntermediation
        // , dbo.Intermediation.IDListeService
        // , dbo.Intermediation.IDListeSousService
        // , 'VD' as Apercu
        // , dbo.Liste_Societe_Profiler_v4.TypeNature
        // , Liste_Societe_Profiler_v4.IcoNature
        // FROM dbo.Intermediation
        // JOIN dbo.Enquete_Societe
        //  ON dbo.Intermediation.IDEnqueteVendeur = dbo.Enquete_Societe.IDEnquete
        // JOIN dbo.Liste_Societe_Profiler_v4
        //  ON dbo.Enquete_Societe.IDSociete = dbo.Liste_Societe_Profiler_v4.IDSociete
        // JOIN dbo.Liste_Contact_Profiler_v3
        //  ON dbo.Enquete_Societe.IDContact = dbo.Liste_Contact_Profiler_v3.IDContact
        // WHERE ( dbo.Intermediation.IDIntermediation IN ( 53 ) )
        // ORDER BY dbo.Enquete_Societe.DateEnqueteSociete DESC
        #endregion
        public async Task<List<Model_EventSociete>> LoadData_SocieteInEvent(int Idintermediation)
        {
            var lst_1 = new List<Model_EventSociete>();
            var lst_2 = new List<Model_EventSociete>();
            var lst_reult = new List<Model_EventSociete>();


            lst_1 = await (from intermediation in _context.Intermediation
                           join enquete_Societe in _context.EnqueteSociete on intermediation.IdenqueteAcheteur equals enquete_Societe.Idenquete
                           join liste_Societe_Profiler_v4 in _context.Liste_Societe_Profiler_v4 on enquete_Societe.Idsociete equals liste_Societe_Profiler_v4.IDSociete
                           join liste_Contact_Profiler_v3 in _context.Liste_Contact_Profiler_v3 on enquete_Societe.Idcontact equals liste_Contact_Profiler_v3.IDContact
                           where intermediation.Idintermediation == Idintermediation
                           select new Model_EventSociete()
                           {
                               IDEnqueteSociete = enquete_Societe.IdenqueteSociete,
                               IDEnquete = enquete_Societe.Idenquete,
                               IDUtilisateur = enquete_Societe.Idutilisateur,
                               IDSociete = enquete_Societe.Idsociete,
                               DateEnqueteSociete = enquete_Societe.DateEnqueteSociete,
                               NomSociete = liste_Societe_Profiler_v4.NomSociete,
                               Localisation = liste_Societe_Profiler_v4.Localisation,
                               LibelleAPE2008 = liste_Societe_Profiler_v4.LibelleAPE2008,
                               PrenomContact = liste_Contact_Profiler_v3.PrenomContact,
                               NomContact = liste_Contact_Profiler_v3.NomContact,
                               IDContact = enquete_Societe.Idcontact,
                               CodeAPE2008 = liste_Societe_Profiler_v4.CodeAPE2008,
                               IDStatut = enquete_Societe.Idstatut,
                               IDStatutClient = enquete_Societe.IdstatutClient,
                               TypeEffectifAbrege = liste_Societe_Profiler_v4.TypeEffectifAbrege,
                               FonctionGeneriqueAbrege = liste_Contact_Profiler_v3.FonctionGeneriqueAbrege,
                               IDIntermediation = intermediation.Idintermediation,
                               IDListeService = intermediation.IdlisteService,
                               IDListeSousService = intermediation.IdlisteSousService,
                               Apercu = "ACH",
                               TypeNature = liste_Societe_Profiler_v4.TypeNature,
                               IcoNature = liste_Societe_Profiler_v4.IcoNature,
                               IsCheck_Participants = _context.Contact.Where(x => x.Idcontact == Convert.ToInt32(enquete_Societe.Idcontact)).Count()
                           }).ToListAsync();
            lst_2 = await (from intermediation in _context.Intermediation
                           join enquete_Societe in _context.EnqueteSociete on intermediation.IdenqueteVendeur equals enquete_Societe.Idenquete
                           join liste_Societe_Profiler_v4 in _context.Liste_Societe_Profiler_v4 on enquete_Societe.Idsociete equals liste_Societe_Profiler_v4.IDSociete
                           join liste_Contact_Profiler_v3 in _context.Liste_Contact_Profiler_v3 on enquete_Societe.Idcontact equals liste_Contact_Profiler_v3.IDContact
                           where intermediation.Idintermediation == Idintermediation
                           select new Model_EventSociete()
                           {
                               IDEnqueteSociete = enquete_Societe.IdenqueteSociete,
                               IDEnquete = enquete_Societe.Idenquete,
                               IDUtilisateur = enquete_Societe.Idutilisateur,
                               IDSociete = enquete_Societe.Idsociete,
                               DateEnqueteSociete = enquete_Societe.DateEnqueteSociete,
                               NomSociete = liste_Societe_Profiler_v4.NomSociete,
                               Localisation = liste_Societe_Profiler_v4.Localisation,
                               LibelleAPE2008 = liste_Societe_Profiler_v4.LibelleAPE2008,
                               PrenomContact = liste_Contact_Profiler_v3.PrenomContact,
                               NomContact = liste_Contact_Profiler_v3.NomContact,
                               IDContact = enquete_Societe.Idcontact,
                               CodeAPE2008 = liste_Societe_Profiler_v4.CodeAPE2008,
                               IDStatut = enquete_Societe.Idstatut,
                               IDStatutClient = enquete_Societe.IdstatutClient,
                               TypeEffectifAbrege = liste_Societe_Profiler_v4.TypeEffectifAbrege,
                               FonctionGeneriqueAbrege = liste_Contact_Profiler_v3.FonctionGeneriqueAbrege,
                               IDIntermediation = intermediation.Idintermediation,
                               IDListeService = intermediation.IdlisteService,
                               IDListeSousService = intermediation.IdlisteSousService,
                               Apercu = "ACH",
                               TypeNature = liste_Societe_Profiler_v4.TypeNature,
                               IcoNature = liste_Societe_Profiler_v4.IcoNature,
                               IsCheck_Participants = _context.Contact.Where(x => x.Idcontact == Convert.ToInt32(enquete_Societe.Idcontact)).Count()
                           }).ToListAsync();

            lst_reult = lst_1.Union(lst_2).OrderByDescending(x => x.DateEnqueteSociete).Distinct().ToList();
            return lst_reult;
        }

        #endregion
    }
}

