using System;
using System.Threading;
using System.Windows.Forms;
using PureComponents.NicePanel;

namespace SHC.UROCare.UI
{
    internal static class Program
    {
        /// <summary>
        ///   The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SetThirdPartyLicense();
            var splashScreen = new SplashScreen();
            splashScreen.Show();
            Application.DoEvents();
            Thread.Sleep(5000);
            splashScreen.Dispose();

            using (var loginForm = new LoginForm())
            {
                var dialogResult = loginForm.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    Application.Run(new MainForm());
                }
            }
        }

        /// <summary>
        /// Sets license keys of third party tools.
        /// </summary>
        private static void SetThirdPartyLicense()
        {
            NicePanel.LicenseKey = "NPNL10-";
        }
    }
}