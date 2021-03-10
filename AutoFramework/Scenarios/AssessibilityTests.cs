

namespace SFB_Test_Automation.AutoFramework.Scenarios
{
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
    using global::AutoFramework;
    using global::AutoFramework.Pages;

    [Parallelizable]

    public class AssessibilityTests

    {
        IAlert alert;
        IWebDriver driver;

        public AssessibilityTests()
        {
        }

        [SetUp]
        public void SetupBeforeEachTest()

        {
            var testName = TestContext.CurrentContext.Test.FullName;
            Config.Credentials.deletefiles(@"C:\TEMP\" + testName + ".jpg");
           driver =  Actions.InitializeDriver(5);
        }

        [Test]
        public void AccessibilityTestHomePage()
        {
            Selenium.Axe.AxeResult axeResult = new Selenium.Axe.AxeBuilder(driver).Analyze();
            Console.WriteLine(axeResult.Violations);
            Assert.IsEmpty(axeResult.Violations);
        }

        [Test]
        public void AccessibilityTestForSchoolDetailPage()
        {
            driver.Navigate().GoToUrl("https://as-t1stg-sfb.azurewebsites.net/school/detail?urn=113650");
            Actions.acceptCookie(driver);
            Selenium.Axe.AxeResult axeResult = new Selenium.Axe.AxeBuilder(driver).Analyze();
            Assert.IsEmpty(axeResult.Violations);
        }

        [Test]
        public void AccessibilityTestForTrustDetailPage()
        {
            driver.Navigate().GoToUrl("https://as-t1stg-sfb.azurewebsites.net/trust/index?companyNo=10192252");
            Actions.acceptCookie(driver);
            Selenium.Axe.AxeResult axeResult = new Selenium.Axe.AxeBuilder(driver).Analyze();
            Assert.IsEmpty(axeResult.Violations);
        }

        [Test]
        public void AccessibilityTestForComparisonPage()
        {
            driver.Navigate().GoToUrl("https://as-t1stg-sfb.azurewebsites.net/BenchmarkCriteria/ComparisonStrategy?urn=143308");
            Actions.acceptCookie(driver);
            Selenium.Axe.AxeResult axeResult = new Selenium.Axe.AxeBuilder(driver).Analyze();
            Assert.IsEmpty(axeResult.Violations);
        }

        [Test]
        public void AccessibilityTestBenchMarkPage()
        {
            driver.Navigate().GoToUrl("https://as-t1stg-sfb.azurewebsites.net/BenchmarkCharts/GenerateFromSimpleCriteria?SimpleCriteria.IncludeFsm=true&SimpleCriteria.IncludeSen=true&SimpleCriteria.IncludeEal=true&BasketSize=15&Urn=143308&ComparisonType=Basic&EstType=Academies");
            Actions.acceptCookie(driver);
            Selenium.Axe.AxeResult axeResult = new Selenium.Axe.AxeBuilder(driver).Analyze();
            Assert.IsEmpty(axeResult.Violations);
        }

        [Test]
        public void accessibilitytest2()
        {
            Selenium.Axe.AxeResult axeResult = new Selenium.Axe.AxeBuilder(driver).Analyze();
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
            driver.CreateAxeHtmlReport(axeResult,path);
        }

        [Test]
        public void verifyaccessibilityLink()
        {
            HomePage home = new HomePage(driver);
            Assert.IsTrue(home.AccessibilityLink.Displayed);

        }

    
        [TearDown]
        public void TeardownAfterEachTest()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                var testName = TestContext.CurrentContext.Test.FullName;
                TestContext.Out.WriteLine();
                screenshot.SaveAsFile(@"C:\TEMP\" + testName + ".jpg");
                driver.Close();
                driver.Quit();
            }
            driver.Close();
            driver.Quit();
        }
    }
}
