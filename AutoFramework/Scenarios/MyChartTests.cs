
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
            var testName = TestContext.CurrentContext.Test.FullName;
            Config.Credentials.deletefiles(@"C:\TEMP\" + testName + ".jpg");
            Actions.InitializeDriver(Config.FirefoxDriverUnderTest);

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
            //AssessibilityActions assessibility = new AssessibilityActions();
            //assessibility.accessibilitytest();


        }
        [TearDown]
        public void TeardownAfterEachTest()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var screenshot = ((ITakesScreenshot)Driver.driver).GetScreenshot();
                var testName = TestContext.CurrentContext.Test.FullName;
                screenshot.SaveAsFile(@"C:\TEMP\" + testName + ".jpg");
                //Driver.driver.Close();
                Driver.driver.Quit();
            }
            //Driver.driver.Close();
            Driver.driver.Quit();
        }

    }

}



