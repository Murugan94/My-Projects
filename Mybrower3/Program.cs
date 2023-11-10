using EasyTabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mybrower3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AppContainer());
            AppContainer container = new AppContainer();

            //Add the initial tab
            container.Tabs.Add(
                // our first tab created by default in the applicaiton will have the content of form1
                new TitleBarTab(container)
                {
                    Content = new frmBrowser
                    {
                        Text = "New Tab" 
                    }
                        
        
                }


              );
            // Set initial tab the first tab
            container.SelectedTabIndex = 0;

            //create tabs and start applications
            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();


            applicationContext.Start(container);
            Application.Run(applicationContext);
            
        }
    }
}
