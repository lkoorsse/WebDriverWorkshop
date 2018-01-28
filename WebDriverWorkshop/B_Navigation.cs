using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace WebDriverWorkshop
{
    [TestFixture]
    public class B_Navigation
    {
        [Test]
        public void B_Navigate()
        {
            //Create a driver
            var Driver = new ChromeDriver();
            //We need to use to the Navigate method.
            Driver.Navigate().GoToUrl("http://thefriendlytester.co.uk");
            Driver.Navigate().GoToUrl("http://www.thefriendlytester.co.uk/p/about-me.html");
            Driver.Navigate().Back();
            Driver.Navigate().Forward();
            Driver.Navigate().Refresh();
            Driver.Quit();
        }
    }
}
