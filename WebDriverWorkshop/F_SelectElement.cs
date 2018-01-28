using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;

namespace WebDriverWorkshop
{
    [TestFixture]
    public class F_SelectElement
    {
        [Test]
        public void F_SelectElementExample()
        {
            //Start a Firefox Instance
            var Driver = new FirefoxDriver();

            Driver.Navigate().GoToUrl("http://www.facebook.com");

            SelectElement selDay = new SelectElement(Driver.FindElementById("day"));
            selDay.SelectByText("14");
            Console.WriteLine(selDay.SelectedOption.Text);
            Driver.Quit();
        }       

    }
}
