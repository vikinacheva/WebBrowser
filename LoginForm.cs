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
            txtPassword.PasswordChar = '*'; // Set PasswordChar to '*' to hide the password
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (userCredentials.ContainsKey(username) && userCredentials[username] == password)
            {
                MessageBox.Show("Login successful!");
                this.DialogResult = DialogResult.OK; // Set DialogResult to OK only on successful login
                this.Close();
            }
            else
            {
                MessageBox.Show("Please try again.");
            }
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            this.Hide(); // Hide the LoginForm before showing the RegisterForm
            using (RegisterForm registerForm = new RegisterForm(userCredentials))
            {
                registerForm.ShowDialog();
            }
            this.Show(); // Show the LoginForm again after closing the RegisterForm
        }
    }
}
