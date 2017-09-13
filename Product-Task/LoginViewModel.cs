using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Task
{
    public class LoginViewModel : BaseModel
    {
        public List<User> Users { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public User AuthenticatedUser { get; set; }
        public LoginViewModel()
        {

            Users = new List<User>
            {
                new User {Username = "asdf", Password = "1234", Money = 1000}
            };
        }
        public bool Login()
        {
            foreach (var user in Users)
                if (user.Username == Username && user.Password == Password)
                {

                    AuthenticatedUser = user;
                    return true;
                }
            return false;
        }


    }

}

