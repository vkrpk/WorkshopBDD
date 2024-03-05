using ConsoleApplication.CustomExceptions;
using ConsoleApplication.Interfaces;
using ConsoleApplication.Settings;
using Microsoft.Extensions.Configuration;

namespace ConsoleApplication.Configuration;

public class ConfigReader : IConfig
{
    private GameSettings settings;

    public ConfigReader()
    {
        IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .AddEnvironmentVariables()
            .Build();

        settings = config.GetRequiredSection(nameof(GameSettings)).Get<GameSettings>();
    }

    public BrowserType GetBrowser()
    {
        string browser = settings.Browser;

        try
        {
            return (BrowserType)Enum.Parse(typeof(BrowserType), browser);
        }
        catch (ArgumentException)
        {
            throw new NoSuitableDriverFound("Aucun driver n'a été trouvé  : " + settings.Browser);
        }
    }

    public string GetUsername()
    {
        return settings.Username;
    }

    public string GetPassword()
    {
        return settings.Password;
    }

    public string GetWebsite()
    {
        return settings.Website;
    }
}