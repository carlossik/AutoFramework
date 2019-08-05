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

    [TestFixture]

    public class Schoolsearchtests
    {


        public void SchoolsearchTest()
        {
        }
        [SetUp]
        public void SetupBeforeEachTest()
        //[OneTimeSetUp]

        //public void Initialize()
        {
            Actions.InitializeDriver();
            
            //Actions.FillLoginForm();
        }

        [Test]
        [Category("QuickTests")]
        public void SearchSchool()

        {
            
            Actions.schoolSearchwithLaestab("8782446");
            SchoolDetailPage detailspage = new SchoolDetailPage();
            Assert.IsTrue(detailspage.School_Name.Displayed);
            Assert.AreEqual((detailspage.School_Name).Text, Driver.driver.FindElement(By.XPath("/html/body/div/div[9]/main/h1")).Text);
            Assert.IsTrue(detailspage.Telephone_Number.Displayed);
            Assert.IsTrue(detailspage.OfstedRating.Displayed);
            Assert.IsTrue(detailspage.DataFromOtherSources.Displayed);
            Assert.IsTrue(detailspage.Services.Displayed);
            

        }
        [Test]
        public void SearchSchool_closed_school()
        {
            
            Actions.SearchClosedschool("101405");
            SchoolDetailPage detailspage = new SchoolDetailPage();
            Assert.IsTrue(detailspage.Date_Of_Closure.Displayed);
            Assert.IsFalse(detailspage.CompareWithOtherSchools.Displayed);
           
            

        }
        [Test]
        public void SearchSchool_closed_schoolWithLAESTAB()
        {

            Actions.SearchClosedschool("3032004");
            SchoolDetailPage detailspage = new SchoolDetailPage();
            Assert.IsTrue(detailspage.schooldetailnotfoundmessage.Text.Contains("No schools found"));
            
           

        }
        [Test]
        public void SearchSchool_closed_schoolWithURN()
        {

            Actions.SearchClosedschool("101405");
            SchoolDetailPage detailspage = new SchoolDetailPage();
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector("dt.metadata-school-detail__dt:nth-child(29)")).Displayed); //verify the date of closure is on the school page as it is a closed school
           // Assert.IsTrue(detailspage.schooldetailnotfoundmessage.Text.Contains("We found no matches for"));

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


        }
        [Test]
        public void testclosebasketviaresultspage()
        {
            
            Actions.addtobasketviaresultspage();
            Assert.IsTrue(Driver.driver.Url.Contains(Config.currentTestEnv + "SchoolSearch/Search?nameId="));
            

            
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
            //Assert.AreEqual(Driver.driver.Url, "https://as-t1dv-sfb.azurewebsites.net/BenchmarkCharts");
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
       // [Test]
        public void EditBasketAddSchools()
        {
            //Initialize();
            
            Actions.CallingClass.AddSchools();
            SchoolDetailPage detailspage = new SchoolDetailPage();
            Assert.AreEqual(detailspage.SchooldetailInfoPanel.Text, "2 schools");
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
            Assert.AreEqual(detatilscomparison.BodyText1.Text, "Which characteristics would you like to use for your comparison?");



        }
        [Test]
        public void IsmapDisplayed()
        {
            Actions.CallingClass.SchoolMap();
            SchoolDetailPage detailspage = new SchoolDetailPage();
            Assert.IsTrue(detailspage.School_Location_Map.Displayed);

        }
        [Test]
        public void testrefineto30schools()
        {
            BenchMarkActions.refineto30schools("135747");
           //Assert.IsTrue(Driver.driver.FindElement(By.Id("modal-content")).Displayed);
        }
        [Test]
        public void testrefineZeroschoolsfound()
        {
            BenchMarkActions.testrefinezerofound("135747");
            Assert.IsTrue(Driver.driver.FindElement(By.Id("modal-content")).Displayed);
            Assert.IsTrue(Driver.driver.FindElement(By.Id("modal-content")).Text == "Please refine the characteristics entered until there are between 1 and 30 matched schools.");

        }
            
        [Test]
        [Category("QuickTests")]
        public void SearchViaLocationManualEntry()
        {
            Actions.SearchByLocationManualEntry();
            Assert.That(Driver.driver.FindElement(By.CssSelector(".heading-xlarge")).Text, Does.Contain("Schools in and near First Avenue"));
            Assert.AreEqual(Driver.driver.FindElement(By.CssSelector("#js-search-results-info > div > p > span")).Text, "109");
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
            Assert.That(Driver.driver.FindElement(By.CssSelector(".heading-xlarge")).Text, Does.Contain("Schools in Bexley"));

        }
        [Test]
        public void TestOfstedNotRated()
        {
            Actions.CallingClass.SearchViaSchoolurn("144406");
            Assert.That(Driver.driver.FindElement(By.CssSelector("dd.metadata-school-detail__dd:nth-child(16)")).Text, Does.Contain("Not rated"));
        }
        [Test]
        public void OnclickReportingTest()
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
        public void OnclickReportingLondonTest()
        {
            Actions.OnclickReportingLondonTest("100140");
            Assert.That(Driver.driver.FindElement(By.CssSelector("#benchmarkBasket > div > div > div")).Text, Does.Contain("Your benchmark basket contains 15 schools "));
            BenchMarkChartPage quickreportpage = new BenchMarkChartPage();
            var londonweighting = quickreportpage.DefaultSchoolValueLondonweighting.Text;
            Assert.AreEqual(londonweighting, "Outer");
            //var londoweightingcomparisoncriteria = quickreportpage.DefaultSchoolValueLondonweighting.Text;
            //Assert.AreEqual(londoweightingcomparisoncriteria, "Inner, Outer");
        }
        [Test]
        public void OnclickReportingNotLondonTest()
        {
            Actions.OnclickReportingNonLondonTest("143590");
            //Assert.That(Driver.driver.FindElement(By.CssSelector("#benchmarkBasket > div > div > div")).Text, Does.Contain("Your benchmark basket contains 15 schools "));
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
            //sert.IsTrue()
        }
        [Test]
        public void Savebenchmarkbasket()
        {
            Actions.savebenchmarkbasket();
        }
            
        [Test]
        public void FlipBetweencharts()
        {
            Actions.FlipBetweenCharts();
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector("#PrintLinkText")).Displayed);
            Assert.IsTrue(Driver.driver.FindElement(By.Id("DownloadLinkText")).Displayed);
            Assert.IsTrue(Driver.driver.FindElement(By.Id("PrintLinkText")).Displayed);
        }
        //[Test]
        public void ATestBasketCapacity()
        {
            Actions.CallingClass.Verifybasketcapacity();
            Assert.IsTrue(Driver.driver.FindElement(By.Id("modal-title")).Text.Contains("Not enough space in basket"));
            Driver.driver.Quit();
         

        }
        [Test]
        public void searchschoolwithLAESTAB()
        {
            Actions.schoolSearchwithLaestab("8882096");
            SchoolDetailPage detailpage = new SchoolDetailPage();
            Assert.AreEqual((detailpage.School_Name).Text, "Accrington Huncoat Primary School");
        }
        [Test]
        [Category("QuickTests")]
        public void test_School_schoolname()

        {
            Actions.schoolSearchwithLaestab("8604084");
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
            //Assert.IsTrue(detailspage.DealsForSchools_Link.Displayed);
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


            Assert.IsFalse((detailspage.FinanceDisplayed.Text) == "0");
        }

        //[OneTimeTearDown]
        [TearDown]
        public void TeardownAfterEachTest()
        //public void CleanUp()
            
        {
            Driver.driver.Quit();
        }
    }
}