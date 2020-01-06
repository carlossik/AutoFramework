
namespace AutoFramework
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System.Drawing.Imaging;
    using System;

    public class FiltersTest
    {
        public FiltersTest()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeChromeDriver();
           
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
            Assert.AreEqual(expectedText.Text, "Woolwich Polytechnic school for Girls");

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
            Assert.AreEqual(Driver.driver.FindElement(By.CssSelector("div.pagination-container:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1)")).Text, "Showing 1 - 50 of 92 schools");
            Console.WriteLine(Driver.driver.FindElement(By.CssSelector("div.pagination-container:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1)")).Text);



        }

        

        [OneTimeTearDown]
        public void CleanUp()
        {
            
            Driver.driver.Close();
            Driver.driver.Quit();
        }
        
        
    }

             
}


