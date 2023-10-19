using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook_Account_Gen
{
    public class ExtensionJsonConfig
    {
        public string apiKey { get; set; }
        public string appId { get; set; }
        public bool useCapsolver { get; set; }
        public bool manualSolving { get; set; }
        public string solvedCallback { get; set; }
        public bool useProxy { get; set; }
        public string proxyType { get; set; }
        public string hostOrIp { get; set; }
        public string port { get; set; }
        public string proxyLogin { get; set; }
        public string proxyPassword { get; set; }
        public bool enabledForBlacklistControl { get; set; }
        public List<object> blackUrlList { get; set; }
        public bool enabledForRecaptcha { get; set; }
        public bool enabledForRecaptchaV3 { get; set; }
        public bool enabledForHCaptcha { get; set; }
        public bool enabledForFunCaptcha { get; set; }
        public bool enabledForImageToText { get; set; }
        public string reCaptchaMode { get; set; }
        public string hCaptchaMode { get; set; }
        public int reCaptchaDelayTime { get; set; }
        public int hCaptchaDelayTime { get; set; }
        public int textCaptchaDelayTime { get; set; }
        public int reCaptchaRepeatTimes { get; set; }
        public int reCaptcha3RepeatTimes { get; set; }
        public int hCaptchaRepeatTimes { get; set; }
        public int funCaptchaRepeatTimes { get; set; }
        public int textCaptchaRepeatTimes { get; set; }
        public string textCaptchaSourceAttribute { get; set; }
        public string textCaptchaResultAttribute { get; set; }
    }

    public class Config
    {
        public static ExtensionJsonConfig GetConfig(string path)
        {
            if (!File.Exists(path))
                return null;

            string contents = File.ReadAllText(path);

            return JsonConvert.DeserializeObject<ExtensionJsonConfig>(contents);
        }

        public static void SetConfig(string path, ExtensionJsonConfig config)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(config, Formatting.Indented));
        }
    }
}
