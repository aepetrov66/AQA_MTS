using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SeleniumAdvanced.Tests
{
    public class AlertTests : BaseTest
    {
        [Test]
        public void ContextMenu()
        {
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/context_menu");
            var hotSpotFrame = WaitsHelper.WaitForVisibilityLocatedBy(By.Id("hot-spot"));
            Actions actions = new Actions(Driver);
            actions.ContextClick(hotSpotFrame).Perform();
            IAlert alert = Driver.SwitchTo().Alert();
            Assert.That(alert.Text, Is.EqualTo("You selected a context menu"));
            alert.Accept();
        }
    }
}
