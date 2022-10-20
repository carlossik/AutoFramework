
namespace AutoFramework
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System.Drawing.Imaging;
    using System;
    using SFB_Test_Automation.AutoFramework.Pages;
    using NUnit.Framework.Interfaces;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.IE;

   // [Parallelizable]

    public class FiltersTest
    {
        IAlert alert;
        public IWebDriver driver { get; set; }

        public FiltersTest()
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
        public void FilterBy1mile()
        {
            FilterActions.FilterBy1Mile("DA7 5SS",driver);
            Assert.That(driver.Url, Does.Contain("/SchoolSearch/Search?radius=1"));
        }

        [Test]
        public void FilterBy3miles()
        {
           
            
            FilterActions.FilterBy3Miles("DA7 5SS",driver);
            Assert.That(driver.Url, Does.Contain("/SchoolSearch/Search?radius=3"));
        }
        [Test]
        public void FilterBy5miles()
        {
            FilterActions.FilterBy5Miles("DA7 5SS",driver);
            FiltersPage filters = new FiltersPage(driver);
            
            string ResultsDisplayedFinally = (filters.ResultsCount).Text;
            
            Console.WriteLine(ResultsDisplayedFinally);
            Assert.That(driver.Url, Does.Contain("/SchoolSearch/Search?radius=5"));
            

        }

        [Test]
        public void FilterBy10miles()
        {
            FilterActions.FilterBy10Miles("se18 3jl",driver);
            Assert.That(driver.Url, Does.Contain("/SchoolSearch/Search?radius=10"));
        }
        [Test]
        public void FilterBy15miles()
        {
            FilterActions.FilterBy15Miles("DA7 5SS",driver);
            FiltersPage filters = new FiltersPage(driver);
            
            string ResultsDisplayedFinally = (filters.ResultsCount).Text;

            Console.WriteLine(ResultsDisplayedFinally);
            Assert.That(driver.Url, Does.Contain("/SchoolSearch/Search?radius=15"));
        }
        [Test]
        public void FilterByEducationPhasePrimary()
        {
            FilterActions.FilterByEducationPhasePrimary("DA7 5SS",driver);
        }
        [Test]
        public void FilterByAlphabeticalOrderAZ()
        {
            FilterActions.SortByAlpabeticalOrderAZ("DA7 5SS",driver);
            var expectedText = driver.FindElement(By.CssSelector("li.school-document:nth-child(1) > div:nth-child(1) > div:nth-child(1) > a:nth-child(1)"));
            Assert.AreEqual(expectedText.Text, "Abbey Wood Nursery School");

        }
        [Test]
        public void FilterByAlphabeticalOrderZA()
        {
            FilterActions.SortByAlpabeticalOrderZA("DA7 5SS",driver);
            var expectedText = driver.FindElement(By.CssSelector("li.school-document:nth-child(1) > div:nth-child(1) > div:nth-child(1) > a:nth-child(1)"));
            Console.WriteLine(expectedText.Text);
            Assert.That(expectedText.Text, Does.Contain("Woolwich Polytechnic"));

          

        }
        [Test]
        public void verifySearchResults()
        {
            FilterActions.selectAllEducationPhase("DA7 5SS",driver);
        }
        [Test]
        public void VerifySearchResultsWithSchoolType()
        {
            FilterActions.selectAllSchoolType("camden",driver);
            


            Assert.That(driver.FindElement(By.CssSelector("div.pagination-container:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1)")).Text, Does.Contain("Showing 1 - 50 of"));
            //Assert.AreEqual(driver.FindElement(By.CssSelector("div.pagination-container:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1)")).Text, "Showing 1 - 50 of 90 schools");
            Console.WriteLine(driver.FindElement(By.CssSelector("div.pagination-container:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1)")).Text);



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
               // driver.Close();
                driver.Quit();
                foreach (var process in System.Diagnostics.Process.GetProcessesByName("geckodriver"))
                {
                    process.Kill();
                }
            }
           // driver.Close();
            driver.Quit();
        }



    }


}


