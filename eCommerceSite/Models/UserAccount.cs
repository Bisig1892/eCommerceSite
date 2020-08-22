using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceSite.Models
{
    public class UserAccount
    {

        public int UserId { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string password { get; set; }

        public DateTime? DateOfBirth { get; set; }
    }
}
