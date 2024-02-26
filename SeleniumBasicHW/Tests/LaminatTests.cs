using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumBasicHW.Core;

namespace SeleniumBasicHW.Tests;

public class LaminatTests : BaseTest
{
    [Test]
    public void Laminate()
    {
        Driver.Navigate().GoToUrl("https://home-ex.ru/calculation/");

        IWebElement area = Driver.FindElement(By.Id("area"));
        IWebElement btnCalculate = Driver.FindElement(By.Id("btn_calculate"));

        area.SendKeys("10");
        btnCalculate.Click();
        Thread.Sleep(2000);

        string output = Driver.FindElement(By.ClassName("calc-result")).Text;

        string[] parts = output.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
        double requiredQuantity = double.Parse(parts[0].Split(':')[1].Trim());
        double packsQuantity = double.Parse(parts[1].Split(':')[1].Trim());
        double cost = double.Parse(parts[2].Split(':')[1].Trim().Replace(" руб", ""));
        double weight = double.Parse(parts[3].Split(':')[1].Trim().Replace(" кг", ""));

        Assert.That(requiredQuantity, Is.EqualTo(45));
        Assert.That(packsQuantity, Is.EqualTo(5));
        Assert.That(cost, Is.EqualTo(0));
        Assert.That(weight, Is.EqualTo(0));
    }
}