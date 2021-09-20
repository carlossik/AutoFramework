namespace AutoFramework
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System.Threading;
    using AutoFramework.Pages;
    using System;
    using AutoFramework.Pages.PageElements;
    using SFB_Test_Automation.AutoFramework;
    using NUnit.Framework.Interfaces;
    using System.Drawing.Imaging;

   // [Parallelizable]

    public class Charttests
    {
        IAlert alert;
        IWebDriver driver;

        [SetUp]
        public void SetupBeforeEachTest()
        
        {
            var testName = TestContext.CurrentContext.Test.FullName;
            Config.Credentials.deletefiles(@"C:\TEMP\" + testName + ".jpg");
            driver = Actions.InitializeDriver(1);

        }
        [Test]
        [Category("QuickTests")]
        public void QuickCompareChartsTest()
        {
            Actions.CallingClass.QuickCompareWithOtherSchools("2032471",driver);
            Assert.IsTrue(driver.FindElement(By.Id("BCHeader")).Text == "Benchmarking charts");
   
        }

        [Test]
        [Category("QuickTests")]
        [Ignore("Ignore a test")]
        public void PercentageOfTotalTabChange()
        {
            Actions.CallingClass.QuickCompareWithOtherSchools("2032471",driver);
            BenchMarkActions.PercentageOfTotal(driver);
             string perecentageofincomedisplayed = driver.FindElement(By.CssSelector("#ShowValue > option:nth-child(4)")).Text;
            Assert.IsTrue(perecentageofincomedisplayed == "Percentage of total income");

        }

        [Test]
        [Category("QuickTests")]
        [Ignore("Ignore a test")]
        public void DealsForSchoolsLink()
        {

            Actions.dealforswchools("2032471",driver);
            
        }
        [Test]
        public void CostOffinanceTestQuickComparison()
        {
            Actions.CallingClass.QuickCompareWithOtherSchools("2032471",driver);
            BenchMarkActions.costoffinance(driver);
            Assert.IsTrue(driver.FindElement(By.CssSelector("div.chart-container:nth-child(3) > div:nth-child(1) > h2:nth-child(1) > a:nth-child(1) > span:nth-child(1)")).Displayed);
            

        }

        [Test]
        public void CostOffinanceTestDetailComparison()
        {
            DetailedComparisonActions.IncludechoolswithIncFinanceAllSchoolsAllEngland("145789",driver);
            BenchMarkActions.costoffinance(driver);
            Assert.IsTrue(driver.FindElement(By.CssSelector("div.chart-container:nth-child(3) > div:nth-child(1) > h2:nth-child(1) > a:nth-child(1) > span:nth-child(1)")).Displayed);
           
        }

        [Test]
        public void CostOffinanceTestBICComparison()
        {
            Actions.CallingClass.BestInClassComparison(driver);
            BenchMarkActions.costoffinance(driver);
            Assert.IsTrue(driver.FindElement(By.CssSelector("div.chart-container:nth-child(3) > div:nth-child(1) > h2:nth-child(1) > a:nth-child(1) > span:nth-child(1)")).Displayed);
            


        }
        [Test]
        public void TestBestInClassComparisonSchoolsTab()
        {
            Actions.CallingClass.BestInClassComparison(driver);
            BenchMarkActions.NavigateToBestInClassComparisonSchoolsTab(driver);
            BenchmarkPageTabs tabspage = new BenchmarkPageTabs(driver);
            Assert.IsTrue(tabspage.BICSchool.Displayed);
            Assert.IsTrue(tabspage.BICPupils.Displayed);
            Assert.IsTrue(tabspage.LocalAuthority.Displayed);
            Assert.IsTrue(tabspage.BICFSM.Displayed);
            Assert.IsTrue(tabspage.BICEHCP.Displayed);
            Assert.IsTrue(tabspage.BICExpenditureperPupil.Displayed);
            Assert.IsTrue(tabspage.BICUrbanRural.Displayed);
            Assert.IsTrue(tabspage.BICProgress8.Displayed);


        }

        [Test]
        public void TestComparisonSchoolsTabOtherCharts()
        {
            Actions.CallingClass.QuickCompareWithOtherSchools("2032471",driver);
            BenchMarkActions.NavigateToOtherComparisonSchoolsTab(driver);
            BenchmarkPageTabs tabspage = new BenchmarkPageTabs(driver);
            Assert.IsTrue(tabspage.SchoolTab.Displayed);
            Assert.IsTrue(tabspage.PhaseOfEducationTab.Displayed);
            Assert.IsTrue(tabspage.OfStedRatingTab.Displayed);
           
        }
        [Test]
        public void PercenTageOfTotal()
        {
            Actions.CallingClass.BestInClassComparison(driver);
            BenchMarkActions.costoffinance(driver);
        }
            [Test]
        [Ignore("Ignore a test")]
        public void SortComparisonTabBySchool()
        {
            //throw new NotImplementedException();
        }
        [Test]
        [Ignore("Ignore a test")]
        public void SortComparisonTabByOfstedRating()
        {
            //throw new NotImplementedException();
        }
        [Test]
        [Ignore("Ignore a test")]
        public void VerifyInspectionDateOfstedRating()
        {
            //throw new NotImplementedException();
        }

        [Test]
        [Ignore("Ignore a test")]
        public void VerifyTeacherPayscaleInfo()
        {
            throw new NotImplementedException();
        }
        [Test]
        [Ignore("Ignore a test")]
        public void VerifyperecentageOfIncomeExpenditureTabs()
        {
            throw new NotImplementedException();
        }
        [Test]
        //[Ignore("Ignore a test")]
        public void BestInClassAllThrough()
        {
            Actions.AllThroughBIC("Bournemouth, Christchurch & Poole",driver);
        }


        [TearDown]
        public void TeardownAfterEachTest()
        {
            Console.WriteLine(TestContext.CurrentContext.Result.Outcome);
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                var testName = TestContext.CurrentContext.Test.FullName;
                screenshot.SaveAsFile(@"C:\TEMP\"+testName +".jpg");
                driver.Close();
                driver.Quit();
            }
            driver.Close();
            driver.Quit();
        }

    }
}
