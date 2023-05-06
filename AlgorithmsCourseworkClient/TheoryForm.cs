using Microsoft.Web.WebView2.Core;
using System;
using System.Windows.Forms;

namespace AlgorithmsCourseworkGUI
{
    public partial class TheoryForm : Form
    {
        public TheoryForm()
        {
            InitializeComponent();
            InitializeAsync();
        }

        async void InitializeAsync()
        {
            await webView.EnsureCoreWebView2Async(null);
            webView.CoreWebView2.SetVirtualHostNameToFolderMapping(hostName: "localhost",
                                                                   folderPath: "",
                                                                   accessKind: CoreWebView2HostResourceAccessKind.Allow);

            webView.CoreWebView2.Navigate("https://localhost/report.pdf");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void titleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TitleForm nextForm = new TitleForm();
            nextForm.Show();
        }
    }
}
