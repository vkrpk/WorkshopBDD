using ConsoleApplication.Interfaces;
using OpenQA.Selenium;

namespace ConsoleApplication.BaseClasses;

public class ObjectRepository
{
    public static IConfig Config { get; set; }
    public static IWebDriver Driver { get; set; }
}
