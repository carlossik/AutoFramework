
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
    using System.Collections.Generic;

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
            DetailPage.StartAComparison.Click();
            TypeOfComparisonPage comparepage = new TypeOfComparisonPage(driver);
            Assert.IsFalse(comparepage.EfficiencyMetrictButton.Displayed);


        }

        [Test]
        public void Verify_Special_School_doesnt_have_EM_link()
        {
            Actions.schoolSearchwithLaestab("3037004",driver);

            SchoolDetailPage DetailPage = new SchoolDetailPage(driver);
            DetailPage.StartAComparison.Click();
            TypeOfComparisonPage comparepage = new TypeOfComparisonPage(driver);
            Assert.IsFalse(comparepage.EfficiencyMetrictButton.Displayed);
          
        }
        [Test]
        public void Verify_16plus_doesnt_have_EM_link()
        {
            Actions.schoolSearchwithLaestab("2034717",driver);

            SchoolDetailPage DetailPage = new SchoolDetailPage(driver);
            DetailPage.StartAComparison.Click();
            TypeOfComparisonPage compare = new TypeOfComparisonPage(driver);
            Assert.IsFalse(compare.EfficiencyMetrictButton.Displayed);
            //2034717

        }
        [Test]
        public void Verify_qualifiedSchool_Has_EM_Link()
        {

            Actions.schoolSearchwithLaestab("2032471",driver);
           
            SchoolDetailPage DetailPage = new SchoolDetailPage(driver);
            DetailPage.StartAComparison.Click();
            TypeOfComparisonPage compare = new TypeOfComparisonPage(driver);
            Assert.IsTrue(compare.EfficiencyMetrictButton.Displayed);
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
        public void verifyAllSchooLinksWork()
        {
            EfficiencyMetricActions.GotoSchholEfficiencyMetric("100000", driver);
            EfficiencyMetricActions.clickonallLinks(driver);
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
            Assert.AreEqual(driver.Url , Config.currentTestEnv+"efficiency-metric/contact-details/100000");
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
        public void validateFSM( )
        {
            EfficiencyMetricActions.GotoSchholEfficiencyMetric("111286", driver);
            EfficiencyMetricPage metricPage = new EfficiencyMetricPage(driver);
            IWebElement defaultschool = driver.FindElement(By.XPath("//table[@id='emTableDesktop']/tbody[@class='govuk-table__body' and 49]/tr[@class='govuk-table__row table-row--default-school' and 1]/td[@class='govuk-table__cell em-table-name-cell' and 2]/a[@class='govuk-link table-cell-highlight' and 1]"));
            Assert.IsTrue(defaultschool.Displayed);
            IWebElement fsmSen = driver.FindElement(By.CssSelector("#emTableDesktop > tbody:nth-child(17) > tr:nth-child(1) > td:nth-child(4)"));
            Console.WriteLine(fsmSen.Text);
            Assert.AreEqual("34.7%", fsmSen.Text);
            IWebElement Sen = driver.FindElement(By.CssSelector("#emTableDesktop > tbody:nth-child(17) > tr:nth-child(1) > td:nth-child(5)"));
            Console.WriteLine(Sen.Text);
            Assert.AreEqual("5.0%", Sen.Text);
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
                driver.Close();
                driver.Quit();
            }
            driver.Close();
            driver.Quit();
        }
    }






}
