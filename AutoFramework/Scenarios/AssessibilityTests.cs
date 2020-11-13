using AutoFramework;
using Globant.Selenium.Axe;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFB_Test_Automation.AutoFramework.Scenarios
{
    [TestFixture]
    class AssessibilityTests
    {

        [SetUp]
        public void SetupBeforeEachTest()

        {
            var testName = TestContext.CurrentContext.Test.FullName;
            Config.Credentials.deletefiles(@"C:\TEMP\" + testName + ".jpg");
            Actions.InitializeDriver(Config.ChromeDriverUnderTest);

        }


        [Test]
        public void AccessibilityTest()
        {
            AxeResult results = Driver.driver.Analyze();

            Assert.IsEmpty(results.Violations);

        }


        [Test]
        public void accessibilitytest2()
        {
            AxeResult results = Driver.driver.Analyze();

            foreach (var xyz in results.Violations)
            {
                Console.WriteLine(xyz.Impact.ToString());
                Console.WriteLine(results.Violations.ToList());
                Console.WriteLine(xyz.Description.ToString());
                Console.WriteLine(xyz.Id.ToString());
                
                //log.Info(xyz.Description.ToString());
                //log.Info(xyz.Id.ToString());
            }
            Assert.True(results.Violations.Length == 0, "There are accessibility violations. Please check log file");
        }

    
        [TearDown]
        public void TeardownAfterEachTest()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var screenshot = ((ITakesScreenshot)Driver.driver).GetScreenshot();
                var testName = TestContext.CurrentContext.Test.FullName;
                TestContext.Out.WriteLine();
                screenshot.SaveAsFile(@"C:\TEMP\" + testName + ".jpg");
                Driver.driver.Close();
                Driver.driver.Quit();
            }
            Driver.driver.Close();
            Driver.driver.Quit();
        }
    }
}
/***
 * 
 * [TestFixture]
public class Tests
{
    [Test]
    public void Test()
    {
        var driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.google.com");
            AxeResult results = driver.Analyze();
            driver.Close();
    }
}
 * 
 * 
 * 
 * 
 * 
 * 
 * **/
