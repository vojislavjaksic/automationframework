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

        public MyWishlistPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(wishlistpage));

        }
    }
}
