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
    public partial class LoginForm : Form
    {
        public string Username { get { return txtUsername.Text; } }
        public string Password { get { return txtPassword.Text; } }

        private Dictionary<string, string> userCredentials;

        public LoginForm(Dictionary<string, string> credentials)
        {
            InitializeComponent();
            userCredentials = credentials;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (userCredentials.ContainsKey(username) && userCredentials[username] == password)
            {
                MessageBox.Show("Login successful!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
    }

}
