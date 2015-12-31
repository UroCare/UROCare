// © 2012 - 2012 Sharma Health Care Pvt. Ltd.

using System;
using System.Windows.Forms;
//using PureComponents.NicePanel;

namespace MigrateData
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            SetThirdPartyLicense();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DataMigrationForm());
        }

        /// <summary>
        /// Sets license keys of third party tools.
        /// </summary>
        private static void SetThirdPartyLicense()
        {
           // NicePanel.LicenseKey = "NPNL10-";
        }
    }
}