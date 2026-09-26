using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace CelSuiteRepoExplorer
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();

            string dir = Path.Combine(Path.GetTempPath(), "CelSuiteExplorer");
            Directory.CreateDirectory(dir);

            string[] assets = { "index.html", "icon.webp", "wallpaper.webp" };
            foreach (string name in assets)
            {
                using (Stream s = typeof(Program).Assembly.GetManifestResourceStream(name))
                {
                    if (s == null) continue;
                    using (FileStream f = File.Create(Path.Combine(dir, name)))
                    {
                        s.CopyTo(f);
                    }
                }
            }

            Application.Run(new MainForm(dir));
        }
    }

    public sealed class MainForm : Form
    {
        private readonly string _dir;
        private readonly WebView2 _web = new WebView2();

        public MainForm(string dir)
        {
            _dir = dir;
            Text = "CelSuite GitHub Repository Explorer";
            ClientSize = new Size(1280, 800);
            StartPosition = FormStartPosition.CenterScreen;
            _web.Dock = DockStyle.Fill;
            Controls.Add(_web);
            Load += async (s, e) => await StartAsync();
        }

        private async Task StartAsync()
        {
            try
            {
                CoreWebView2Environment env = await CoreWebView2Environment.CreateAsync(
                    null,
                    Path.Combine(Path.GetTempPath(), "CelSuiteExplorerProfile"));
                await _web.EnsureCoreWebView2Async(env);
                _web.CoreWebView2.Navigate(new Uri(Path.Combine(_dir, "index.html")).AbsoluteUri);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    "WebView2 failed to start:\n" + ex.Message,
                    "CelSuite GitHub Repository Explorer",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
