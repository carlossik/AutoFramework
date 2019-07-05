namespace AutoFramework
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System.Threading;
    using AutoFramework.Pages;
    using System;
    using AutoFramework.Pages.PageElements;
    using System.Diagnostics;

    [TestFixture]
    public class ComparisonTests
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
        public void QuickCompare()
        {
            Actions.CallingClass.QuickCompareWithOtherSchools();
            Thread.Sleep(2000);
           
            Assert.IsTrue(Driver.driver.FindElement(By.Id("Expenditure")).Displayed);//verify that the Expenditure tab is displayed and in focus
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector(".add-schools > span:nth-child(2)")).Displayed);//verify that the Add another School by name or location is available
            //Assert.IsTrue(Driver.driver.FindElement(By.Id("CentralFinancing")).Selected);
            //Assert.IsFalse(Driver.driver.FindElement(By.Id("la")).Selected);
            //Actions.CallingClass.ContinuetoBenchmarkCharts();


        }
        //[Test]
        public void ContinueToCharts()
        {
            Actions.CallingClass.QuickCompareWithOtherSchools();
            Actions.CallingClass.ContinuetoBenchmarkCharts();
            
        }
   
        [Test]
        public void zBestInClassComparison()
        {
            Actions.CallingClass.BestInClassComparison();
            SchoolDetailPage detailspage = new SchoolDetailPage();
            BestInClass bestinclasspage = new BestInClass();
            
            Assert.IsTrue(((bestinclasspage.BasketCount).Text).Contains("16 schools"));
           



        }
        [Test]
        public void TestIntepretingTheCharts()
        {
            Actions.CallingClass.InterpretingTheChartsTest();
            Assert.IsTrue(Driver.driver.Url == Config.currentTestEnv+"Help/InterpretingCharts");
            //need to add some assertions on the links present and the order
        }
        [Test]
        public void CompareTrusts()
        {
            Actions.TrustComparison();
        }
        //[OneTimeTearDown]
        [TearDown]
        public void TeardownAfterEachTest()
        //public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}
