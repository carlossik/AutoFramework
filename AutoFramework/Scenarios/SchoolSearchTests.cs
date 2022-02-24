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
    using System.Collections;
    using System.IO;

    public class Schoolsearchtests
    {
        IAlert alert;
        IWebDriver driver;

        [SetUp]
       
        public void SetupBeforeEachTest()
        
        {
            var testName = TestContext.CurrentContext.Test.FullName;
            Config.Credentials.deletefiles(@"C:\TEMP\" + testName + ".jpg");
            driver = Actions.InitializeDriver(5);
            


        }
        [Test]
        public void testschoolperformancetables()
        {
            Actions.CallingClass.sptlinkscheck(driver);
            SchoolDetailPage Schooldetails = new SchoolDetailPage(driver);
            String schoolUrn = Schooldetails.Urn.Text;
            IWebElement sptlink = Schooldetails.schoolPerformanceTableLink;
            Console.WriteLine(schoolUrn);
            Assert.IsTrue(sptlink.Displayed);

            //Assert.IsTrue(driver.Url.Contains ("https://www.compare-school-performance.service.gov.uk/school/"+ schoolUrn));
        }
        [Test]
        public void SearchSchoolLA_Code()
        {
            Actions.searchSchoolViaLaCode("303", driver);
        }
           
        [Test]
        [Category("QuickTests")]
        public void SearchSchool()

        {
            
            Actions.schoolSearchwithLaestab("8782446",driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            Assert.IsTrue(detailspage.School_Name.Displayed);
            Assert.AreEqual((detailspage.School_Name).Text, driver.FindElement(By.CssSelector("h1.govuk-heading-xl")).Text); //.heading-xlarge///html/body/div/div[9]/main/div[1]/div[1]/h1
            Assert.IsTrue(detailspage.Telephone_Number.Displayed);
            Assert.IsTrue(detailspage.OfstedRating.Displayed);
            Assert.IsTrue(detailspage.DataFromOtherSources.Displayed);
            Assert.IsTrue(detailspage.Services.Displayed);
            Assert.IsTrue(detailspage.SchoolPhase.Text == "Infant and junior");
            

        }
        [Test]
        [Ignore("Ignore this test")]
        public void verifyNewsPage()

        {
            
            Actions.gotonewspage(driver);
            Thread.Sleep(2000);
            Console.WriteLine(driver.Url);
            //Console.WriteLine(Config.currentTestEnv + "news?referrer=%2FAccount%2FLogin%3FReturnUrl%3D%252F");
            Assert.IsTrue(driver.Url.Contains(Config.currentTestEnv+"News"));
           // Console.WriteLine(driver.FindElement(By.CssSelector(".heading-xlarge")).Text);
           //Assert.IsTrue(driver.FindElement(By.CssSelector(".heading-xlarge")).Text == "News");

            
        }
        [Test]
        public void SearchSchool_closed_school_withName()
        {
            try
            {

           
            Actions.SearchClosedschoolLAEstab("101421",driver);//"Belmont Primary School"
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            Assert.IsTrue(detailspage.Date_Of_Closure.Displayed);
            //Assert.IsFalse(detailspage.StartAComparison.Displayed);
            } catch (NoSuchElementException )
            {
                
            }
        
                
            




            }
        [Test]
        public void SearchSchool_closed_schoolWithLAESTAB()
        {

            Actions.SearchClosedschoolLAEstab("3032004",driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            Assert.IsTrue(detailspage.schooldetailnotfoundmessage.Text.Contains("We couldn't find any schools matching your search criteria"));
            Console.WriteLine(detailspage.schooldetailnotfoundmessage.Text);
       
        }
        
       [Ignore("Ignore this test")]
        [Test]
        public void SearchSchool_closed_schoolWithURN()
        {

            Actions.SearchClosedschoolUrn("101449",driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            Assert.IsTrue(driver.FindElement(By.CssSelector("dt.metadata-school-detail__dt:nth-child(29)")).Displayed); //verify the date of closure is on the school page as it is a closed school
          

        }


       
        [Test]
        public void testMaps()
        {
            Actions.CallingClass.SchoolMap(driver);

            Assert.IsTrue(driver.FindElement(By.Id("SchoolLocationMap")).Displayed);
        }
        [Test]
        [Ignore("Ignore this test")]
        [Category("QuickTests")]
        public void TestDatasourcesLink()
        {
            Actions.CallingClass.TestDatasourcesLink(driver);
            Assert.AreEqual(driver.Url,  Config.currentTestEnv+ "Help/DataSources");
            Console.WriteLine(driver.Url);

        }
        [Test]
        
        public void testclosebasketviaresultspage()
        {
            
            Actions.addtobasketviaresultspage("DA7 5SS",driver);
            //Assert.IsTrue(driver.Url.Contains(Config.currentTestEnv + "SchoolSearch/Search?searchtype=search"));
            Console.Write(driver.Title);
            

            
        }
        //[Test]
        //public static void TestIntepreTingTheChartsLinks()
        //{
            
        //    Actions.CallingClass.TestIntepreTingTheChartsLinks(driver);
        //    Assert.AreEqual(driver.Url,Config.currentTestEnv + "Help/InterpretingCharts");
        //}
        [Test]
        [Ignore("Ignore this test")]
        public void TestHelpUsingSiteLink()
        {
            Actions.CallingClass.TestHelpUsingSiteLinks(driver);
            Assert.AreEqual(driver.Url, Config.currentTestEnv+"Help/Guidance");
        }
       

        //[Test]
        [Category("QuickTests")]
        public void TestButtonsOnDetailsPage()
        {
            Actions.CallingClass.IsButtonPresent(driver);
            Assert.AreEqual(driver.Url, Config.currentTestEnv);

        }
        [Test]
        [Category("QuickTests")]
        public void TestBasket()
        {
            Actions.CallingClass.Verifybasket(driver);
            Assert.That(driver.FindElement(By.CssSelector("#benchmarkBasket > div > div > div")).Text, Does.Contain("Your benchmark set contains 1 schools "));

        }
        [Test]
        public void editBasket()
        {
            Actions.CallingClass.Verifybasket(driver);
            
        }
        
        [Test]
        [Ignore("Ignore a test")]
        public void SearchSchoolIncludeExcludeCheckBox()
        {
            Actions.testExcludeIncludeCheckboxSchName("100000",driver);
            IWebElement myInput = driver.FindElement(By.CssSelector("input[type=\"text\"]"));
            Assert.IsFalse(myInput.GetAttribute("value").Equals(""));
           
        }


        [Test]
       // [Ignore("Ignore a test")]
        public void EditBasketAddSchools()
        {   
            Actions.CallingClass.AddSchools(driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            Assert.AreEqual(detailspage.SchooldetailInfoPanel.Text, "Your benchmark set contains 2 schools");
        }
        [Ignore("Ignore a test")]
        [Test]
        public void verifyDefaultSchool()
        {

            Actions.defaultsSchool(driver);
            String Textcolor = driver.FindElement(By.ClassName("bold-small")).GetCssValue("background-color");
            String LinkColour = driver.FindElement(By.CssSelector(".form-group > fieldset:nth-child(1) > p:nth-child(2) > a:nth-child(1)")).GetCssValue("color"); 
            String BackGroundColor = driver.FindElement(By.ClassName("bold-small")).GetCssValue("background-color");
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
            Actions.CallingClass.SearchViaSchoolurn("Carlos",driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
           // Assert.IsTrue(detailspage.schooldetailnotfoundmessage.Text.Contains) "There are errors on this page that require attention.");
            Assert.That(detailspage.schooldetailnotfoundmessage.Text.Contains("We couldn't find any schools matching your search criteria"));
                
        }    
        [Test]
        public void Testtextoncomparisonpage()
        {
            BenchMarkActions.CreateBenchmarkViaDetailComparison("100000",driver);
            DetailComparisonPage detatilscomparison = new DetailComparisonPage(driver);
            Assert.IsTrue(detatilscomparison.General_Header.Displayed);
            Assert.IsTrue(detatilscomparison.Sen_Header.Displayed);
            Assert.IsTrue(detatilscomparison.Performance_Header.Displayed);
            Assert.IsTrue(detatilscomparison.WorkForce_Header.Displayed);
          
        }
        [Test]
        public void IsmapDisplayed()
        {
            Actions.CallingClass.SchoolMap(driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            Assert.IsTrue(detailspage.School_Location_Map.Displayed);

        }
        [Test]
        //[Ignore("Ignore a test")]
        public void testrefineto30schools()
        {
            BenchMarkActions.refineto30schools("135747",driver);
           Assert.IsTrue(driver.FindElement(By.Id("modal-content")).Displayed);
        }
        [Test]
        public void testrefineZeroschoolsfound()
        {
            BenchMarkActions.testrefinezerofound("135747",driver);
            Assert.IsTrue(driver.FindElement(By.Id("modal-content")).Displayed);
            Assert.AreEqual(driver.FindElement(By.Id("modal-content")).Text, "Refine the characteristics entered until there are between 1 and 30 matched schools.");

        }
        [Test]
        public void testPaginationUsing_PostCode()
        {
            Actions.SearchByLocationUsingPostcode("Se18 3jl",driver);
            Actions.navigatepagination(driver);

        }

        [Test]
        public void testPagination_UsingLA_Code()
        {
            Actions.searchSchoolViaLaCode("352", driver);
            Actions.navigatepagination(driver);

        }

        [Test]
        public void testPagination_UsingLA_Code_EducationPhase()
        {
            Actions.searchSchoolViaLaCode("352", driver);
            Actions.testNumberOfResultsDisplayedForAllFilters(driver);

        }

        [Test]
        [Category("QuickTests")]
        public void SearchViaLocationManualEntry()
        {
            Actions.SearchByLocationUsingPostcode("DA7 5SS",driver);
            Assert.That(driver.FindElement(By.CssSelector("h1.govuk-heading-xl")).Text, Does.Contain("Schools in and near First Avenue"));
            //Assert.AreEqual(driver.FindElement(By.CssSelector("div.pagination-container:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > span:nth-child(1)")).Text, "109");
                   }

        [Test]
        [Category("QuickTests")]
        public void SearchViaLocationUsingLocationLink()
        {
            Actions.SearchByLocationUsingLink(driver);
            
            Assert.IsTrue(driver.Url.Contains(Config.currentTestEnv + "SchoolSearch/S"));
        }

        [Test]
        [Category("QuickTests")]
        public void TrustSearchByLaCode()
        {
            Actions.CallingClass.SearchByLaCode("303",driver);
            Assert.That(driver.FindElement(By.CssSelector(".govuk-heading-xl")).Text, Does.Contain("Academy trusts with schools operating in Bexley"));

        }
        [Test]
        public void TestOfstedNotRated()
        {
            Actions.CallingClass.SearchViaSchoolurn("144406",driver);
            Assert.That(driver.FindElement(By.CssSelector("dd.metadata-school-detail__dd:nth-child(16)")).Text, Does.Contain("Not rated"));
        }
        [Ignore("Ignore this test as Basic reports have been removed")]
        [Test]
        public void BasicComparisonReportingTest()
        {
            Actions.OnclickReportingTest(driver);
            Assert.That(driver.FindElement(By.CssSelector("#benchmarkBasket > div > div > div")).Text, Does.Contain("Your benchmark set contains 15 schools "));

        }
        [Test]
        public void VerifyLAlink()
        {
            Actions.CallingClass.verifylalink(driver);
            //Assert.That(driver.FindElement(By.CssSelector("#benchmarkBasket > div > div > div")).Text, Does.Contain("Your benchmark basket contains 15 schools "));

        }
        
        [Test]
        public void VerifyEncodingForSchoolNameText() //test school is 126416 but we can use any school to verify the script works
        {
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            String GiasValue = detailspage.compareWithGiasData(driver, "126416");
            Actions.CallingClass.SearchViaSchoolurn("126416", driver);
            Assert.AreEqual(GiasValue, detailspage.School_Name.Text);

        }

        [Test]
        public void VerifyEncodingForHead_Teacher_NameText() //test school is 126416 but we can use any school to verify the script works
        {
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            String GiasValue = detailspage.compareWithGiasDataHeadTeacher_Name(driver, "103119");//
            
            Actions.CallingClass.SearchViaSchoolurn("103119", driver);
            Assert.AreEqual(GiasValue, detailspage.HeadTeacher_Name.Text);
            //Console.WriteLine(detailspage.HeadTeacher_Name.Text + ""+GiasValue);
        }


        [Test]
        public void TestcorrectLADisplayed()
        {
            Actions.searchschoolLaCode("303", driver);
            
            SearchResultsPage resultsPage = new SearchResultsPage(driver);
            Actions.CallingClass.verifyschoolLA(driver);



        }
        [Test]
        public void TestAddschoolVianameorlocationlink()
        {
            Actions.CallingClass.addanotherschoolvianameorlocationlink(driver);
            Assert.AreEqual(driver.Url, Config.currentTestEnv + "schoolsearch/addschools");
           

        }
        [Test]
       public void TestDownloadPdf()
        {
            Actions.downloadpdf(driver);
            //Assert.IsTrue(Actions.CheckFileDownloaded("sfb-benchmark-charts.pdf"));
            FileAssert.Exists(Config.downloadDirectory+ "sfb-benchmark-charts.pdf");
        }
        [Test]
        public void TestDownloadCsv()
        {
            Actions.downloadcsv(driver);
            
        }
        [Test]
        public void TestDownloadPPT()
        {
            Actions.downloadppt(driver);
            FileAssert.Exists(Config.downloadDirectory + "sfb-benchmark-charts.pptx");
            FileInfo fi = new FileInfo(Config.downloadDirectory + "sfb-benchmark-charts.pptx");
            long emptyOrNot = (fi.Length/1000);
            Console.WriteLine("This is the size of the downloaded file in KiloBytes "+emptyOrNot);
            Assert.IsTrue(emptyOrNot > 2);
        }
        [Test]
        public void Savebenchmarkbasket()
        {
            Actions.savebenchmarkbasket(driver);
            String expected_response = "Link copied to clipboard";
            Assert.AreEqual(expected_response, (driver.FindElement(By.CssSelector("div.save-modal-js:nth-child(2) > h1:nth-child(2)")).Text));
        }
            
        [Test]
        public void FlipBetweencharts()
        {
            Actions.FlipBetweenCharts(driver);
            Assert.IsTrue(driver.FindElement(By.CssSelector("#PrintLinkText")).Displayed);
            Assert.IsTrue(driver.FindElement(By.Id("DownloadLinkText")).Displayed);
            Assert.IsTrue(driver.FindElement(By.Id("PrintLinkText")).Displayed);
        }
        [Test]
        public void TestBasketCapacity()
        {
            Actions.CallingClass.Verifybasketcapacity(driver);
            Assert.IsTrue(driver.FindElement(By.Id("modal-title")).Text.Contains("Not enough space in basket"));
        }
        [Ignore("Ignore a test")]
        [Test]
        public void VerifyDefaultSchoolColor()
        {
            Actions.CallingClass.VerifyDefaultSchoolColour("108000",driver);
            string colortext = driver.FindElement(By.CssSelector(".highlight > span:nth-child(1)")).GetAttribute("color");
            //Assert.IsTrue(colortext[1].Equals("FFFFFF"));
            Console.WriteLine(colortext);
            Console.Write(colortext);
        }
        [Test]
        public void searchschoolwithLAESTAB()
        {
            Actions.schoolSearchwithLaestab("8882096",driver);
            SchoolDetailPage detailpage = new SchoolDetailPage(driver);
            Assert.AreEqual((detailpage.School_Name).Text, "Accrington Huncoat Primary School");
        }
        [Test]
        public void searchforschoolwith16plus()
        {
            Actions.SearchByLocationUsingPostcode("Se18 3JL",driver);
            SearchResultsPage resultspage = new SearchResultsPage(driver);
            Assert.IsTrue(resultspage.Checkbox_16plus.Displayed);
        }
        [Test]
        [Category("QuickTests")]
        public void test_School_schoolname()

        {
            Actions.schoolSearchwithLaestab("8953525",driver);//("860408");
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            Assert.IsTrue(detailspage.School_Name.Displayed);
        }
        [Test]
        [Category("QuickTests")]
        public void test_School_telephoneNumber()

        {
            Actions.schoolSearchwithLaestab("8782446",driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            Assert.IsTrue(detailspage.Telephone_Number.Displayed);
        }
        [Test]
        [Category("QuickTests")]
        public void test_School_OtherSources()

        {

            Actions.schoolSearchwithLaestab("9332010",driver);

            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            Assert.IsTrue(detailspage.DataFromOtherSources.Displayed);

        }
        [Test]
        public void verifyBackToCharacteristicsOnSpecialsPage()
        {
          
                BenchMarkActions.createBenchmarkforSpecials("144041",driver);//must be a special school
                BenchMarkChartPage chartpage = new BenchMarkChartPage(driver);
                Assert.IsTrue(chartpage.backToViewCharacteristicsUsed.Displayed);
        }
        [Test]
        [Category("QuickTests")]
        public void test_School_OfstedRating()

        {
            Actions.schoolSearchwithLaestab("9362489",driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            Assert.IsTrue(detailspage.Telephone_Number.Displayed);
        }

        [Test]
        [Category("QuickTests")]
        public void test_trust_finance_displayed()

        {
            Actions.TrustSearchWithCompanynumber("6982127",driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            detailspage.FinanceDropdown.Click();

            Thread.Sleep(1000);
            detailspage.FinanceDropdown_Trust_Only.Click();
            Thread.Sleep(1000);

            Assert.IsFalse((detailspage.FinanceDisplayed.Text) == "£0");
        }
        [Test]
        public void testemailsuccess()

        {
            DataQueriesPage queriesPage = new DataQueriesPage(driver);
            Actions.testmailSuccess("carl.fagan@education.gov.uk",driver);
            Assert.IsTrue((queriesPage.queryConfirmation).Text == "Your query has been sent");
            
            //Console.WriteLine((queriesPage.queryreferencenumber).Text);
            //Console.WriteLine((queriesPage.queryConfirmation).Text);

        }

        [Test]
        public void testemail_FailuresWrongEmail()
        {
            DataQueriesPage queriesPage = new DataQueriesPage(driver);
            Actions.testmailSuccess("carl.fagan",driver);
            Assert.IsTrue((queriesPage.EmailErrorMessage).Text == "The Email field is not a valid e-mail address.");

        }

        [Test]
        public void test_contactUsPage()
        {
            HomePage home = new HomePage(driver);
            home.contactUs_footer.Click();
            ContactUsPage contactpage = new ContactUsPage(driver);
            contactpage.Name.SendKeys("Carlos");
            contactpage.EmailField.SendKeys("carlossidfe@outlook.com");
            contactpage.Contactus_Message_field.SendKeys("This is a test so Please ignore");
            contactpage.SubmitButton.Click();
            Assert.IsTrue(contactpage.SubmitMessage.Displayed);


        }

        [Test]
        public void testSpecialSchoolPage()
        {
            string[] specialschools = { "8797066", "3037004", "8797063", "8797065", "8777001" };
            List<string> specialschooolsundertest = new List<string>(specialschools);
            foreach (string school in specialschooolsundertest) {
                Actions.schoolSearchwithLaestab(school,driver);//must be a special School
                HomePage schoolhomepage = new HomePage(driver);
                Assert.IsTrue(schoolhomepage.SenSpecialCharacteristicsLink.Displayed);
                driver.Navigate().GoToUrl(Config.currentTestEnv);
            }
        }



        [Test]
        public void testspecialschoolsSenCharacteristics()
        {

            string[] specialschools = {"8797066"};
            List<string> specialschooolsundertest = new List<string>(specialschools);
            foreach (string school in specialschooolsundertest)
            {
                Actions.schoolsearchforSpecialSchool(school,driver);//Should be a special School
                IList sencharacteristics = driver.FindElements(By.XPath("//tr/td[1]/span[1]"));
                Assert.IsTrue(sencharacteristics.Count > 0);
                
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
              
                driver.Quit();
            }
          
            driver.Quit();
        }
    }
}