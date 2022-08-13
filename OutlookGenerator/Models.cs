using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookGenerator
{
    public class Driver
    {
        public string driverFileName;
        public string driverDownload;
        public WebDriver driverObject;

        public Driver(string file, string download)
        {
            this.driverFileName = file;
            this.driverDownload = download;
        }
    }
    
    public class ConfigModel
    {
        public Driver Driver;
        public List<AccountModel> Accounts;
    }

    public class AccountModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        
        public AccountModel(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
