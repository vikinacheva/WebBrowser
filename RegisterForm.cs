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
    public partial class RegisterForm : Form
    {
        private Dictionary<string, string> userCredentials;

        public RegisterForm(Dictionary<string, string> credentials)
        {
            InitializeComponent();
            userCredentials = credentials;
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password cannot be empty.");
                return;
            }

            if (userCredentials.ContainsKey(username))
            {
                MessageBox.Show("Username already exists. Please choose a different username.");
            }
            else
            {
                userCredentials[username] = password;
                MessageBox.Show("Registration successful!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the RegisterForm before showing the LoginForm
            using (LoginForm loginForm = new LoginForm(userCredentials))
            {
                loginForm.ShowDialog();
            }
            this.Show(); // Show the RegisterForm again after closing the LoginForm
        }
    }
}
