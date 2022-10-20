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

    //[Parallelizable]

    [TestFixture]
    
    public class BenchmarkingTests 
    {
        IAlert alert;
        IWebDriver driver;

        public BenchmarkingTests()
        {
        }


        [SetUp]
        public void SetupBeforeEachTest()
        
        {
            var testName = TestContext.CurrentContext.Test.FullName;
            Config.Credentials.deletefiles(@"C:\TEMP\" + testName + ".jpg");
            driver = Actions.InitializeDriver(5);

        }
        [Test]
        
        [Category("QuickTests")]
       
        public void ManualBenchMarkCreationViaSchool()
        {

            BenchMarkActions.CreateManualBenchMarkViaName("143592",driver);
            BenchMarkChartPage chartpage = new BenchMarkChartPage(driver);
            Assert.AreEqual(chartpage.PageTitle.Text, "Benchmarking charts");


        }
        [Test]
        
        public void ManualBenchmarkTest()
        {
            BenchMarkActions.CreateManualBenchMarkViaName("100000",driver);
            BenchMarkChartPage chartpage = new BenchMarkChartPage(driver);

            Assert.AreEqual(chartpage.PageTitle.Text, "Benchmarking charts");
        }
        [Test]

        public void RemoveSchool_From_ManualBenchmarkTest()
        {
            BenchMarkActions.removeSchoolFromManualList("100000", driver);
            //BenchMarkChartPage chartpage = new BenchMarkChartPage(driver);
        }

        [Test]
        public void ManualBenchmarkViaLACode()
        {
            BenchMarkActions.CreateManualBenchMarkviaLACode("303",driver);
            BenchMarkChartPage chartpage = new BenchMarkChartPage(driver);
            Assert.AreEqual(chartpage.PageTitle.Text, "Benchmarking charts");
        }
        [Test]
        public void AddAnotherSchoolByNameOrLocationLink()
        {
            Actions.CallingClass.QuickCompareWithOtherSchools("2032471",driver);
            BenchMarkActions.addschoolvianameorlocationlink(driver);

        }
        [Test]
        public void Savebenchmarkbaskettest()
        {
            Actions.savebenchmarkbasket(driver);
            BenchMarkBasketPage basketpage = new BenchMarkBasketPage(driver);
            Assert.IsTrue(basketpage.existsElement("js-modal-close",driver));

        }
        [Test]
        [Ignore("")]
        public  void PasteBasketLessThan30Schools()
        {

            Actions.OnclickReportingTest(driver);
            BenchMarkActions.CopyAndPasteChart(driver);
           
            ComparingSimilarSchoolsPage similar = new ComparingSimilarSchoolsPage(driver);
            similar.AddToExistingBasket.Click();
            similar.ContinueButton.Click();
            Thread.Sleep(3);
            Assert.AreEqual(driver.FindElement(By.CssSelector(".message")).Text, "Showing the 15 schools in your benchmark set");



        }
       // [Test]
       public void PasteBasketGreaterThan30Schools()
        {
            BenchMarkActions.createbenchmarkviadefault("125249", driver);
            BenchMarkActions.getclipboardTextmaximum(driver);
            ReplaceCurrentBenchmarkbasketPage replace = new ReplaceCurrentBenchmarkbasketPage(driver);
            replace.ReplaceBasket.Click();
            //replace.ContinueButton.Click();
            Thread.Sleep(200);
            Assert.AreEqual(driver.FindElement(By.CssSelector(".message")).Text , "Showing the 30 schools in your benchmark set");

        }
        [Test]
       public void PasteBasketLessThan30SchoolsCancell()
        {
           
            Actions.OnclickReportingTest(driver);
            BenchMarkActions.CopyAndPasteChart(driver);
           
            ComparingSimilarSchoolsPage similar = new ComparingSimilarSchoolsPage(driver);
            ReplaceCurrentBenchmarkbasketPage replace = new ReplaceCurrentBenchmarkbasketPage(driver);
            replace.Cancelt.Click();
           Assert.IsTrue(driver.Url == Config.currentTestEnv);

        }
        [Test]
       public void VerifyDefaulSchoolCopied_QuickCompare()
        {
            BenchMarkActions.createbenchmarkviadefault("100140", driver);//"125249"

            BenchMarkActions.CopyAndPasteChart(driver);
            Assert.IsTrue(driver.Url.Contains("&default=100140"));

        }

        [Test]
       public void VerifyDefaulSchoolCopied_AdvancedCompare()
        {
            DetailedComparisonActions.ExcludeschoolswithIncFinanceAcademiesAllEngland("141976", "239", "239", driver);
            
            BenchMarkActions.CopyAndPasteChart(driver);
            Assert.IsTrue(driver.Url.Contains("&default=141976" ));
            
        }

        [Test]
       public void VerifyDefaulSchoolCopied_BestInClass()
        {
            Actions.CallingClass.BestInClassComparison(driver);
            BenchMarkActions.CopyAndPasteChart(driver);
            Assert.IsTrue(driver.Url.Contains("&default=125271"));

        }

        [Test]
        [Ignore("Ignore this test")]
        public void VerifyDefaulSchoolCopied_ManualCompare()
        {
            throw new NotImplementedException();
        }

        [Test]
       public void PasteBasketGreaterThan30SchoolsCancell()
        {
            BenchMarkActions.createbenchmarkviadefault("125249", driver);
            BenchMarkActions.getclipboardTextmaximum(driver);
            ReplaceCurrentBenchmarkbasketPage replace = new ReplaceCurrentBenchmarkbasketPage(driver);
            replace.Cancelt.Click();
            Thread.Sleep(2000);
            Assert.IsTrue(driver.Url == Config.currentTestEnv);
        }
        [Test]
       public void ExcludeschoolswithIncFinanceMaintainedAllEngland()
        {
            DetailedComparisonActions.ExcludeschoolswithIncFinanceMaintainedAllEngland("142071", driver);
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsFalse(driver.PageSource.Contains(errorText));


        }
        [Test]
       public void ExcludeschoolswithIncFinanceAcademiesAllEngland()
        {
            DetailedComparisonActions.ExcludeschoolswithIncFinanceAcademiesAllEngland("141976", "239", "240", driver);
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsFalse(driver.PageSource.Contains(errorText));
        }
        [Test]
       public void veryifyP8Bandingforsecondariescolour()
        {
            //We test here to ensure that secondary schools have p8 banding background colour
            DetailedComparisonActions.detailedComparisonOnlySecondarySchools("se18 3jl", driver);


        }
        [Test]
       public void ExcludeschoolswithIncFinanceAllSchoolsAllEngland()
        {
            DetailedComparisonActions.ExcludeschoolswithIncFinanceAllSchoolsAllEngland("100140", driver);
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsFalse(driver.PageSource.Contains(errorText));
        }
        [Test]
       public void IncludeschoolswithIncFinanceMaintainedAllEngland()
        {
            DetailedComparisonActions.IncludeschoolswithIncFinanceMaintainedAllEngland("142071", driver);
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsTrue(driver.PageSource.Contains(errorText));

        }
        [Test]
       public void IncludeschoolswithIncFinanceAcademiesAllEngland()

        {
            DetailedComparisonActions.IncludeschoolswithIncFinanceAcademiesAllEngland("100028", "199", "199.5", driver);//("144407","64","64");//"145621", "879", "350","1003"
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsTrue(driver.PageSource.Contains(errorText));
        }
        [Test]
       public void IncludechoolswithIncFinanceAllSchoolsAllEngland()
        {
            DetailedComparisonActions.IncludechoolswithIncFinanceAllSchoolsAllEngland("145789", driver);
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsTrue(driver.PageSource.Contains(errorText));
        }
        [Test]
       public void ExcludeschoolswithIncFinanceMaintainedLaCode()
        {
            DetailedComparisonActions.ExcludeschoolswithIncFinanceMaintainedLaCode("100000", driver);
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsFalse(driver.PageSource.Contains(errorText));
        }
        [Test]

       public void ExcludeschoolswithIncFinanceAcademiesLaCode()
        {
            DetailedComparisonActions.ExcludeschoolswithIncFinanceAcademiesLaCode("100140", driver);
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsFalse(driver.PageSource.Contains(errorText));
        }
        [Test]
       public void ExcludeschoolswithIncFinanceAllSchoolsLaCode()
        {
            DetailedComparisonActions.ExcludeschoolswithIncFinanceAllSchoolsLaCode("100140", "303", driver);
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsFalse(driver.PageSource.Contains(errorText));
        }

        [Test]
        [Ignore("Need more data to replace current test school")]
       public void IncludeschoolswithIncFinanceMaintainedLaCode()
        {
            DetailedComparisonActions.IncludeschoolswithIncFinanceMaintainedLaCode("142071", "204", "300", "333", driver);
            //142071,2042238

            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsTrue(driver.PageSource.Contains(errorText));
        }
        [Test]
       public void IncludeschoolswithIncFinanceAcademiesLaCode()
        {
            DetailedComparisonActions.IncludeschoolswithIncFinanceAcademiesLaCode("100000", "879", "270", "500", driver);
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsTrue(driver.PageSource.Contains(errorText));
        }
        [Test]
       public void IncludechoolswithIncFinanceAllSchoolsLaCode()
        {
            DetailedComparisonActions.IncludechoolswithIncFinanceAllSchoolsLaCode("144407", driver);
            //use schools 
            string errorText = "Some schools don't have a complete set of financial data for this period";
            //Assert.IsTrue(driver.PageSource.Contains(errorText));
        }
        [Test]
       public void ExcludeschoolswithIncFinanceMaintainedLaName()
        {
            DetailedComparisonActions.ExcludeschoolswithIncFinanceMaintainedLaName("100140", driver);
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsFalse(driver.PageSource.Contains(errorText));
        }
        [Test]
       public void ExcludeschoolswithIncFinanceAcademiesLaName()
        {
            DetailedComparisonActions.ExcludeschoolswithIncFinanceAcademiesLaName("100140", driver);
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsFalse(driver.PageSource.Contains(errorText));
        }
        [Test]
       public void ExcludeschoolswithIncFinanceAllSchoolsLaName()
        {
            DetailedComparisonActions.ExcludeschoolswithIncFinanceAcademiesLaName("100140", driver);
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsFalse(driver.PageSource.Contains(errorText));
        }
        [Test]
        [Ignore("need new test data")]
       public void IncludeschoolswithIncFinanceMaintainedLaName()
        {
            DetailedComparisonActions.IncludeschoolswithIncFinanceMaintainedLaName("142071", "Hackney", "300", "500", driver);
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsTrue(driver.PageSource.Contains(errorText));
        }
        [Test]
       public void IncludeschoolswithIncFinanceAcademiesLaName()
        {
            DetailedComparisonActions.IncludeschoolswithIncFinanceAcademiesLaName("100000", "Bradford", "270", "400", driver);
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsTrue(driver.PageSource.Contains(errorText));
        }
        [Test]
       public void IncludechoolswithIncFinanceAllSchoolsLaName()
        {
            DetailedComparisonActions.IncludechoolswithIncFinanceAllSchoolsLaName("144407", "Bradford", "20", "170", driver);
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsTrue(driver.PageSource.Contains(errorText));
        }
        [Test]
        [Ignore("")]
       public void Include16plusSchoolsInComparison()
        {
            throw new NotImplementedException();

        }
        [Test]
       public void VerifyShowSENcharacteristicsonbenchmarkpageforspecialschools()
        {
            BenchMarkActions.createBenchmarkforSpecials("101487", driver);

        }
        [TearDown]
        public void TeardownAfterEachTest()
        {
            Console.WriteLine(TestContext.CurrentContext.Result.Outcome);
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                var testName = TestContext.CurrentContext.Test.FullName;
                screenshot.SaveAsFile(@"C:\TEMP\" + testName + ".jpg");
                driver.Close();
                driver.Quit();
                foreach (var process in System.Diagnostics.Process.GetProcessesByName("geckodriver"))
                {
                    process.Kill();
                }
            }
            driver.Close();
            driver.Quit();
        }
    }
}

