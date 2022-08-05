using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInSignUp.BL
{
    internal class User
    {
        private string _username;
        private string _password;

        public User(string username, string password)
        {
            _username = username;
            _password = password;
        }
        public string getUsername()
        {
            return _username;
        }
        public string getPassword()
        {
            return _password;
        }
    }
}
