using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIFramework.Utilities;

namespace UIOrangeHrmPOM.Pages.Admin
{
    public class AdminPage : BasePage
    {
        String searchUserName = ConfigurationManager.AppSettings["SearchKey"];

        #region Locators
        By adminMenuBar = By.XPath("//li[@class='oxd-main-menu-item-wrapper'][1]");
        By userNameElement = By.XPath("//label[contains(text(),'Username')]/parent::div/following-sibling::div/input");
        By SearchButtonElement = By.XPath("//button[@type='submit']");
        By elementList = By.XPath("//div[@class='oxd-table']");
        #endregion

        #region Actions
        public void ClickOnTheActionMenuBar()
        {
            report.test = report._extentReports.CreateTest("The Admin page ").Info("Test Started");
            GetElement(adminMenuBar).Click();
            report.test.Log(Status.Info, "successfully clicked on the Action Menu Bar");

        }

        public void SearchByUserName()
        {
            GetElement(userNameElement).SendKeys(searchUserName);
            report.test.Log(Status.Info, "successfully sended username to the text box");
        }

        public void SearchUsername()
        {
            WaitUnitlElementFound();
            GetElement(userNameElement).Submit();
            report.test.Log(Status.Info, "successfully clicked on search button");
        }

        public void VerifyRecordes()
        {
            if(GetElementsList(elementList).Count > 0)
            {
                report.test.Log(Status.Pass,  "Element exists in the record");
            }
            else
            {
                report.test.Log(Status.Fail, "Element not exists in the record");
            }
        }

        #endregion
    }
}
