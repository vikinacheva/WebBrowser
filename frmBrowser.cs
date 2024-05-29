using EasyTabs;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class frmBrowser : Form
    {
        private Dictionary<string, string> userCredentials = new Dictionary<string, string>(); // Define at class level

        public frmBrowser()
        {
            InitializeComponent();

            var appName = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe";
            using (var Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true))
                Key.SetValue(appName, 99999, RegistryValueKind.DWord);

            webBrowser1.Navigate("https://www.google.com/");
        }

        public UserAccount CurrentUser
        {
            get { return UserStateManager.CurrentUser; }
            set { UserStateManager.CurrentUser = value; }
        }

        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            btnRefresh.Image = imgRefresh.Image;
            txtSearchUrl.Text = webBrowser1.Url.AbsoluteUri;
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack) webBrowser1.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward) webBrowser1.GoForward();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://google.com/");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnFav_Click(object sender, EventArgs e)
        {
            if (CurrentUser == null)
            {
                MessageBox.Show("Please log in to manage favorites.");
                return;
            }

            // Add current URL to favorites
            CurrentUser.Favorites.Add(webBrowser1.Url.AbsoluteUri);

            // Refresh the list of favorites in the AccountForm if it's open
            AccountForm accountForm = Application.OpenForms.OfType<AccountForm>().FirstOrDefault();
            accountForm?.RefreshUserInfo();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            if (CurrentUser != null) // Check if user is already logged in
            {
                AccountForm accountForm = new AccountForm(CurrentUser);
                if (accountForm.ShowDialog() == DialogResult.OK)
                {
                    // If the account form was closed with OK result (logout), clear currentUser
                    CurrentUser = null;
                }
            }
            else
            {
                LoginForm loginForm = new LoginForm(userCredentials);
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // User logged in successfully, open AccountForm
                    CurrentUser = new UserAccount(loginForm.Username, loginForm.Password);
                    AccountForm accountForm = new AccountForm(CurrentUser);
                    if (accountForm.ShowDialog() == DialogResult.OK)
                    {
                        // If the account form was closed with OK result (logout), clear currentUser
                        CurrentUser = null;
                    }
                }
            }
        }

        private void txtSearchUrl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtSearchUrl.Text.Trim().Length > 0)
            {
                if (txtSearchUrl.Text.Contains("."))
                {
                    webBrowser1.Navigate(txtSearchUrl.Text.Trim());
                }
                else
                {
                    webBrowser1.Navigate("https://www.google.com/search?client=opera&q=" + txtSearchUrl.Text.Trim().Replace(" ", "+") + "&sourceid=opera&ie=UTF-8&oe=UTF-8");
                }
            }
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            btnRefresh.Image = imgSpinner.Image;
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            btnRefresh.Image = imgRefresh.Image;
        }
    }
}
