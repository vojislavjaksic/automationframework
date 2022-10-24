using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationPracticeFramework.Pages
{
    class MyAccountPage
    {
        readonly IWebDriver driver;

        public By myaccount = By.Id("my-account");
        public By navigationpage = By.Id("navigation_page");
        public By wishlistenter = By.ClassName("lnk_wishlist");
        public By myinfo = By.Id("icon-user");
        public MyAccountPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(myaccount));

        }

        public bool MyAccountPageIsDisplayed(string pageName)
        {
            By page = By.XPath("//*[@class='navigation_page'][contains(text(),'" + pageName + "')]");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(page)).Displayed;

        }

    }
}

    
