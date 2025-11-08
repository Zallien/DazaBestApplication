using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemBackEnd.Models;
using SystemBackEnd.ServiceModels;

namespace SystemBackEnd.Services
{
    public class SecurityQuestionServices
    {
        private BackEndDBContext _db;

        public SecurityQuestionServices(BackEndDBContext mdb)
        {
            _db = mdb;
        }

        //Add Questions and Answer to Database
        public async Task<bool> AddSecurityQuestionAsync(InsertSecurityQuestion theData)
        {
            try
            {
                
                // Iterate through each question and answer pair
                foreach (var item in theData.AllQuestionAnswers)
                {
                    SecurityQuestions securityQuestions = new SecurityQuestions();
                    securityQuestions.AccountId = theData.AccountId;
                    securityQuestions.QuestionId = Guid.NewGuid();
                    securityQuestions.Question = item.Question;
                    securityQuestions.Answer = item.Answer;
                    await _db.AddAsync(securityQuestions);
                    await _db.SaveChangesAsync();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
