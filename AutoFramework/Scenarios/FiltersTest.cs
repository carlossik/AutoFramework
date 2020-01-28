﻿
namespace AutoFramework
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System.Drawing.Imaging;
    using System;
    using SFB_Test_Automation.AutoFramework.Pages;
    using NUnit.Framework.Interfaces;

    public class FiltersTest
    {
        public FiltersTest()
        {
        }

        [SetUp]
        public void SetupBeforeEachTest()

        {
            Actions.InitializeChromeDriver("firefox");
            //Actions.InitializeFireFoxDriver();
        }
       

        [Test]
        public void FilterBy1mile()
        {
            FilterActions.FilterBy1Mile();
            Assert.That(Driver.driver.Url, Does.Contain("/SchoolSearch/Search?radius=1"));
        }

        [Test]
        public void FilterBy3miles()
        {
           
            
            FilterActions.FilterBy3Miles();
            Assert.That(Driver.driver.Url, Does.Contain("/SchoolSearch/Search?radius=3"));
        }
        [Test]
        public void FilterBy5miles()
        {
            FilterActions.FilterBy5Miles();
            FiltersPage filters = new FiltersPage();
            //string ResultsDisplayedInitially = (filters.ResultsCount).Text;
            string ResultsDisplayedFinally = (filters.ResultsCount).Text;
            
            Console.WriteLine(ResultsDisplayedFinally);
            Assert.That(Driver.driver.Url, Does.Contain("/SchoolSearch/Search?radius=5"));
            

        }

        [Test]
        public void FilterBy10miles()
        {
            FilterActions.FilterBy10Miles();
            Assert.That(Driver.driver.Url, Does.Contain("/SchoolSearch/Search?radius=10"));
        }
        [Test]
        public void FilterBy15miles()
        {
            FilterActions.FilterBy15Miles();
            FiltersPage filters = new FiltersPage();
            //string ResultsDisplayedInitially = (filters.ResultsCount).Text;
            string ResultsDisplayedFinally = (filters.ResultsCount).Text;

            Console.WriteLine(ResultsDisplayedFinally);
            Assert.That(Driver.driver.Url, Does.Contain("/SchoolSearch/Search?radius=15"));
        }
        [Test]
        public void FilterByEducationPhasePrimary()
        {
            FilterActions.FilterByEducationPhasePrimary();
        }
        [Test]
        public void FilterByAlphabeticalOrderAZ()
        {
            FilterActions.SortByAlpabeticalOrderAZ();
            var expectedText = Driver.driver.FindElement(By.CssSelector("li.school-document:nth-child(1) > div:nth-child(1) > div:nth-child(1) > a:nth-child(1)"));
            Assert.AreEqual(expectedText.Text, "Abbey Wood Nursery School");

        }
        [Test]
        public void FilterByAlphabeticalOrderZA()
        {
            FilterActions.SortByAlpabeticalOrderZA();
            var expectedText = Driver.driver.FindElement(By.CssSelector("li.school-document:nth-child(1) > div:nth-child(1) > div:nth-child(1) > a:nth-child(1)"));
            Console.WriteLine(expectedText.Text);
            Assert.IsTrue((expectedText.Text == "Woolwich Polytechnic school for Girls"));

        }
        [Test]
        public void verifySearchResults()
        {
            FilterActions.selectAllEducationPhase();
        }
        [Test]
        public void VerifySearchResultsWithSchoolType()
        {
            FilterActions.selectAllSchoolType();
            //Assert.AreEqual((Driver.driver.FindElement(By.CssSelector("#benchmarkBasket > div > div > div")).Text), "23");
            Assert.AreEqual(Driver.driver.FindElement(By.CssSelector("div.pagination-container:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1)")).Text, "Showing 1 - 50 of 90 schools");
            Console.WriteLine(Driver.driver.FindElement(By.CssSelector("div.pagination-container:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1)")).Text);



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


