using TechTalk.SpecFlow;
using UIFramework.Utilities;

namespace UIOrangeHrmTest
{
    public class BasePageTest : BasePage
    {

        [SetUp]
        public void InvockingDriver()
        {
            SetDriver();
            Start();
        }

        [TearDown]
        public void ClosingDriver()
        {
            Stop();
        }

    }
}