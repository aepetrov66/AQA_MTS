using NUnit.Framework.Internal;
using OpenQA.Selenium;
using SauceDemo.Helpers.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SauceDemo.Tests
{
    public class SauceDemoLocatorsTests : BaseTest
    {
        [Test]
        public void SauceDemoTest()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);

            var userNameClass = Driver.FindElement(By.Id("login_credentials")); //id
            var usrNames = userNameClass.Text.Split('\n');

            Driver.FindElement(By.TagName("input")).SendKeys(usrNames[new Random().Next(1, usrNames.GetUpperBound(0))]); //TagName

            var passwordClass = Driver.FindElement(By.ClassName("login_password")); //className
            var password = passwordClass.Text.Split('\n')[1];

            Driver.FindElement(By.Name("password")).SendKeys(password);
            Driver.FindElement(By.Id("login-button")).Click();
            Assert.That(Driver.FindElement(By.LinkText("Sauce Labs Backpack")).Displayed); //LinkText
            Assert.That(Driver.FindElement(By.PartialLinkText("Test.allTheThings()")).Displayed); //PartialLinkText

            #region XPath
            Assert.That(Driver.FindElement(By.XPath("//div[@class='inventory_item_desc']")).Displayed);
            Assert.That(Driver.FindElement(By.XPath("//div[text()='Sauce Labs Backpack']")).Displayed);
            Assert.That(Driver.FindElement(By.XPath("//div[contains(@class,'inventory_item')]")).Displayed);
            Assert.That(Driver.FindElement(By.XPath("//div[text()='Sauce Labs Backpack']//ancestor::a")).Displayed);
            Assert.That(Driver.FindElement(By.XPath("//div[@class='pricebar']//descendant::div")).Displayed);
            Assert.That(Driver.FindElement(By.XPath("//a[@id='item_4_title_link']//following::div")).Displayed);
            Assert.That(Driver.FindElement(By.XPath("//a[@id='item_4_title_link']//following::div//parent::div")).Displayed);
            Assert.That(Driver.FindElement(By.XPath("//div[@class='inventory_item_desc']//preceding::div")).Displayed);
            #endregion

            #region СSS
            Assert.That(Driver.FindElement(By.CssSelector(".inventory_item_name")).Displayed);
            Driver.FindElement(By.CssSelector("#react-burger-menu-btn")).Click();
            Thread.Sleep(2000);
            Assert.That(Driver.FindElement(By.CssSelector(".bm-item.menu-item")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector(".bm-menu .bm-item-list")).Displayed);
            Driver.FindElement(By.CssSelector("[id*=cross-btn]")).Click();
            Thread.Sleep(2000);
            Assert.That(Driver.FindElement(By.CssSelector("img")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector("div.inventory_item_img")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector("[data-test=product_sort_container]")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector("[class~=btn_inventory]")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector("[data-test|=add]")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector("[name^=add-to-cart-sauce-labs]")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector("[name$=onesie]")).Displayed);


            #endregion



        }
    }
}
