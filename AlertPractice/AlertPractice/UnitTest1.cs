using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using System.Diagnostics;

namespace AlertPractice
{
    public class SimpleAlerts
    {
        
        [SetUp]
        public void Setup()
        {

            String driverPath = Path.GetFullPath("..\\..\\..\\Drivers");
            IWebDriver driver=new ChromeDriver(driverPath);
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(15);
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();
           
            IWebElement alertFrameElement=driver.FindElement(By.XPath("//h5[contains(text(),'Alerts, Frame & Windows')]"));

            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", alertFrameElement);

            IWebElement alertElement = driver.FindElement(By.XPath("//span[contains(text(),'Alerts')]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", alertElement);

            IWebElement simpleAlertButton = driver.FindElement(By.XPath("//button[@id='alertButton']"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", simpleAlertButton);
            IAlert alertWindow= driver.SwitchTo().Alert();
            alertWindow.Accept();

            //IWebElement timerAlertButton = driver.FindElement(By.XPath("//button[@id='promtButton']"));
            //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", timerAlertButton);
            //driver.SwitchTo().Alert().Accept();

            //IWebElement confirmationAlertButton = driver.FindElement(By.XPath("//button[@id='confirmButton']"));
            //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", confirmationAlertButton);
            ////driver.SwitchTo().Alert().Accept();
            //driver.SwitchTo().Alert().Dismiss();

            //IWebElement promptBoxAlertButton = driver.FindElement(By.XPath("//button[@id='promtButton']"));
            //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", promptBoxAlertButton);
            //driver.SwitchTo().Alert().SendKeys("Suraj Kumar");
            ////driver.SwitchTo().Alert().Accept();
            //driver.SwitchTo().Alert().Dismiss();



            String parentWindow = driver.CurrentWindowHandle;
            Console.WriteLine(parentWindow);
            IWebElement windowsElement = driver.FindElement(By.XPath("//span[contains(text(),'Browser Windows')]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", windowsElement);
            IWebElement windowButton = driver.FindElement(By.XPath("//button[@id='windowButton']"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", windowButton);
            IWebElement newWindowMessageButton = driver.FindElement(By.XPath("//button[@id='messageWindowButton']"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", newWindowMessageButton);

            List<String> allWindows=driver.WindowHandles.ToList();
            foreach(String currentWindow in allWindows)
            {
                driver.SwitchTo().Window(currentWindow);
                if(!parentWindow.Equals(currentWindow))
                    driver.Close();

            }
            driver.SwitchTo().Window(parentWindow);
            IWebElement frameElement = driver.FindElement(By.XPath("//span[text()='Frames']"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", frameElement);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("frame1")));

        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}