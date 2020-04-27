using CefSharp;
using CefSharp.SchemeHandler;
using CefSharp.WinForms;
using System;
using System.IO;
using System.Windows.Forms;

namespace KioskMenu.Forms
{
    public partial class frmAbout : Form
    {
        private ChromiumWebBrowser chromeBrowser;

        public frmAbout()
        {
            InitializeComponent();
            InitializeChromium();
        }

        private void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

            settings.RegisterScheme(new CefCustomScheme
            {
                SchemeName = "localfolder",
                DomainName = "cefsharp",
                SchemeHandlerFactory = new FolderSchemeHandlerFactory(
                rootFolder: projectDirectory + @"\..\Webpage",
                hostName: "cefsharp",
                defaultPage: "index.html" // will default to index.html
                )
            });

            // Initizlie cef with provided settins.
            if (Cef.IsInitialized == false)
                Cef.Initialize(settings);

            chromeBrowser = new ChromiumWebBrowser("localfolder://cefsharp/");
            this.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
        }

        private void frmAbout_FormClosed(object sender, FormClosedEventArgs e)
        {
            chromeBrowser.Dispose();
        }
    }
}
