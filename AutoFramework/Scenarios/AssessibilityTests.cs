

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
    using global::AutoFramework.Pages.PageElements;
    using SFB_Test_Automation.AutoFramework.Pages;

    //[Parallelizable]

    public class SchoolDashboardTests

    {
        IAlert alert;
        IWebDriver driver;
        
        public SchoolDashboardTests()
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
        public void VerifyDashboardTab()
        {
            Actions.schoolSearchwithLaestab("113441", driver);
            SchoolDetailPage detailpage = new SchoolDetailPage(driver);

            Assert.IsTrue(detailpage.SchoolPageDashBoardTab.Enabled);
        }
     
        [Test]
        public void VerifyDetailsTab()
        {
            Actions.schoolSearchwithLaestab("113441", driver);
            SchoolDetailPage detailpage = new SchoolDetailPage(driver);

            Assert.IsTrue(detailpage.SchoolPageDetailsTab.Enabled);
        }
      
        [Test]
        public void VerifyFinancetab()
        {
            Actions.schoolSearchwithLaestab("113441", driver);
            SchoolDetailPage detailpage = new SchoolDetailPage(driver);

            Assert.IsTrue(detailpage.SchoolPageFinanceTab.Enabled);
        }
      
        [Test]
        public void VerifyWorkForceTab()
        {
            Actions.schoolSearchwithLaestab("113441", driver);
            SchoolDetailPage detailpage = new SchoolDetailPage(driver);

            Assert.IsTrue(detailpage.SchoolPageWorkForceTab.Enabled);
        }
       
        [Test]
        public void VerifyWorkForceDropDowns()
        {
            Actions.schoolSearchwithLaestab("113441", driver);

            SchoolDetailPage detailpage = new SchoolDetailPage(driver);
            detailpage.SchoolPageWorkForceTab.Click();
            detailpage.workForce_DropDownLink.Click();




        }
        [Ignore("ignore this test")]
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
        public void verifyaccessibilityLinkOnHomePage()
        {
            HomePage home = new HomePage(driver);
            Assert.IsTrue(home.AccessibilityLink.Displayed);

        }
      
        [Test]
        public void verifyCookiesBanner()
        {
            HomePage home = new HomePage(driver);
            home.cookies_footer.Click();
            Assert.Fail();//failing this until the issue in safari is fixed 48178

        }

        
        [Test]
        public void verifyaccessibilityLinkSAD()
        {
            HomePage home = new HomePage(driver);
            Actions.CallingClass.SearchViaSchoolurn("100000", driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            detailspage.StartAComparison.Click();
            TypeOfComparisonPage typeofcompare = new TypeOfComparisonPage(driver);
            typeofcompare.SelfAssessMentDashboardButton.Click();
            Actions.acceptCookie(driver);
            SelfAssessmentPage sadpage = new SelfAssessmentPage(driver);

            Assert.IsTrue(sadpage.AccessibilityLink.Displayed);

        }

        [Test]
        public void verifyaccessibilityLinkChartsPage()
        {
            HomePage home = new HomePage(driver);
            Assert.IsTrue(home.AccessibilityLink.Displayed);

        }
        [Test]
        public void verifyaccessibilityLinkonSchoolDetailPage()
        {
            HomePage home = new HomePage(driver);
            Actions.CallingClass.SearchViaSchoolurn("100000", driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            Assert.IsTrue(detailspage.AssessibilityLink.Displayed);

        }
        [Test]
        public void verifyaccessibilityLinkEMPage()
        {
            HomePage home = new HomePage(driver);
            Actions.CallingClass.SearchViaSchoolurn("100000", driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            detailspage.StartAComparison.Click();
            TypeOfComparisonPage typeofcompare = new TypeOfComparisonPage(driver);
            typeofcompare.EfficiencyMetrictButton.Click();
            EfficiencyMetricIntroPage emintropage = new EfficiencyMetricIntroPage(driver);
            emintropage.ContinueToEfficiencyMetricButton.Click();
            Actions.acceptCookie(driver);
            EfficiencyMetricPage empage = new EfficiencyMetricPage(driver);
            Assert.IsTrue(empage.AccessibilityLink.Displayed);




        }

        [TearDown]
        public void TeardownAfterEachTest()
        {
            Console.WriteLine(TestContext.CurrentContext.Result.Outcome);
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
