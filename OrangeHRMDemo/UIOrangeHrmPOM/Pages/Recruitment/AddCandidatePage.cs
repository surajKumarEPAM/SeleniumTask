using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V106.DOM;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIFramework.Utilities;

namespace UIOrangeHrmPOM.Pages.Recruitment
{
    public class AddCandidatePage : BasePage
    {
        #region Locators
        By recruitmentMenuBar = By.XPath("//li[@class='oxd-main-menu-item-wrapper'][5]");
        By addButtonElement = By.XPath("//div[@class='orangehrm-header-container']/button");
        By saveButton = By.XPath("//button[@type='submit']");
        By applicationStageNameElement = By.XPath("//label[text()='Name']/parent::div/following-sibling::div");
        By messageArea = By.XPath("//input[@placeholder='Last Name']/parent::div/following-sibling::span");

        #endregion

        #region 
        By FindElementByName(string name)
        {
            return By.XPath($"//input[@placeholder='{name}']");
        }

        public void NavigateToRecruitmentPage()
        {
            report.test = report._extentReports.CreateTest("The RecruitmentPage page ").Info("Test Started");
            GetElement(recruitmentMenuBar).Click();
            report.test.Log(Status.Info, "successfully clicked on the recruitment Menu Bar");
        }

        public void ClickOnAddButon()
        {
            ClickOnElement(addButtonElement);
            report.test.Log(Status.Info, "successfully clicked on the the add user button");
        }

        public void EnterFirstName()
        {
            (GetElement(FindElementByName("First Name"))).SendKeys(ConfigurationManager.AppSettings["firstname"]);
            report.test.Log(Status.Info, "successfully entered the fistname");
        }

        public void EnterLastName()
        {
            (GetElement(FindElementByName("Last Name"))).SendKeys(ConfigurationManager.AppSettings["lastname"]);
            report.test.Log(Status.Info, "successfully entered the lastname");
        }

        public void EnterEmailID()
        {
            (GetElement(FindElementByName("Type here"))).SendKeys(ConfigurationManager.AppSettings["email"]);
            report.test.Log(Status.Info, "successfully entered the emailId");
        }

        public void ClickOnTheSaveButton()
        {
            GetElement(saveButton).Submit();
            report.test.Log(Status.Info, "successfully submited the form");
        }

        public void VerifyUserAddedInApplicationStage()
        {
            if(GetElement(applicationStageNameElement).Text.Contains(ConfigurationManager.AppSettings["firstname"]))
            {
                report.test.Log(Status.Pass, "user record exists in application area");
            }
            else
            {
                report.test.Log(Status.Fail, "user record is not found");
            }
        }

        public void InvalidRegistration(string message)
        {
            if ((GetElement(messageArea).Text).Equals(message))
            {
                report.test.Log(Status.Fail, "Invalid Login-Last Name required");
            }
            else
            {
                report.test.Log(Status.Pass, "user application is registered");
            }
        }

        #endregion
    }
}
