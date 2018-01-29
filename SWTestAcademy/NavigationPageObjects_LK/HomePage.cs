using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using WebDriverWorkshop.NavigationPageObjects_LK;


namespace WebDriverWorkshop.NavigationPageObjects_LK
{
    public class HomePage
    {
        public IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        [FindsBy(How = How.CssSelector, Using = ".fusion-main-menu a[href*='about']")]
        public IWebElement about;

        //[FindsBy(How = How.ClassName, Using = "fusion-main-menu-icon")]
        //private IWebElement searchicon;

        public void goToPage()
        {
            driver.Navigate().GoToUrl("https://www.swtestacademy.com");
            
        }

        public AboutPage goToAboutPage()
        {
            about.Click();
            return new AboutPage(driver);
        }

    }
}
