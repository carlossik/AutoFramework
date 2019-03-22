namespace AutoFramework
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System.Threading;
    using AutoFramework.Pages;
    using System;
    using AutoFramework.Pages.PageElements;

    public class Schoolsearchtests
    {
       // private IAlert alert;

        //IAlert alert;

        public void  SchoolsearchTest()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            NavigateTo.LoginFormScenarioThroughTestCases();
            Actions.FillLoginForm();
        }
                
       [Test]
        public void SearchSchool()
        {
            Actions.SearchSchool();
            Assert.IsTrue(Driver.driver.FindElement(By.XPath("/html/body/div/main/h1")).Text.Contains("results"));
        }
        [Test]
        public void TrustSearch()
        {
            Actions.TrustSearch();
        }
        [Test]
        public void TrustSearchwithUrnNo()
        {
            Actions.TrustSearchWithTrustnumber();

        }
        private object SearchResultsPage()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void TestLinks()
        {
            Actions.TestLinks();

        }
        [Test]
        public void TestBasket()
        {
            Actions.verifybasket();
          
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector("#benchmarkBasket > div > div > div")).Text.Equals("Your benchmark basket contains 0 schools"));
            
        }
        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}