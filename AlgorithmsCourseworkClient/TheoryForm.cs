using AlgorithmsCourseworkLibrary;
using Microsoft.Web.WebView2.Core;
using System;
using System.IO;
using System.Windows.Forms;

namespace AlgorithmsCourseworkGUI
{
    public partial class TheoryForm : Form
    {
        public TheoryForm()
        {
            InitializeComponent();
            InitializeAsync();

            AlgorithmsCoursework.SetupVersion(versionLabel);
            AlgorithmsCoursework.SetupTimer(timeLabel);
        }

        private async void InitializeAsync()
        {
            var env = await CoreWebView2Environment.CreateAsync(userDataFolder: Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            await webView.EnsureCoreWebView2Async(env);

            webView.CoreWebView2.SetVirtualHostNameToFolderMapping(hostName: "localhost",
                                                                   folderPath: "",
                                                                   accessKind: CoreWebView2HostResourceAccessKind.Allow);

            webView.CoreWebView2.Navigate("http://localhost/report.pdf");

        }

        private void SetPage(int pageIndex)
        {
            string newUri = "http://localhost/report.pdf#page=" + pageIndex;
            webView.CoreWebView2.Navigate(newUri);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TitleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TitleForm nextForm = new TitleForm();
            nextForm.Show();
        }

        private void HandleItem_Click(object sender, EventArgs e)
        {
            String tag = (String) ((ToolStripItem)sender).Tag;
            if (tag != null && tag.Length != 0) {
                SetPage(Convert.ToInt32(tag));
            }
        }
    }
}
