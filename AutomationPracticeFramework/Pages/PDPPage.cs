using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationPracticeFramework.Pages
{
    class PDPPage
    {
        readonly IWebDriver driver;
        public By pdpdialog = By.Id("product");
        public By quantity = By.Id("quantity_wanted");
        public By productname = By.XPath("//h1[@itemprop='name']");
        public By addbutton = By.Id("add_to_cart");
        
        public PDPPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(pdpdialog));


        }
    }
}
