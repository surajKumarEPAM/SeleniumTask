using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UIOrangeHrmPOM.Pages.Admin;

namespace UIOrangeHrmTest.StepDefination.Admin
{
    [Binding]
    public class AddUser
    {

        AddUserPage addUser = new AddUserPage();
        [When(@": I Enter the username")]
        public void WhenIEnterTheUsername()
        {
            addUser.SendUserName();
        }

        [When(@"Clicked on the Add button")]
        public void WhenClickedOnTheAddButton()
        {
            addUser.ClickOnTheAddButon();
        }

        [When(@": I select the user role")]
        public void WhenISelectTheUserRole()
        {
            addUser.SelectTheUserRole();
        }

        [When(@": Enter the Name")]
        public void WhenEnterTheName()
        {
            addUser.SendKeysToTheEmployeeName();
        }

        [When(@": Select status")]
        public void WhenSelectStatus()
        {
            addUser.SelectStatus();
        }

        [When(@": Entered Username")]
        public void WhenEnteredUsername()
        {
            addUser.SendUserName();
        }

        [When(@": Enter password")]
        public void WhenEnterPassword()
        {
            addUser.EnterPassword();
        }

        [When(@": Confirm password")]
        public void WhenConfirmPassword()
        {
            addUser.ConfirmPassword();
        }

        [When(@": Click on save button")]
        public void WhenClickOnSaveButton()
        {
            addUser.ClickOnSave();
        }

    }
}

