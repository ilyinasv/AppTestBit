using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Account
    {
        public int AccountId { get; set; }
        public string Username { get; set; }
        public string UserRoles { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
    }
}
