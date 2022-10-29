using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationPracticeFramework.Pages
{
    class OverlayPage
    {
        readonly IWebDriver driver;

        public By layercart = By.Id("layer_cart");
        public By proceed = By.XPath("//*[@class='btn btn-default button button-medium']");

        public OverlayPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(layercart));

        }
    }
}
