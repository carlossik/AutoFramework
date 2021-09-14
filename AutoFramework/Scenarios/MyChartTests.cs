
namespace AutoFramework
{
    using NUnit.Framework;
    using NUnit.Framework.Interfaces;
    using OpenQA.Selenium;
    using SFB_Test_Automation.AutoFramework.Pages;
    using SFB_Test_Automation.AutoFramework;
    using System;

    public class MyChartTests
   

    {

        IAlert alert;
        IWebDriver driver;


        public MyChartTests()
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
        public void TestMyChartTab()
        {
            MyChartActions.Gotomycharts(driver);
            MyChartsPage chartspage = new MyChartsPage(driver);
            Assert.IsTrue(chartspage.AddOrRemoveChartsLink.Displayed);
           
        }
        [Test]
        public void AddOrRemoveCharts()
        {
            MyChartActions.AddCharts(driver);
            MyChartsPage chartspage = new MyChartsPage(driver);
            Assert.IsTrue(chartspage.AddOrRemoveChartsLink.Displayed);
         }
        [Test]
        public void VeriFyChartPersists()
        {
            MyChartActions.AddCharts(driver);
            MyChartActions.persistCharts(driver);
            MyChartsPage chartspage = new MyChartsPage(driver);
            
            Assert.AreEqual(chartspage.YourChartsTabAfterAddingChart.Text, "Your charts\r\n(3 selected)");



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
               
                driver.Quit();
            }
            
            driver.Quit();
        }

    }

}



