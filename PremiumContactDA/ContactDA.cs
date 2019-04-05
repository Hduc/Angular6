using System;
using System.Linq;
using db = PremiumcontactMaster.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using System.Net;
using PremiumcontactMaster.ModelData;
using System.ComponentModel;
using System.Net.Http;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace PremiumcontactMaster.PremiumContactDA
{
    public class ContactDA
    {
        db.DBContext _context;
        public ContactDA(db.DBContext context)
        {
            _context = context;
        }
        #region participants Contact
        // Load data participants
        public async Task<List<Model_Contact>> LoadData_Contact(int intSociete)
        {
            var lst = new List<Model_Contact>();
            lst = await (from contact in _context.Contact
                         join societe in _context.Societe on contact.Idsociete equals societe.Idsociete
                         join liste_Contact_PhotoID in _context.Liste_Contact_PhotoID on contact.Idcontact equals liste_Contact_PhotoID.IDContact into listeContactPhotoID
                         from Left_liste_Contact_PhotoID in listeContactPhotoID.DefaultIfEmpty()
                         join liste_Fonction in _context.Liste_Fonction on contact.IdlisteFonction equals liste_Fonction.IDListeFonction
                         where contact.Idsociete == intSociete && contact.Idstatut == 10
                         select new Model_Contact()
                         {
                             Idcontact = contact.Idcontact,
                             PrenomContact = contact.PrenomContact,
                             NomContact = contact.NomContact,
                             EmailContact = contact.EmailContact,
                             TelephoneContact = contact.TelephoneContact,
                             FonctionContact = contact.FonctionContact,
                             PortableContact = contact.PortableContact,
                             Idcivilite = contact.Idcivilite,
                             FonctionGeneriqueAbrege = liste_Fonction.FonctionGeneriqueAbrege,
                             FonctionGenerique = liste_Fonction.FonctionGenerique,
                             IDTypeFonction = liste_Fonction.IDTypeFonction,
                             IDListeFonction = contact.IdlisteFonction,
                             NomSociete = societe.NomSociete,
                             PhotoUrl = Left_liste_Contact_PhotoID.UrlPhoto
                         }).Distinct().ToListAsync();
            // var data = await _context.Contact.Where(x => x.Idsociete == intSociete && x.Idstatut == 10).ToListAsync();

            return lst;
        }
        // Insert participants in table Contact with IdStatus = 10
        public async Task<int> Insert_Contact(Model_Contact obj)
        {
            var contact = new db.Contact();
            var objContact = new db.Contact();

            try
            {
                var idcontact = obj.Idcontact;
                if (idcontact > 0)
                {
                    contact = await _context.Contact.FirstOrDefaultAsync(x => x.Idcontact == idcontact);
                    objContact.Acheteur = contact.Acheteur;
                    objContact.DateCreationContact = contact.DateCreationContact;
                    objContact.DateMajcontact = contact.DateMajcontact;
                    objContact.DateMajmanuelleContact = contact.DateMajmanuelleContact;
                    objContact.EmailContact = contact.EmailContact;
                    objContact.EmailContact2 = contact.EmailContact2;
                    objContact.FaxContact = contact.FaxContact;
                    objContact.FonctionContact = contact.FonctionContact;
                    objContact.Idcivilite = contact.Idcivilite;
                    objContact.Idcontact = 0;
                    objContact.IdlisteBase = contact.IdlisteBase;
                    objContact.IdlisteFonction = contact.IdlisteFonction;
                    objContact.IdnomContact = contact.IdnomContact;
                    objContact.Idsociete = contact.Idsociete;
                    objContact.Idstatut = 10;
                    objContact.IdtypeUtilisateur = contact.IdtypeUtilisateur;
                    objContact.Idutilisateur = contact.Idutilisateur;
                    objContact.IdutilisateurCreateur = contact.IdutilisateurCreateur;
                    objContact.ImportanceContact = contact.ImportanceContact;
                    objContact.ListeRougeFax = contact.ListeRougeFax;
                    objContact.ListeRougeMail = contact.ListeRougeMail;
                    objContact.ListeRougePortable = contact.ListeRougePortable;
                    objContact.ListeRougeTelephone = contact.ListeRougeTelephone;
                    objContact.Login = contact.Login;
                    objContact.MailCorrect = contact.MailCorrect;
                    objContact.MotdePasse = contact.MotdePasse;
                    objContact.NomContact = contact.NomContact;
                    objContact.NombreRefusEmail = contact.NombreRefusEmail;
                    objContact.OldIdcontact = contact.OldIdcontact;
                    objContact.PortableContact = contact.PortableContact;
                    objContact.PrenomContact = contact.PrenomContact;
                    objContact.TelephoneContact = contact.TelephoneContact;
                    objContact.Vendeur = contact.Vendeur;

                    _context.Contact.Add(objContact);
                    _context.SaveChanges();
                    return objContact.Idcontact;
                }
                else
                {
                    objContact.EmailContact = obj.EmailContact;
                    objContact.Idcivilite = Convert.ToByte(obj.Idcivilite);
                    objContact.Idcontact = 0;
                    objContact.FonctionContact = obj.FonctionContact;
                    objContact.IdlisteFonction = obj.IDListeFonction;
                    objContact.Idsociete = obj.IdSociete;
                    objContact.Idstatut = 10;
                    objContact.Idutilisateur = obj.Idutilisateur;
                    objContact.NomContact = obj.NomContact;
                    objContact.PortableContact = obj.PortableContact;
                    objContact.PrenomContact = obj.PrenomContact;
                    objContact.TelephoneContact = obj.TelephoneContact;
                    _context.Contact.Add(objContact);
                    _context.SaveChanges();
                    return objContact.Idcontact;
                }
            }
            catch (System.Exception)
            {
                return 0;
            }
        }
        // Update participants in table Contact with IdStatus = 10  
        public async Task<int> Update_Contact(Model_Contact objContact)
        {
            var obj_Contact = new db.Contact();
            try
            {
                var idcontact = objContact.Idcontact;
                obj_Contact = await _context.Contact.FirstOrDefaultAsync(x => x.Idcontact == idcontact && x.Idstatut == 10);
                if (obj_Contact.Idcontact > 0)
                {
                    obj_Contact.PrenomContact = objContact.PrenomContact;
                    obj_Contact.NomContact = objContact.NomContact;
                    obj_Contact.TelephoneContact = objContact.TelephoneContact;
                    obj_Contact.FonctionContact = objContact.FonctionContact;
                    obj_Contact.EmailContact = objContact.EmailContact;
                    obj_Contact.IdlisteFonction = objContact.IDListeFonction;
                    obj_Contact.PortableContact = objContact.PortableContact;
                    obj_Contact.Idcivilite = Convert.ToByte(objContact.Idcivilite);

                    // update societe
                    await _context.SaveChangesAsync();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (System.Exception)
            {
                return 0;
            }
        }
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public async Task<int> Delete_Contact(int Idcontact)
        {
            var objContact = new db.Contact();
            objContact = await _context.Contact.FirstOrDefaultAsync(x => x.Idcontact == Idcontact && x.Idstatut == 10);
            if (objContact != null)
            {
                _context.Contact.Remove(objContact);
                _context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public async Task<Model_Contact> LoadUser_ByID(int idContact)
        {
            var objContact = new Model_Contact();
            objContact = await (from contact in _context.Contact
                                join contact_Civilite in _context.ContactCivilite on contact.Idcivilite equals contact_Civilite.Idcivilite
                                join liste_Fonction in _context.Liste_Fonction on contact.IdlisteFonction equals liste_Fonction.IDListeFonction
                                join photoID in _context.Liste_Contact_PhotoID on contact.Idutilisateur equals photoID.IDContact
                                where contact.Idcontact == idContact && contact.Idstatut == 10
                                select new Model_Contact()
                                {
                                    Idcontact = contact.Idcontact,
                                    PrenomContact = contact.PrenomContact,
                                    NomContact = contact.NomContact,
                                    EmailContact = contact.EmailContact,
                                    TelephoneContact = contact.TelephoneContact,
                                    FonctionContact = contact.FonctionContact,
                                    PortableContact = contact.PortableContact,
                                    Idcivilite = contact.Idcivilite,
                                    FonctionGeneriqueAbrege = liste_Fonction.FonctionGeneriqueAbrege,
                                    FonctionGenerique = liste_Fonction.FonctionGenerique,
                                    IDTypeFonction = liste_Fonction.IDTypeFonction,
                                    IDListeFonction = contact.IdlisteFonction,
                                    PhotoUrl = photoID.UrlPhoto
                                }).FirstOrDefaultAsync();
            return objContact;
        }
        // Serach User by username
        public async Task<Model_Contact> SearchUser(string prenom, int idSociete, int idListeService)
        {
            var lst = Task.FromResult(new List<Model_Contact>());
            lst = LoadUserOfSociete(idSociete, idListeService);
            await Task.WhenAll(lst);
            var obj = lst.Result.FirstOrDefault(x => x.IdSociete == idSociete && x.PrenomContact == prenom);
            return obj;
        }
        // Load all user of Societe
        #region SQL Load User Of Societe
        //             SELECT
        //   DISTINCT TOP( 100 ) PERCENT dbo.Contact.IDContact
        // , dbo.Contact_Civilite.CiviliteAbrege
        // , dbo.Contact.PrenomContact
        // , dbo.Contact.NomContact
        // , dbo.Liste_Fonction.FonctionGeneriqueAbrege
        // , dbo.Liste_Fonction.FonctionGenerique
        // , dbo.Contact.TelephoneContact
        // , dbo.Contact.PortableContact
        // , dbo.Contact.EmailContact
        // , 0 AS ContactPardefaut
        // , Blackliste.EmailContact AS Blackliste
        // , dbo.Contact.FonctionContact
        // , dbo.Contact.IDStatut
        // , dbo.Liste_Contact_Erreur.motivation
        // , ReseauSocial.URLReseauSocial
        // , ReseauSocial.Icon_ReseauSocial
        // , dbo.Contact.NombreRefusEMail
        // , '' as IDFonctionCiblee
        // , ( SELECT TOP( 1 ) DoublonMailTemp.IDSociete FROM dbo.Contact AS DoublonMailTemp WHERE( DoublonMailTemp.EmailContact = dbo.Contact.EmailContact ) AND( DoublonMailTemp.IDSociete <> dbo.Contact.IDSociete ) ) AS DoublonMail
        // , dbo.Contact.ListeRougeTelephone
        // , dbo.Contact.ListeRougePortable
        // , dbo.Contact.ListeRougeMail
        // , dbo.Liste_Contact_PhotoID.UrlPhoto
        // FROM dbo.Contact
        // JOIN dbo.Contact_Civilite
        //  ON dbo.Contact.IDCivilite = dbo.Contact_Civilite.IDCivilite
        // JOIN dbo.Liste_Fonction
        //  ON dbo.Contact.IDListeFonction = dbo.Liste_Fonction.IDListeFonction
        // LEFT JOIN dbo.Liste_Contact_PhotoID
        //  ON dbo.Contact.IDContact = dbo.Liste_Contact_PhotoID.IDContact
        // LEFT JOIN
        // (
        //     SELECT
        //       dbo.Contact_ReseauSocial.IDContact
        //     , dbo.Type_ReseauSocial.Icon_ReseauSocial
        //     , dbo.Contact_ReseauSocial.URLReseauSocial
        //     FROM dbo.Contact_ReseauSocial
        //     JOIN dbo.Type_ReseauSocial
        //      ON dbo.Contact_ReseauSocial.IDTypeReseauSocial = dbo.Type_ReseauSocial.IDTypeReseauSocial
        // ) AS ReseauSocial
        //  ON dbo.Contact.IDContact = ReseauSocial.IDContact
        // LEFT JOIN dbo.Liste_Contact_Erreur
        //  ON dbo.Contact.IDContact = dbo.Liste_Contact_Erreur.IDContact
        // LEFT JOIN
        // (
        //     SELECT
        //       EmailContact
        //     FROM dbo.Contact_Blackliste
        //     WHERE ( IDListeService = 35700 )
        // ) AS Blackliste
        //  ON dbo.Contact.EmailContact = Blackliste.EmailContact
        // WHERE ( dbo.Contact.IDStatut < 3 )
        // AND ( dbo.Contact.IDSociete = 528221 )
        // OR ( dbo.Contact.IDStatut < 3 )
        // AND ( dbo.Contact.IDSociete = 528221 )
        // AND ( dbo.Contact.IDContact IN
        // (
        //     SELECT
        //       DISTINCT IDContact
        //     FROM dbo.Contact_Historique
        //     WHERE ( IDSociete = 528221 )
        //     AND ( IDListeService = 35700 )
        // ) )
        // ORDER BY ContactPardefaut DESC , dbo.Contact.NomContact
        #endregion
        public async Task<List<Model_Contact>> LoadUserOfSociete(int idSociete, int idListeService)
        {
            var lstUser = new List<Model_Contact>();
            var lst_IdContact = (from Contact_Historique in _context.ContactHistorique
                                 where Contact_Historique.Idsociete == idSociete && Contact_Historique.IdlisteService == idListeService
                                 select new { Contact_Historique.Idcontact }).Distinct().ToList();
            lstUser = await (from contact in _context.Contact
                             join contact_Civilite in _context.ContactCivilite on contact.Idcivilite equals contact_Civilite.Idcivilite
                             join liste_Fonction in _context.Liste_Fonction on contact.IdlisteFonction equals liste_Fonction.IDListeFonction
                             join liste_Contact_PhotoID in _context.Liste_Contact_PhotoID on contact.Idcontact equals liste_Contact_PhotoID.IDContact into listeContactPhotoID
                             from Left_liste_Contact_PhotoID in listeContactPhotoID.DefaultIfEmpty()
                             join ReseauSocial in (
                                 from contact_ReseauSocial in _context.Contact_ReseauSocial
                                 join type_ReseauSocial in _context.Type_ReseauSocial on contact_ReseauSocial.IDTypeReseauSocial equals type_ReseauSocial.IDTypeReseauSocial
                                 select new
                                 {
                                     contact_ReseauSocial.IDContact,
                                     type_ReseauSocial.Icon_ReseauSocial,
                                     contact_ReseauSocial.URLReseauSocial
                                 }
                             ) on contact.Idcontact equals ReseauSocial.IDContact into ReseauSocialGroup
                             from left_ReseauSocial in ReseauSocialGroup.DefaultIfEmpty()
                             join liste_Contact_Erreur in _context.liste_Contact_Erreur on contact.Idcontact equals liste_Contact_Erreur.IDContact into liste_Contact_ErreurGroup
                             from left_liste_Contact_Erreur in liste_Contact_ErreurGroup.DefaultIfEmpty()
                             join Blackliste in (
                                 from contact_Blackliste in _context.ContactBlackliste
                                 where contact_Blackliste.IdlisteService == idListeService
                                 select new { contact_Blackliste.EmailContact }
                             ) on contact.EmailContact equals Blackliste.EmailContact
                             where (contact.Idstatut < 3 && contact.Idsociete == idSociete)
                              || (contact.Idstatut < 3 && contact.Idsociete == idSociete
                             && lst_IdContact.ToString().Contains(contact.Idcontact.ToString()))
                             select new Model_Contact()
                             {
                                 Idcontact = contact.Idcontact,
                                 IdSociete = idSociete,
                                 Idcivilite = contact.Idcivilite,
                                 PrenomContact = contact.PrenomContact,
                                 NomContact = contact.NomContact,
                                 FonctionGeneriqueAbrege = liste_Fonction.FonctionGeneriqueAbrege,
                                 FonctionGenerique = liste_Fonction.FonctionGenerique,
                                 TelephoneContact = contact.TelephoneContact,
                                 PortableContact = contact.PortableContact,
                                 EmailContact = contact.EmailContact,
                                 FonctionContact = contact.FonctionContact,
                                 IDStatut = contact.Idstatut,
                                 ContactPardefaut = 0,
                                 IDTypeFonction = liste_Fonction.IDTypeFonction,
                                 IDListeFonction = contact.IdlisteFonction,
                                 PhotoUrl = Left_liste_Contact_PhotoID.UrlPhoto
                             }).
                            GroupBy(x => x.Idcontact).Select(grp => grp.FirstOrDefault())
                            .OrderBy(x => x.NomContact).ToListAsync();
            return lstUser;
        }

        #endregion
        #region participants Liste_Fonction
        // Loada data Famille fonction
        public async Task<List<db.Liste_Fonction>> LoadData_FamilleFonction()
        {
            var lst = new List<db.Liste_Fonction>();
            lst = await _context.Liste_Fonction.GroupBy(p => p.IDTypeFonction).Select(g => g.FirstOrDefault()).OrderBy(x => x.IDTypeFonction).Distinct().ToListAsync();

            return lst;
        }
        // Loada data Fonction générique
        public async Task<List<Model_Liste_Fonction>> LoadData_FonctionGenerique(string idTypeFonction)
        {
            var lst = new List<Model_Liste_Fonction>();
            lst = await (from liste_Fonction in _context.Liste_Fonction
                         where liste_Fonction.IDTypeFonction == idTypeFonction
                         select new Model_Liste_Fonction()
                         {
                             IDTypeFonction = liste_Fonction.IDTypeFonction,
                             TypeFonction = liste_Fonction.TypeFonction,
                             IDListeFonction = liste_Fonction.IDListeFonction,
                             FonctionGenerique = liste_Fonction.FonctionGenerique,
                             ImportanceListeFonction = liste_Fonction.ImportanceListeFonction,
                             FonctionGeneriqueAbrege = liste_Fonction.FonctionGeneriqueAbrege
                         }
            ).ToListAsync();

            return lst;
        }
        #endregion
        #region participants Mediatheque_Document
        public async Task<int> Insert_MediathequeDocument(int idContact, string nomDocument, string extension)
        {
            var contact = new db.Contact();
            var objDocument = new db.MediathequeDocument();

            try
            {
                contact = await _context.Contact.FirstOrDefaultAsync(x => x.Idcontact == idContact);
                objDocument.IdtypeDocument = 34038; // type of img
                objDocument.Idsociete = contact.Idsociete;
                objDocument.IdenqueteSociete = 0;
                objDocument.NomDocument = nomDocument;
                objDocument.Extension = extension;
                objDocument.Taille = 0;
                objDocument.Idstatut = 0;
                objDocument.DateMaj = DateTime.Now;
                objDocument.DateCreation = DateTime.Now;
                objDocument.Idutilisateur = contact.Idutilisateur;
                objDocument.IdlisteService = 0;
                objDocument.IdlisteSousService = 0;
                objDocument.Commentaire = "";

                _context.MediathequeDocument.Add(objDocument);
                _context.SaveChanges();
                return 1;
            }
            catch (System.Exception)
            {
                return 0;
            }
        }
        public async Task<int> Update_MediathequeDocument(int idDocument, string nomDocument, string extension)
        {
            var objDocument = new db.MediathequeDocument();

            try
            {
                int res = 0;
                objDocument = await _context.MediathequeDocument.FirstOrDefaultAsync(x => x.Iddocument == idDocument);
                if (objDocument.Iddocument > 0)
                {
                    objDocument.NomDocument = nomDocument;
                    objDocument.Extension = extension;
                    
                    _context.SaveChanges();
                    res = 1;
                }
                else
                    res = 0;
                return res;
            }
            catch (System.Exception er)
            {
                return 0;
            }
        }
        #endregion
        #region atelier Contact
        public async Task<List<Model_Contact>> LoadData_Atelier(int intSociete)
        {
            var lst = new List<Model_Contact>();
            lst = await (from contact in _context.Contact
                         join societe in _context.Societe on contact.Idsociete equals societe.Idsociete
                         join liste_Contact_PhotoID in _context.Liste_Contact_PhotoID on contact.Idcontact equals liste_Contact_PhotoID.IDContact into listeContactPhotoID
                         from Left_liste_Contact_PhotoID in listeContactPhotoID.DefaultIfEmpty()
                         join liste_Fonction in _context.Liste_Fonction on contact.IdlisteFonction equals liste_Fonction.IDListeFonction
                         where contact.Idsociete == intSociete && contact.Idstatut == 11
                         select new Model_Contact()
                         {
                             Idcontact = contact.Idcontact,
                             PrenomContact = contact.PrenomContact,
                             NomContact = contact.NomContact,
                             EmailContact = contact.EmailContact,
                             TelephoneContact = contact.TelephoneContact,
                             FonctionContact = contact.FonctionContact,
                             PortableContact = contact.PortableContact,
                             Idcivilite = contact.Idcivilite,
                             FonctionGeneriqueAbrege = liste_Fonction.FonctionGeneriqueAbrege,
                             FonctionGenerique = liste_Fonction.FonctionGenerique,
                             IDTypeFonction = liste_Fonction.IDTypeFonction,
                             IDListeFonction = contact.IdlisteFonction,
                             NomSociete = societe.NomSociete,
                             PhotoUrl = Left_liste_Contact_PhotoID.UrlPhoto
                         }).Distinct().ToListAsync();
            // var data = await _context.Contact.Where(x => x.Idsociete == intSociete && x.Idstatut == 10).ToListAsync();

            return lst;
        }
        // Insert participants in table Contact with IdStatus = 10
        public async Task<int> Insert_Atelier(Model_Contact obj)
        {
            var contact = new db.Contact();
            var objContact = new db.Contact();

            try
            {
                var idcontact = obj.Idcontact;
                if (idcontact > 0)
                {
                    contact = await _context.Contact.FirstOrDefaultAsync(x => x.Idcontact == idcontact);
                    objContact.Acheteur = contact.Acheteur;
                    objContact.DateCreationContact = contact.DateCreationContact;
                    objContact.DateMajcontact = contact.DateMajcontact;
                    objContact.DateMajmanuelleContact = contact.DateMajmanuelleContact;
                    objContact.EmailContact = contact.EmailContact;
                    objContact.EmailContact2 = contact.EmailContact2;
                    objContact.FaxContact = contact.FaxContact;
                    objContact.FonctionContact = contact.FonctionContact;
                    objContact.Idcivilite = contact.Idcivilite;
                    objContact.Idcontact = 0;
                    objContact.IdlisteBase = contact.IdlisteBase;
                    objContact.IdlisteFonction = contact.IdlisteFonction;
                    objContact.IdnomContact = contact.IdnomContact;
                    objContact.Idsociete = contact.Idsociete;
                    objContact.Idstatut = 11;
                    objContact.IdtypeUtilisateur = contact.IdtypeUtilisateur;
                    objContact.Idutilisateur = contact.Idutilisateur;
                    objContact.IdutilisateurCreateur = contact.IdutilisateurCreateur;
                    objContact.ImportanceContact = contact.ImportanceContact;
                    objContact.ListeRougeFax = contact.ListeRougeFax;
                    objContact.ListeRougeMail = contact.ListeRougeMail;
                    objContact.ListeRougePortable = contact.ListeRougePortable;
                    objContact.ListeRougeTelephone = contact.ListeRougeTelephone;
                    objContact.Login = contact.Login;
                    objContact.MailCorrect = contact.MailCorrect;
                    objContact.MotdePasse = contact.MotdePasse;
                    objContact.NomContact = contact.NomContact;
                    objContact.NombreRefusEmail = contact.NombreRefusEmail;
                    objContact.OldIdcontact = contact.OldIdcontact;
                    objContact.PortableContact = contact.PortableContact;
                    objContact.PrenomContact = contact.PrenomContact;
                    objContact.TelephoneContact = contact.TelephoneContact;
                    objContact.Vendeur = contact.Vendeur;

                    _context.Contact.Add(objContact);
                    _context.SaveChanges();
                    return objContact.Idcontact;
                }
                else
                {
                    objContact.EmailContact = obj.EmailContact;
                    objContact.Idcivilite = Convert.ToByte(obj.Idcivilite);
                    objContact.Idcontact = 0;
                    objContact.FonctionContact = obj.FonctionContact;
                    objContact.IdlisteFonction = obj.IDListeFonction;
                    objContact.Idsociete = obj.IdSociete;
                    objContact.Idstatut = 11;
                    objContact.Idutilisateur = obj.Idutilisateur;
                    objContact.NomContact = obj.NomContact;
                    objContact.PortableContact = obj.PortableContact;
                    objContact.PrenomContact = obj.PrenomContact;
                    objContact.TelephoneContact = obj.TelephoneContact;
                    _context.Contact.Add(objContact);
                    _context.SaveChanges();
                    return objContact.Idcontact;
                }
            }
            catch (System.Exception)
            {
                return 0;
            }
        }
        // Update participants in table Contact with IdStatus = 10  
        public async Task<int> Update_Atelier(Model_Contact objContact)
        {
            var obj_Contact = new db.Contact();
            try
            {
                var idcontact = objContact.Idcontact;
                obj_Contact = await _context.Contact.FirstOrDefaultAsync(x => x.Idcontact == idcontact && x.Idstatut == 11);
                if (obj_Contact.Idcontact > 0)
                {
                    obj_Contact.PrenomContact = objContact.PrenomContact;
                    obj_Contact.NomContact = objContact.NomContact;
                    obj_Contact.TelephoneContact = objContact.TelephoneContact;
                    obj_Contact.FonctionContact = objContact.FonctionContact;
                    obj_Contact.EmailContact = objContact.EmailContact;
                    obj_Contact.IdlisteFonction = objContact.IDListeFonction;
                    obj_Contact.PortableContact = objContact.PortableContact;
                    obj_Contact.Idcivilite = Convert.ToByte(objContact.Idcivilite);

                    // update societe
                    await _context.SaveChangesAsync();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (System.Exception)
            {
                return 0;
            }
        }
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public async Task<int> Delete_Atelier(int Idcontact)
        {
            var objContact = new db.Contact();
            objContact = await _context.Contact.FirstOrDefaultAsync(x => x.Idcontact == Idcontact && x.Idstatut == 11);
            if (objContact != null)
            {
                _context.Contact.Remove(objContact);
                _context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public async Task<Model_Contact> LoadUserAtelier_ByID(int idContact)
        {
            var objContact = new Model_Contact();
            objContact = await (from contact in _context.Contact
                                join contact_Civilite in _context.ContactCivilite on contact.Idcivilite equals contact_Civilite.Idcivilite
                                join liste_Fonction in _context.Liste_Fonction on contact.IdlisteFonction equals liste_Fonction.IDListeFonction
                                join photoID in _context.Liste_Contact_PhotoID on contact.Idutilisateur equals photoID.IDContact
                                where contact.Idcontact == idContact && contact.Idstatut == 11
                                select new Model_Contact()
                                {
                                    Idcontact = contact.Idcontact,
                                    PrenomContact = contact.PrenomContact,
                                    NomContact = contact.NomContact,
                                    EmailContact = contact.EmailContact,
                                    TelephoneContact = contact.TelephoneContact,
                                    FonctionContact = contact.FonctionContact,
                                    PortableContact = contact.PortableContact,
                                    Idcivilite = contact.Idcivilite,
                                    FonctionGeneriqueAbrege = liste_Fonction.FonctionGeneriqueAbrege,
                                    FonctionGenerique = liste_Fonction.FonctionGenerique,
                                    IDTypeFonction = liste_Fonction.IDTypeFonction,
                                    IDListeFonction = contact.IdlisteFonction,
                                    PhotoUrl = photoID.UrlPhoto
                                }).FirstOrDefaultAsync();
            return objContact;
        }
        // Serach User by username
        public async Task<Model_Contact> SearchUserAtelier(string prenom, int idSociete, int idListeService)
        {
            var lst = Task.FromResult(new List<Model_Contact>());
            lst = LoadUserOfSociete(idSociete, idListeService);
            await Task.WhenAll(lst);
            var obj = lst.Result.FirstOrDefault(x => x.IdSociete == idSociete && x.PrenomContact == prenom);
            return obj;
        }
        #endregion
    }
}
