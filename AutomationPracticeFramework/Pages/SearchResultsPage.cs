using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationPracticeFramework.Pages
{
    class SearchResultsPage
    {
        readonly IWebDriver driver;

        public By searchResult = By.ClassName("lighter");
        public By searhPage = By.Id("search");

        public SearchResultsPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(searhPage));
        }
    }
}
