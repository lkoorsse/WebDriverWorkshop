using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverWorkshop.NavigationPageObjects_LK;

namespace POMExample
{
    public class TestClass
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
         //   driver.Manage().Window.Maximize();
        }

        [Test]
        public void J_SearchTextFromAboutPage()
        {
            HomePage home = new HomePage(driver);
            home.goToPage();
            AboutPage about = home.goToAboutPage();
            ResultPage result = about.search("selenium c#");
            result.clickOnFirstArticle();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}