namespace AutoFramework
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System.Threading;
    using AutoFramework.Pages;
    using System;
    using AutoFramework.Pages.PageElements;
    using SFB_Test_Automation.AutoFramework.Pages;
    using SFB_Test_Automation.AutoFramework;

    [TestFixture]
    public class BenchmarkingTests
    {
        //[OneTimeSetUp]
        [SetUp]
        public void SetupBeforeEachTest()
        //public void Initialize()
        {
            Actions.InitializeDriver();

            //Actions.FillLoginForm();
        }
        [Test]
        [Category("QuickTests")]
        public void ManualBenchMarkCreationViaSchool()
        {
            BenchMarkActions.CreateManualBenchMark();


        }
        [Test]
        public void ManualBenchmarkViaLocation()
        {
            BenchMarkActions.CreateManualBenchMarkViaLocation();
            BenchMarkChartPage chartpage = new BenchMarkChartPage();

            Assert.AreEqual(chartpage.PageTitle.Text, "Benchmarking charts");
        }
        //[Test]
        public void ManualBenchmarkViaLACode()
        {

        }
        [Test]
        public void AddAnotherSchoolByNameOrLocationLink()
        {
            Actions.CallingClass.QuickCompareWithOtherSchools();
            BenchMarkActions.addschoolvianameorlocationlink();

        }
        [Test]
        public void Savebenchmarkbaskettest()
        {
            Actions.savebenchmarkbasket();
            BenchMarkBasketPage basketpage = new BenchMarkBasketPage();
            Assert.IsTrue(basketpage.existsElement("js-modal-close"));

        }
        [Test]
        public static void PasteBasketLessThan30Schools()
        {
            BenchMarkActions.CreateBenchmarkViaDetailComparison("125249");

            BenchMarkActions.getclipboardText();
            ComparingSimilarSchoolsPage similar = new ComparingSimilarSchoolsPage();
            similar.AddToExistingBasket.Click();
            similar.NextButton.Click();
            Thread.Sleep(30);
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector(".message")).Text == "Showing the 15 schools in your benchmark basket");



        }
        [Test]
        public static void PasteBasketGreaterThan30Schools()
        {
            BenchMarkActions.createbenchmarkviadefault("125249");
            BenchMarkActions.getclipboardTextmaximum();
            ReplaceCurrentBenchmarkbasketPage replace = new ReplaceCurrentBenchmarkbasketPage();
            replace.Viewbenchmarkbasket.Click();
            Thread.Sleep(2000);
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector(".message")).Text == "Showing the 30 schools in your benchmark basket");


            //hread.Sleep(30000);
        }
        [Test]
        public static void PasteBasketLessThan30SchoolsCancell()
        {
            BenchMarkActions.CreateBenchmarkViaDetailComparison("125249");
            //Actions.savebenchmarkbasket();
            BenchMarkActions.getclipboardText();
            ComparingSimilarSchoolsPage similar = new ComparingSimilarSchoolsPage();
            ReplaceCurrentBenchmarkbasketPage replace = new ReplaceCurrentBenchmarkbasketPage();
            replace.Cancelt.Click();
            Assert.IsTrue(Driver.driver.Url == "https://as-t1dv-sfb.azurewebsites.net/");

        }
        [Test]
        public static void PasteBasketGreaterThan30SchoolsCancell()
        {
            BenchMarkActions.createbenchmarkviadefault("125249");
            BenchMarkActions.getclipboardTextmaximum();
            ReplaceCurrentBenchmarkbasketPage replace = new ReplaceCurrentBenchmarkbasketPage();
            replace.Cancelt.Click();
            Assert.IsTrue(Driver.driver.Url == "https://as-t1dv-sfb.azurewebsites.net/");
        }
        [Test]
        public static void ExcludeschoolswithIncFinanceMaintainedAllEngland()
        {
            DetailedComparisonActions.ExcludeschoolswithIncFinanceMaintainedAllEngland("142071");
            string errorText = "Some schools don't have a complete set of financial data for this period";              
            Assert.IsFalse(Driver.driver.PageSource.Contains(errorText));


        }
        [Test]
        public static void ExcludeschoolswithIncFinanceAcademiesAllEngland()
        {
            DetailedComparisonActions.ExcludeschoolswithIncFinanceAcademiesAllEngland("141976", "239", "240");
            //string modal_error = (Driver.driver.FindElement(By.Id("modal-content")).Text);
            //Assert.IsFalse(Driver.driver.PageSource.Contains(modal_error));
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsFalse(Driver.driver.PageSource.Contains(errorText));

        }
        [Test]
        public static void ExcludeschoolswithIncFinanceAllSchoolsAllEngland()
        {
            DetailedComparisonActions.ExcludeschoolswithIncFinanceAllSchoolsAllEngland("100140");
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsFalse(Driver.driver.PageSource.Contains(errorText));
        }
        [Test]
        public static void IncludeschoolswithIncFinanceMaintainedAllEngland()
        {
            DetailedComparisonActions.IncludeschoolswithIncFinanceMaintainedAllEngland("142071");
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsTrue(Driver.driver.PageSource.Contains(errorText));

        }
        [Test]
        public static void IncludeschoolswithIncFinanceAcademiesAllEngland()
            
        {
            DetailedComparisonActions.IncludeschoolswithIncFinanceAcademiesAllEngland("144407","64","64");
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsTrue(Driver.driver.PageSource.Contains(errorText));
        }
        [Test]
        public static void IncludechoolswithIncFinanceAllSchoolsAllEngland()
        {
            DetailedComparisonActions.IncludechoolswithIncFinanceAllSchoolsAllEngland("145789");
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsTrue(Driver.driver.PageSource.Contains(errorText));
        }
        [Test]
        public static void ExcludeschoolswithIncFinanceMaintainedLaCode()
        {
            DetailedComparisonActions.ExcludeschoolswithIncFinanceMaintainedLaCode("142974");
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsFalse(Driver.driver.PageSource.Contains(errorText));
        }
        [Test]
        public static void ExcludeschoolswithIncFinanceAcademiesLaCode()
        {
            DetailedComparisonActions.ExcludeschoolswithIncFinanceAcademiesLaCode("100140");
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsFalse(Driver.driver.PageSource.Contains(errorText));
        }
        [Test]
        public static void ExcludeschoolswithIncFinanceAllSchoolsLaCode()
        {
            DetailedComparisonActions.ExcludeschoolswithIncFinanceAllSchoolsLaCode("100140");
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsFalse(Driver.driver.PageSource.Contains(errorText));
        }
        [Test]
        public static void IncludeschoolswithIncFinanceMaintainedLaCode()
        {
            DetailedComparisonActions.IncludeschoolswithIncFinanceMaintainedLaCode("3032083", "303", "245", "600");
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsTrue(Driver.driver.PageSource.Contains(errorText));
        }
        [Test]
        public static void IncludeschoolswithIncFinanceAcademiesLaCode()
        {
            DetailedComparisonActions.IncludeschoolswithIncFinanceAcademiesLaCode("100140", "209", "200","303");
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsTrue(Driver.driver.PageSource.Contains(errorText));
        }
        [Test]
        public static void IncludechoolswithIncFinanceAllSchoolsLaCode()
        {
            DetailedComparisonActions.IncludechoolswithIncFinanceAllSchoolsLaCode("142974");
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsTrue(Driver.driver.PageSource.Contains(errorText));
        }
        [Test]
        public static void ExcludeschoolswithIncFinanceMaintainedLaName()
        {
            DetailedComparisonActions.ExcludeschoolswithIncFinanceMaintainedLaName("100140");
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsFalse(Driver.driver.PageSource.Contains(errorText));
        }
        [Test]
        public static void ExcludeschoolswithIncFinanceAcademiesLaName()
        {
            DetailedComparisonActions.ExcludeschoolswithIncFinanceAcademiesLaName("100140");
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsFalse(Driver.driver.PageSource.Contains(errorText));
        }
        [Test]
        public static void ExcludeschoolswithIncFinanceAllSchoolsLaName()
        {
            DetailedComparisonActions.ExcludeschoolswithIncFinanceAcademiesLaName("100140");
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsFalse(Driver.driver.PageSource.Contains(errorText));
        }
        [Test]
        public static void IncludeschoolswithIncFinanceMaintainedLaName()
        {
            DetailedComparisonActions.IncludeschoolswithIncFinanceMaintainedLaName("3035200", "Bexley", "200", "509");
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsTrue(Driver.driver.PageSource.Contains(errorText));
        }
        [Test]
        public static void IncludeschoolswithIncFinanceAcademiesLaName()
        {
            DetailedComparisonActions.IncludeschoolswithIncFinanceAcademiesLaName("3035200", "Bexley", "200","509");
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsTrue(Driver.driver.PageSource.Contains(errorText));

        }
        [Test]
        public static void IncludechoolswithIncFinanceAllSchoolsLaName()
        {
            DetailedComparisonActions.IncludechoolswithIncFinanceAllSchoolsLaName("144407","Greenwich","20","201");
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsTrue(Driver.driver.PageSource.Contains(errorText));
        }
        [TearDown]
        public void TeardownAfterEachTest()
        {
            Driver.driver.Quit();
        }
    }
}

