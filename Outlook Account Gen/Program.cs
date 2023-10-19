using Newtonsoft.Json;
using PuppeteerSharp;
using PuppeteerSharp.Input;

namespace Outlook_Account_Gen;

abstract class Program
{
    private static IPage? _page;

    private static  string GetRandomString(int length = 10, bool usePasswordChars = false)
    {
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwyz0123456789";

        if (usePasswordChars)
            chars += @"!@#$%^&*()_+<>?/.,;'{}[]\|~`";
    
        var random = new Random();
        var randomString = new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
        return randomString;
    }

    public static async Task TypeAndClickNext(string selector, string text)
    {
        if (_page == null)
            return;


        await _page.MainFrame.WaitForSelectorAsync(selector);
        await _page.MainFrame.TypeAsync(selector, text);
        await _page.Keyboard.PressAsync(Key.Enter);
    }

    public static async Task Main(string[] args)
    {
        Console.WriteLine("Loading extension, This must be in the same directory in a folder named 'CapSolver.Browser.Extension'");
        string pathToExtension = Path.GetFullPath("CapSolver.Browser.Extension");

        if (!Directory.Exists(pathToExtension))
        {
            Console.WriteLine("Extension must be downloaded and placed in the same folder, Check github for instructions");
            Console.Read();
            return;
        }

        string configPath = pathToExtension + "\\assets\\config.json";

        // Parse config.json
        ExtensionJsonConfig configJson = Config.GetConfig(configPath);

        if (configJson == null)
            throw new Exception("Failed to parse config.json");

        if (configJson.apiKey == "")
        {
            Console.WriteLine("Enter apikey, if you do not have one enter 'no'");

            string input = Console.ReadLine() ?? "no";

            configJson.apiKey = input;
        }

        Config.SetConfig(configPath, configJson);

        using var browserFetcher = new BrowserFetcher();
        Console.WriteLine("Attempting Chromium Download");
        await browserFetcher.DownloadAsync(BrowserFetcher.DefaultChromiumRevision);

        var browser = await Puppeteer.LaunchAsync(new LaunchOptions
        {
            Headless = false,
            Args = new[]
            {
                $@"--disable-extensions-except=""{pathToExtension}""",
                $@"--load-extension=""{pathToExtension}"""
            }
        });
        Console.WriteLine("Chromium Downloaded");

        _page = await browser.NewPageAsync();
        await _page.GoToAsync("https://signup.live.com/signup");

        string email = $"F{GetRandomString()}@outlook.com";
        string password = GetRandomString(20, true);

        await TypeAndClickNext("#MemberName", email);
        await TypeAndClickNext("#PasswordInput", password);
        await TypeAndClickNext("#FirstName", GetRandomString());
        await TypeAndClickNext("#LastName", GetRandomString());
        
        await _page.MainFrame.WaitForSelectorAsync("#BirthMonth");
        await _page.MainFrame.ClickAsync("#BirthMonth");
        await _page.Keyboard.PressAsync(Key.Enter);
        await _page.Keyboard.PressAsync(Key.ArrowDown);
        
        Thread.Sleep(500); // Some errors here so I wrote this lol

        await _page.MainFrame.WaitForSelectorAsync("#BirthDay");
        await _page.MainFrame.ClickAsync("#BirthDay");
        await _page.Keyboard.PressAsync(Key.Enter);
        await _page.Keyboard.PressAsync(Key.ArrowDown);
        await TypeAndClickNext("#BirthYear", "2000");

        _page.DefaultTimeout = int.MaxValue - 1;

        string okButton = "#id__0";
        
        await _page.MainFrame.WaitForSelectorAsync(okButton);
        await _page.MainFrame.ClickAsync(okButton);
        await _page.Keyboard.PressAsync(Key.Enter);


        await _page.CloseAsync();
        await _page.CloseAsync(); // Close twice because it opens 2 tabs for some reason
        await browser.CloseAsync();

        Console.WriteLine("Email: " + email);
        Console.WriteLine("Password: " + password);

        File.AppendAllText("accounts.txt", $"{email}:{password}\n");

        Console.ReadLine();
    }
}

