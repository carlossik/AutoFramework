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

    public class Charttests
    {

        [SetUp]
        public void SetupBeforeEachTest()
        
        {
            var testName = TestContext.CurrentContext.Test.FullName;
            Config.Credentials.deletefiles(@"C:\TEMP\" + testName + ".jpg");
            Actions.InitializeDriver(Config.FirefoxDriverUnderTest);
  
        }
        [Test]
        [Category("QuickTests")]
        public void QuickCompareChartsTest()
        {
            Actions.CallingClass.QuickCompareWithOtherSchools();
            Assert.IsTrue(Driver.driver.FindElement(By.Id("BCHeader")).Text == "Benchmarking charts");
   
        }

        [Test]
        [Category("QuickTests")]
        [Ignore("Ignore a test")]
        public void PercentageOfTotalTabChange()
        {
            Actions.CallingClass.QuickCompareWithOtherSchools();
            BenchMarkActions.PercentageOfTotal();
             string perecentageofincomedisplayed = Driver.driver.FindElement(By.CssSelector("#ShowValue > option:nth-child(4)")).Text;
            Assert.IsTrue(perecentageofincomedisplayed == "Percentage of total income");

        }

        [Test]
        [Category("QuickTests")]
        [Ignore("Ignore a test")]
        public void DealsForSchoolsLink()
        {

            Actions.dealforswchools();
            //Assert.IsTrue(Driver.driver.FindElement(By.CssSelector("div.chart-container:nth-child(4) > div:nth-child(1) > div:nth-child(3) > a:nth-child(1)")).Displayed);
            //Assert.IsTrue(Driver.driver.FindElement(By.CssSelector("div.chart-container:nth-child(3) > div:nth-child(1) > div:nth-child(3) > a:nth-child(1)")).Displayed);
            //Assert.IsTrue(Driver.driver.FindElement(By.CssSelector("div.chart-container:nth-child(5) > div:nth-child(1) > div:nth-child(3) > a:nth-child(1)")).Displayed);
            //Assert.IsTrue(Driver.driver.FindElement(By.CssSelector("div.chart-container:nth-child(6) > div:nth-child(1) > div:nth-child(3) > a:nth-child(1)")).Displayed);
            
        }
        [Test]
        public void CostOffinanceTestQuickComparison()
        {
            Actions.CallingClass.QuickCompareWithOtherSchools();
            BenchMarkActions.costoffinance();
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector("div.chart-container:nth-child(3) > div:nth-child(1) > div:nth-child(2)")).Displayed);
            //Assert.IsFalse(Driver.driver.FindElement(By.CssSelector("div.chart-container:nth-child(3) > div:nth-child(1) > div:nth-child(3) > details:nth-child(2) > summary:nth-child(1) > span:nth-child(1)")).Displayed);
            //testing that anyother below cost of finance should be in an accordion

        }

        [Test]
        public void CostOffinanceTestDetailComparison()
        {
            DetailedComparisonActions.IncludechoolswithIncFinanceAllSchoolsAllEngland("145789");
            BenchMarkActions.costoffinance();
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector("div.chart-container:nth-child(3) > div:nth-child(1) > div:nth-child(2)")).Displayed);
            //Assert.IsFalse(Driver.driver.FindElement(By.CssSelector("div.chart-container:nth-child(3) > div:nth-child(1) > div:nth-child(3) > details:nth-child(2) > summary:nth-child(1) > span:nth-child(1)")).Displayed);
            //testing that anyother below cost of finance should be in an accordion
        }

        [Test]
        public void CostOffinanceTestBICComparison()
        {
            Actions.CallingClass.BestInClassComparison();
            BenchMarkActions.costoffinance();
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector("div.chart-container:nth-child(3) > div:nth-child(1) > div:nth-child(2)")).Displayed);
            //testing that anyother below cost of finance should be in an accordion


        }
        [Test]
        public void TestBestInClassComparisonSchoolsTab()
        {
            Actions.CallingClass.BestInClassComparison();
            BenchMarkActions.NavigateToBestInClassComparisonSchoolsTab();
            BenchmarkPageTabs tabspage = new BenchmarkPageTabs();
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
            Actions.CallingClass.QuickCompareWithOtherSchools();
            BenchMarkActions.NavigateToOtherComparisonSchoolsTab();
            BenchmarkPageTabs tabspage = new BenchmarkPageTabs();
            Assert.IsTrue(tabspage.SchoolTab.Displayed);
            Assert.IsTrue(tabspage.PhaseOfEducationTab.Displayed);
            Assert.IsTrue(tabspage.OfStedRatingTab.Displayed);
            //Assert.IsTrue(tabspage.Progress8Tab.Displayed);
            //Assert.IsTrue(tabspage.PupilsTab.Displayed);
        }
        [Test]
        public void PercenTageOfTotal()
        {
            Actions.CallingClass.BestInClassComparison();
            BenchMarkActions.costoffinance();
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
            Actions.AllThroughBIC("Bournemouth, Christchurch & Poole");
        }


        [TearDown]
        public void TeardownAfterEachTest()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var screenshot = ((ITakesScreenshot)Driver.driver).GetScreenshot();
                var testName = TestContext.CurrentContext.Test.FullName;
                screenshot.SaveAsFile(@"C:\TEMP\"+testName +".jpg");
                Driver.driver.Close();
                Driver.driver.Quit();
            }
            Driver.driver.Close();
            Driver.driver.Quit();
        }

    }
}
