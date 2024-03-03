using OpenQA.Selenium;
using Locators.Core;

namespace Locators.Tests;

public class BaseTest
{
    protected IWebDriver Driver { get; set; }

    [SetUp]
    public void FactoryDriverTest()
    {
        Driver = new Browser().Driver;
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }

}