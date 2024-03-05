using ConsoleApplication.BaseClasses;

namespace MSTest;

[TestClass]
public class ConfigReaderTests
{
    [TestMethod]
    public void UsernameIsEqualToExpected()
    {
        Assert.AreEqual("bee", ObjectRepository.Config.GetUsername());
    }

    [TestMethod]
    public void PasswordIsEqualToExpected()
    {
        Assert.AreEqual("bug", ObjectRepository.Config.GetPassword());
    }

    [TestMethod]
    public void WebsiteIsEqualToExpected()
    {
        Assert.AreEqual("http://localhost:80", ObjectRepository.Config.GetWebsite());
    }
}