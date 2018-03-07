using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverWorkshop
{
    [TestFixture]
    public class G_Waits
    {
        [Test]
        public void G_ImplicitWait()
        {
            //WebDriver will wait for the page to load, http traffic, but not ajax!

            var Driver = new FirefoxDriver();
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");

            System.Threading.Thread.Sleep(5000);

            Driver.Quit();
        }

        [Test]
        public void G_ImplicitWaitDriverTimeout()
        {
            var Driver = new FirefoxDriver();
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");
            //Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            //Driver.FindElement(By.Id("ThisIsNotReal"));
            Driver.Quit();
        }

        [Test]
        public void G_ExplicitWaits()
        {
            var Driver = new FirefoxDriver();
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(D => D.FindElement(By.Id("username")).Displayed);

            Driver.Quit();
        }
    }
}
