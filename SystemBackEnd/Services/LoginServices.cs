using BCrypt.Net;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using SystemBackEnd.Models;
using SystemBackEnd.ServiceModels;

namespace SystemBackEnd.Services
{
    public class LoginServices
    {
        private BackEndDBContext _db;

        public LoginServices(BackEndDBContext mdb)
        {
            _db = mdb;
        }

        // ======= HASH PASSWORD =======
        public static string HashPassword(string password)
        {
            // Automatically includes salt and cost factor (default 11)
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        // ======= VERIFY PASSWORD =======
        public static bool VerifyPassword(string password, string storedHash)
        {
            if (string.IsNullOrEmpty(storedHash) || string.IsNullOrEmpty(password))
                return false;

            return BCrypt.Net.BCrypt.Verify(password, storedHash);
        }

        // ======= REGISTER ACCOUNT =======
        public async Task<bool> RegisterAccountAsync(RegisterAccount registeredaccount)
        {
            if (await _db.Accounts.AnyAsync(x => x.Username == registeredaccount.Username))
                return false; // username already exists

            string hashedPassword = HashPassword(registeredaccount.Password);
            Guid theaccid = Guid.NewGuid();
            var newAccount = new Accounts
            {
                Username = registeredaccount.Username,
                Password = hashedPassword,
                DateCreated = DateTime.Now,
                AccountId = theaccid,
                AccountNumber = "",
                IsActive = true,
                IsOwner = registeredaccount.IsOwner,
                FirstName = registeredaccount.Firstname,
                LastName = registeredaccount.Lastname,
                FirstTimeLogout = true,
            };

            _db.Accounts.Add(newAccount);
            await _db.SaveChangesAsync();
            var updateaccountnumber = await _db.Accounts.FirstOrDefaultAsync(y => y.AccountId == theaccid);
            if (updateaccountnumber != null)
            {
                updateaccountnumber.AccountNumber = $"DazaAcc-{updateaccountnumber.Row.ToString("D3")}";
                _db.Update(updateaccountnumber);
                await _db.SaveChangesAsync();
            }

            return true;
        }

        // ======= LOGIN ACCOUNT =======
        public async Task<bool> LoginAccountAsync(string username, string password)
        {
            var user = await _db.Accounts.FirstOrDefaultAsync(x => x.Username == username);
            if (user == null)
                return false;

            return VerifyPassword(password, user.Password);
        }

        public async Task<int> AccountsCounts()
        {
            int count = 0;
            try
            {
                count = await _db.Accounts.CountAsync();
            }
            catch (Exception)
            {

            }
            return count;
        }
        public async Task<LoggedinAccount> GetAccountInfo(string username)
        {
            LoggedinAccount loggedinAccount = null;
            try
            {
                var acc = await _db.Accounts.FirstOrDefaultAsync(y => y.Username == username);
                loggedinAccount = new LoggedinAccount()
                {
                    Username = acc.Username,
                    Password = acc.Password,
                    Fullname = acc.Fullname,
                    AccountId = acc.AccountId,
                    AccountNumber = acc.AccountNumber,
                    DateCreated = acc.DateCreated,
                    IsOwner = acc.IsOwner,
                    NewlyLoggedIn = acc.FirstTimeLogout
                };
                return loggedinAccount;
            }
            catch (Exception e)
            {

            }
            return loggedinAccount;
        }

        //Change Account First Time Logout
        public async Task<bool> ChangeFirstTimeLogout(Guid accountId)
        {
            try
            {
                var acc = await _db.Accounts.FirstOrDefaultAsync(y => y.AccountId == accountId);
                if (acc != null)
                {
                    acc.FirstTimeLogout = false;
                    _db.Update(acc);
                    await _db.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception e)
            {

            }
            return false;


        }
        //Get All Accounts with SecurityQuestion
        public async Task<List<AccountDisplay>> GetAllAccountwithQuestion()
        {
            List<AccountDisplay> accountDisplays = new List<AccountDisplay>();
            try
            {
                //Accounts
                var accounts = await _db.Accounts.ToListAsync();
                if(accounts.Count > 0)
                {
                    //Get Questions Based On AccountId
                    foreach (var account in accounts)
                    {
                        accountDisplays.Add(new AccountDisplay()
                        {
                            AccountId = account.AccountId,
                            Fullname = account.Fullname,
                            Username = account.Username,
                            AllSecurityQuestions = await _db.SecurityQuestions
                                            .Where(q => q.AccountId == account.AccountId)
                                            .Select(q => new SecurityQuestionwithId
                                            {
                                                QuestionId = q.QuestionId,
                                                Question = q.Question,
                                                Answer = q.Answer
                                            }).ToListAsync()
                        });
                    }
                }
            }
            catch (Exception e)
            {

            }

            return accountDisplays;
        }


    }
}
