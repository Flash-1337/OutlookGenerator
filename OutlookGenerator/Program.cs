using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookGenerator
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!File.Exists("chromedriver.exe")) 
            {
                DialogResult dialogResult = MessageBox.Show("chromedriver.exe not found, would you like to download it?", "Driver Missing", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dialogResult == DialogResult.Yes)
                {
                    Process.Start("https://chromedriver.chromium.org/downloads");
                }
                
            }

            if (!File.Exists("accounts.json"))
                File.Create("accounts.json");


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
