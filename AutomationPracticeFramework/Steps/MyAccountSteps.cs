using System;
using AutomationPracticeFramework.Helpers;
using AutomationPracticeFramework.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AutomationPracticeFramework.Steps
{
    [Binding]
    public class MyAccountSteps : Base
    {
        Utilities ut = new Utilities(Driver);
        HomePage hp = new HomePage(Driver);

        [Given(@"user clicks on Sign in section")]
        public void GivenUserClicksOnSection()
        {
            ut.ClickOnElement(hp.signin);
        }

        [When(@"user fills the fields '(.*)' emailaddress and '(.*)' password")]
        public void WhenUserFillsTheFieldsEmailaddressAndPassword(string emailaddress, string password)
        {
            SignInPage sip = new SignInPage(Driver);
            ut.EnterTextInElement(sip.email, emailaddress);
            ut.EnterTextInElement(sip.password, password);
        }

        [When(@"submits the form")]
        public void WhenSubmitsTheForm()
        {
            SignInPage sip = new SignInPage(Driver);
            ut.ClickOnElement(sip.signinbtn);
        }

        [Then(@"then the correct '(.*)' is displayed")]
        public void ThenHeShouldBeAbleToAccess(string page)
        {
            MyAccountPage map = new MyAccountPage(Driver);
            Assert.True(map.MyAccountPageIsDisplayed(page), "Expected page is not displayed");

        }
    }
}