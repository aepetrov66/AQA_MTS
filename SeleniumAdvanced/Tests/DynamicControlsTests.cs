using OpenQA.Selenium;

namespace SeleniumAdvanced.Tests
{
    public class DynamicControlsTests : BaseTest
    {
        [Test]
        public void DynamicControlsTest()
        {
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dynamic_controls");
            var removeButton = WaitsHelper.WaitForVisibilityLocatedBy(By.CssSelector("button[onclick=\"swapCheckbox()\"]"));
            removeButton.Click();
            var messageText = WaitsHelper.WaitForVisibilityLocatedBy(By.Id("message"));
            Assert.That(messageText.Text.Equals("It's gone!"));
            Assert.That(WaitsHelper.WaitForElementInvisible(By.Id("checkbox")));
            var inputText = Driver.FindElement(By.CssSelector("input[type=text]"));
            Assert.That(!inputText.Enabled);
            var enableButton = Driver.FindElement(By.CssSelector("button[onclick=\"swapInput()\"]"));
            enableButton.Click();
            messageText = WaitsHelper.WaitForVisibilityLocatedBy(By.Id("message"));
            Assert.That(messageText.Text.Equals("It's enabled!"));
            Assert.That(inputText.Enabled);
        }
    }
}
