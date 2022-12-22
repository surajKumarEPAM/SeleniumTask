using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIFramework.BasicSetUp;

namespace UIFramework.ReportGenerator.Screenshots
{
    public class ScreenshotTaker
    {
        static int countOfScreenShot = 1;
        public static string screenShotPath;

        public static void TakeSecreenShot()
        {
            string currentDirectory, solutionDirectoryPath;
            currentDirectory = Directory.GetCurrentDirectory();
            solutionDirectoryPath = Directory.GetParent(currentDirectory).Parent.Parent.Parent.FullName;
            screenShotPath = solutionDirectoryPath + "//UIOrangeHrmTest//Reports//ScreenShots//myShot" + (countOfScreenShot++) + ".png";
            Screenshot screenshot = (Driver.driver as ITakesScreenshot).GetScreenshot();
            screenshot.SaveAsFile(screenShotPath, ScreenshotImageFormat.Png);
        }
    }
}
