using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationPracticeFramework.Pages
{
    class CartPage
    {
        readonly IWebDriver driver;

        public By cartpage = By.Id("order");

        public CartPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(cartpage));
        }

        public bool CartPageIsDisplayed(string pageName)
        {
            By page = By.XPath("//*[@class='navigation_page'][contains(text(),'" + pageName + "')]");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(page)).Displayed;

        }


    }
}
