using EasyTabs;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;
using System.Xml;
using Win32Interop.Enums;
using System.Web;
using System.Xml.Linq;
using System.IO;
using SelectPdf;



namespace Mybrower3
{
    public partial class frmBrowser : Form
    {
        private object htmlDocument;

        public frmBrowser()
        {
            InitializeComponent();

            
            //Upgrade the default web browser
            var appName = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe";
            using (var Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true)) 
              Key.SetValue(appName, 99999, RegistryValueKind.DWord);


            //setting home page

            webBrowser1.Navigate("https://upload.wikimedia.org/wikipedia/commons/b/bd/Logo_C_sharp.svg");
            //webBrowser1.Navigate("https://www.google.com/ ");
            //webBrowser1.Navigate("https://www.example.com/ ");
        }

        protected TitleBarTabs ParentTabs
        {
            get 
            { 
                return (ParentTabs as TitleBarTabs); 
            
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //when the page has loaded th pictureBox1 gif will become invisible.
            pictureBox1.Visible = false;
            pictureBox1.Enabled = false;
            //The URl of the website will be displayed
            label1.Text = webBrowser1.Url.AbsoluteUri;


            //This is the section of experimental webscrapping
            HtmlWeb web = new HtmlWeb();
            //HtmlDocument();
            HtmlDocument document = web.Load(label1.Text);

            //var title = document.DocumentNode.SelectNodes("/html/body").First().InnerText;

            //Console.WriteLine(title);

            var divs = document.DocumentNode.Descendants("div").Where(node => node.GetAttributeValue("class", "").Contains("mw-parser-output")).ToList();

            Console.WriteLine(divs);

            foreach (var div in divs)
            {
                Console.WriteLine(div);
                

            }

            /*
            // First, pre-ES6 way.
            var htmlCollection = document.getElementsByClassName('btn');
            htmlCollection = Array.prototype.slice.call(elements);

            // Or you could do the same thing using ES6 syntax.
            var nodeList = document.querySelectorAll('.btn');
            nodeList = [...nodeList];

            // Or use Array.from method as suggested by Traek Wells in comments. 😎
            var imageHtmlCollection = document.getElementsByTagName('img');
            imageHtmlCollection = Array.from(htmlCollection);*/




        }
        private void button1_Click_1(object sender, EventArgs e)
    {
            webBrowser1.Navigate("https://upload.wikimedia.org/wikipedia/commons/b/bd/Logo_C_sharp.svg");
            //webBrowser1.Navigate("https://www.google.com/ ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack) webBrowser1.GoBack();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward) webBrowser1.GoForward();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Refresh_button_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        { 
        
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            //when the page is loading th pictureBox1 gif will become visible.
            pictureBox1.Enabled = true;
            pictureBox1.Visible = true;
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "URL") 
            {
                webBrowser1.Navigate(textBox1.Text);
            }
            
            else if (comboBox1.Text == "Google")
            {
                webBrowser1.Navigate("https://www.google.com/search?client=opera&q="+textBox1.Text.Trim().Replace(" ","+")+"&sourceid=opera&ie=UFT-8&ae=UTF-8");
            }

            else if (comboBox1.Text == "Bing")
            {
                webBrowser1.Navigate("https://www.Bing.com/search?client=opera&q=" + textBox1.Text.Trim().Replace(" ", "+") + "&sourceid=opera&ie=UFT-8&ae=UTF-8");
            }

            else if (comboBox1.Text == "Yahoo")
            {
                webBrowser1.Navigate("https://uk.search.yahoo.com/search?p="   + textBox1.Text.Trim().Replace(" ", "+") + "&fr=yfp-t&fr2=p%3Afp%2Cm%3Asb&ei=UTF-8&fp=1");
            }

            else if (comboBox1.Text == "DuckDuckGo")
            {
                webBrowser1.Navigate("https://duckduckgo.com/?va=q&t=hf&q=" + textBox1.Text.Trim().Replace(" ","+") + "&ia=web");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void PDF_Click(object sender, EventArgs e)
        {
            //This is to download the website as a pdf.
            HtmlToPdf converter = new HtmlToPdf();
            PdfDocument doc = converter.ConvertUrl(label1.Text);
            string file_name = label1.Text.Replace("/","_");
            Console.WriteLine(file_name + "is saved in download folder");
            doc.Save($@"C:\Users\Vishnu\Downloads\file_name.pdf");
            //must find a way to change the name of the pdf file and make it automatically find the download folder.
            doc.Close();
            

        }
    }
}
