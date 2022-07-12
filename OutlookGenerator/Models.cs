using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookGenerator
{
    public class AccountModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        
        public AccountModel(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
