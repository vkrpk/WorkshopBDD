using System.Reflection;
using ConsoleApplication.BaseClasses;
using ConsoleApplication.Configuration;
using ConsoleApplication.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace MSTest.NavigatorTests;

[TestClass]
public class NavigatorTests
{
    [TestMethod]
    public void OpenChromeAndGoToHomePage()
    {
        IWebDriver driver = new ChromeDriver();
        IConfig config = new ConfigReader();
        driver.Navigate().GoToUrl(config.GetWebsite());
        driver.Close();
        driver.Quit();
    }

    [TestMethod]
    public void OpenFirefoxAndGoToHomePage()
    {
        IWebDriver driver = new FirefoxDriver();
        IConfig config = new ConfigReader();
        driver.Navigate().GoToUrl(config.GetWebsite());
        driver.Close();
        driver.Quit();
    }

    [TestMethod]
    public void OpenUrlFromObjectRepository()
    {
        Console.WriteLine(ObjectRepository.Config.GetWebsite());
    }

    [TestMethod]
    public void OpenUrlFromObjectRepositoryAndGetTitle()
    {
        Console.WriteLine(ObjectRepository.Config.GetWebsite());
    }

    [TestMethod]
    public void OpenUrlFromObjectRepositoryAndGetTitleFromPageHelper()
    {
        Console.WriteLine(ObjectRepository.Config.GetWebsite());
    }
}