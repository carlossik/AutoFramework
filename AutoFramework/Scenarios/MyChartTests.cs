
namespace AutoFramework
{
    using NUnit.Framework;
    using NUnit.Framework.Interfaces;
    using OpenQA.Selenium;
    using SFB_Test_Automation.AutoFramework.Pages;
    using SFB_Test_Automation.AutoFramework;

    public class MyChartTests
      //[TestFixture(typeof(FirefoxDriver))]
//    [TestFixture(typeof(InternetExplorerDriver))]
//    [TestFixture(typeof(ChromeDriver))]

    {
        [SetUp]
        public void SetupBeforeEachTest()

        {
            Actions.InitializeDriver(Config.DriverUnderTest1);

        }

        [Test]
        public void TestMyChartTab()
        {
            MyChartActions.Gotomycharts();
            MyChartsPage chartspage = new MyChartsPage();
            Assert.IsTrue(chartspage.AddOrRemoveChartsLink.Displayed);
            //Assert.That(Driver.driver.Url, Does.Contain("/SchoolSearch/Search?radius=1"));
        }
        [Test]
        public void AddOrRemoveCharts()
        {
            MyChartActions.AddCharts();
            MyChartsPage chartspage = new MyChartsPage();
            Assert.IsTrue(chartspage.AddOrRemoveChartsLink.Displayed);
            //Assert.That(Driver.driver.Url, Does.Contain("/SchoolSearch/Search?radius=1"));


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



//namespace SeleniumTests
//{
//    [TestFixture(typeof(FirefoxDriver))]
//    [TestFixture(typeof(InternetExplorerDriver))]
//    [TestFixture(typeof(ChromeDriver))]
//    public class TestWithMultipleBrowsers<TWebDriver> where TWebDriver : IWebDriver, new()
//    {
//        private IWebDriver driver;

//        [SetUp]
//        public void CreateDriver()
//        {
//            this.driver = new TWebDriver();
//        }
//        [Test]
//        public void TestMyChartTab()
//         {
//          MyChartActions.Gotomycharts();
//          MyChartsPage chartspage = new MyChartsPage();
//          Assert.IsTrue(chartspage.AddOrRemoveChartsLink.Displayed);
//          //Assert.That(Driver.driver.Url, Does.Contain("/SchoolSearch/Search?radius=1"));
//          }
//        //[Test]
//        //public void GoogleTest()
//        //{
//        //    driver.Navigate().GoToUrl("http://www.google.com/");
//        //    IWebElement query = driver.FindElement(By.Name("q"));
//        //    query.SendKeys("Bread" + Keys.Enter);

//        //    Thread.Sleep(2000);

//        //    Assert.AreEqual("bread - Google Search", driver.Title);
//        //    driver.Quit();
//        //}
//    }
//}
