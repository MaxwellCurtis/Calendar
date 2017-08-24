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
        public String username { get; set; }
        public String password { get; set; }

        public override string ToString()
        {
            return $"{username}, {password}\n";
        }
        
    }
}
