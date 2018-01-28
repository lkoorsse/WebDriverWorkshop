using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverWorkshop.PageObjects
{
    [TestFixture]
    public class I_CheckUsingPageObjects_Answers
    {
        [Test]
        public void I_InvalidPasswordPageObjects()
        {
            var Driver = new FirefoxDriver();
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");

            var loginPageAnswer = new LoginPageAnswer(Driver);
            loginPageAnswer.PopulateUsername("tomsmith");

            var loginErrorPage = loginPageAnswer.ClickLoginExpectingError();
            Assert.True(loginErrorPage.ReadErrorMessage().Contains("Your password is invalid!"));

            Driver.Quit();
        }

        [Test]
        public void I_IncorrectPasswordPageObjects()
        {
            var Driver = new FirefoxDriver();
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");

            var loginPageAnswer = new LoginPageAnswer(Driver);
            loginPageAnswer.PopulateUsername("tomsmith");
            loginPageAnswer.PopulatePassword("password");

            var loginErrorPage = loginPageAnswer.ClickLoginExpectingError();
            Assert.True(loginErrorPage.ReadErrorMessage().Contains("Your password is invalid!"));

            Driver.Quit();
        }

        [Test]
        public void I_CorrectPasswordPageObjects()
        {
            var Driver = new FirefoxDriver();
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");

            var loginPageAnswer = new LoginPageAnswer(Driver);
            loginPageAnswer.PopulateUsername("tomsmith");
            loginPageAnswer.PopulatePassword("SuperSecretPassword!");

            var loggedInPage = loginPageAnswer.ClickLoginExpectingSuccess();
            Assert.True(loggedInPage.ReadSuccessMessage().Contains("You logged into a secure area!"));

            Driver.Quit();
        }
    }
}
