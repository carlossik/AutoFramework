using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace SFB_Test_Automation.AutoFramework.Scenarios
{
    [TestFixture]
    public class ReportsCreator
    {
        ExtentReports reports = null;
        [OneTimeSetUp]
        public void reportstarter()
        {
            reports = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\kwaku\OneDrive\Desktop\C#\AutoFramework\TestReport.html");
            reports.AttachReporter(htmlReporter);

        }
        [OneTimeTearDown]
        public void reportcloser()
        {
            reports.Flush();

        }
    }
}
