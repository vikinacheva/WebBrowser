using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;
using ComponentFactory.Krypton.Toolkit;
using CefSharp.WinForms;
using CefSharp;
using CefSharp.WinForms;

namespace WebBrowser
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            InitializeIcons();
        }

        public ChromiumWebBrowser chromeBrowser;

        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            if (!Cef.IsInitialized)
            {
                Cef.Initialize(settings);
            }

            chromeBrowser = new ChromiumWebBrowser("https://google.com");

            pnlBody.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;

            chromeBrowser.LoadingStateChanged += ChromeBrowser_LoadingStateChanged;
        }

        private void ChromeBrowser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            SetLoading(e.IsLoading);
        }

        private void SetLoading(bool displayLoader)
        {
            this.Invoke((Action)delegate
            {
                iconLoader.Visible = displayLoader;
                iconLock.Visible = !displayLoader;
                this.Cursor = displayLoader ? Cursors.WaitCursor : Cursors.Default;
            });
        }

        private void InitializeIcons()
        {
            // Assuming iconLock and iconLoader are added in the designer
            iconLock.Image = new Bitmap(""); // Replace with the actual path to your lock icon
            iconLoader.Image = new Bitmap("path_to_loader.png"); // Replace with the actual path to your loader icon
            iconLoader.Visible = false; // Initially hide the loader icon
        }

        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }
    }
}
