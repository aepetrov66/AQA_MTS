using OpenQA.Selenium;
using System.Reflection;

namespace SeleniumAdvanced.Tests
{
    public class FileUploadTests : BaseTest
    {
        [Test]
        public void FileUploadTest()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/upload");

            var fileUploadElement = WaitsHelper.WaitForExists(By.Id("file-upload"));
            string assemblyPass = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string filePath = Path.Combine(assemblyPass, "Resources", "download.jpeg");
            fileUploadElement.SendKeys(filePath);
            WaitsHelper.WaitForExists(By.Id("file-submit")).Submit();
            var fileName = WaitsHelper.WaitForExists(By.Id("uploaded-files"));
            Assert.That(fileName.Text.Equals("download.jpeg"));
        }

        [Test]
        public void FileDownloadTest()
        {
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/download");

            var fileClick = WaitsHelper.WaitForExists(By.CssSelector("a[href=\"download/some-file.txt\"]"));
            fileClick.Click();

            string assemblyPass = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string filePath = Path.Combine(assemblyPass, "Resources", fileClick.Text);
            WaitsHelper.WaitForDownload(filePath);
            File.Delete(filePath);
        }
    }
}
