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

        public static List<AccountModel> LoadConfig()
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
                    return config;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString() + "Error occured reading accounts.json");
            }
            return null;
        }

        public static void SaveConfig()
        {
            try
            {
                var json = JsonConvert.SerializeObject(MainForm.accounts);
                File.WriteAllText("accounts.json", json);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error occured saving accounts in accounts.json");
            }
        }
    }
}
