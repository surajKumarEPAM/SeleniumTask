using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIFramework.Utilities;

namespace UiSaucedemoPOM.Pages
{
    public class CheckoutPage :BasePage
    {
        #region Locator
        By titelOfTheBageElement => By.ClassName("title");
        #endregion

        #region Actions
        string checkoutButton = "checkout", firstNameTextBox = "first-name", lastNameTextBox = "last-name", postalCodetextBox = "postal-code", continueButton = "continue";
        public By LocateByID(string idName)
        {
            return By.Id(idName);
        }
        public void ClickOnTheCheckOutButton()
        {
            report.test = report._extentReports.CreateTest("Checkout Page Test").Info("Test Started");
            ClickOnElement(LocateByID(checkoutButton));
            report.test.Log(Status.Info, "successfully clicked on the checkout button");
        }

        public void ClickOnTheContinueButton()
        {
            ClickOnElement(LocateByID(continueButton));
            report.test.Log(Status.Info, "successfully clicked on the continue button");
            report.test.Log(Status.Pass, "Each item matches in the cart which is added in the inventory page");
        }

        public void SendKeyToTheFirstNameTextField(string firstName)
        {
            SendKeysToTextFiled(LocateByID(firstNameTextBox), firstName);
            report.test.Log(Status.Info, "successfully firstname "+firstName+" sended to the firstname text field");
        }

        public void SendKeyToThePinTextField( string pinCode)
        {
            SendKeysToTextFiled(LocateByID(postalCodetextBox), pinCode);
            report.test.Log(Status.Info, "successfully pincode " + pinCode + " sended to the pincode text field");
        }

        public void SendKeyToTheLastNameTextField( string lastName)
        {
            SendKeysToTextFiled(LocateByID(lastNameTextBox), lastName);
            report.test.Log(Status.Info, "successfully lastname " + lastName + " sended to the lasstname text field");
        }

        public void checkHeadingOfThePage(string expectedTitle)
        {
            string actualTitle = GetElement(titelOfTheBageElement).Text;
            if(expectedTitle==actualTitle)
            {
                report.test.Log(Status.Info, "successfully navigated to the checkout page");
            }
            else
            {
                report.test.Log(Status.Info, "There is some problem for navigation on the checkout page");

            }
        }

        #endregion
    }
}
