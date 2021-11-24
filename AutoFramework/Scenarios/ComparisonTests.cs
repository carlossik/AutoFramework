namespace AutoFramework
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System.Threading;
    using AutoFramework.Pages;
    using System;
    using AutoFramework.Pages.PageElements;
    using System.Diagnostics;
    using SFB_Test_Automation.AutoFramework;
    using NUnit.Framework.Interfaces;
    using SFB_Test_Automation.AutoFramework.Pages;

    [TestFixture]
   // [Parallelizable]
    public class ComparisonTests
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
        [Category("QuickTests")]
        public void QuickCompare()
        {
            Actions.CallingClass.QuickCompareWithOtherSchools("2032471",driver);
            Thread.Sleep(2000);
           
            Assert.IsTrue(driver.FindElement(By.Id("Expenditure")).Displayed);//verify that the Expenditure tab is displayed and in focus
            Assert.IsTrue(driver.FindElement(By.CssSelector(".add-schools > span:nth-child(2)")).Displayed);//verify that the Add another School by name or location is available


        }
        //[Test]
        public void ContinueToCharts()
        {
            Actions.CallingClass.QuickCompareWithOtherSchools("2032471",driver);
            Actions.CallingClass.ContinuetoBenchmarkCharts(driver);
            
        }
   
        [Test]
        public void zBestInClassComparison()
        {
            Actions.CallingClass.BestInClassComparison(driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            BestInClass bestinclasspage = new BestInClass(driver);
            
            Assert.IsTrue(((bestinclasspage.BasketCount).Text).Contains("16 schools"));
            
        }
        [Test]
        public void TestIntepretingTheCharts()
        {
            Actions.CallingClass.InterpretingTheChartsTest(driver);
           // IWebElement intepretingthechartsLink = driver.FindElement(By.XPath("//ul[@class='list font-xsmall']/li[2]"));
            Assert.AreEqual(driver.Url, Config.currentTestEnv+ "Help/DataSources#interpret-data");
            //need to add some assertions on the links present and the order
        }
        [Test]
        public void specialschoolQuickComparisonTest()
        {
            Actions.quickcompareSpecialSchoolWithSimilar("8797068",driver);
            BenchMarkChartPage chartpage = new BenchMarkChartPage(driver);
            Assert.AreEqual(chartpage.NumberOfitemsInBasket.Text, "15 schools");
            //add assertion to verify characteristics used
        }

        [Test]
        public void specialschoolQuickComparisonTestWithoutSimilaragedPupils()
        {
            Actions.quickcompareSpecialSchoolWithoutSimilar("8797068",driver);
            BenchMarkChartPage chartpage = new BenchMarkChartPage(driver);
            Assert.AreEqual(chartpage.NumberOfitemsInBasket.Text, "15 schools");
            //add assertion to verify characteristics used
        }

        [Test]
        public void specialschoolBenchmarkChart_TestCharacteristics()
        {
            Actions.quickcompareSpecialSchoolWithoutSimilar("8797068",driver);
            Actions.viewcharacteristicsOnChartPage(driver);
            BenchMarkChartPage chartpage = new BenchMarkChartPage(driver);
            Assert.AreEqual(chartpage.NumberOfitemsInBasket.Text, "15 schools");
            //add assertion to verify characteristics used
        }

        [Test]
        public void CompareTrusts()
        {
           TrustActions.ManualTrustComparison("Portico Academy Trust", driver);
        }
        [Test]
        public void VerifySchoolPhaseAndOverAllPhase()
        {
         DetailedComparisonActions.GeneralDetailedJourney("100008",driver);
             String TestValue = driver.FindElement(By.XPath("//body/div[@id='js-modal-page']/div[@id='content']/div[1]/main[1]/section[1]/div[1]/div[3]/div[1]/form[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[2]/div[1]/fieldset[1]/div[1]/span[1]/span[1]")).Text;
           SchoolDetailPage detailspage = new SchoolDetailPage(driver);
        
            Assert.AreEqual(TestValue, "Primary (Infant and junior)");//need to change this test to parameterize the test value
           
        }

        [Test]
        public void TestToAndFromFieldsNumOfPupils()
        {
            DetailedComparisonActions.IncludeschoolswithIncFinanceAcademiesAllEngland("144407", "64", "50",driver);
            
            string errorText = "'From' value can not be greater than the 'To' value";
            Assert.IsTrue(driver.PageSource.Contains(errorText));
        }
        [Test]
        [Ignore("Ignore a test")]

        public void TestToAndFromFieldsEligibilityFreeschmeals()
        {
            DetailedComparisonActions.IncludeschoolswithIncFinanceAcademiesAllEngland("144407", "64", "50",driver);
            string errorText = "'From' value can not be greater than the 'To' value";


            Assert.IsTrue(driver.PageSource.Contains(errorText));
        }
        [Test]
        [Ignore("Ignore a test")]
        public void TestToAndFromFieldsNumOfPupilsEduNeeds()
        {
            DetailedComparisonActions.IncludeschoolswithIncFinanceAcademiesAllEngland("144407", "64", "50",driver);
            string errorText = "'From' value can not be greater than the 'To' value";


            Assert.IsTrue(driver.PageSource.Contains(errorText));
        }
        [Test]
        [Ignore("Ignore a test")]
        public void TestToAndFromFieldsNumInSixthForm()
        {
            DetailedComparisonActions.IncludeschoolswithIncFinanceAcademiesAllEngland("144407", "64", "50",driver);
            string errorText = "'From' value can not be greater than the 'To' value";


            Assert.IsTrue(driver.PageSource.Contains(errorText));
        }

        [Test]
        
        public void DisplayComparisonschoolsTab()
        {
            DetailedComparisonActions.IncludeschoolswithIncFinanceAcademiesAllEngland("144407", "64", "65",driver);
            Assert.IsTrue(driver.FindElement(By.CssSelector("#ComparisonSchools > a:nth-child(1)")).Displayed);
        }
        [Test]
        public void detailedComparisonOptions()
        {
            
            DetailedComparisonActions.GeneralDetailedJourney("100000",driver);
            //Assertions to follow but for now we make sure all options are clicked as a check that these buttons are available
           
          
            


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
            }
            driver.Close();
            driver.Quit();
        }

    }
}
