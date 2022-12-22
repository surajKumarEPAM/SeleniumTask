using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIFramework.Utilities;

namespace UIOrangeHrmPOM.Pages.Time
{
    public class TimeSheetPage : BasePage
    {
        #region Locators
        By elementList = By.XPath("//div[@class='oxd-table-card']");
        By timesheetMenuBar = By.XPath("//li[@class='oxd-main-menu-item-wrapper'][4]");
        #endregion

        #region Actions
        public void NavigateToLeavePage()
        {
            report.test = report._extentReports.CreateTest("The Timesheet page ").Info("Test Started");
            GetElement(timesheetMenuBar).Click();
            report.test.Log(Status.Info, "successfully clicked on the timesheet Menu Bar");
        }

        public void ValidatePendingGridDisplay()
        {
            if (GetElementsList(elementList).Count > 0)
            {
                report.test.Log(Status.Pass, "Grid is found with "+ GetElementsList(elementList).Count+" records");
            }
            else
            {
                report.test.Log(Status.Fail, "pending grid is not found in timesheet page");
            }
        }

        #endregion
    }
}
