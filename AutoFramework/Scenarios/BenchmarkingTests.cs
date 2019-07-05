namespace AutoFramework
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System.Threading;
    using AutoFramework.Pages;
    using System;
    using AutoFramework.Pages.PageElements;

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
        [Test]
        public void ManualBenchmarkViaLACode()
        {

        }
        [Test]
        public void AddAnotherSchoolByNameOrLocationLink()
        {

        }
        [Test]
        public void Savebenchmarkbaskettest()
        {
            Actions.savebenchmarkbasket();
            BenchMarkBasketPage basketpage = new BenchMarkBasketPage();
            Assert.IsTrue(basketpage.existsElement("js-modal-close"));

        }
        //[OneTimeTearDown]
        //public void CleanUp()
        [TearDown]
        public void TeardownAfterEachTest()
        {
            Driver.driver.Quit();
        }
    }

}
