using ConsoleApplication.Configuration;
using ConsoleApplication.Interfaces;
using Microsoft.Extensions.Configuration;

namespace MSTest.ConfigTests;

[TestClass]
public class SettingsTest
{
    private GameSettings settings;

    [TestInitialize]
    public void Init()
    {
        IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .AddEnvironmentVariables()
            .Build();

        settings = config.GetRequiredSection(nameof(GameSettings)).Get<GameSettings>();
    }

    [TestMethod]
    public void GetBrowserFromConfig()
    {
        Console.WriteLine($"Browser = { settings.Browser }");
    }

    [TestMethod]
    public void GetUsernameFromConfig()
    {
        Console.WriteLine($"Username = { settings.Username }");
    }

    [TestMethod]
    public void GetPasswordFromConfig()
    {
        Console.WriteLine($"Password = { settings.Password }");
    }

    [TestMethod]
    public void GetWebsiteFromConfig()
    {
        Console.WriteLine($"Website = { settings.Website }");
    }

    [TestMethod]
    public void GetSettingsKeysFromConfigReader()
    {
        IConfig config = new ConfigReader();
        Console.WriteLine("Browser : " + config.GetBrowser());
        Console.WriteLine("Username : " + config.GetUsername());
        Console.WriteLine("Password : " + config.GetPassword());
        Console.WriteLine("Website : " + config.GetWebsite());
    }
}