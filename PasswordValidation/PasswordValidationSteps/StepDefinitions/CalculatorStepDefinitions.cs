using NUnit.Framework;
using PasswordValidation;
using TechTalk.SpecFlow.CommonModels;

namespace PasswordValidationSteps.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        PasswordVerification p = new PasswordVerification();
        String ans;
       [Given(@"the password is ""([^""]*)""")]
        public void GivenThePasswordIs(string p0)
        {
            p.password = p0;
        }
        [When(@"i validate the password")]
        public void WhenIValidateThePassword()
        {
            ans=p.IsValidPassword();

        }
        [Then(@"should show ""([^""]*)""")]
        public void ThenShouldShow(string ActualPassword)
        {
            ActualPassword.Should().Be(ans);
        }
        [Given(@"the password is (.*)")]
        public void GivenThePasswordIs(int ActualPassword)
        {
            p.password = "";
            Console.WriteLine("password must be a string type");
        }




    }
}