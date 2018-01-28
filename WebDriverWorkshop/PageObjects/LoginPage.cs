using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace WebDriverWorkshop.PageObjects
{
    public class LoginPage
    {
        //Activity from BTDConf

        [FindsBy(How = How.Id, Using = "username")]
        private IWebElement txtUsername;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement txtUserPassword;

        [FindsBy(How = How.CssSelector, Using = "button.radius")]
        private IWebElement btnLogin;

        private IWebDriver Driver;

        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5000));
            wait.Until(D => D.FindElement(By.Id("username")));
        }

        public void PopulateUsername(string username)
        {
            txtUserPassword.SendKeys(username);
        }

        public void PopulatePassword(string password)
        {
            txtUsername.SendKeys(password);
        }

        public LoginErrorPage ClickLogin()
        {
            btnLogin.Click();
            return new LoginErrorPage(Driver);
        }

        public LoginErrorPage ClickLoginExpectingError()
        {
            btnLogin.Click();
            return new LoginErrorPage(Driver);
        }

        //public LoggedInPageSuccess ClickLoginExpectingSuccess()
        //{
        //    btnLogin.Click();
        //    return new LoggedInPageSuccess(Driver);
        //}
    }
}
