using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace OutlookGenerator
{
    public class SeleniumUtils
    {
        public static WebDriver driver = new FirefoxDriver();
        public static WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10000));

        public static string getRandomString(int length = 10)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwyz0123456789";

            var random = new Random();
            var randomString = new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            return randomString;
        }

        public static string getRandomPasswordString(int length = 10)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwyz0123456789!@#$%^&*";

            var random = new Random();
            var randomString = new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            return randomString;
        }


        public static void AwaitForElementAndClickById(string id)
        {
            var element = wait.Until(e => e.FindElement(By.Id(id)));
            element.Click();
        }

        public static void SendKeysToElementById(string id, string text, bool pressEnter = true)
        {
            var element = wait.Until(e => e.FindElement(By.Id(id)));
            element.SendKeys(pressEnter ? text + OpenQA.Selenium.Keys.Enter : text);
        }


        public static AccountModel GenerateLogin()
        {
            string email = "S" + getRandomString(16) + "@outlook.com";
            string password = getRandomPasswordString(8);
            return (new AccountModel(email, password));
        }



        public static AccountModel CreateOutlook()
        {
            AccountModel creds = GenerateLogin();
            try
            {
                driver.Navigate().GoToUrl("https://signup.live.com/signup");

                SendKeysToElementById("MemberName", creds.Email);
                SendKeysToElementById("PasswordInput", creds.Password);
                SendKeysToElementById("FirstName", "Jack");
                SendKeysToElementById("LastName", "Cough");
                SendKeysToElementById("BirthMonth", OpenQA.Selenium.Keys.Enter + OpenQA.Selenium.Keys.ArrowDown);
                SendKeysToElementById("BirthDay", OpenQA.Selenium.Keys.Enter + OpenQA.Selenium.Keys.ArrowDown);
                SendKeysToElementById("BirthYear", "2000");

                AwaitForElementAndClickById("idSIButton9");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error occured");
            }
            return creds;
        }

    }
}
