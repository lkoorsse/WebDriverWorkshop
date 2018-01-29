using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace WebDriverWorkshop.PageObjects
{
    [TestFixture]
    public class I_CheckUsingPageObjects
    {
        [Test]
        public void I_InvalidPasswordPageObjects()
        {
            var Driver = new FirefoxDriver();
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");

            var loginPage = new LoginPage(Driver);
            loginPage.PopulateUsername("tomsmith");

            var loginErrorPage = loginPage.ClickLogin();
            Assert.True(loginErrorPage.ReadErrorMessage().Contains("Your password is invalid!"));

            Driver.Quit();
        }

        [Test]
        public void I_IncorrectPasswordPageObjects()
        {
            var Driver = new FirefoxDriver();
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");

            var loginPage = new LoginPage(Driver);
            loginPage.PopulateUsername("tomsmith");
            loginPage.PopulatePassword("password");

            var loginErrorPage = loginPage.ClickLogin();
            Assert.True(loginErrorPage.ReadErrorMessage().Contains("Your password is invalid!"));

            Driver.Quit();
        }

        [Test]
        public void I_CorrectPasswordPageObjects()
        {
            //Try to automate this
            //You will need to alter the original page objects

          
        }
    }
}
