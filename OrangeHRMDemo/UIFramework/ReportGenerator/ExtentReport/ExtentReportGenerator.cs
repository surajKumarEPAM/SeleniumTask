using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIFramework.ReportGenerator.ExtentReport
{
    public class ExtentReportGenerator
    {
        public ExtentReports _extentReports = new ExtentReports();
        public ExtentHtmlReporter _extentHtmlReporter;
        public ExtentTest test = null;
        static string htmlReportPath;

        public void setReportPath()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string solutionDirectoryPath = Directory.GetParent(currentDirectory).Parent.Parent.Parent.FullName;
            htmlReportPath = solutionDirectoryPath + "//UIOrangeHrmTest//Reports//ExtentReports//";
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
