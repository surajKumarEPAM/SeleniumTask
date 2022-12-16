using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using UIFramework.BasicSetUp;

namespace UIFramework.ReportGenerator.ScreenShotsTaker
{
    public class MyScreenshot
    {
        static int countOfScreenShot=1;
        public static string screenShotPath;

        public static void TakeSecreenShot()
        {
            string currentDirectory, solutionDirectoryPath;
            currentDirectory = Directory.GetCurrentDirectory();
            solutionDirectoryPath = Directory.GetParent(currentDirectory).Parent.Parent.Parent.FullName;
            screenShotPath = solutionDirectoryPath + "//UiSaucedemoTest//Reports//ScreenShots//myShot"+(countOfScreenShot++)+".png";
            Screenshot screenshot = (Driver.driver as ITakesScreenshot).GetScreenshot();
            screenshot.SaveAsFile(screenShotPath, ScreenshotImageFormat.Png);
        }
       
    }
}
