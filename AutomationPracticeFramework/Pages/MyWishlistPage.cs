using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationPracticeFramework.Pages
{
    class MyWishlistPage
    {
        readonly IWebDriver driver;
        public By wishlistpage = By.Id("mywishlist");
        public By nameset = By.Id("name");
        public By submit = By.Id("submitWishlist");
        public By wlsname = By.ClassName("block-center");

        public MyWishlistPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(wishlistpage));

        }
        public bool MyWishlistPageIsDisplayed(string pageName)
        {
            By page = By.XPath("//*[@class='navigation_page'][contains(text(),'" + pageName + "')]");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(page)).Displayed;

        }
    }
}
