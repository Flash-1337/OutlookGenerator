using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookGenerator
{
    public partial class MainForm : Form
    {
        public static List<AccountModel> accounts = new List<AccountModel>();
        public MainForm()
        {
            CheckForIllegalCrossThreadCalls = false;
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
                new Thread(() => {

                   
                    
                    var account = SeleniumUtils.CreateOutlook();
                    accounts.Add(account);
                    accountGridView.Rows.Add(account.Email, account.Password);
                }).Start();
            }
            AccountConfig.SaveConfig();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (SeleniumUtils.driver != null)
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


        private void removeAccountButton_Click(object sender, EventArgs e)
        {
            if (accountGridView.SelectedRows.Count != 0)
                accountGridView.Rows.Remove(accountGridView.SelectedRows[0]);
        }

        private void openLaunchFolder_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath);
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if (accountGridView.SelectedCells.Count == 0) return;
            string text = accountGridView.SelectedCells[0].Value.ToString()
                + ":" + accountGridView.SelectedCells[1].Value.ToString();
            Clipboard.SetText(text);
        }

    }
}
    