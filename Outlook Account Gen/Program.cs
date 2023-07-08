using PuppeteerSharp;
using PuppeteerSharp.Input;

namespace Outlook_Account_Gen;

abstract class Program
{
    private static IPage? _page;
    private const string OkButton = "#idSIButton9";

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
        using var browserFetcher = new BrowserFetcher();

        Console.WriteLine("Attempting Chromium Download");
        await browserFetcher.DownloadAsync(BrowserFetcher.DefaultChromiumRevision);
        Console.WriteLine("Chromium Downloaded");

        var browser = await Puppeteer.LaunchAsync(new LaunchOptions
        {
            Headless = false
        });

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
        
        Thread.Sleep(1000);

        await _page.MainFrame.WaitForSelectorAsync("#BirthDay");
        await _page.MainFrame.ClickAsync("#BirthDay");
        await _page.Keyboard.PressAsync(Key.Enter);
        await _page.Keyboard.PressAsync(Key.ArrowDown);
        await TypeAndClickNext("#BirthYear", "2000");
        Console.WriteLine("No captcha solver implemented, you are going to have to do this yourself");

        _page.DefaultTimeout = int.MaxValue - 1;

        string okButton = "#id__0";
        
        await _page.MainFrame.WaitForSelectorAsync(okButton);
        await _page.MainFrame.ClickAsync(okButton);
        await _page.Keyboard.PressAsync(Key.Enter);

        
        Console.WriteLine("Email: " + email);
        Console.WriteLine("Password: " + password);
        
        
        string yesButton = "#idSIButton9";
        
        await _page.MainFrame.WaitForSelectorAsync(okButton);
        await _page.MainFrame.ClickAsync(okButton);
        await _page.Keyboard.PressAsync(Key.Enter);

    }
}

