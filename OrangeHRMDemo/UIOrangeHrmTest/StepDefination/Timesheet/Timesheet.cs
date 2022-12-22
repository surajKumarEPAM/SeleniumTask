using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UIOrangeHrmPOM.Pages.Leave;
using UIOrangeHrmPOM.Pages.Time;

namespace UIOrangeHrmTest.StepDefination.Timesheet
{
    [Binding]
    public class Timesheet
    {
        TimeSheetPage timeSheet =new TimeSheetPage();
    
        [When(@": I clicked on the Timesheet tab in menu tab")]
        public void WhenIClickedOnTheTimesheetTabInMenuTab()
        {
            timeSheet.NavigateToLeavePage();
        }

        [Then(@": Pending action grid should display")]
        public void ThenPendingActionGridShouldDisplay()
        {
            timeSheet.ValidatePendingGridDisplay();
        }

    }
}
