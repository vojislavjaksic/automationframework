using System;
using AutomationPracticeFramework.Helpers;
using AutomationPracticeFramework.Pages;
using NUnit.Framework;
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
            
            By iframe = By.ClassName("fancybox-iframe");
            Driver.SwitchTo().Frame(Driver.FindElement(iframe));
            PDPPage pdp = new PDPPage(Driver);
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
            OverlayPage op = new OverlayPage(Driver);
            ut.ClickOnElement(op.proceed);
        }

        
        [Then(@"'(.*)' is opened and product is added to cart")]
        public void ThenIsOpenedAndProductIsAddedToCart(string page)
        {
            CartPage cp = new CartPage(Driver);
            Assert.True(cp.CartPageIsDisplayed(page), "Expected page is not displayed");
            Assert.That(ut.ReturnTextFromElement(cp.productname), Is.EqualTo(productData.ProductName), "");
        }




    }
}
