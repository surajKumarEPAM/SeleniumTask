using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UIOrangeHrmPOM.Pages.Leave;

namespace UIOrangeHrmTest.StepDefination.Leaves
{
    [Binding]
    public class Leave
    {
        LeavePage leavePage=new LeavePage();
        [When(@": I clicked on the Leave tab in menu tab")]
        public void WhenIClickedOnTheLeaveTabInMenuTab()
        {
            leavePage.NavigateToLeavePage();
        }

        [When(@": I enterd the start date")]
        public void WhenIEnterdTheStartDate()
        {
            leavePage.PassingStratDate();
        }

        [When(@": End date")]
        public void WhenEndDate()
        {
            leavePage.PassingEndDate();
        }

        [When(@": I clicked on the search button")]
        public void WhenIClickedOnTheSearchButton()
        {
            leavePage.ClickOnSearchButton();
        }

        [Then(@": Matching records should display")]
        public void ThenMatchingRecordsShouldDisplay()
        {
            leavePage.VerifyRecordes();
        }

    }
}
