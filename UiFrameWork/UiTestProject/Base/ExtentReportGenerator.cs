using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UiTestProject.Base
{
    public class ExtentReportGenerator
    {
        public ExtentReports _extentReports = null;
        public ExtentHtmlReporter _extentHtmlReporter;
        public ExtentTest test = null;
        string htmlReportPath = Path.GetFullPath("..//..//..//..//UiTestProject//ExtentReport//");
        //string path =File.

        public void ExtentReportStart()
        {
            _extentHtmlReporter = new ExtentHtmlReporter(htmlReportPath);
            _extentReports = new ExtentReports();
            _extentReports.AttachReporter(_extentHtmlReporter);
        }

        public void ExtentReportClose()
        {
            _extentReports.Flush();
        }
    }
}
