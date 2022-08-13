using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookGenerator
{
    internal class DriverUtils
    {
        public static bool isDriverDownloaded()
        {
            return File.Exists("geckodriver.exe");
        }

        public static void downloadDriver()
        {
            Process.Start("https://github.com/mozilla/geckodriver/releases");
        }
    }
}
