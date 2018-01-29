using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using WebDriverWorkshop.NavigationPageObjects_LK;


namespace WebDriverWorkshop.NavigationPageObjects_LK
{
    public class AboutPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public AboutPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver,this);
        }

        [FindsBy(How = How.CssSelector, Using = ".fusion-custom-menu-item")]
        private IWebElement searchIcon;

        [FindsBy(How = How.CssSelector, Using = ".s")]
        private IWebElement searchText;

        [FindsBy(How = How.CssSelector, Using = ".searchsubmit")]
        private IWebElement searchSelect;



        public ResultPage search(string text)
        {

            searchIcon.Click();
         //   wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".fusion-custom-menu-item")))searchIcon.Click();

            searchText.SendKeys(text);
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".searchsubmit"))).Click();
            return new ResultPage(driver);
        }
    }
}
