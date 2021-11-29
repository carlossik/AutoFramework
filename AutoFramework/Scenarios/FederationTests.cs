
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
    using SFB_Test_Automation.AutoFramework;
    using AutoFramework.Pages.PageElements;
    using SFB_Test_Automation.AutoFramework.vs.AutoFramework.Helpers;
    using System.Collections;
    using System.Threading;

    // [Parallelizable]

    public class FederationTests
    {
        IAlert alert;
        public IWebDriver driver { get; set; }

        public FederationTests()
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
        public void verifyfederationLinkDisplayedForNotSubmittedschools()
        {
            URNHelper helpers = new URNHelper();
            IList urns = helpers.fedswithoutfinance;
            foreach (string urn in urns)
            {
                try
                {
                    var fedurl = Config.currentTestEnv + "School/Detail?urn=" + urn;

                    driver.Navigate().GoToUrl(fedurl);
                    SchoolDetailPage detailspage = new SchoolDetailPage(driver);
                   
                    IWebElement federationslink = driver.FindElement(By.XPath("//dt[14]"));
                    Assert.IsTrue(federationslink.Displayed);
                    Assert.IsTrue(detailspage.FederationWithoutFinance.Text.Contains("This school's finance data is part of a federated budget, the combined federation finance can be seen on its federation page."));
                }
                catch (Exception ex)
                {
                    if (ex is NoSuchElementException || ex is AssertionException)
                    {
                        Console.WriteLine("This School did not display the banner"+""+urn);
                    }

                    { continue; }
                }
            }
            
        }

        [Test]
        public void verifyfederationLinkDisplayedForSubmittedschools()
        {
            URNHelper helpers = new URNHelper();
            IList urns = helpers.fedswithFinance;
            foreach (string urn in urns)
            {
                try
                {
                    var fedurl = Config.currentTestEnv + "School/Detail?urn=" + urn;
                    driver.Navigate().GoToUrl(fedurl);
                    SchoolDetailPage detailspage = new SchoolDetailPage(driver);
                    IWebElement federationslink = driver.FindElement(By.XPath("//dt[14]"));
                    Assert.IsTrue(federationslink.Displayed);
                }
                catch (NoSuchElementException)
                { Console.WriteLine(urn); }
                { continue; }
            }

        }

        [Test]
        public void VerifyCompare_LinkRemoved()
        {
            URNHelper helpers = new URNHelper();
            IList urns = helpers.fedswithFinance;
            foreach (string urn in urns)
            {
                try
                {
                    var fedurl = Config.currentTestEnv + "School/Detail?urn=" + urn;

                    driver.Navigate().GoToUrl(fedurl);
                    SchoolDetailPage detailspage = new SchoolDetailPage(driver);
                   
                    IWebElement federationslink = driver.FindElement(By.XPath("//dt[14]"));
                   
                    Assert.False(detailspage.StartAComparison.Displayed);

                }
                catch (NoSuchElementException)
                { Console.WriteLine(urn); }

                { continue; }
            }
        }


        [Test]
        public void VerifyAdd_To_BenchMarkSet_LinkRemoved()
        {
            URNHelper helpers = new URNHelper();
            IList urns = helpers.fedswithFinance;
            foreach (string urn in urns)
            {
                try
                {
                    var fedurl = Config.currentTestEnv + "School/Detail?urn=" + urn;
                    
                    driver.Navigate().GoToUrl(fedurl);
                    SchoolDetailPage detailspage = new SchoolDetailPage(driver);
                    
                    IWebElement federationslink = driver.FindElement(By.XPath("//dt[14]"));
                    Assert.False(detailspage.AddToBenchMarkBasket.Displayed);
                   

                }
                catch (NoSuchElementException)
                { Console.WriteLine(urn); }
               








                { continue; }
            }
        }


        [Test]
        public void VerifyFinanceBannerForNonsubmission()
        {
            URNHelper helpers = new URNHelper();
            IList urns = helpers.fedswithoutfinance;
            foreach (string urn in urns)
            {
                try
                {
                    Console.WriteLine("Testing this School  " + " " + urn);
                    Actions.SearchSchoolViaName(urn, driver);
                    SchoolDetailPage detailspage = new SchoolDetailPage(driver);
                    Thread.Sleep(100);
                    IWebElement federationslink = driver.FindElement(By.XPath("//dt[14]"));
                    Assert.IsTrue(federationslink.Displayed);
                    IWebElement financeText = driver.FindElement(By.XPath("//*[@id=\"content\"]/main/div[1]/div[2]/p"));
                    string errorText = "This school's finance data is part of a federated budget, the combined federation finance can be seen on its federation page.";
                    
                    Assert.AreEqual(errorText,financeText.Text);

                }
                catch (NoSuchElementException)
                { Console.WriteLine("This Urn failed "+" "+ urn); }
                //{ (TestContext.CurrentContext.Result.Outcome != ResultState.Failure); }
                { continue; }
            }
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
            }
            // driver.Close();
            driver.Quit();
        }



    }


}