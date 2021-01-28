using AutoFramework;
using Globant.Selenium.Axe;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selenium.Axe;
using System.IO;
//using AxeResult = Selenium.Axe.AxeResult;
//using AxeBuilder = Globant.Selenium.Axe.AxeBuilder;

namespace SFB_Test_Automation.AutoFramework.Scenarios
{
    [TestFixture]
    class AssessibilityTests
    {

        [SetUp]
        public void SetupBeforeEachTest()

        {
            var testName = TestContext.CurrentContext.Test.FullName;
            Config.Credentials.deletefiles(@"C:\TEMP\" + testName + ".jpg");
            Actions.InitializeDriver(Config.FirefoxDriverUnderTest);
        }

        [Test]
        public void AccessibilityTestHomePage()
        {
            Selenium.Axe.AxeResult axeResult = new Selenium.Axe.AxeBuilder(Driver.driver).Analyze();
            Assert.IsEmpty(axeResult.Violations);
        }

        [Test]
        public void AccessibilityTestForSchoolDetailPage()
        {
            Driver.driver.Navigate().GoToUrl("https://as-t1stg-sfb.azurewebsites.net/school/detail?urn=113650");
            Selenium.Axe.AxeResult axeResult = new Selenium.Axe.AxeBuilder(Driver.driver).Analyze();
            Assert.IsEmpty(axeResult.Violations);
        }

        [Test]
        public void AccessibilityTestForTrustDetailPage()
        {
            Driver.driver.Navigate().GoToUrl("https://as-t1stg-sfb.azurewebsites.net/trust/index?companyNo=10192252");
            Selenium.Axe.AxeResult axeResult = new Selenium.Axe.AxeBuilder(Driver.driver).Analyze();
            Assert.IsEmpty(axeResult.Violations);
        }

        [Test]
        public void AccessibilityTestForComparisonPage()
        {
            Driver.driver.Navigate().GoToUrl("https://as-t1stg-sfb.azurewebsites.net/BenchmarkCriteria/ComparisonStrategy?urn=143308");
            Selenium.Axe.AxeResult axeResult = new Selenium.Axe.AxeBuilder(Driver.driver).Analyze();
            Assert.IsEmpty(axeResult.Violations);
        }

        [Test]
        public void AccessibilityTestBenchMarkPage()
        {
            Driver.driver.Navigate().GoToUrl("https://as-t1stg-sfb.azurewebsites.net/BenchmarkCharts/GenerateFromSimpleCriteria?SimpleCriteria.IncludeFsm=true&SimpleCriteria.IncludeSen=true&SimpleCriteria.IncludeEal=true&BasketSize=15&Urn=143308&ComparisonType=Basic&EstType=Academies");
            Selenium.Axe.AxeResult axeResult = new Selenium.Axe.AxeBuilder(Driver.driver).Analyze();
            Assert.IsEmpty(axeResult.Violations);
        }

        [Test]
        public void accessibilitytest2()
        {
            Selenium.Axe.AxeResult axeResult = new Selenium.Axe.AxeBuilder(Driver.driver).Analyze();
            foreach (var xyz in axeResult.Violations)
            {
                Console.WriteLine(xyz.Impact.ToString());
                Console.WriteLine(axeResult.Violations.ToList());
                Console.WriteLine(xyz.Description.ToString());
                Console.WriteLine(xyz.Id.ToString());
            }
            Assert.True(axeResult.Violations.Length == 0, "There are accessibility violations. Please check log file");
            var testName = TestContext.CurrentContext.Test.FullName;
            string path = Path.Combine(@"C:\TEMP\", "AxeReport.html");
            Driver.driver.CreateAxeHtmlReport(axeResult,path);
        }

    
        [TearDown]
        public void TeardownAfterEachTest()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var screenshot = ((ITakesScreenshot)Driver.driver).GetScreenshot();
                var testName = TestContext.CurrentContext.Test.FullName;
                TestContext.Out.WriteLine();
                screenshot.SaveAsFile(@"C:\TEMP\" + testName + ".jpg");
                Driver.driver.Close();
                Driver.driver.Quit();
            }
            Driver.driver.Close();
            Driver.driver.Quit();
        }
    }
}
