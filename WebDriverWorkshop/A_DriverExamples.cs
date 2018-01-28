using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;
using System;

namespace WebDriverWorkshop
{
    [TestFixture]
    public class A_DriverExamples
    {
        [Test]
        public void A_CreateFirefoxDriver()
        {
            FirefoxDriver Driver = new FirefoxDriver();
        }

        [Test]
        public void A_CreateChromeDriver()
        {
            ChromeDriver Driver = new ChromeDriver();
        }

        [Test]
        public void A_CreateEdgeDriver()
        {
            EdgeDriver Driver = new EdgeDriver();
        }

        [Test]
        public void A_RemoteWebDriver()
        {
            RemoteWebDriver Driver = new RemoteWebDriver(new Uri(""), DesiredCapabilities.Firefox());
        }
    }
}
