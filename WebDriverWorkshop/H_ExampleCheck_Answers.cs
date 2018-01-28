using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;

namespace WebDriverWorkshop
{
    public class H_ExampleCheck_Answers
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
            //Automate this scenario
        }

        [Test]
        public void H_CorrectPassword()
        {
            //Automate this scenario
        }
    }
}
