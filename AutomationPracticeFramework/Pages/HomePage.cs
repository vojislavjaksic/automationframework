using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationPracticeFramework.Pages
{
    class HomePage
    {
        readonly IWebDriver driver;

        public By homepage = By.Id("index");
        public By contactUs = By.Id("contact-link");
        public By search = By.Id("search_query_top");
        public By searchBtn = By.Name("submit_search");
        public By signin = By.ClassName("login");
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(homepage));
    
        }

        public IList<IWebElement> ReturnCategoryList(string catName)
        {
            By catOption = By.CssSelector(".sf-menu [title='" + catName+"']");
            IList<IWebElement> category = driver.FindElements(catOption);
            return category;
        }

    }
}
