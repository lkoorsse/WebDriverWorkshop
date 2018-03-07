using NUnit.Framework;
using OpenQA.Selenium.Firefox;

namespace WebDriverWorkshop
{
    [TestFixture]
    public class E_Screenshots
    {
        [Test]
        public void E_ScreenshotExample()
        {
            //Start a Firefox Instance
            var Driver = new FirefoxDriver();
            //Navigate to a Website.
            Driver.Navigate().GoToUrl("http://www.twitter.com");

            //var screenShot = Driver.GetScreenshot();
            //screenShot.SaveAsFile(@"C:\Users\koorssel\Documents\twitter.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            Driver.Quit();
        }
    }
}
