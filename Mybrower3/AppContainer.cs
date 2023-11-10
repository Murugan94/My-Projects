using EasyTabs;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace Mybrower3
{
    public partial class AppContainer : TitleBarTabs
    {
        public AppContainer()
        {
            InitializeComponent();
            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);

;

        }

        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                //the content will be an instance of a new form
                //In this example will create a new instance of form1
                
                Content = new frmBrowser
                {
                    Text = "New tab"
                }

                
             };

             
        }
        private void AppContainer_Load(object sender, EventArgs e)
        {
            
        }
    }
}
