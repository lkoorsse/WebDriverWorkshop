﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace WebDriverWorkshop.PageObjects
{
    public class LoginErrorPageAnswer
    {
        [FindsBy(How = How.Id, Using = "flash")]
        private IWebElement errorMessagePanel;

        private IWebDriver Driver;

        public LoginErrorPageAnswer(IWebDriver driver)
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
