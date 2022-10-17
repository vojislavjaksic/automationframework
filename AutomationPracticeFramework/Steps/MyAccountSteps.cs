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

        private readonly PersonData personData;
        private readonly WishListName wishListName;
        public MyAccountSteps(PersonData personData)
        {
            this.personData = personData;  
        }
        public MyAccountSteps(WishListName wishlistName)
        {
            this.wishlistName = wishlistName;
        }

        [Given(@"user clicks on Sign in section")]
        public void GivenUserClicksOnSection()
        {
            ut.ClickOnElement(hp.signin);
        }

        [When(@"user fills the fields '(.*)' emailaddress and '(.*)' password")]
        public void WhenUserFillsTheFieldsEmailaddressAndPassword(string emailaddress, string password)
        {
            SignUpPage sip = new SignUpPage(Driver);
            ut.EnterTextInElement(sip.email, emailaddress);
            ut.EnterTextInElement(sip.password, password);
        }

        [When(@"submits the form")]
        public void WhenSubmitsTheForm()
        {
            SignUpPage sip = new SignUpPage(Driver);
            ut.ClickOnElement(sip.signinbtn);
        }

        [Then(@"then the correct '(.*)' is displayed")]
        public void ThenHeShouldBeAbleToAccess(string page)
        {
            MyAccountPage map = new MyAccountPage(Driver);
            Assert.True(map.MyAccountPageIsDisplayed(page), "Expected page is not displayed");

        }

        [Given(@"types in the email address")]
        public void GivenTypesInTheEmailAddress()
        {
            SignUpPage sip = new SignUpPage(Driver);
            ut.EnterTextInElement(sip.createanaccountemail, ut.GenerateRandomEmail());
        }

        [Given(@"clicks '(.*)' button")]
        public void GivenClicksButton(string p0)
        {
            SignUpPage sip = new SignUpPage(Driver);
            ut.ClickOnElement(sip.createaccount);
        }

        [When(@"fiils the all required fields")]
        public void WhenFiilsTheAllRequiredFields()
        {
            CreateAccountPage cap = new CreateAccountPage(Driver);
            ut.EnterTextInElement(cap.customerfirstname, TestConstants.FirstName);
            ut.EnterTextInElement(cap.customerlastname, TestConstants.LastName);
            personData.FullName = TestConstants.FirstName + " " + TestConstants.LastName;
            ut.EnterTextInElement(cap.password, TestConstants.Password);
            ut.EnterTextInElement(cap.address, TestConstants.Address);
            ut.EnterTextInElement(cap.city, TestConstants.City);
            ut.EnterTextInElement(cap.postcode, TestConstants.ZipCode);
            ut.EnterTextInElement(cap.mobilephone, TestConstants.MobilePhone);
            ut.DropdownSelect(cap.state, TestConstants.State);

            ut.ClickOnElement(cap.submitaccount);

        }

        [Then(@"the he should be able to create an account")]
        public void ThenTheHeShouldBeAbleToCreateAnAccount()
        {
            Assert.True(ut.TextPresentInElement(personData.FullName).Displayed, "");
        }

        [Given(@"user logs in with '(.*)' emailaddress and '(.*)' password and is on that page")]
        public void GivenUserLogsInWithEmailaddressAndPasswordAndIsOnThatPage(string emailaddress, string password, string page)
        {

            GivenUserClicksOnSection();
            WhenUserFillsTheFieldsEmailaddressAndPassword(emailaddress, password);
            WhenSubmitsTheForm();
            ThenHeShouldBeAbleToAccess(page);


        }
        [Given(@"user clicks on '(.*)' button")]
        public void GivenUserClicksOnButton()
        {
            MyAccountPage map = new MyAccountPage(Driver);
            ut.ClickOnElement(map.wishlistenter);
        }

        [Given(@"enters random whislist name and creates wishlist")]
        public void GivenEntersRandomWhislistNameAndCreatesWishlist()
        {
            MyWishlistPage mwp = new MyWishlistPage(Driver);
            ut.EnterTextInElement(mwp.nameset, ut.GenerateRandomName());
            ut.ClickOnElement(mwp.submit);
        }

        [Then(@"user should be able to see that wishlist")]
        public void ThenUserShouldBeAbleToSeeThatWishlist()
        {
            ScenarioContext.Current.Pending();
        }


    }
}