using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UILibraryProject.Pages;
using UiTestProject.Test.BaseTest;

namespace UiTestProject.StepDefination
{
    [Binding]
    public class SeachPageTest
    {
        SearchPage searchPage=new SearchPage();
        IWebElement searchBar;
        bool isElementDisplayed;
        String expectedTitle = "iphone - Google Search";
        [Given(@"User should launched the browser sucessfully")]
        public void GivenUserShouldLaunchedTheBrowserSucessfully()
        {
            BaseTestForBrowser beseTestForBrowser= new BaseTestForBrowser();
            beseTestForBrowser.Stepup();
        }
        [Given(@"Search box and seach icon should be visible")]
        public void GivenSearchBoxAndSeachIconShouldBeVisible()
        {
            searchBar=searchPage.GetSearchBar();
            isElementDisplayed= searchBar.Displayed;
            Assert.IsNotNull(searchBar);
        }
        [When(@"I provide the search text")]
        public void WhenIProvideTheSearchText()
        {
            searchBar.SendKeys("iphone");
        }
        [When(@"click on the search icon")]
        public void WhenClickOnTheSearchIcon()
        {
            searchPage.GetSearchButton().Click();
        }
        [Then(@"I should get title is ""([^""]*)""")]
        public void ThenIShouldGetTitleIs(string titleOfThePage)
        {
            Assert.That(titleOfThePage,Is.EqualTo(expectedTitle));
        }

    }
}
