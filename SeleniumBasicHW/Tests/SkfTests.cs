using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumBasicHW.Core;

namespace SeleniumBasicHW.Tests;

public class SkfTests : BaseTest
{
    [Test]
    public void ValidateSKF()
    {
        Driver.Navigate().GoToUrl("https://bymed.top/calc/%D1%81%D0%BA%D1%84-2148");
        Driver.SwitchTo().Frame(0);

        IWebElement age = Driver.FindElement(By.Id("age"));
        IWebElement sex = Driver.FindElement(By.Id("sex"));
        SelectElement sexSE = new SelectElement(sex);
        IWebElement creatinin = Driver.FindElement(By.Id("cr"));
        IWebElement measurment = Driver.FindElement(By.Id("cr-size"));
        SelectElement measurmentSE = new (measurment);
        IWebElement race = Driver.FindElement(By.Id("race"));
        SelectElement raceSE = new SelectElement(race);
        IWebElement mass = Driver.FindElement(By.Id("mass"));
        IWebElement grow = Driver.FindElement(By.Id("grow"));
        IWebElement calculateBtn = Driver.FindElement(By.CssSelector("#input-data > p:nth-child(7) > button:nth-child(1)"));

        age.SendKeys("20");
        sexSE.SelectByValue("F");
        age.SendKeys(Keys.ArrowDown);
        creatinin.SendKeys(Keys.ArrowUp);
        measurmentSE.SelectByValue("mg");
        raceSE.SelectByText("Негроидная");
        mass.SendKeys("120");
        grow.SendKeys("160");
        calculateBtn.Click();

        IWebElement mdrdRes = Driver.FindElement(By.Id("mdrd_res"));
        IWebElement mdrdResMesurment = Driver.FindElement(By.XPath("/html/body/div[2]/div[1]/p/i"));
        IWebElement mdrdResDiagnosis = Driver.FindElement(By.XPath("/html/body/div[2]/div[1]/p/span"));
        IWebElement ckdEpiRes = Driver.FindElement(By.Id("ckd_epi_res"));
        IWebElement ckdEpiResMesurment = Driver.FindElement(By.XPath("/html/body/div[2]/div[2]/p/i"));
        IWebElement ckdEpiResDiagnosis = Driver.FindElement(By.XPath("/html/body/div[2]/div[2]/p/span"));
        IWebElement cgeRes = Driver.FindElement(By.Id("cge_res"));
        IWebElement cgeResMesurment = Driver.FindElement(By.XPath("/html/body/div[2]/div[3]/p/i"));
        IWebElement schwartzRes = Driver.FindElement(By.Id("schwartz_res"));
        IWebElement schwartzResMesurment = Driver.FindElement(By.XPath("/html/body/div[2]/div[4]/p/i"));
        IWebElement schwartzResDiagnosis = Driver.FindElement(By.XPath("/html/body/div[2]/div[4]/p/span"));

        Assert.That(mdrdRes.Text, Is.EqualTo("250811.8"));
        Assert.That(mdrdResMesurment.Text, Is.EqualTo("мл/мин/1.73м2"));
        Assert.That(mdrdResDiagnosis.Text, Is.EqualTo("Нормальный уровень СКФ (C1)"));
        Assert.That(ckdEpiRes.Text, Is.EqualTo("1256.39"));
        Assert.That(ckdEpiResMesurment.Text, Is.EqualTo("мл/мин/1.73м2"));
        Assert.That(ckdEpiResDiagnosis.Text, Is.EqualTo("Нормальный уровень СКФ (C1)"));
        Assert.That(cgeRes.Text, Is.EqualTo("171416.67"));
        Assert.That(cgeResMesurment.Text, Is.EqualTo("мл/мин"));
        Assert.That(schwartzRes.Text, Is.EqualTo("88686.08"));
        Assert.That(schwartzResMesurment.Text, Is.EqualTo("мл/мин/1.73м2"));
        Assert.That(schwartzResDiagnosis.Text, Is.EqualTo("Нормальный уровень СКФ (C1)"));
    }
}
