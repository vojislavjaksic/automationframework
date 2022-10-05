﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationPracticeFramework.Pages
{
    class ContactUsPage
    {
        readonly IWebDriver driver;

        public By contactPage = By.Id("contact");
        public By subjectHeading = By.Id("id_contact");
        public By contactEmail = By.Id("email");
        public By message = By.Id("message");
        public By Sendbtn = By.Id("submitMessage");
        public By successMessage = By.ClassName("alert-success");
        public ContactUsPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(contactPage));
        }
    }
}
