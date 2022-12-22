using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UIOrangeHrmPOM.Pages.Recruitment;

namespace UIOrangeHrmTest.StepDefination.Recruitment
{
    [Binding]
    public class AddCanditate
    {
        AddCandidatePage addCandidatePage= new AddCandidatePage();  

        [When(@": I clicked on the Recruitment tab in menu tab")]
        public void WhenIClickedOnTheRecruitmentTabInMenuTab()
        {
            addCandidatePage.NavigateToRecruitmentPage();
        }

        [When(@"Click on the Add button")]
        public void WhenClickOnTheAddButton()
        {
            addCandidatePage.ClickOnAddButon();
        }

        [When(@": Enter the first name")]
        public void WhenEnterTheFirstName()
        {
            addCandidatePage.EnterFirstName();
        }

        [When(@": last name")]
        public void WhenLastName()
        {
            addCandidatePage.EnterLastName();
        }

        [When(@"email ID")]
        public void WhenEmailID()
        {
            addCandidatePage.EnterEmailID();
        }

        [When(@"Click on the save button")]
        public void WhenClickOnTheSaveButton()
        {
            addCandidatePage.ClickOnTheSaveButton();
        }

        [Then(@"user must be present in the application area")]
        public void ThenUserMustBePresentInTheApplicationArea()
        {
            addCandidatePage.VerifyUserAddedInApplicationStage();
        }

        [Then(@"should display some ""([^""]*)"" field")]
        public void ThenShouldDisplaySomeField(string expectedResult)
        {
            addCandidatePage.InvalidRegistration(expectedResult);
        }

    }
}
