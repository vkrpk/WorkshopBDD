namespace ConsoleApplication.BaseClasses.ComponentHelper;

public class PageHelper
{
    public static string GetPageTitle()
    {
        return ObjectRepository.Driver.Title;
    }

    public static string GetPageUrl()
    {
        return ObjectRepository.Driver.Url;
    }
}