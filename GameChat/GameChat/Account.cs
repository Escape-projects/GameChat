using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGame
{
    public class Account
    {
        public string userName;
        public string Email;
        public string password;

        public Account(string userName, string Email, string password)
        {
            this.userName = userName;
            this.Email = Email;
            this.password = password;
        }
    }
}
