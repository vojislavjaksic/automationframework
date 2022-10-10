using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationPracticeFramework.Pages
{
    class SignUpPage
    {
        readonly IWebDriver driver;

        public By signin = By.Id("authentication");
        public By email = By.Id("email");
        public By password = By.Id("passwd");
        public By signinbtn = By.Id("SubmitLogin");
        public By createanaccountemail = By.Id("email_create");
        public By createaccount = By.Id("SubmitCreate");

        public SignUpPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(signin));

        }

    }
}
