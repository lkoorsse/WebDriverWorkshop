using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace WebDriverWorkshop.PageObjects
{
    public class LoginPageIncorrectPassword
    {

        [FindsBy(How = How.Id, Using = "username")]
        private IWebElement txtUsername;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement txtUserPassword;

        [FindsBy(How = How.CssSelector, Using = "button.radius")]
        private IWebElement btnLogin;

        private IWebDriver Driver;
        [FindsBy(How = How.Id, Using = "flash")]
        private IWebElement errorMessagePanel;

       // private IWebDriver Driver;

        public LoginPageIncorrectPassword(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5000));
            wait.Until(D => D.FindElement(By.Id("flash")));
        }

        public string ReadErrorMessage()
        {
            return errorMessagePanel.Text;
        }

    }
}
