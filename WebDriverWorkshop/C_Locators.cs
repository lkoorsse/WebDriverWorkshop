using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System.Linq;
using OpenQA.Selenium.Chrome;

namespace WebDriverWorkshop
{
    [TestFixture]
    public class C_Locators
    {
        [Test]
        public void C_LocatorExamples()
        {
            //Start a Firefox Instance
            var Driver = new ChromeDriver();
            //Navigate to a Website.
            Driver.Navigate().GoToUrl("http://www.twitter.com");
            Driver.FindElement(By.LinkText("Log in")).Click();

            
            var ElementByClassName = Driver.FindElement(By.ClassName("text-input"));
            var ElementByCssSelector = Driver.FindElement(By.CssSelector("input.text-input.email-input"));
            var ElementByName = Driver.FindElement(By.Name("session[username_or_email]"));
            var ElementByTagName = Driver.FindElement(By.TagName("input"));
            var ElementByXPath = Driver.FindElement(By.XPath("/html/body/div[21]/div[2]/div[2]/div[2]/div[2]/form/div[1]/input"));

            //But they can be different   
            var ElementByID = Driver.FindElement(By.Id("login-dialog-dialog"));
            var ElementByXPath1 = Driver.FindElement(By.XPath("//*[@id=\"login-dialog-dialog\"]/div[2]/div[2]/div[2]/form/div[1]/input"));
            var ElementByCssSelector1 = Driver.FindElement(By.CssSelector("#login-dialog-dialog"));
            Driver.Quit();
        }

        [Test]
        public void C_InvalidLocator()
        {
            //NoSuchElementException
            var Driver = new FirefoxDriver();
            Driver.Navigate().GoToUrl("http://www.twitter.com");
            Driver.FindElement(By.Id("LoginBox"));
            Driver.Quit();
        }

        [Test]
        public void C_FindElements()
        {
            //Start a Firefox Instance
            var Driver = new FirefoxDriver();
            //Navigate to a Website.
            Driver.Navigate().GoToUrl("http://www.twitter.com");

            var inputs = Driver.FindElementsByTagName("input").ToList();
            //13/10/2014 it was number 9
            var ElementByTagFindAll = inputs[11];
            System.Console.WriteLine(ElementByTagFindAll.GetAttribute("placeholder"));
            Driver.Quit();
        }
    }
}
