using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUpTest
{
    public class Account
    {
        public Account(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public Account()
        {

        }
        private String username { get; set; }
        private String password { get; set; }

        public override string ToString()
        {
            return $"{username}, {password}\n";
        }
        
    }
}
