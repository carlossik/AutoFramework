
namespace AutoFramework
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System.Drawing.Imaging;

    public class FiltersTest
    {
        public FiltersTest()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
           

            //Actions.FillLoginForm();
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
            Assert.AreEqual(expectedText.Text, "Woolwich Polytechnic School");

        }
        [Test]
        public void verifySearchResults()
        {
            FilterActions.selectAllEducationPhase();
        }
        [Test]
        public void VerifySearchResultsWithSchoolType()
        {
            //FilterActions.
            //Assert.AreEqual((Driver.driver.FindElement(By.CssSelector("#benchmarkBasket > div > div > div")).Text, FilterActions.GetResultsNumbersBeforeFilters()));
             //Assert.AreEqual(Driver.driver.FindElement(By.CssSelector("#js-search-results-info > div > p > span")), "109");


        }

        

        [OneTimeTearDown]
        public void CleanUp()
        {
            //if (TestContext.CurrentContext.Result.Outcome != NUnit.Framework.Interfaces.ResultState.Success)
            //{
            //    var screenshot = ((ITakesScreenshot)Driver.driver).GetScreenshot();
            //    screenshot.SaveAsFile(@"C:\Users\kwaku\OneDrive\Pictures\Screenshots", ImageFormat.Jpeg);
            //}
            Driver.driver.Quit();
        }
        //Driver.driver.Quit();
        
    }

             
}


