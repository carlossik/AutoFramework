
namespace AutoFramework
    
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System.Drawing.Imaging;
    using System;
    using SFB_Test_Automation.AutoFramework.Pages;
    using NUnit.Framework.Interfaces;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.IE;
    using AutoFramework.Pages.PageElements;
    using SFB_Test_Automation.AutoFramework;

    class EfficiencyMetricTests
    {

        
        [SetUp]
        public void SetupBeforeEachTest()

        {
            var testName = TestContext.CurrentContext.Test.FullName;
            Config.Credentials.deletefiles(@"C:\TEMP\" + testName + ".jpg");
            Actions.InitializeDriver(Config.FirefoxDriverUnderTest);

        }

        [Test]
        public void Verify_Nursery_doesnt_have_EM_link()
        {
            Actions.schoolSearchwithLaestab("143085");
            
            SchoolDetailPage DetailPage = new SchoolDetailPage();
            Assert.IsFalse(DetailPage.EfficiencyMetricLink.Displayed);


        }

        [Test]
        public void Verify_Special_School_doesnt_have_EM_link()
        {
            Actions.schoolSearchwithLaestab("3037004");

            SchoolDetailPage DetailPage = new SchoolDetailPage();
            Assert.IsFalse(DetailPage.EfficiencyMetricLink.Displayed);
          
        }
        [Test]
        public void Verify_16plus_doesnt_have_EM_link()
        {
            Actions.schoolSearchwithLaestab("2034717");

            SchoolDetailPage DetailPage = new SchoolDetailPage();
            Assert.IsFalse(DetailPage.EfficiencyMetricLink.Displayed);
            //2034717

        }
        [Test]
        public void Verify_qualifiedSchool_Has_EM_Link()
        {

            Actions.schoolSearchwithLaestab("2032471");
           
            SchoolDetailPage DetailPage = new SchoolDetailPage();
            Assert.IsTrue(DetailPage.EfficiencyMetricLink.Displayed);
        }
        [Test]
        public void Verify_Items_on_EMpage()
        {

            EfficiencyMetricActions.GotoSchholEfficiencyMetric("2032471");
            EfficiencyMetricPage MetricPage = new EfficiencyMetricPage();
            Assert.IsTrue(MetricPage.BenchMarkTheseSchoolsButton.Displayed);
            Assert.IsTrue(MetricPage.HomeBreadCrumb.Displayed);
            Assert.IsTrue(MetricPage.SchoolBreadCrumb.Displayed);
            Assert.IsTrue(MetricPage.Introduction_To_Efficiency_Metric_BreadCrumb.Displayed);
        }

        [Test]
        public void Verify_School_Rank()
        {

            EfficiencyMetricActions.GotoSchholEfficiencyMetric("2032471");
            EfficiencyMetricActions.seeschoolrank();
            EfficiencyMetricPage MetricPage = new EfficiencyMetricPage();
            Assert.IsTrue(MetricPage.See_tools_toImprove_EM.Displayed);
            
        }
        [Test]
        public void Verify_EM_BenchmarkChart()
        {

            EfficiencyMetricActions.createBenchMarkForEMVia30percent("2032471");
            


        }

        [Test]
        public void Verify_EM_Benchmarkfor30_percent_Ofschools()
        {

            EfficiencyMetricActions.createBenchMarkForEMVia30percent("2032471");


        }
        [Test]
        public void Verify_EM_BenchmarkChartManually()
        {

            EfficiencyMetricActions.createBenchMarkForEM_Manually("2032471");


        }

        [TearDown]
        public void TeardownAfterEachTest()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var screenshot = ((ITakesScreenshot)Driver.driver).GetScreenshot();
                var testName = TestContext.CurrentContext.Test.FullName;
                screenshot.SaveAsFile(@"C:\TEMP\" + testName + ".jpg");
                Driver.driver.Close();
                Driver.driver.Quit();
            }
            Driver.driver.Close();
            Driver.driver.Quit();
        }
    }






}
