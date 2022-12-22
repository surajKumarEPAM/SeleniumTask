using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UIOrangeHrmPOM.Pages.Admin;
using UIOrangeHrmPOM.Pages.CommonAction;

namespace UIOrangeHrmTest.StepDefination.Admin
{
    [Binding]
    public class Admin
    {
        LoginPage loginPage = new LoginPage();
        AdminPage adminPage = new AdminPage();
        [Given(@": I Navigated to the Dashboard page")]
        public void GivenINavigatedToTheDashboardPage()
        {
            loginPage.WaitForPageLoade();
            loginPage.SendUserNameToUserTextBox(ConfigurationManager.AppSettings["username"]);
            loginPage.SendPasswordToPasswordTextBox(ConfigurationManager.AppSettings["password"]);
            loginPage.ClickOnLoginButton();
        }

        [When(@": I clicked on the Admin tab in menu")]
        public void WhenIClickedOnTheAdminTabInMenu()
        {
            adminPage.ClickOnTheActionMenuBar();
        }

        [When(@": Search user By username")]
        public void WhenSearchUserByUsername()
        {
            adminPage.SearchByUserName();
        }

        [When(@": Click on the search button")]
        public void WhenClickOnTheSearchButton()
        {
            adminPage.SearchUsername();
        }

        [Then(@":Related records will be displayed")]
        public void ThenRelatedRecordsWillBeDisplayed()
        {
            adminPage.VerifyRecordes();
        }

    }
}
