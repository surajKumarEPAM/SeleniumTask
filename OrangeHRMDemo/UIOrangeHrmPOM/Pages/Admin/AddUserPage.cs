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
    public class AddUserPage : BasePage
    {
        string userName = ConfigurationManager.AppSettings["Uname"],
               userRole = ConfigurationManager.AppSettings["UserRole"],
               EmployeeName = ConfigurationManager.AppSettings["EmployeeName"],
               loginPassword = ConfigurationManager.AppSettings["LoginPassword"];
                
        #region Locator
        By addButtonElement = By.XPath("//div[@class='orangehrm-header-container']/button");
        By userNameElement = By.XPath("//label[contains(text(),'Username')]/parent::div/following-sibling::div/input");
        By userRoleElement = By.XPath("//label[contains(text(),'User')]/parent::div/following-sibling::div//div[contains(text(),'Select')]");
        By EmployeeNameElement = By.XPath("//input[@placeholder='Type for hints...']");
        By StausElement = By.XPath("//label[contains(text(),'Status')]/parent::div/following-sibling::div//div[contains(text(),'Select')]");
        By userData = By.XPath("//input[@placeholder='Type for hints...']/parent::div/following-sibling::div");
        By PasswordElement = By.XPath("//label[text()='Password']/parent::div/following-sibling::div/input");
        By ConfirmPasswordElement = By.XPath("//label[contains(text(),'Confirm Password')]/parent::div/following-sibling::div/input");
        By SaveButtonElement = By.XPath("//button[@type='submit']");
        #endregion

        #region Actions
        public void ClickOnTheAddButon()
        {
            report.test = report._extentReports.CreateTest("Add user page ").Info("Test Started");
            ClickOnElement(addButtonElement);
            report.test.Log(Status.Info, "successfully clicked on the the add user button");
        }

        public void SendUserName()
        {
            SendKeysToTextFiled(userNameElement, userName);
            report.test.Log(Status.Info, "successfully sended the username to username textBox");
        }

        public void SendKeysToTheEmployeeName()
        {
            GetElement(EmployeeNameElement).SendKeys(ConfigurationManager.AppSettings["EmployeeName"]);
            WaitUnitlElementFound();
            GetElement(userData).Click();
            report.test.Log(Status.Info, "successfully sended the employee name to employee name textBox");
        }

        public void SelectTheUserRole()
        {
            ClickOnElement(userRoleElement);
            GetElement(userRoleElement).SendKeys(Keys.ArrowDown +""+ Keys.Enter);
            report.test.Log(Status.Info, "successfully selected role of the user");
        }

        public void SelectStatus()
        {
            ClickOnElement(StausElement);
            GetElement(StausElement).SendKeys(Keys.ArrowDown + "" + Keys.Enter);
            report.test.Log(Status.Info, "successfully selected status of the user");
        }

        public void EnterPassword()
        {
            GetElement(PasswordElement).SendKeys(loginPassword);
            report.test.Log(Status.Info, "successfully sended password of the user");
        }

        public void ConfirmPassword()
        {
            GetElement(ConfirmPasswordElement).SendKeys(loginPassword);
            report.test.Log(Status.Info, "successfully confirmed password of the user");
        }

        public void ClickOnSave()
        {
            
            GetElement(SaveButtonElement).Submit();
            report.test.Log(Status.Info, "successfully clicked on the save button");
            report.test.Log(Status.Pass, "User added successfully");
        }

        #endregion
    }
}
//div[@class='orangehrm-header-container']/button

//usrname
//div[@class='oxd-form-row']//div/input

//select user role
//label[contains(text(),'User Role')]/parent::div/following-sibling::div/div/div

//select status
//label[contains(text(),'Status')]/parent::div/following-sibling::div/div/div

//input[@placeholder='Type for hints...']

//userRole
//label[contains(text(),'User')]/parent::div/following-sibling::div//div[contains(text(),'Select')]
//label[contains(text(),'Status')]/parent::div/following-sibling::div//div[contains(text(),'Select')]
//usrname
//label[contains(text(),'Username')]/parent::div/following-sibling::div/input
//label[contains(text(),'Confirm Password')]/parent::div/following-sibling::div/input
//label[text()='Password']/parent::div/following-sibling::div/input