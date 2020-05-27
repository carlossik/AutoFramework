namespace AutoFramework
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System.Threading;
    using AutoFramework.Pages;
    using System;
    using AutoFramework.Pages.PageElements;
    using SFB_Test_Automation.AutoFramework.Pages;
    using SFB_Test_Automation.AutoFramework.Pages.PageElements.Helpers;
    using SFB_Test_Automation.AutoFramework;
    using NUnit.Framework.Interfaces;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.IE;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Safari;

    [TestFixture]
    
    public class BenchmarkingTests :BrowserToRunWith
    {
       

        //[OneTimeSetUp]
          [SetUp]
        public void SetupBeforeEachTest()
        
        {
            Actions.InitializeDriver("chrome");
         
        }
        [Test]
        
        [Category("QuickTests")]
       
        public void ManualBenchMarkCreationViaSchool()
        {

            BenchMarkActions.CreateManualBenchMarkViaName("143592");
            BenchMarkChartPage chartpage = new BenchMarkChartPage();
            Assert.AreEqual(chartpage.PageTitle.Text, "Benchmarking charts");


        }
        [Test]
        //[Ignore("Ignore a test")]
        public void ManualBenchmarkViaLocation()
        {
            BenchMarkActions.CreateManualBenchMarkViaLocation("100000");
            BenchMarkChartPage chartpage = new BenchMarkChartPage();

            Assert.AreEqual(chartpage.PageTitle.Text, "Benchmarking charts");
        }
        [Test]
        public void ManualBenchmarkViaLACode()
        {
            BenchMarkActions.CreateManualBenchMarkviaLACode("303");
            BenchMarkChartPage chartpage = new BenchMarkChartPage();
            Assert.AreEqual(chartpage.PageTitle.Text, "Benchmarking charts");
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
            BenchMarkActions.CreateBenchmarkViaDetailComparison("100140");//"125249"

            BenchMarkActions.getclipboardText();
            ComparingSimilarSchoolsPage similar = new ComparingSimilarSchoolsPage();
            similar.AddToExistingBasket.Click();
            similar.ContinueButton.Click();
            Thread.Sleep(300);
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector(".message")).Text == "Showing the 16 schools in your benchmark basket");



        }
        [Test]
        public static void PasteBasketGreaterThan30Schools()
        {
            BenchMarkActions.createbenchmarkviadefault("125249");
            BenchMarkActions.getclipboardTextmaximum();
            ReplaceCurrentBenchmarkbasketPage replace = new ReplaceCurrentBenchmarkbasketPage();
            replace.ReplaceBasket.Click();
            Thread.Sleep(200);
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector(".message")).Text == "Showing the 30 schools in your benchmark basket");

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
            Assert.IsTrue(Driver.driver.Url == Config.currentTestEnv);

        }
        [Test]
        public static void PasteBasketGreaterThan30SchoolsCancell()
        {
            BenchMarkActions.createbenchmarkviadefault("125249");
            BenchMarkActions.getclipboardTextmaximum();
            ReplaceCurrentBenchmarkbasketPage replace = new ReplaceCurrentBenchmarkbasketPage();
            replace.Cancelt.Click();
            Assert.IsTrue(Driver.driver.Url == Config.currentTestEnv);
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
            DetailedComparisonActions.IncludeschoolswithIncFinanceAcademiesAllEngland("100028","200","200");//("144407","64","64");//"145621", "879", "350","1003"
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
            DetailedComparisonActions.ExcludeschoolswithIncFinanceAllSchoolsLaCode("100140","303");
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsFalse(Driver.driver.PageSource.Contains(errorText));
        }
        [Test]
        public static void IncludeschoolswithIncFinanceMaintainedLaCode()
        {
            DetailedComparisonActions.IncludeschoolswithIncFinanceMaintainedLaCode("2042238", "204", "300", "333");


            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsTrue(Driver.driver.PageSource.Contains(errorText));
        }
        [Test]
        public static void IncludeschoolswithIncFinanceAcademiesLaCode()
        {
            DetailedComparisonActions.IncludeschoolswithIncFinanceAcademiesLaCode("145621", "879", "350","1030");
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsTrue(Driver.driver.PageSource.Contains(errorText));
        }
        [Test]
        public static void IncludechoolswithIncFinanceAllSchoolsLaCode()
        {
            DetailedComparisonActions.IncludechoolswithIncFinanceAllSchoolsLaCode("144407");
            //use schools 
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
            DetailedComparisonActions.IncludeschoolswithIncFinanceMaintainedLaName("2042238", "Hackney", "300", "500");
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
            DetailedComparisonActions.IncludechoolswithIncFinanceAllSchoolsLaName("144407", "Bradford", "20", "170");
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsTrue(Driver.driver.PageSource.Contains(errorText));
        }
        [Test]
        public static void Include16plusSchoolsInComparison()
        {
  
        }
        [Test]
        public static void VerifyBestyInClassIncludesAllSchoolTypes()
        {

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

