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
    public class CommonActions
    {
        CommonActionPage commonAction = new CommonActionPage();
        [Given(@"I navigated at Inventory page")]
        public void GivenINavigatedAtInventoryPage()
        {
            commonAction.SendUserNameToUserTextBox("standard_user");
            commonAction.SendPasswordToPasswordTextBox("secret_sauce");
            commonAction.ClickOnLoginButton();
        }

        [Given(@"All products is added in the cart")]
        public void GivenAllProductsIsAddedInTheCart()
        {
            commonAction.AddAllItemsInTheCart();
        }

        [When(@"I click on the cart icon on inventory page")]
        public void WhenIClickOnTheCartIconOnInventoryPage()
        {
            commonAction.ClickOnTheCartIcon();
        }

    }
}
