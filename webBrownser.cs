using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using CefSharp;
using CefSharp.WinForms;

namespace cashdro
{
    public partial class webBrownser : DevComponents.DotNetBar.OfficeForm
    {
        public ChromiumWebBrowser chromeBrowser;
        string _url = "http://www.google.cl";
        public webBrownser()
        {
            InitializeComponent();
            
        }
        public webBrownser(string url)
        {
            InitializeComponent();
            _url = url;


        }


        private void Form2_Load(object sender, EventArgs e)
        {
            InitializeChromium();


        }

        public void InitializeChromium()
        {


          
            //Before instantiating a ChromiumWebBrowser object
            //CefSettings settings = new CefSettings();
            //settings.IgnoreCertificateErrors = true;
            //Cef.Initialize(settings);



        
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser(_url);
          //  chromeBrowser.ShowDevTools();
            // Add it to the form and fill it to the form window.
         //   this.pContainer.Controls.Add(chromeBrowser);
            this.Controls.Add(chromeBrowser);

            chromeBrowser.Dock = DockStyle.Fill;
            chromeBrowser.AddressChanged += ChromiumWebBrowser_AddressChanged;

            //el evento de nueva url se gatilla con      chromeBrowser.Load(txturl)
            //el evento de refresh pagina se gatilla con      chromeBrowser.Refresh()
            //el evento de back pagina se gatilla con      chromeBrowser.back(),  si chromeBrowser.CanGoBack)

            //  Cef.Shutdown();

        }

        private void ChromiumWebBrowser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
                    {
                        //   txtUrl.text = " ";
                    }
                    ));
        }

        private void webBrownser_FormClosed(object sender, FormClosedEventArgs e)
        {
          //  Cef.Shutdown();
        }
    }
}