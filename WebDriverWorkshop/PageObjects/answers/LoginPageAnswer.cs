using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace WebDriverWorkshop.PageObjects
{
    public class LoginPageAnswer
    {
        [FindsBy(How = How.Id, Using = "username")]
        private IWebElement txtUsername;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement txtPassword;

        [FindsBy(How = How.CssSelector, Using = "button.radius")]
        private IWebElement btnLogin;

        private IWebDriver Driver;

        //Initialize page
        public LoginPageAnswer(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5000));
            wait.Until(D => D.FindElement(By.Id("username")));
        }

        public void PopulateUsername(string username)
        {
            txtUsername.SendKeys(username);
        }

        public void PopulatePassword(string password)
        {
            txtPassword.SendKeys(password);
        }

        public LoginErrorPageAnswer ClickLoginExpectingError()
        {
            btnLogin.Click();
            return new LoginErrorPageAnswer(Driver);
        }

        public LoggedInPageAnswer ClickLoginExpectingSuccess()
        {
            btnLogin.Click();
            return new LoggedInPageAnswer(Driver);
        }
    }
}
