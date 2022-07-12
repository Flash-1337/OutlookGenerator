using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookGenerator
{
    internal class AccountConfig
    {
        //Newtonsoft on top

        public static void LoadConfig()
        {
            try
            {
                var file = File.OpenText("accounts.json");
                int length = file.ReadToEnd().Count();
                file.Dispose();

                if (length != 0)
                {
                    
                    var json = File.ReadAllText("accounts.json");
                    var config = JsonConvert.DeserializeObject<List<AccountModel>>(json);
                    MainForm.accounts.AddRange(config);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString() + "Error occured reading accounts.json");
            }
        }

        public static void SaveConfig()
        {
            try
            {
                var json = JsonConvert.SerializeObject(MainForm.accounts);
                var str = File.AppendText("accounts.json");

                str.Write(json);
                str.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error occured saving accounts in accounts.json");
            }
        }
    }
}
