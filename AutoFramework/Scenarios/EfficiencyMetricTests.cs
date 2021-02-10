
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

    public class EfficiencyMetricTests
    {
        IAlert alert;
        IWebDriver driver;

        [SetUp]
        public void SetupBeforeEachTest()

        {
            var testName = TestContext.CurrentContext.Test.FullName;
            Config.Credentials.deletefiles(@"C:\TEMP\" + testName + ".jpg");
           driver = Actions.InitializeDriver(5);

        }

        [Test]
        public void Verify_Nursery_doesnt_have_EM_link()
        {
            Actions.schoolSearchwithLaestab("143085",driver);
            
            SchoolDetailPage DetailPage = new SchoolDetailPage(driver);
            Assert.IsFalse(DetailPage.EfficiencyMetricLink.Displayed);


        }

        [Test]
        public void Verify_Special_School_doesnt_have_EM_link()
        {
            Actions.schoolSearchwithLaestab("3037004",driver);

            SchoolDetailPage DetailPage = new SchoolDetailPage(driver);
            Assert.IsFalse(DetailPage.EfficiencyMetricLink.Displayed);
          
        }
        [Test]
        public void Verify_16plus_doesnt_have_EM_link()
        {
            Actions.schoolSearchwithLaestab("2034717",driver);

            SchoolDetailPage DetailPage = new SchoolDetailPage(driver);
            Assert.IsFalse(DetailPage.EfficiencyMetricLink.Displayed);
            //2034717

        }
        [Test]
        public void Verify_qualifiedSchool_Has_EM_Link()
        {

            Actions.schoolSearchwithLaestab("2032471",driver);
           
            SchoolDetailPage DetailPage = new SchoolDetailPage(driver);
            Assert.IsTrue(DetailPage.EfficiencyMetricLink.Displayed);
        }
        [Test]
        public void Verify_Items_on_EMpage()
        {

            EfficiencyMetricActions.GotoSchholEfficiencyMetric("2032471",driver);
            EfficiencyMetricPage MetricPage = new EfficiencyMetricPage(driver);
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

            EfficiencyMetricActions.GotoSchholEfficiencyMetric("2032471",driver);
            EfficiencyMetricActions.seeschoolrank(driver);
            EfficiencyMetricPage MetricPage = new EfficiencyMetricPage(driver);
            Assert.IsTrue(MetricPage.See_tools_toImprove_EM.Displayed);
            
        }
        [Test]
        public void Verify_EM_BenchmarkChart()
        {

            EfficiencyMetricActions.createBenchMarkForEMVia30percent("2032471",driver);
            


        }
        [Test]
        public void Verify_school_contact_details()
        {
            EfficiencyMetricActions.ListSchoolDetails("100000",driver);
            Assert.IsTrue(driver.Url == "https://as-t1stg-sfb-em.azurewebsites.net/efficiency-metric/contact-details/100000");
        }

        [Test]
        public void Verify_tools_to_improve_PlanningCheckList()
        {
            EfficiencyMetricActions.TestEMToolLinks_PlanningChecklist("2032471",driver);
            
            ToolsToImproveEMPage improveEMPage = new ToolsToImproveEMPage(driver);
            Assert.IsTrue(improveEMPage.UseFinancial_PlanningCheckList_Link.Displayed);
            Assert.IsTrue(improveEMPage.UseTheTop10PlanningChecksLink.Displayed);
            Assert.IsTrue(improveEMPage.UseFinancial_PlanningCheckList_Link.Displayed);


        }


        [Test]
        public void Verify_tools_to_improve_Top10_PlanningChecks()
        {
            EfficiencyMetricActions.TestEMToolLinks_Top10FinancialPlanningChecks("2032471",driver);
            Console.WriteLine(driver.Url);
            Assert.IsTrue(driver.Url == "https://educationendowmentfoundation.org.uk/evidence-summaries/teaching-learning-toolkit/");


        }

        [Test]
        public void Verify_tools_to_improve_UseTheToolKit()
        {
            EfficiencyMetricActions.TestEMToolLinks_UseTheToolkit("2032471",driver);
            driver.SwitchTo().ActiveElement();
            Console.WriteLine(driver.Url);
            Assert.IsTrue(driver.Url == "https://educationendowmentfoundation.org.uk/evidence-summaries/teaching-learning-toolkit/");
           
        }

        [Test]
        public void Verify_Link_To_ImprovementTools_work()
        {
            EfficiencyMetricActions.navigateToToolPage("2032471",driver);
            Console.WriteLine(driver.Url);
            Assert.IsTrue(driver.Url == "https://educationendowmentfoundation.org.uk/evidence-summaries/teaching-learning-toolkit/");


        }


        [Test]
        public void Verify_how_EfficiencyMetricCalculation()
        {
            EfficiencyMetricActions.GotoSchholEfficiencyMetric("2032471",driver);
            EfficiencyMetricPage metricPage = new EfficiencyMetricPage(driver);
            metricPage.How_Efficiency_Is_Calculated.Click();
            Thread.Sleep(500);
            Assert.IsTrue(driver.FindElement(By.CssSelector(".govuk-heading-xl")).Text == "How the efficiency metric is calculated");
            Assert.IsTrue(driver.FindElement(By.CssSelector(".govuk-back-link")).Displayed);


        }


        [Test]
        public void Verify_EM_Benchmarkfor30_percent_Ofschools()
        {

            EfficiencyMetricActions.createBenchMarkForEMVia30percent("2032471",driver);
            //Asserts to follow


        }
        [Test]
        public void Verify_EM_BenchmarkChartManually()
        {
            EfficiencyMetricActions.createBenchMarkForEM_Manually("2032471",driver);
            EfficiencyMetricActions.addschoolstoBasket(driver);
            BenchMarkChartPage chartpage = new BenchMarkChartPage(driver);
            Assert.IsTrue(chartpage.ViewAsTables.Displayed);
            //Asserts to follow

        }

        [TearDown]
        public void TeardownAfterEachTest()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                var testName = TestContext.CurrentContext.Test.FullName;
                screenshot.SaveAsFile(@"C:\TEMP\" + testName + ".jpg");
                //driver.Close();
                driver.Quit();
            }
            //driver.Close();
            driver.Quit();
        }
    }






}
