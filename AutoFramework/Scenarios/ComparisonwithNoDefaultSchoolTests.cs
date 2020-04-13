﻿
namespace AutoFramework
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System.Threading;
    using AutoFramework.Pages;
    using System;
    using AutoFramework.Pages.PageElements;
    using SFB_Test_Automation.AutoFramework.Pages;
    using SFB_Test_Automation.AutoFramework.Pages.PageElements.Helpers;
    using SFB_Test_Automation.AutoFramework;
    using NUnit.Framework.Interfaces;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.IE;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Safari;
    //using OpenQA.Selenium.Remote.DesiredCapabilities;



    public class ComparisonwithNoDefaultSchoolTests
    {
        public ComparisonwithNoDefaultSchoolTests()
        {

        }
             [SetUp]
        public void SetupBeforeEachTest()
        {
            Actions.InitializeDriver("IE");
        }
        [Test]

        public void CompareByDetailedComparisonMaintainedExclude()
        {
            NoDefaultSchoolActions.detailedComparisonExcludeMaintained();
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsFalse(Driver.driver.PageSource.Contains(errorText));

        }
        [Test]

        public void CompareByDetailedComparisonMaintainedInclude()
        {
            NoDefaultSchoolActions.detailedComparisonIncludeMaintained();
            string errorText = "Some schools don't have a complete set of financial data for this period";
            Assert.IsTrue(Driver.driver.PageSource.Contains(errorText));

        }
        [Test]
        [Ignore("Ignore a test")]

        public void CompareByDetailedComparisonAcademiesExclude()
        {

            //assertions to be added here
        }
        [Test]
        [Ignore("Ignore a test")]

        public void CompareByDetailedComparisonAcademiesInclude()
        {
            //assertions to be added here

        }
        [Test]
        [Ignore("Ignore a test")]
        public void CompareByDetailedComparisonAllSchoolsExclude()
        {

            //assertions to be added here
        }
        [Test]
        [Ignore("Ignore a test")]
        public void CompareByDetailedComparisonAllSchoolsInclude()
        {
            //assertions to be added here

        }

        [Test]
        [Ignore("Ignore a test")]
        public void CompareByManualComparisonName()
        {
            //assertions to be added here

        }
        [Test]
        //[Ignore("Ignore a test")]
        public void CompareByManualComparisonLocation()
        {
            NoDefaultSchoolActions.ManualComparisonByLocation();
            //assertions to be added here


        }
        [TearDown]



        public void TeardownAfterEachTest()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var screenshot = ((ITakesScreenshot)Driver.driver).GetScreenshot();
                var testName = TestContext.CurrentContext.Test.FullName;
                screenshot.SaveAsFile(@"C:\Users\kwaku\OneDrive\Desktop\C#\AutoFramework\AutoFramework\Pages\screenshot" + testName + ".jpg");
                Driver.driver.Close();
                Driver.driver.Quit();
            }
            Driver.driver.Close();
            Driver.driver.Quit();
        }
    }
            


    
}