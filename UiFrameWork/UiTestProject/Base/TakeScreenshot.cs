using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UILibraryProject;

namespace UiTestProject.Base
{
    internal class TakeScreenshot
    {
        public void TakeSecreenShot()
        {
            String screenshotPath = Path.GetFullPath("..//..//..//..//UiTestProject//Screenshots//MyScreenShot.png");

            OpenQA.Selenium.Screenshot screenshot = (BrowserElement.driver as ITakesScreenshot).GetScreenshot();

            screenshot.SaveAsFile(screenshotPath, ScreenshotImageFormat.Png);
          
        }
    }
}
