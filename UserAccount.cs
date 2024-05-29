using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser
{
    public class UserAccount
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<string> Favorites { get; set; }

        public UserAccount(string username, string password)
        {
            Username = username;
            Password = password;
            Favorites = new List<string>();
        }
    }
}
