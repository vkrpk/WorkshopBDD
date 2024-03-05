using ConsoleApplication.Configuration;
using ConsoleApplication.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace ConsoleApplication.BaseClasses;

[TestClass]
public class BaseClassTest
{
    public static IWebDriver GetChromeWebDriver()
    {
        IWebDriver driver = new ChromeDriver();
        return driver;
    }

    public static IWebDriver GetFirefoxWebDriver()
    {
        IWebDriver driver = new FirefoxDriver();
        return driver;
    }

    public static IWebDriver GetInternetExplorerWebDriver()
    {
        IWebDriver driver = new InternetExplorerDriver();
        return driver;
    }

    [AssemblyInitialize]
    public static void InitWebDriver(TestContext tc)
    {
        ObjectRepository.Config = new ConfigReader();

        switch (ObjectRepository.Config.GetBrowser())
        {
            case BrowserType.Chrome:
                ObjectRepository.Driver = GetChromeWebDriver();
                break;

            case BrowserType.Firefox:
                ObjectRepository.Driver = GetFirefoxWebDriver();
                break;

            case BrowserType.InternetExplorer:
                ObjectRepository.Driver = GetInternetExplorerWebDriver();
                break;
        }

        ObjectRepository.Driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());
    }

    [AssemblyCleanup]
    public static void TearDownWebDriver()
    {
        if (ObjectRepository.Driver != null)
        {
            ObjectRepository.Driver.Close();
            ObjectRepository.Driver.Quit();
        }
    }
}