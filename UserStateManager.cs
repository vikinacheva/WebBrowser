using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser
{
    public static class UserStateManager
    {
        private static UserAccount currentUser;

        public static UserAccount CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }
    }
}

