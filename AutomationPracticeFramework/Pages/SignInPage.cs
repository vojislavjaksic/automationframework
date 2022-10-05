﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationPracticeFramework.Pages
{
    class SignInPage
    {
        readonly IWebDriver driver;

        public By signin = By.Id("authentication");
        public By email = By.Id("email");
        public By password = By.Id("passwd");
        public By signinbtn = By.Id("SubmitLogin");

        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(signin));

        }

    }
}
