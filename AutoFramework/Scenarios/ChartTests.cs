namespace AutoFramework
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System.Threading;
    using AutoFramework.Pages;
    using System;
    using AutoFramework.Pages.PageElements;
    using SFB_Test_Automation.AutoFramework;

    public class Charttests
    {



        
        [SetUp]
        public void SetupBeforeEachTest()
        
        {
            Actions.InitializeDriver();

           
        }
        [Test]
        [Category("QuickTests")]
        public void QuickCompareChartsTest()
        {
            Actions.CallingClass.QuickCompareWithOtherSchools();
            Assert.IsTrue(Driver.driver.FindElement(By.Id("BCHeader")).Text == "Benchmarking charts");
           // Assert.IsTrue(Driver.driver.FindElement(By.Id("comparing-text")).Text.Contains "Comparing Foxfield Primary School to schools matching your chosen characteristics.");


            

        }

        //[Test]
        [Category("QuickTests")]
        public void TestIncompleteFinanceCharts()
        {
            Actions.CallingClass.searchschoolwithIncompleteFinance("139619");
        }

        [Test]
        [Category("QuickTests")]
        [Ignore("Ignore a test")]
        public void DealsForSchoolsLink()
        {
            Actions.dealforswchools();
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector("div.chart-container:nth-child(4) > div:nth-child(1) > div:nth-child(3) > a:nth-child(1)")).Displayed);
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector("div.chart-container:nth-child(3) > div:nth-child(1) > div:nth-child(3) > a:nth-child(1)")).Displayed);
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector("div.chart-container:nth-child(5) > div:nth-child(1) > div:nth-child(3) > a:nth-child(1)")).Displayed);
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector("div.chart-container:nth-child(6) > div:nth-child(1) > div:nth-child(3) > a:nth-child(1)")).Displayed);
            
        }
        [Test]
        public void CostOffinanceTestQuickComparison()
        {
            Actions.CallingClass.QuickCompareWithOtherSchools();
            BenchMarkActions.costoffinance();
            Assert.IsFalse(Driver.driver.FindElement(By.CssSelector("div.chart-container:nth-child(3) > div:nth-child(1) > div:nth-child(3) > details:nth-child(2) > summary:nth-child(1) > span:nth-child(1)")).Displayed);


        }

        [Test]
        public void CostOffinanceTestDetailComparison()
        {
            DetailedComparisonActions.IncludechoolswithIncFinanceAllSchoolsAllEngland("145789");
            BenchMarkActions.costoffinance();
            Assert.IsFalse(Driver.driver.FindElement(By.CssSelector("div.chart-container:nth-child(3) > div:nth-child(1) > div:nth-child(3) > details:nth-child(2) > summary:nth-child(1) > span:nth-child(1)")).Displayed);

        }

        [Test]
        public void CostOffinanceTestBICComparison()
        {
            Actions.CallingClass.BestInClassComparison();
            BenchMarkActions.costoffinance();
            Assert.IsFalse(Driver.driver.FindElement(By.CssSelector("div.chart-container:nth-child(3) > div:nth-child(1) > div:nth-child(3) > details:nth-child(2) > summary:nth-child(1) > span:nth-child(1)")).Displayed);



        }




       
        [TearDown]
        public void TeardownAfterEachTest()
        {
            Driver.driver.Quit();
        }

    }
    }
