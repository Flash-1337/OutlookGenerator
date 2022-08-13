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
    internal class Config
    {
        //Newtonsoft on top

        public static ConfigModel LoadConfig()
        {
            try
            {
                var file = File.OpenText("config.json");
                int length = file.ReadToEnd().Count();
                file.Dispose();

                if (length != 0)
                {
                    
                    var json = File.ReadAllText("config.json");
                    var config = JsonConvert.DeserializeObject<ConfigModel>(json);
                    MainForm.accounts.AddRange(config.Accounts);
                    return config;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString() + "Error occured reading config.json");
            }
            return null;
        }

        public static void SaveConfig()
        {
            try
            {
                var jsonObj = new ConfigModel();
                jsonObj.Accounts = MainForm.accounts;
                
                var json = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
                File.WriteAllText("config.json", json);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error occured saving accounts in config.json");
            }
        }
    }
}
