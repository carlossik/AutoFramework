
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
    using System.Threading;

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
            Assert.IsTrue(MetricPage.See_tools_toImprove_EM.Displayed);
            Assert.IsTrue(MetricPage.Contact_Details_Of_Schools.Displayed);
            Assert.IsTrue(MetricPage.How_Efficiency_Is_Calculated.Displayed);
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
        public void Verify_school_contact_details()
        {
            EfficiencyMetricActions.ListSchoolDetails("100000");
            Assert.IsTrue(Driver.driver.Url == "https://as-t1stg-sfb-em.azurewebsites.net/efficiency-metric/contact-details/100000");
        }

        [Test]
        public void Verify_tools_to_improve_PlanningCheckList()
        {
            EfficiencyMetricActions.TestEMToolLinks_PlanningChecklist("2032471");
            
            ToolsToImproveEMPage improveEMPage = new ToolsToImproveEMPage();
            Assert.IsTrue(improveEMPage.UseFinancial_PlanningCheckList_Link.Displayed);
            Assert.IsTrue(improveEMPage.UseTheTop10PlanningChecksLink.Displayed);
            Assert.IsTrue(improveEMPage.UseFinancial_PlanningCheckList_Link.Displayed);


        }


        [Test]
        public void Verify_tools_to_improve_Top10_PlanningChecks()
        {
            EfficiencyMetricActions.TestEMToolLinks_Top10FinancialPlanningChecks("2032471");
            Console.WriteLine(Driver.driver.Url);
            Assert.IsTrue(Driver.driver.Url == "https://educationendowmentfoundation.org.uk/evidence-summaries/teaching-learning-toolkit/");


        }

        [Test]
        public void Verify_tools_to_improve_UseTheToolKit()
        {
            EfficiencyMetricActions.TestEMToolLinks_UseTheToolkit("2032471");
            Driver.driver.SwitchTo().ActiveElement();
            Console.WriteLine(Driver.driver.Url);
            Assert.IsTrue(Driver.driver.Url == "https://educationendowmentfoundation.org.uk/evidence-summaries/teaching-learning-toolkit/");
           
        }

        [Test]
        public void Verify_Link_To_ImprovementTools_work()
        {
            EfficiencyMetricActions.navigateToToolPage("2032471");
            Console.WriteLine(Driver.driver.Url);
            Assert.IsTrue(Driver.driver.Url == "https://educationendowmentfoundation.org.uk/evidence-summaries/teaching-learning-toolkit/");


        }


        [Test]
        public void Verify_how_EfficiencyMetricCalculation()
        {
            EfficiencyMetricActions.GotoSchholEfficiencyMetric("2032471");
            EfficiencyMetricPage metricPage = new EfficiencyMetricPage();
            metricPage.How_Efficiency_Is_Calculated.Click();
            Thread.Sleep(500);
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector(".govuk-heading-xl")).Text == "How the efficiency metric is calculated");
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector(".govuk-back-link")).Displayed);


        }


        [Test]
        public void Verify_EM_Benchmarkfor30_percent_Ofschools()
        {

            EfficiencyMetricActions.createBenchMarkForEMVia30percent("2032471");
            //Asserts to follow


        }
        [Test]
        public void Verify_EM_BenchmarkChartManually()
        {
            EfficiencyMetricActions.createBenchMarkForEM_Manually("2032471");
            EfficiencyMetricActions.addschoolstoBasket();
            BenchMarkChartPage chartpage = new BenchMarkChartPage();
            Assert.IsTrue(chartpage.ViewAsTables.Displayed);
            //Asserts to follow

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
