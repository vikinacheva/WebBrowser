using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class AccountForm : Form
    {
        private UserAccount currentUser;

        public AccountForm(UserAccount user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            lblUsername.Text = currentUser.Username;
            foreach (string favorite in currentUser.Favorites)
            {
                lstFavorites.Items.Add(favorite);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; // Notify the main form that the user logged out
            this.Close();
        }
    }

}
