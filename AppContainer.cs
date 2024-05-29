using EasyTabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser
{
    public partial class AppContainer : TitleBarTabs
    {
        public AppContainer()
        {
            InitializeComponent();
            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
        }

        public override TitleBarTab CreateTab()
        {
            var browserTab = new frmBrowser
            {
                Text = "Voogle"
            };

            return new TitleBarTab(this)
            {
                Content = browserTab
            };
        }
    }
}
