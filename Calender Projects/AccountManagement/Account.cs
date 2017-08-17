using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calender_Projects.AccountManagement
{
    public class Account
    {
        private String username;
        private String password;

        public Account()
        {

        }
        public Account(String UserName, String PassWord)
        {
            username = UserName;
            password = PassWord;
        }

        public String getUserName()
        {
            return username;
        }

        public override String ToString()
        {
            return username;
        }
    }
    }