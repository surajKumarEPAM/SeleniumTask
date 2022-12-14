using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UiTestProject.Base;

namespace UiTestProject.Test.BaseTest
{
    public class BaseTestForBrowser
    {
        [SetUp]
        public void Stepup()
        {
            BaseClass.InvokeBrowser();
        }
        [TearDown]
        public void CloseTest()
        {
            //BaseClass.driver.Close();

        }
    }
}
