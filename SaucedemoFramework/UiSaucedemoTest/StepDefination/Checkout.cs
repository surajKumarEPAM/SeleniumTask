using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UiSaucedemoPOM.Pages;

namespace UiSaucedemoTest.StepDefination
{
    [Binding]
    public class Checkout
    {
        CheckoutPage checkout = new CheckoutPage();

        [When(@"I click on the checkout button")]
        public void WhenIClickOnTheCheckoutButton()
        {
            checkout.ClickOnTheCheckOutButton();
        }

        [Then(@"The heading of the page should show ""([^""]*)""")]
        public void ThenTheHeadingOfThePageShouldShow(string pageHeading)
        {
            checkout.checkHeadingOfThePage(pageHeading);
        }

        [When(@"I Enter '([^']*)'")]
        public void WhenIEnter(string firstName)
        {
            checkout.SendKeyToTheFirstNameTextField(firstName);
        }

        [When(@"I Enter The '([^']*)'")]
        public void WhenIEnterThe(string lastName)
        {
            checkout.SendKeyToTheLastNameTextField(lastName);
        }

        [When(@"The '([^']*)'")]
        public void WhenThe(string pinCode)
        {
            checkout.SendKeyToThePinTextField(pinCode);
        }

        [When(@"Click on the continue button")]
        public void WhenClickOnTheContinueButton()
        {
            checkout.ClickOnTheContinueButton();
        }

    }
}
