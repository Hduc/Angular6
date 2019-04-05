using System;
using System.Linq;
using db = PremiumcontactMaster.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using System.Net;
using PremiumcontactMaster.ModelData;

namespace PremiumcontactMaster.PremiumContactDA
{
    public class Question
    {
        db.DBContext _context;
        public Question(db.DBContext context)
        {
            _context = context;
        }
        // question by societe
        public async Task<List<Model_Question_Societe>> QuestionBySociete(int idEnqueteSociete)
        {
            //             SELECT dbo.Enquete_Societe.IDEnqueteSociete,dbo.Enquete_Question.IDQuestion,dbo.Enquete_Question.Question,dbo.Enquete_Question.IDTypeStockageQuestion
            // FROM            dbo.Enquete_Societe INNER JOIN					
            // dbo.Enquete_Question ON dbo.Enquete_Societe.IDEnquete = dbo.Enquete_Question.IDEnquete					
            // WHERE        (dbo.Enquete_Question.NonImprimable = 0) AND (dbo.Enquete_Question.IDStatut = 2) and (dbo.Enquete_Societe.IDEnqueteSociete= 1024103)			
            // ORDER BY dbo.Enquete_Question.OrdreQuestion, dbo.Enquete_Question.IDQuestion

            var question = await (from equestion in _context.EnqueteQuestion
                                  join esociete in _context.EnqueteSociete on equestion.Idenquete equals esociete.Idenquete
                                  where esociete.IdenqueteSociete == idEnqueteSociete && equestion.NonImprimable == false && equestion.Idstatut == 2
                                  orderby equestion.OrdreQuestion, equestion.Idquestion
                                  select new Model_Question_Societe()
                                  {
                                      IDEnqueteSociete = esociete.IdenqueteSociete,
                                      IDQuestion = equestion.Idquestion,
                                      Question = equestion.Question,
                                      IDTypeStockageQuestion = equestion.IdtypeStockageQuestion
                                  }).ToListAsync();
            return question;
        }
        public async Task<db.EnqueteReponse> InsertOrUpdateReponse(int idEnqueteSociete, int idQuestion, int typeStockage, string question)
        {

            var reponse = new db.EnqueteReponse();
            var res = new db.EnqueteReponse();
            var obj = await _context.EnqueteReponse.FirstOrDefaultAsync(x => x.IdenqueteSociete == idEnqueteSociete && x.Idquestion == idQuestion);
            // if obj ==null ==> Insert 1 item EnqueteReponse
            if (idEnqueteSociete <= 0 && idQuestion <= 0) return res;
            if (obj == null)
            {
                reponse.IdenqueteSociete = idEnqueteSociete;
                reponse.Idquestion = idQuestion;
                // typeStockage== 198 boolen yes/no
                if (typeStockage == 198) reponse.ReponseBit = Convert.ToBoolean(question);
                // typeStockage== 197 int
                else if (typeStockage == 197) reponse.Reponseint = Int32.Parse(question);
                // typeStockage== 196 note 
                else if (typeStockage == 196) reponse.ReponseMemo = question;
                // typeStockage== 194 note 
                else if (typeStockage == 194) reponse.ReponseDate = DateTime.Parse(question);
                else reponse.ReponseTexte = question;
                await _context.EnqueteReponse.AddAsync(reponse);
                await _context.SaveChangesAsync();

                res = await _context.EnqueteReponse.FirstOrDefaultAsync(x => x.IdenqueteSociete == idEnqueteSociete && x.Idquestion == idQuestion);
            }
            else
            {
                // typeStockage== 198 boolen yes/no
                if (typeStockage == 198) obj.ReponseBit = Convert.ToBoolean(question);
                // typeStockage== 197 int
                else if (typeStockage == 197) obj.Reponseint = Int32.Parse(question);
                // typeStockage== 196 note 
                else if (typeStockage == 196) obj.ReponseMemo = question;
                // typeStockage== 194 note 
                else if (typeStockage == 194) obj.ReponseDate = DateTime.Parse(question);
                else obj.ReponseTexte = question;
                await _context.SaveChangesAsync();
                res = await _context.EnqueteReponse.FirstOrDefaultAsync(x => x.IdenqueteSociete == idEnqueteSociete && x.Idquestion == idQuestion);
            }
            return res;
        }
        // public async Task<db.EnqueteReponse> UpdateReponse(int idEnqueteSociete, int idQuestion, int typeStockage, string question)
        // {
        //     var res = new db.EnqueteReponse();
        //     var obj = await _context.EnqueteReponse.FirstOrDefaultAsync(x => x.IdenqueteSociete == idEnqueteSociete && x.Idquestion == idQuestion);
        //     if (obj != null && idEnqueteSociete > 0 && idQuestion > 0)
        //     {
        //         // typeStockage== 198 boolen yes/no
        //         if (typeStockage == 198) obj.ReponseBit = Convert.ToBoolean(question);
        //         // typeStockage== 197 int
        //         else if (typeStockage == 197) obj.Reponseint = Int32.Parse(question);
        //         // typeStockage== 196 note 
        //         else if (typeStockage == 196) obj.ReponseMemo = question;
        //         // typeStockage== 194 note 
        //         else if (typeStockage == 194) obj.ReponseDate = DateTime.Parse(question);
        //         else obj.ReponseTexte = question;
        //         await _context.SaveChangesAsync();
        //         res = await _context.EnqueteReponse.FirstOrDefaultAsync(x => x.IdenqueteSociete == idEnqueteSociete && x.Idquestion == idQuestion);
        //     }
        //     return res;
        // }

    }
}