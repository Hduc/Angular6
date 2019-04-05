using System;
using System.Linq;
using db = PremiumcontactMaster.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using System.Net;

namespace PremiumcontactMaster.PremiumContactDA
{
    public class Liste_UtilisateurDA
    {
        db.DBContext _context;
        public Liste_UtilisateurDA(db.DBContext context)
        {
            _context = context;
        }
        // checkUserName if null return false
        public async Task<Boolean> checkUserName(string id)
        {
            var data = await _context.Liste_Utilisateur.FirstOrDefaultAsync(l => l.LoginUtilisateur == id);
            if (data != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // checkEmail if null return false
        public async Task<Boolean> checkEmail(string email)
        {
            var data = await _context.Liste_Utilisateur.FirstAsync(l => l.EmailUtilisateur == email);
            if (data != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<db.Liste_Utilisateur> Login(string id, string pass)
        {
            // && a.IDStatutUtilisateur ==2
            db.Liste_Utilisateur lst = new db.Liste_Utilisateur();
            lst = await (from a in _context.Liste_Utilisateur
                         where a.LoginUtilisateur == id && a.MotdePasseUtilisateur == pass 
                         select a).FirstOrDefaultAsync();
            return lst;
        }
        public Task sendEmailIsID(string email)
        {
            // MailMessage mail = new MailMessage();
            // mail.To.Add(email);
            // mail.From = new MailAddress(Commons.EmailFrom);
            // mail.Subject = "re-connecter mot de passe à premiumcontact";
            // mail.Body = "Hello ducnh passe: 132456";
            // mail.IsBodyHtml = true;
            // SmtpClient smtp = new SmtpClient(Commons.SMTPHost, Commons.SMTPPort);
            // smtp.Credentials = new System.Net.NetworkCredential(Commons.EmailFrom, Commons.PasswordEmailFrom);
            // smtp.UseDefaultCredentials = false;
            // smtp.EnableSsl = true;
            // smtp.Send(mail);
            var client = new SmtpClient(Commons.SMTPHost, Commons.SMTPPort)
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(Commons.EmailFrom, Commons.PasswordEmailFrom)
            };
            var mailMessage = new MailMessage
            {
                From = new MailAddress(Commons.EmailFrom)
            };
            mailMessage.To.Add(email);
            mailMessage.Subject = "re-connecter mot de passe à premiumcontact";
            mailMessage.Body = "<h1>Hello ducnh passe: 132456</h1>";
            return client.SendMailAsync(mailMessage);
        }
        public Task sendEmailNotID(string email)
        {
            var client = new SmtpClient(Commons.SMTPHost, Commons.SMTPPort)
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(Commons.EmailFrom, Commons.PasswordEmailFrom)
            };
            var mailMessage = new MailMessage
            {
                From = new MailAddress(Commons.EmailFrom)
            };
            mailMessage.To.Add(email);
            mailMessage.Subject = "re-connecter mot de passe à premiumcontact";
            mailMessage.Body = "<h1>Hello ducnh id :đâsdas passe: 132456</h1>";
            return client.SendMailAsync(mailMessage);
        }

        // Ngan_10-09-2018: load data user by userName
        public async Task<db.Liste_Utilisateur> LoadUser_ByID(string id)
        {
            var data = await _context.Liste_Utilisateur.FirstOrDefaultAsync(l => l.IDUtilisateur == Convert.ToInt32(id));
            return data;
        }
        //Ngan_14_09_2018: Load data user participation event
        public async Task<List<db.Liste_Utilisateur>> LoadUser_InEvent(int id)
        {
            var lst = new List<db.Liste_Utilisateur>();
            // Neu id = 236690 la admin thi hien thi danh sach tat ca cac thanh vien trong su kien
            if (id == 236690)
            {
                lst = await (from a in _context.Liste_Enquete_Contact
                             join b in _context.Contact on a.IDContact equals b.Idcontact
                             join u in _context.Liste_Utilisateur on b.Idutilisateur equals u.IDUtilisateur
                             where a.IDSociete == id && a.DateFinEnquete > DateTime.Now
                             select u
                             ).GroupBy(x => new
                             {
                                 x.IDUtilisateur,
                                 x.PrenomUtilisateur,
                                 x.EmailUtilisateur,
                                 x.LoginUtilisateur,
                                 x.NomUtilisateur,
                                 x.FonctionUtilisateur
                             })
                  .Select(y => new db.Liste_Utilisateur()
                  {
                      IDUtilisateur = y.Key.IDUtilisateur,
                      PrenomUtilisateur = y.Key.PrenomUtilisateur,
                      EmailUtilisateur = y.Key.EmailUtilisateur,
                      LoginUtilisateur = y.Key.LoginUtilisateur,
                      NomUtilisateur = y.Key.NomUtilisateur,
                      FonctionUtilisateur = y.Key.FonctionUtilisateur
                  }).OrderBy(x=>x.LoginUtilisateur).ToListAsync();
                return lst;
            }
            else
            {
               lst = await (from a in _context.Liste_Enquete_Contact
                             join b in _context.Contact on a.IDContact equals b.Idcontact 
                             join u in _context.Liste_Utilisateur on b.Idutilisateur equals u.IDUtilisateur
                             where a.IDSociete == id && a.DateFinEnquete > DateTime.Now
                             select u
                             ).GroupBy(x => new
                             {
                                  x.IDUtilisateur,
                                 x.PrenomUtilisateur,
                                 x.EmailUtilisateur,
                                 x.LoginUtilisateur,
                                 x.NomUtilisateur,
                                 x.FonctionUtilisateur
                             })
                  .Select(y => new db.Liste_Utilisateur()
                  {
                        IDUtilisateur = y.Key.IDUtilisateur,
                      PrenomUtilisateur = y.Key.PrenomUtilisateur,
                      EmailUtilisateur = y.Key.EmailUtilisateur,
                      LoginUtilisateur = y.Key.LoginUtilisateur,
                      NomUtilisateur = y.Key.NomUtilisateur,
                      FonctionUtilisateur = y.Key.FonctionUtilisateur
                  }).OrderBy(x=>x.LoginUtilisateur).ToListAsync();
                return lst;
            }
        }
      

    }
}
