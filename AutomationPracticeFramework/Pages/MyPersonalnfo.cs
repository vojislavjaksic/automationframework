using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPracticeFramework.Pages
{
public class MyPersonalnfo
    {
        readonly IWebDriver driver;

        public By mypersonalpage = By.Id("columns");
        public By lastnamefield = By.Id("lastname");

        public MyPersonalnfo(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(mypersonalpage));

        }


    }
}
