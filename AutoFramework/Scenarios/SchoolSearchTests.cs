namespace AutoFramework
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System;
    using AutoFramework.Pages.PageElements;
    using AutoFramework.Pages;


    public class Schoolsearchtests
    {


        public void SchoolsearchTest()
        {
        }

        [OneTimeSetUp]

        public void Initialize()
        {
            Actions.InitializeDriver();
            
            Actions.FillLoginForm();
        }

        [Test]
        [Category("QuickTests")]
        public void SearchSchool()

        {
            
            Actions.schoolSearchwithLaestab("8782446");
            SchoolDetailPage detailspage = new SchoolDetailPage();
            Assert.IsTrue(detailspage.School_Name.Displayed);
            Assert.AreEqual((detailspage.School_Name).Text, Driver.driver.FindElement(By.XPath("/html/body/div/main/h1")).Text);
            Assert.IsTrue(detailspage.Telephone_Number.Displayed);
            Assert.IsTrue(detailspage.OfstedRating.Displayed);
            Assert.IsTrue(detailspage.DataFromOtherSources.Displayed);
            Assert.IsTrue(detailspage.Services.Displayed);
            Assert.IsTrue(detailspage.DealsForSchools_Link.Displayed);

        }
        [Test]
        public void SearchSchool_closed_school()
        {
            
            Actions.SearchClosedschool("101405");
            SchoolDetailPage detailspage = new SchoolDetailPage();
            Assert.IsTrue(detailspage.Date_Of_Closure.Displayed);
            Assert.IsFalse(detailspage.CompareWithOtherSchools.Displayed);
           
            Assert.IsTrue(detailspage.DealsForSchools_Link.Displayed);

        }
        [Test]
        public void SearchSchool_closed_schoolWithLAESTAB()
        {

            Actions.SearchClosedschool("3032004");
            SchoolDetailPage detailspage = new SchoolDetailPage();
            Assert.IsTrue(detailspage.schooldetailnotfoundmessage.Text.Contains("We found no matches for"));
            
           

        }
        [Test]
        public void SearchSchool_closed_schoolWithURN()
        {

            Actions.SearchClosedschool("101405");
            SchoolDetailPage detailspage = new SchoolDetailPage();
            Assert.IsTrue(detailspage.schooldetailnotfoundmessage.Text.Contains("We found no matches for"));

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
        public void TestLinks()
        {
            Actions.CallingClass.TestLinks();

        }
        [Test]
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
        [Test]
        public void EditBasketAddSchools()
        {
            Actions.CallingClass.AddSchools();
            SchoolDetailPage detailspage = new SchoolDetailPage();
            Assert.AreEqual(detailspage.SchooldetailInfoPanel.Text, "2 schools");
        }
        [Test]
        public void EditBasketClearSchools()
        {
            
            Actions.CallingClass.ClearSchools();
            BenchMarkBasketPage basketpage = new BenchMarkBasketPage();
            Assert.That((basketpage.benchmarkbasketmessage.Text), Does.Contain("0"));
        }
        [Test]
        public void IsmapDisplayed()
        {
            Actions.CallingClass.SchoolMap();
            SchoolDetailPage detailspage = new SchoolDetailPage();
            Assert.IsTrue(detailspage.School_Location_Map.Displayed);

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
            Assert.That(Driver.driver.FindElement(By.CssSelector(".heading-xlarge")).Text, Does.Contain("Schools in and near"));
            Assert.AreEqual(Driver.driver.FindElement(By.CssSelector("#js-search-results-info > div > p > span")).Text, "109");
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
            Assert.That(Driver.driver.FindElement(By.CssSelector("dd.metadata-school-detail__dd:nth-child(14)")).Text, Does.Contain("Not rated"));

        }
        [Test]
        public void OnclickReportingTest()
        {
            Actions.OnclickReportingTest();
            Assert.That(Driver.driver.FindElement(By.CssSelector("#benchmarkBasket > div > div > div")).Text, Does.Contain("Your benchmark basket contains 15 schools "));

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
            //Assert.That(Driver.driver.FindElement(By.CssSelector("dd.metadata-school-detail__dd:nth-child(16)")).Text, Does.Contain("Not rated"));

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
        [Test]
        [Category("QuickTests")]
        public void test_School_DealsForSchools()

        {

            Actions.schoolSearchwithLaestab("8812035");
            SchoolDetailPage detailspage = new SchoolDetailPage();
            Assert.IsTrue(detailspage.DealsForSchools_Link.Displayed);
        }
        [Test]
        [Category("QuickTests")]
        public void test_School_OfstedRating()

        {

            Actions.schoolSearchwithLaestab("9362489");
            SchoolDetailPage detailspage = new SchoolDetailPage();
            Assert.IsTrue(detailspage.Telephone_Number.Displayed);

        }



        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}