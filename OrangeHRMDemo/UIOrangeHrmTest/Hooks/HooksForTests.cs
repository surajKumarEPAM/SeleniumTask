using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UIFramework.Utilities;

namespace UIOrangeHrmTest.Hooks
{
    [Binding]
    internal class HooksForTests :BasePageTest
    {
        BasePage basePage = new BasePage();

        [BeforeScenario]
        public void LaunchingBrowser()
        {
            InvockingDriver();
        }

        [AfterScenario]
        public void CloseDriverAferScenario()
        {
            ClosingDriver();
        }

    }
}
