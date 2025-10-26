using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.Models
{
    public class Accounts
    {
        [Key]
        public int Row { get; set; }
        public Guid AccountId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Fullname
        {
            get { return $"{FirstName} {LastName}"; }
        }
        public DateTime DateCreated { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsOwner { get; set; }
    }
}
