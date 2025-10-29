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

            var newAccount = new Accounts
            {
                Username = registeredaccount.Username,
                Password = hashedPassword,
                DateCreated = DateTime.Now
            };

            _db.Accounts.Add(newAccount);
            await _db.SaveChangesAsync();
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
                };
                return loggedinAccount;
            }
            catch (Exception e)
            {

            }
            return loggedinAccount;
        }


    }
}
