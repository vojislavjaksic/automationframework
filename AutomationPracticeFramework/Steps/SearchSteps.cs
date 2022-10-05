using System;
using AutomationPracticeFramework.Helpers;
using AutomationPracticeFramework.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AutomationPracticeFramework.Steps
{
    [Binding]
    public class SearchSteps : Base
    {
        Utilities ut = new Utilities(Driver);
        HomePage hp = new HomePage(Driver);
        
        [Given(@"user enters '(.*)' search term")]
        public void GivenUserEntersSearchTerm(string term)
        {
            ut.EnterTextInElement(hp.search, term);
            
        }
        
        [When(@"user submits the search")]
        public void WhenUserSubmitsTheSearch()
        {
            ut.ClickOnElement(hp.searchBtn);
        }
        
        [Then(@"the results for '(.*)' search term are displayed")]
        public void ThenTheResultsForSearchTermAreDisplayed(string text)
        {
            SearchResultsPage srp = new SearchResultsPage(Driver);
            Assert.That(ut.ReturnTextFromElement(srp.searchResult), Does.Contain(text), "Wrong search results");

        }
    }
}
