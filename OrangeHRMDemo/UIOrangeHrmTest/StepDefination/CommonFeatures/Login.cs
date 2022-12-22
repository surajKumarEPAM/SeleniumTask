using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UIFramework.BasicSetUp;
using UIOrangeHrmPOM.Pages.CommonAction;

namespace UIOrangeHrmTest.StepDefination.CommonFeatures
{
    [Binding]
    public class Login 
    {
        LoginPage loginPage = new LoginPage();
        BasePageTest basePageTest= new BasePageTest();
      
        [When(@"I entered the valid username")]
        public void WhenIEnteredTheValidUsername()
        {
            string username = ConfigurationManager.AppSettings["username"];
            loginPage.SendUserNameToUserTextBox(username);
        }

        [When(@"entered the valid password")]
        public void WhenEnteredTheValidPassword()
        {
            string password = ConfigurationManager.AppSettings["password"];
            loginPage.SendPasswordToPasswordTextBox(password);
        }

        [Given(@"I Navigated to orangeHRM website login page")]
        public void GivenINavigatedToOrangeHRMWebsiteLoginPage()
        {
            loginPage.WaitForPageLoade();
        }

        [When(@"Clicked on the login button")]
        public void WhenClickedOnTheLoginButton()
        {
            loginPage.ClickOnLoginButton();
        }

        [Then(@"user should be able to login sucessessfully with tilte ""([^""]*)""")]
        public void ThenUserShouldBeAbleToLoginSucessessfullyWithTilte(string expectedTitle)
        {

            string actualTitle = loginPage.TitleOfThePage();
            Assert.That(expectedTitle, Is.EqualTo(actualTitle));
        }

        [Then(@"user should be able to login sucessessfully and having url contains ""([^""]*)""")]
        public void ThenUserShouldBeAbleToLoginSucessessfullyAndHavingUrlContains(string contaningText)
        {
            bool isSatisfy = loginPage.CheckUrlContains(contaningText);
            Assert.IsTrue(isSatisfy);
        }

    }
}
