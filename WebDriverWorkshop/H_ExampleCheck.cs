using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;

namespace WebDriverWorkshop
{
    public class H_ExampleCheck
    {
        [Test]
        public void H_IncorrectPassword()
        {
            var Driver = new FirefoxDriver();
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5000));
            wait.Until(D => D.FindElement(By.Id("username")));

            var txtUsername = Driver.FindElementById("username");
            txtUsername.SendKeys("tomsmith");

            var btnLogin = Driver.FindElement(By.CssSelector("button.radius"));
            btnLogin.Click();

            WebDriverWait waitForError = new WebDriverWait(Driver, TimeSpan.FromSeconds(5000));
            wait.Until(D => D.FindElement(By.Id("flash")));

            Console.WriteLine(Driver.FindElement(By.Id("flash")).Text);
            Assert.True(Driver.FindElement(By.Id("flash")).Text.Contains("Your password is invalid!"));

            Driver.Quit();
        }

        [Test]
        public void H_InvalidPassword()
        {
            var Driver = new FirefoxDriver();
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5000));
            wait.Until(D => D.FindElement(By.Id("username")));

            var txtUsername = Driver.FindElementById("username");
            txtUsername.SendKeys("tomsmith");

            var txtPassword = Driver.FindElementById("password");
            txtPassword.SendKeys("password");

            var btnLogin = Driver.FindElement(By.CssSelector("button.radius"));
            btnLogin.Click();

            WebDriverWait waitForError = new WebDriverWait(Driver, TimeSpan.FromSeconds(5000));
            wait.Until(D => D.FindElement(By.Id("flash")));

            Console.WriteLine(Driver.FindElement(By.Id("flash")).Text);
            Assert.True(Driver.FindElement(By.Id("flash")).Text.Contains("Your password is invalid!"));

            Driver.Quit();
        }

        [Test]
        public void H_CorrectPassword()
        {
            var Driver = new FirefoxDriver();
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5000));
            wait.Until(D => D.FindElement(By.Id("username")));

            var txtUsername = Driver.FindElementById("username");
            txtUsername.SendKeys("tomsmith");

            var txtPassword = Driver.FindElementById("password");
            txtPassword.SendKeys("SuperSecretPassword!");

            var btnLogin = Driver.FindElement(By.CssSelector("button.radius"));
            btnLogin.Click();

            WebDriverWait waitForSuccess = new WebDriverWait(Driver, TimeSpan.FromSeconds(5000));
            wait.Until(D => D.FindElement(By.Id("flash")));

            Console.WriteLine(Driver.FindElement(By.Id("flash")).Text);
            Assert.True(Driver.FindElement(By.Id("flash")).Text.Contains("You logged into a secure area!"));

            Driver.Quit();
        }
    }
}
