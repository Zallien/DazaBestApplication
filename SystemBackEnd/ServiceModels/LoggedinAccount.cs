using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class LoggedinAccount
    {
        public Guid AccountId { get; set; }
        public string AccountNumber { get; set; }
        public string Fullname { get; set; }
        public DateTime DateCreated { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsOwner { get; set; }
    }
}
