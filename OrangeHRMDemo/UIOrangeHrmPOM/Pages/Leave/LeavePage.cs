using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIFramework.Utilities;

namespace UIOrangeHrmPOM.Pages.Leave
{
    public class LeavePage : BasePage
    {
        #region Locators
        By leaveMenuBar = By.XPath("//li[@class='oxd-main-menu-item-wrapper'][3]");
        By searchButton = By.XPath("//button[@type='submit']");
        By elementList = By.XPath("//div[@class='oxd-table-card']");
        #endregion

        #region Actions
        By FindElementByName(string name)
        {
            return By.XPath($"//label[text()='{name} Date']/parent::div/following-sibling::div//input");
        }

        public void NavigateToLeavePage()
        {
            report.test = report._extentReports.CreateTest("The Leave page ").Info("Test Started");
            GetElement(leaveMenuBar).Click();
            report.test.Log(Status.Info, "successfully clicked on the leave Menu Bar");
        }

        public void PassingStratDate()
        {
            GetElement(FindElementByName("From")).Clear();
            GetElement(FindElementByName("From")).SendKeys(ConfigurationManager.AppSettings["fromdate"]);
            report.test.Log(Status.Info, "successfully passed starting date of the leave");
        }

        public void PassingEndDate()
        {
            GetElement(FindElementByName("To")).Clear();
            GetElement(FindElementByName("To")).SendKeys(ConfigurationManager.AppSettings["todate"]);
            report.test.Log(Status.Info, "successfully passed last date of the leave");
        }

        public void ClickOnSearchButton()
        {
            GetElement(searchButton).Submit();
            report.test.Log(Status.Info, "successfully clicked on the search button");

        }

        public void VerifyRecordes()
        {
            if (GetElementsList(elementList).Count > 0)
            {
                report.test.Log(Status.Pass, "Matching element is found");
            }
            else
            {
                report.test.Log(Status.Fail, "No matching element is found");

            }
        }

        #endregion
    }
}

//label[text()='From Date']/parent::div/following-sibling::div//input