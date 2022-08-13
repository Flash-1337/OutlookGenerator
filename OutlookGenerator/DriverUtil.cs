using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chromium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookGenerator
{
    internal class DriverUtils
    {
        public static string downloadUrl, driverFileName;
        public static WebDriver webDriver;


        public static List<Driver> drivers = new List<Driver>();

        
        public static void InitDrivers()
        {
            //Honestly have no clue how else to add this

            drivers.Add(new Driver("chromedriver.exe", "https://chromedriver.chromium.org/downloads"));
        }

        public static bool IsDriverInstalled(Driver driver)
        {
            return File.Exists(driver.driverFileName);
        }

        public static void ShowDriverHelp(Driver driver)
        {
            DialogResult dialogResult = MessageBox.Show($"{driver.driverFileName} not found, would you like to download it?", "Driver Missing", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dialogResult == DialogResult.Yes)
            {
                Process.Start(driver.driverDownload);
            }
        }
    }
}
