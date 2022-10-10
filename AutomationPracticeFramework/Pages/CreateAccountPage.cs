using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace AutomationPracticeFramework.Pages
{
    class CreateAccountPage
    {
        readonly IWebDriver driver;

        public By customerfirstname = By.Id("customer_firstname");
        public By customerlastname = By.Id("customer_lastname");
        public By email = By.Id("email");
        public By password = By.Id("passwd");
        public By firstname = By.Id("firstname");
        public By lastname = By.Id("lastname");
        public By address = By.Id("address1");
        public By city = By.Id("city");
        public By state = By.Id("id_state");
        public By postcode = By.Id("postcode");
        public By country = By.Id("id_country");
        public By mobilephone = By.Id("phone_mobile");

        public CreateAccountPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
