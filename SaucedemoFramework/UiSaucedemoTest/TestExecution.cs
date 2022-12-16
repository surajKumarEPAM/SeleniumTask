using UIFramework;
using UIFramework.Utilities;

namespace UiSaucedemoTest
{
    public class BaseTestpz : BasePage
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