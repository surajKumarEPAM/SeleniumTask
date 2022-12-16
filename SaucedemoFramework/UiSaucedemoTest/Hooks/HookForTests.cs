using TechTalk.SpecFlow;
using UIFramework.BasicSetUp;
using UIFramework.Utilities;

namespace UiSaucedemoTest.Hooks
{
    [Binding]
    public sealed class HookForTests : BaseTestpz
    {
        BasePage basePage = new BasePage();
       
        [BeforeScenario]
        public void LaunchingBrowser()
        {
            InvockingDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            ClosingDriver();
        }
        
    }
}