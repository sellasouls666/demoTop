using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.User
{
    public class UserService
    {
        private UserRepository userRepository_;

        public UserService(UserRepository userRepository)
        {
            userRepository_ = userRepository;
        }

        public bool CheckLogin(string login)
        {
            List<User> users = userRepository_.GetUsers();
            foreach (User user in users)
            {
                if (user.Login == login)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Authorize(string login, string password)
        {
            List<User> users = userRepository_.GetUsers();
            foreach (User user in users)
            {
                if (user.Login == login)
                {
                    if (user.Password == password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public User Getuser(string login)
        {
            List<User> users = userRepository_.GetUsers();
            foreach (User user in users)
            {
                if (user.Login == login)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
