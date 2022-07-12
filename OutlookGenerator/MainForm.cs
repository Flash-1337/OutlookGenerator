using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookGenerator
{
    public partial class MainForm : Form
    {
        public static List<AccountModel> accounts = new List<AccountModel>();
        public MainForm()
        {
            InitializeComponent();
            AccountConfig.LoadConfig();

            foreach (var account in accounts)
            {
                accountGridView.Rows.Add(account.Email, account.Password);
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < amountNumericUpDown.Value; i++)
            {
                SeleniumUtils.driver.SwitchTo().NewWindow(WindowType.Tab);
                var account = SeleniumUtils.CreateOutlook();
                accounts.Add(account);
                accountGridView.Rows.Add(account.Email, account.Password);

            }
            AccountConfig.SaveConfig();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            SeleniumUtils.driver.Dispose();
            AccountConfig.SaveConfig();
            Environment.Exit(0);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            accounts.Clear();
            AccountConfig.SaveConfig();
            accountGridView.Rows.Clear();
        }

        private void openLaunchFolder_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath);
        }
    }
}
    