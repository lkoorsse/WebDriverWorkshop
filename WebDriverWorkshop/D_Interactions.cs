using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;

namespace WebDriverWorkshop
{
    [TestFixture]
    public class D_Interactions
    {
        [Test]
        public void D_SimpleInteractions()
        {
            //Start a Firefox Instance
            var Driver = new FirefoxDriver();
            //Navigate to a Website.
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");

            //Read the text of an element, in this case the first H2 tag.
            Console.WriteLine(Driver.FindElement(By.TagName("h2")).Text);
            //Enter a value in the username field using SendKeys.
            Driver.FindElement(By.Id("username")).SendKeys("tomsmith");
            //Read the value that is in the username input field
            Console.WriteLine(Driver.FindElement(By.Id("username")).GetAttribute("value"));
            //We can read any attribute
            //Read the placeholder attribute of the password field
            Console.WriteLine(Driver.FindElement(By.Id("password")).GetAttribute("name"));
            //Click on the first button, the sign in button in this instance
            Driver.FindElement(By.CssSelector("button.radius")).Click();
            Driver.Quit();
        }

        [Test]
        public void D_DriverInteractions()
        {
            //Start a Firefox Instance
            var Driver = new FirefoxDriver();
            //Navigate to a Website.
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");
            //Click on the first button, the sign in button in this instance
            Driver.FindElement(By.CssSelector("button.radius")).Click();
            //Read the url of the page.
            Console.WriteLine(Driver.Url);
            //Read the page title / tab title
            Console.WriteLine(Driver.Title);
            Driver.Quit();
        }
    }
}
