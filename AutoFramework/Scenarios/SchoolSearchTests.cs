namespace AutoFramework
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System.Threading;
    using AutoFramework.Pages;
    using System;
    using AutoFramework.Pages.PageElements;
    using AutoFramework.Pages;



    public class Schoolsearchtests
    {
       

        public void  SchoolsearchTest()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            //NavigateTo.LoginFormScenarioThroughTestCases();
            Actions.FillLoginForm();
        }
                
      [Test]
      [Category("QuickTests")]
        public void SearchSchool()
        {
            Actions.SearchSchool();
            //Assert.AreEqual( Driver.driver.FindElement(By.XPath("/html/body/div/main/h1")).Text);
        }
       
        private object SearchResultsPage()
        {
            throw new NotImplementedException();
        }
        [Test]
        public void testMaps()
        {
            Actions.CallingClass.SchoolMap();
        }
        [Test]
        [Category("QuickTests")]
        public void TestLinks()
        {
            Actions.CallingClass.TestLinks();

        }
        [Test]
        [Category("QuickTests")]
        public void TestButtonsOnDetailsPage()
        {
            Actions.CallingClass.IsButtonPresent();
            Assert.AreEqual(Driver.driver.Url, "https://as-t1dv-sfb.azurewebsites.net/BenchmarkCharts");




        }
        [Test]
        [Category("QuickTests")]
        public void TestBasket()
        {
            Actions.CallingClass.Verifybasket();
            Assert.That(Driver.driver.FindElement(By.CssSelector("#benchmarkBasket > div > div > div")).Text,Does.Contain ("Your benchmark basket contains 1 schools "));
            
        }
        [Test]
        [Category("QuickTests")]
        public void SearchViaLocation()
        {
            Actions.SearchByLocation();
            Assert.That(Driver.driver.FindElement(By.CssSelector(".heading-xlarge")).Text, Does.Contain("Schools in and near First Avenue, Welling (Bexley), Kent"));

        }

        [Test]
        [Category("QuickTests")]
        public void SearchByLaCode()
        {
            Actions.CallingClass.SearchByLaCode();
            Assert.That(Driver.driver.FindElement(By.CssSelector(".heading-xlarge")).Text, Does.Contain("Schools in Greenwich"));

        }
        [Test]
        public void TestOfstedNotRated()
        {
            Actions.SearchSchool();
            Assert.That(Driver.driver.FindElement(By.CssSelector("dd.metadata-school-detail__dd:nth-child(16)")).Text, Does.Contain("Not rated"));

        }
        [Test]
        public void TestBasketCapacity()
        {
            //Actions.CallingClass.();
            //Assert.That(Driver.driver.FindElement(By.CssSelector("dd.metadata-school-detail__dd:nth-child(16)")).Text, Does.Contain("Not rated"));

        }
        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}