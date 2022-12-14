using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UILibraryProject.Extensions;
using UILibraryProject.Pages;

namespace UiTestProject.StepDefination
{
    [Binding]
    internal class SignPageSteps
    {
        string message,expectedTitle= "Sign in - Google Accounts";
        bool isSignInButtonDisplayed;
        IWebElement resultTextElement;
        SignInPage signInpage=new SignInPage();
        SearchPage searchPage=new SearchPage();
        ExtensionMethod extensionMethod=new ExtensionMethod();  
        
        [Given(@"Sign in button should be displayed")]
        public void GivenSignInButtonShouldBeDisplayed()
        {
            bool isElementDisplayed=searchPage.GetSignInButton().Displayed;
            Assert.IsNotNull(isSignInButtonDisplayed);

        }
        [When(@"I Click on the sign in button")]
        public void WhenIClickOnTheSignInButton()
        {
            searchPage.GetSignInButton().Click();
        }
        [When(@"The Title of the page should be""([^""]*)""")]
        public void WhenTheTitleOfThePageShouldBe(string titleOFTheSignInPage)
        {
            Assert.That(expectedTitle,Is.EqualTo(titleOFTheSignInPage));
        }
        [When(@"i provide the invalid email in the mail box")]
        public void WhenIProvideTheInvalidEmailInTheMailBox()
        {
            signInpage.GetEmailText().SendKeys("xyz@gmail.com");
        }
        [When(@"Click on the Next Button")]
        public void WhenClickOnTheNextButton()
        {
            signInpage.GetNextButton().Click();
        }
        [Then(@"It should show display is ""([^""]*)""")]
        public void ThenItShouldShowDisplayIs(string expectedResult)
        {
            resultTextElement=extensionMethod.FindElementByXpath("//div[@class='o6cuMc']");
            message=resultTextElement.Text;
           Assert.That(expectedResult, Is.EqualTo(message));    

            
        }






    }
}
