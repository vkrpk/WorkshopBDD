using ConsoleApplication.BaseClasses;
using ConsoleApplication.BaseClasses.ComponentHelper;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace MSTest.PageNavigationTests;

[TestClass]
public class PageNavigationTests
{
    [TestMethod]
    public void OpenUrlFromDriver()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("http://localhost:80");
        driver.Close();
        driver.Quit();
    }

    [TestMethod]
    public void OpenPageFromObjectRepository()
    {
        NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
    }

    [TestMethod]
    public void OpenPageFromObjectRepositoryAndGetTitle()
    {
        NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
        Console.WriteLine(ObjectRepository.Driver.Title);
    }

    [TestMethod]
    public void OpenPageFromObjectRepositoryAndGetTitleFromPageHelper()
    {
        NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
        Console.WriteLine(PageHelper.GetPageTitle());
    }

    // [TestMethod]
    // public void OpenUrlFromDriver()
    // {
    //     IWebDriver driver = new FirefoxDriver();
    //     driver.Navigate().GoToUrl("http://localhost:80");
    // }
}