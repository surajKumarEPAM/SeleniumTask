using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIFramework.ReportGenerator.ExtentReportGenerator
{
    public class ExtentReport
    {
        public ExtentReports _extentReports = new ExtentReports();
        public ExtentHtmlReporter _extentHtmlReporter;
        public ExtentTest test = null;
        static string htmlReportPath;

        public void setReportPath()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string solutionDirectoryPath = Directory.GetParent(currentDirectory).Parent.Parent.Parent.FullName;
            htmlReportPath = solutionDirectoryPath + "//UiSaucedemoTest//Reports//ExtentReport//";
        }

        public void ExtentReportStart()
        {
            setReportPath();
            _extentHtmlReporter = new ExtentHtmlReporter(htmlReportPath);
            _extentReports.AttachReporter(_extentHtmlReporter);
        }

        public void ExtentReportClose()
        {
            _extentReports.Flush();
        }

    }
}
