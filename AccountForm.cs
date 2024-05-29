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
            // Refresh user info only if a user is logged in
            if (currentUser != null)
            {
                RefreshUserInfo();
            }
        }
        public void RefreshUserInfo()
        {
            if (currentUser != null)
            {
                lblUsername.Text = currentUser.Username;

                lstFav.Items.Clear(); // Clear previous items
                foreach (string favorite in currentUser.Favorites)
                {
                    lstFav.Items.Add(favorite);
                }
            }
            else
            {
                // If currentUser is null, clear the controls
                lblUsername.Text = "";
                lstFav.Items.Clear();
            }
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            // Clear currentUser only when the user explicitly logs out
            currentUser = null;

            // Close the account form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
