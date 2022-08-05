using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignInSignUp.BL;

namespace SignInSignUp.DL
{
    internal class UserCRUD
    {
        public static List<User> userList = new List<User>();

        public static bool isUsernameAvailable(string name)
        {
            foreach (User u in userList)
            {
                if (u.getUsername() == name)
                {
                    return false;
                }
            }
            return true;
        }
        public static void addUser(User u)
        {
            userList.Add(u);
        }
        public static bool isUserExist(string name, string password)
        {
            foreach (User u in userList)
            {
                if (u.getUsername() == name && u.getPassword() == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
