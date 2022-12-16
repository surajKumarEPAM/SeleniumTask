using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UIFramework.SourceForSetUp;
using UiSaucedemoPOM.Pages;

namespace UiSaucedemoTest.StepDefination
{
    [Binding]
    public class LogIn
    {
        LoginPage loginPage = new LoginPage();
        string titleOfThePage = "";
        [Given(@"I Navigated to the login page")]

        public void GivenINavigatedToTheLoginPage() { }

        [When(@"I enter the '([^']*)'")]
        public void WhenIEnterThe(string username)
        {
            loginPage.SendUserNameToUserTextBox(username);
        }

        [When(@"Entered the password ""([^""]*)""")]
        public void WhenEnteredThePassword(string password)
        {
            loginPage.SendPasswordToPasswordTextBox(password);
        }

        [When(@"Click on the Login Button")]
        public void WhenClickOnTheLoginButton()
        {
            loginPage.ClickOnLoginButton();
        }

        [Then(@"I should got url contain keyword ""([^""]*)"";")]
        public void ThenIShouldGotUrlContainKeyword(string urlKeyword)
        {
            loginPage.VerifyTheValidUser(urlKeyword);
        }

    }
}
