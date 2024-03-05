using System.Collections.ObjectModel;
using ConsoleApplication.BaseClasses;
using ConsoleApplication.BaseClasses.ComponentHelper;
using OpenQA.Selenium;

namespace MSTest.FindElementTest;

[TestClass]
public class FindElementTests
{
    [TestMethod]
    public void GetElementTests()
    {
        try
        {
            ObjectRepository.Driver
                .FindElement(By.LinkText("CONTACT")); // Trouver un lien existant ("New User" par exemple)
        }
        catch (NoSuchElementException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    [TestMethod]
    public void GetElementsTests()
    {
        try
        {
            ReadOnlyCollection<IWebElement> elements = ObjectRepository.Driver.FindElements(By.TagName("input"));
            Console.WriteLine(elements.Count);
        }
        catch (NoSuchElementException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    [TestMethod]
    public void GetElementFromGenericHelper()
    {
        Assert.IsNotNull(GenericHelper.GetElement(By.LinkText("CONTACT")));
    }

    [TestMethod]
    public void IsElementPresentOnce()
    {
        Assert.IsTrue(ObjectRepository.Driver.FindElements(By.LinkText("CONTACT")).Count == 1);
    }

    [TestMethod]
    public void IsElementPresentOnceFromGenericHelper()
    {
        Assert.IsTrue(GenericHelper.IsElementPresentOnce(By.LinkText("CONTACT")));
    }
}