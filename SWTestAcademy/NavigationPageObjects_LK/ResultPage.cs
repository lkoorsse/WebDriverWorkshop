using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using WebDriverWorkshop.NavigationPageObjects_LK;


namespace WebDriverWorkshop.NavigationPageObjects_LK
{
    public class ResultPage
    {
        private IWebDriver driver;

        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
            
        }

        [FindsBy(How = How.CssSelector, Using = "#post-3794 > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > h2:nth-child(1)")]
        private IWebElement firstArticle;

        public void clickOnFirstArticle()
        {
            firstArticle.Click();
        }
    }
}
