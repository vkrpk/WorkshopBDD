using ConsoleApplication.Settings;

namespace ConsoleApplication.Interfaces;

public interface IConfig
{
    public BrowserType GetBrowser();

    public string GetUsername();

    public string GetPassword();
    public string GetWebsite();
}