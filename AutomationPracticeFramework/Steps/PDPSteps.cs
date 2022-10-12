using System;
using AutomationPracticeFramework.Helpers;
using AutomationPracticeFramework.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AutomationPracticeFramework.Steps
{
    [Binding]
    public class PDPSteps : Base
    {
        HomePage hp = new HomePage(Driver);
        Utilities ut = new Utilities(Driver);

        private readonly ProductData productData;

        public PDPSteps(ProductData productData)
        {
            this.productData = productData;
        }

        

        [Given(@"user opens '(.*)' section")]
        public void GivenUserOpensSection(string cat)
        {
            hp.ReturnCategoryList(cat)[1].Click();
        }
        
        [Given(@"opens first product from the list")]
        public void GivenOpensFirstProductFromTheList()
        {
            PLPPage plp = new PLPPage(Driver);
            ut.ClickOnElement(plp.firstproduct);
        }
        
        [Given(@"increases quantity to '(.*)'")]
        public void GivenIncreasesQuantityTo(string qty)
        {
            PDPPage pdp = new PDPPage(Driver);
            By iframe = By.ClassName("fancybox-iframe");
            Driver.SwitchTo().Frame(Driver.FindElement(iframe));
            ut.ClearInputField(pdp.quantity);
            ut.EnterTextInElement(pdp.quantity, qty);
            productData.ProductName = ut.ReturnTextFromElement(pdp.productname);

        }
        
        [When(@"user clicks on aad to cart button")]
        public void WhenUserClicksOnAadToCartButton()
        {
            PDPPage pdp = new PDPPage(Driver);
            ut.ClickOnElement(pdp.addbutton);
        }
        
        [When(@"user proceeds to checkout")]
        public void WhenUserProceedsToCheckout()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"cart is opened and product is added to cart")]
        public void ThenCartIsOpenedAndProductIsAddedToCart()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
