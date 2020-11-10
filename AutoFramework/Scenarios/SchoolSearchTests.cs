namespace AutoFramework
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System;
    using AutoFramework.Pages.PageElements;
    using AutoFramework.Pages;
    using System.Threading;
    using Selenium.WebDriver.Extensions;
    using By = Selenium.WebDriver.Extensions.By;
    using SFB_Test_Automation.AutoFramework.Pages;
    using System.Collections.Generic;
    using NUnit.Framework.Interfaces;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.IE;
    using OpenQA.Selenium.Chrome;

    

    public class Schoolsearchtests
    { 
    
        [SetUp]
       
        public void SetupBeforeEachTest()
        
        {
            var testName = TestContext.CurrentContext.Test.FullName;
            Config.Credentials.deletefiles(@"C:\TEMP\" + testName + ".jpg");
            Actions.InitializeDriver(Config.ChromeDriverUnderTest);
            


        }
        [Test]
        public void testschoolperformancetables()
        {
            Actions.CallingClass.sptlinkscheck();
            SchoolDetailPage Schooldetails = new SchoolDetailPage();
            String schoolUrn = Schooldetails.Urn.Text;
            IWebElement sptlink = Schooldetails.schoolPerformanceTableLink;
            Console.WriteLine(schoolUrn);
            Assert.IsTrue(sptlink.Displayed);

            //Assert.IsTrue(Driver.driver.Url.Contains ("https://www.compare-school-performance.service.gov.uk/school/"+ schoolUrn));
        }

        [Test]
        [Category("QuickTests")]
        public void SearchSchool()

        {
            
            Actions.schoolSearchwithLaestab("8782446");
            SchoolDetailPage detailspage = new SchoolDetailPage();
            Assert.IsTrue(detailspage.School_Name.Displayed);
            Assert.AreEqual((detailspage.School_Name).Text, Driver.driver.FindElement(By.CssSelector(".heading-xlarge")).Text); //.heading-xlarge///html/body/div/div[9]/main/div[1]/div[1]/h1
            Assert.IsTrue(detailspage.Telephone_Number.Displayed);
            Assert.IsTrue(detailspage.OfstedRating.Displayed);
            Assert.IsTrue(detailspage.DataFromOtherSources.Displayed);
            Assert.IsTrue(detailspage.Services.Displayed);
            Assert.IsTrue(detailspage.SchoolPhase.Text == "Infant and junior");
            

        }
        [Test]
        public void verifyNewsPage()
        {
            
            Actions.gotonewspage();
            Thread.Sleep(2000);
            Console.WriteLine(Driver.driver.Url);
            //Console.WriteLine(Config.currentTestEnv + "news?referrer=%2FAccount%2FLogin%3FReturnUrl%3D%252F");
            Assert.IsTrue(Driver.driver.Url.Contains(Config.currentTestEnv+"News"));
           // Console.WriteLine(Driver.driver.FindElement(By.CssSelector(".heading-xlarge")).Text);
           //Assert.IsTrue(Driver.driver.FindElement(By.CssSelector(".heading-xlarge")).Text == "News");

            
        }
        [Test]
        public void SearchSchool_closed_school_withName()
        {
            
            Actions.SearchClosedschoolLAEstab("101421");//"Belmont Primary School"
            SchoolDetailPage detailspage = new SchoolDetailPage();
           // Assert.IsTrue(detailspage.Date_Of_Closure.Displayed);
            Assert.IsFalse(detailspage.CompareWithOtherSchools.Displayed);
           
            

        }
        [Test]
        public void SearchSchool_closed_schoolWithLAESTAB()
        {

            Actions.SearchClosedschoolLAEstab("3032004");
            SchoolDetailPage detailspage = new SchoolDetailPage();
            Assert.IsTrue(detailspage.schooldetailnotfoundmessage.Text.Contains("We couldn't find any schools matching your search criteria"));
            Console.WriteLine(detailspage.schooldetailnotfoundmessage.Text);
       
        }
        
        //[Test]
        public static void verifynewspagefromNewsBanner()
        {
            Actions.gotonewspagefrombanner();

        }
        [Test]
        public void SearchSchool_closed_schoolWithURN()
        {

            Actions.SearchClosedschoolUrn("101449");
            SchoolDetailPage detailspage = new SchoolDetailPage();
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector("dt.metadata-school-detail__dt:nth-child(29)")).Displayed); //verify the date of closure is on the school page as it is a closed school
          

        }


        private object SearchResultsPage()
        {
            throw new NotImplementedException();
        }
        [Test]
        public void testMaps()
        {
            Actions.CallingClass.SchoolMap();

            Assert.IsTrue(Driver.driver.FindElement(By.Id("SchoolLocationMap")).Displayed);
        }
        [Test]
        [Category("QuickTests")]
        public void TestDatasourcesLink()
        {
            Actions.CallingClass.TestDatasourcesLink();
            Assert.AreEqual(Driver.driver.Url,  Config.currentTestEnv+ "Help/DataSources");
            Console.WriteLine(Driver.driver.Url);

        }
        [Test]
        
        public void testclosebasketviaresultspage()
        {
            
            Actions.addtobasketviaresultspage("DA7 5SS");
            Assert.IsTrue(Driver.driver.Url.Contains(Config.currentTestEnv + "SchoolSearch/Search?searchtype=search"));
            

            
        }
        [Test]
        public static void TestIntepreTingTheChartsLinks()
        {
            
            Actions.CallingClass.TestIntepreTingTheChartsLinks();
            Assert.AreEqual(Driver.driver.Url,Config.currentTestEnv + "Help/InterpretingCharts");
        }
        [Test]
        public void TestHelpUsingSiteLink()
        {
            Actions.CallingClass.TestHelpUsingSiteLinks();
            Assert.AreEqual(Driver.driver.Url, Config.currentTestEnv+"Help/Guidance");
        }
       

        //[Test]
        [Category("QuickTests")]
        public void TestButtonsOnDetailsPage()
        {
            Actions.CallingClass.IsButtonPresent();
            Assert.AreEqual(Driver.driver.Url, Config.currentTestEnv);

        }
        [Test]
        [Category("QuickTests")]
        public void TestBasket()
        {
            Actions.CallingClass.Verifybasket();
            Assert.That(Driver.driver.FindElement(By.CssSelector("#benchmarkBasket > div > div > div")).Text, Does.Contain("Your benchmark basket contains 1 schools "));

        }
        [Test]
        public void editBasket()
        {
            Actions.CallingClass.Verifybasket();
            
        }
        
        [Test]
        [Ignore("Ignore a test")]
        public void SearchSchoolIncludeExcludeCheckBox()
        {
            Actions.testExcludeIncludeCheckboxSchName("100000");
            IWebElement myInput = Driver.driver.FindElement(By.CssSelector("input[type=\"text\"]"));
            Assert.IsFalse(myInput.GetAttribute("value").Equals(""));
           
        }


        [Test]
       // [Ignore("Ignore a test")]
        public void EditBasketAddSchools()
        {   
            Actions.CallingClass.AddSchools();
            SchoolDetailPage detailspage = new SchoolDetailPage();
            Assert.AreEqual(detailspage.SchooldetailInfoPanel.Text, "Your benchmark basket contains 2 schools");
        }
        [Ignore("Ignore a test")]
        [Test]
        public void verifyDefaultSchool()
        {

            Actions.defaultsSchool();
            String Textcolor = Driver.driver.FindElement(By.ClassName("bold-small")).GetCssValue("background-color");
            String LinkColour = Driver.driver.FindElement(By.CssSelector(".form-group > fieldset:nth-child(1) > p:nth-child(2) > a:nth-child(1)")).GetCssValue("color"); 
            String BackGroundColor = Driver.driver.FindElement(By.ClassName("bold-small")).GetCssValue("background-color");
            String ExpectedColor = ("rgba(0, 94, 165, 1)");
            Console.WriteLine( "Colour of Text " + Textcolor);//Assert to follow
            Console.WriteLine("BackGround Colour " + BackGroundColor);//element.getCssValue("color");
            Console.WriteLine("Colour of HyperLink " + LinkColour);
            Console.WriteLine("Expected Colour " + ExpectedColor);
            Assert.IsTrue(ExpectedColor.Contains("0, 94, 165"));
        }
        [Test]
        public void negativeSchoolTest()
        {
            Actions.CallingClass.SearchViaSchoolurn("Carlos");
            SchoolDetailPage detailspage = new SchoolDetailPage();
           // Assert.IsTrue(detailspage.schooldetailnotfoundmessage.Text.Contains) "There are errors on this page that require attention.");
            Assert.That(detailspage.schooldetailnotfoundmessage.Text.Contains("We couldn't find any schools matching your search criteria"));
                
        }    
        [Test]
        public void Testtextoncomparisonpage()
        {
            BenchMarkActions.CreateBenchmarkViaDetailComparison("100000");
            DetailComparisonPage detatilscomparison = new DetailComparisonPage();
            Assert.IsTrue(detatilscomparison.General_Header.Displayed);
            Assert.IsTrue(detatilscomparison.Sen_Header.Displayed);
            Assert.IsTrue(detatilscomparison.Performance_Header.Displayed);
            Assert.IsTrue(detatilscomparison.WorkForce_Header.Displayed);
            Assert.AreEqual(detatilscomparison.SchooNameLink.Text, detatilscomparison.ComparingToText.Text);
            //Assert.AreEqual(detatilscomparison.BodyText1.Text, "Which characteristics would you like to use for your comparison?");
        }
        [Test]
        public void IsmapDisplayed()
        {
            Actions.CallingClass.SchoolMap();
            SchoolDetailPage detailspage = new SchoolDetailPage();
            Assert.IsTrue(detailspage.School_Location_Map.Displayed);

        }
        [Test]
        //[Ignore("Ignore a test")]
        public void testrefineto30schools()
        {
            BenchMarkActions.refineto30schools("135747");
           Assert.IsTrue(Driver.driver.FindElement(By.Id("modal-content")).Displayed);
        }
        [Test]
        public void testrefineZeroschoolsfound()
        {
            BenchMarkActions.testrefinezerofound("135747");
            Assert.IsTrue(Driver.driver.FindElement(By.Id("modal-content")).Displayed);
            Assert.IsTrue(Driver.driver.FindElement(By.Id("modal-content")).Text == "Please refine the characteristics entered until there are between 1 and 30 matched schools.");

        }
        [Test]
        public void testPagination()
        {
            Actions.SearchByLocationUsingPostcode("Se18 3jl");
            Actions.navigatepagination();

        }
            
        [Test]
        [Category("QuickTests")]
        public void SearchViaLocationManualEntry()
        {
            Actions.SearchByLocationUsingPostcode("DA7 5SS");
            Assert.That(Driver.driver.FindElement(By.CssSelector(".heading-xlarge")).Text, Does.Contain("Schools in and near First Avenue"));
            //Assert.AreEqual(Driver.driver.FindElement(By.CssSelector("div.pagination-container:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > span:nth-child(1)")).Text, "109");
                   }

        [Test]
        [Category("QuickTests")]
        public void SearchViaLocationUsingLocationLink()
        {
            Actions.SearchByLocationUsingLink();
            
            Assert.IsTrue(Driver.driver.Url.Contains(Config.currentTestEnv + "SchoolSearch/S"));
        }

        [Test]
        [Category("QuickTests")]
        public void SearchByLaCode()
        {
            Actions.CallingClass.SearchByLaCode("303");
            Assert.That(Driver.driver.FindElement(By.CssSelector(".heading-xlarge")).Text, Does.Contain("Academy trusts with schools operating in Bexley"));

        }
        [Test]
        public void TestOfstedNotRated()
        {
            Actions.CallingClass.SearchViaSchoolurn("144406");
            Assert.That(Driver.driver.FindElement(By.CssSelector("dd.metadata-school-detail__dd:nth-child(16)")).Text, Does.Contain("Not rated"));
        }
        [Test]
        public void BasicComparisonReportingTest()
        {
            Actions.OnclickReportingTest();
            Assert.That(Driver.driver.FindElement(By.CssSelector("#benchmarkBasket > div > div > div")).Text, Does.Contain("Your benchmark basket contains 15 schools "));

        }
        [Test]
        public void VerifyLAlink()
        {
            Actions.CallingClass.verifylalink();
            //Assert.That(Driver.driver.FindElement(By.CssSelector("#benchmarkBasket > div > div > div")).Text, Does.Contain("Your benchmark basket contains 15 schools "));

        }
        [Test]
        public void BasicComparisonReportingLondonTest()
        {
            Actions.OnclickReportingLondonTest("100140");
            Assert.That(Driver.driver.FindElement(By.CssSelector("#benchmarkBasket > div > div > div")).Text, Does.Contain("Your benchmark basket contains 15 schools "));
            BenchMarkChartPage quickreportpage = new BenchMarkChartPage();
            var londonweighting = quickreportpage.DefaultSchoolValueLondonweighting.Text;
            Assert.AreEqual(londonweighting, "Outer");
           
        }
        [Test]
        public void BasicComparisonReportNotLondonTest()
        {
            Actions.OnclickReportingNonLondonTest("143590");
            
            BenchMarkChartPage quickreportpage = new BenchMarkChartPage();
            var londonweighting = quickreportpage.DefaultSchoolValueLondonweighting.Text;
            Assert.AreEqual(londonweighting, "Neither");
        }
        [Test]
        public void TestAddschoolVianameorlocationlink()
        {
            Actions.CallingClass.addanotherschoolvianameorlocationlink();
            Assert.AreEqual(Driver.driver.Url, Config.currentTestEnv + "schoolsearch/addschools");
           

        }
        [Test]
       public void TestDownloadPdf()
        {
            Actions.downloadpdf();
        }
        [Test]
        public void TestDownloadCsv()
        {
            Actions.downloadcsv();
            
        }
        [Test]
        public void TestDownloadPPT()
        {
            Actions.downloadppt();
        }
        [Test]
        public void Savebenchmarkbasket()
        {
            Actions.savebenchmarkbasket();
            String expected_response = "Link copied to clipboard";
            Assert.AreEqual(expected_response, (Driver.driver.FindElement(By.CssSelector("div.save-modal-js:nth-child(2) > h1:nth-child(2)")).Text));
        }
            
        [Test]
        public void FlipBetweencharts()
        {
            Actions.FlipBetweenCharts();
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector("#PrintLinkText")).Displayed);
            Assert.IsTrue(Driver.driver.FindElement(By.Id("DownloadLinkText")).Displayed);
            Assert.IsTrue(Driver.driver.FindElement(By.Id("PrintLinkText")).Displayed);
        }
        [Test]
        public void TestBasketCapacity()
        {
            Actions.CallingClass.Verifybasketcapacity();
            Assert.IsTrue(Driver.driver.FindElement(By.Id("modal-title")).Text.Contains("Not enough space in basket"));
        }
        [Ignore("Ignore a test")]
        [Test]
        public void VerifyDefaultSchoolColor()
        {
            Actions.CallingClass.VerifyDefaultSchoolColour("108000");
            string colortext = Driver.driver.FindElement(By.CssSelector(".highlight > span:nth-child(1)")).GetAttribute("color");
            //Assert.IsTrue(colortext[1].Equals("FFFFFF"));
            Console.WriteLine(colortext);
            Console.Write(colortext);
        }
        [Test]
        public void searchschoolwithLAESTAB()
        {
            Actions.schoolSearchwithLaestab("8882096");
            SchoolDetailPage detailpage = new SchoolDetailPage();
            Assert.AreEqual((detailpage.School_Name).Text, "Accrington Huncoat Primary School");
        }
        [Test]
        public void searchforschoolwith16plus()
        {
            Actions.SearchByLocationUsingPostcode("Se18 3JL");
            SearchResultsPage resultspage = new SearchResultsPage();
            Assert.IsTrue(resultspage.Checkbox_16plus.Displayed);
        }
        [Test]
        [Category("QuickTests")]
        public void test_School_schoolname()

        {
            Actions.schoolSearchwithLaestab("8953525");//("860408");
            SchoolDetailPage detailspage = new SchoolDetailPage();
            Assert.IsTrue(detailspage.School_Name.Displayed);
        }
        [Test]
        [Category("QuickTests")]
        public void test_School_telephoneNumber()

        {
            Actions.schoolSearchwithLaestab("8782446");
            SchoolDetailPage detailspage = new SchoolDetailPage();
            Assert.IsTrue(detailspage.Telephone_Number.Displayed);
        }
        [Test]
        [Category("QuickTests")]
        public void test_School_OtherSources()

        {

            Actions.schoolSearchwithLaestab("9332010");

            SchoolDetailPage detailspage = new SchoolDetailPage();
            Assert.IsTrue(detailspage.DataFromOtherSources.Displayed);

        }
        //[Test] This feature has been decommissioned
        [Category("QuickTests")]
        public void test_School_DealsForSchools()

        {

            Actions.schoolSearchwithLaestab("8812035");
            SchoolDetailPage detailspage = new SchoolDetailPage();
          
        }
        [Test]
        [Category("QuickTests")]
        public void test_School_OfstedRating()

        {
            Actions.schoolSearchwithLaestab("9362489");
            SchoolDetailPage detailspage = new SchoolDetailPage();
            Assert.IsTrue(detailspage.Telephone_Number.Displayed);
        }

        [Test]
        [Category("QuickTests")]
        public void test_trust_finance_displayed()

        {
            Actions.TrustSearchWithCompanynumber("6982127");
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.FinanceDropdown.Click();

            Thread.Sleep(1000);
            detailspage.FinanceDropdown_Trust_Only.Click();
            Thread.Sleep(1000);

            Assert.IsFalse((detailspage.FinanceDisplayed.Text) == "£0");
        }
        [Test]
        public void testemailsuccess()

        {
            DataQueriesPage queriesPage = new DataQueriesPage();
            Actions.testmailSuccess("carl.fagan@education.gov.uk");
            Assert.IsTrue((queriesPage.queryConfirmation).Text == "Your query has been sent");
            
            Console.WriteLine((queriesPage.queryreferencenumber).Text);
            Console.WriteLine((queriesPage.queryConfirmation).Text);

        }

        [Test]
        public void testemail_FailuresWrongEmail()
        {
            DataQueriesPage queriesPage = new DataQueriesPage();
            Actions.testmailSuccess("carl.fagan");
            Assert.IsTrue((queriesPage.EmailErrorMessage).Text == "The Email field is not a valid e-mail address.");

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