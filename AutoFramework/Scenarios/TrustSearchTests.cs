namespace AutoFramework
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using SFB_Test_Automation.AutoFramework.Pages;
    using AutoFramework.Pages;
    using AutoFramework.Pages.PageElements;
    using System;
    using System.Threading;
    using NUnit.Framework.Interfaces;
    using System.Collections.Generic;
    using System.Collections;
    using SFB_Test_Automation.AutoFramework.vs.AutoFramework.Helpers;
    using SFB_Test_Automation;

    public class TrustSearchScenarios :TestBase
    {


        public TrustSearchScenarios()
        {
        }

        [SetUp]
        public void SetupBeforeEachTest(string browsername)

        {
 
        Actions.InitializeDriver(Config.DriverUnderTest1);
        }

        [Test]
        //[TestCaseSource(typeof(Driver), "BrowserToRunWith")]
        public void TrustSearch(String browsername)
        {
            SetupBeforeEachTest(browsername);
            TrustActions.TrustSearchWitNameUsingFirstSuggestedName("Kaleidoscope Learning Trust ");
            TrustComparisonPage trustcomparison = new TrustComparisonPage();
            string trustname = (trustcomparison.TrustName).Text;
            string expectedName = Driver.driver.FindElement(By.CssSelector(".heading-xlarge")).Text;
            Assert.AreEqual(trustname, expectedName);
        }
        [Test]
        //[TestCaseSource(typeof(Driver), "BrowserToRunWith")]
        public void TrustearchwithWrongname()
        {
            //todo
        }
        [Test]
        //[TestCaseSource(typeof(Driver), "BrowserToRunWith")]
        public void TrustSearchwithName()
        {
            TrustActions.TrustSearchWitNameUsingFirstSuggestedName("Brookvale Groby Learning Trust");
            TrustComparisonPage trustcomparison = new TrustComparisonPage();
            string trustname = (trustcomparison.TrustName).Text;
            string expectedName = Driver.driver.FindElement(By.CssSelector(".heading-xlarge")).Text;
            Assert.AreEqual(trustname, expectedName);
        }
        [Test]
        //[TestCaseSource(typeof(Driver), "BrowserToRunWith")]
        public void TrustSearchwithOneschoolinTrust()
        {
            Actions.SearchTrustViaLocalAuthority("303");
            TrustActions.identifyTrustsWithOneSchool();
            //todo assertions
        }
        [Test]
        public void TrustSearchWithCompanyNumber()
        {
            Actions.TrustSearchWithCompanynumber("8929065");
            TrustComparisonPage trustcomparison = new TrustComparisonPage();
            string trustname = (trustcomparison.TrustName).Text;
            Assert.AreEqual(trustname, "Barnwell Academy Trust");
        }
        [Test]
        public void TrustSearchWithwrongcompanynumber()
        {
            Actions.TrustSearchWithCompanynumber("8929778");
            TrustComparisonPage trustcomparison = new TrustComparisonPage();
            string Errormessage = Driver.driver.FindElement(By.ClassName("error-message")).Text;
            Assert.AreEqual(Errormessage, "We couldn't find any trusts matching your search criteria");
        }


        [Test]
        public void Trustcomparison()
        {
            Actions.TrustComparison("Harvey Academy");
            TrustBenchmarkChartsPage trustcharts = new TrustBenchmarkChartsPage();
            Assert.IsTrue(trustcharts.BalanceTab.Displayed);
            Assert.IsTrue(trustcharts.ExpenditureTab.Displayed);
            Assert.IsTrue(trustcharts.IncomeTab.Displayed);
            Assert.IsTrue(trustcharts.ShowValueDropDown.Displayed);
            Assert.IsTrue(trustcharts.CentralFinancingDropdown.Displayed);
        }

        [Test]
        public void TrustcomparisonForNoDataSchool()
        {
            Actions.TrustSearchWithCompanynumber("8133360");
            TrustComparisonPage trustcomparepage = new TrustComparisonPage();
            try
            {
                Assert.IsTrue(trustcomparepage.Compare_withOtherTrusts.Displayed);

            }
            catch (NoSuchElementException)
            {

            }



        }

        [Test]
        public void Trustcomparisonwithmorethan25schools()
        {
            TrustActions.TrustComparisonWithMultipleTrusts();
            TrustBenchmarkChartsPage trustcharts = new TrustBenchmarkChartsPage();
            Assert.IsTrue(trustcharts.BalanceTab.Displayed);
            Assert.IsTrue(trustcharts.ExpenditureTab.Displayed);
            Assert.IsTrue(trustcharts.IncomeTab.Displayed);
            Assert.IsTrue(trustcharts.ShowValueDropDown.Displayed);
            Assert.IsTrue(trustcharts.CentralFinancingDropdown.Displayed);

        }
        [Test]
        public void trustcompanylink()
        {
            //test company number links to gias 
        }

        [Test]
        public void TrustPerformanceLink()
        {
            
            TrustActions.getCompanyNumber();
        }
        [Test]
        public void trustsearchViaLocation()
        {
            Actions.SearchTrustViaLocation();
            Console.WriteLine(Driver.driver.FindElement(By.CssSelector(".heading-xlarge")).Text);
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector(".heading-xlarge")).Text == "Academy trusts with schools operating in and near First Avenue, Welling, Kent");
        }
        [Test]
        public void trustsearchViaLA()
        {
            Actions.SearchTrustViaLocalAuthority("303");
            string numberOfSchools = Driver.driver.FindElement(By.CssSelector(".count-js")).Text;
            Console.WriteLine(Driver.driver.FindElement(By.CssSelector(".count-js")).Text);
            Assert.IsTrue(Convert.ToInt32(numberOfSchools) > 0);
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector(".heading-xlarge")).Text == "Academy trusts with schools operating in Bexley");
            
        }
        [Test]
        public void verifyCompaniesHouseNumberOnTrustLASearchResults()
        {
            Actions.SearchTrustViaLocalAuthority("303");
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector("li.school-document:nth-child(1) > div:nth-child(2) > div:nth-child(1) > a:nth-child(1)")).Displayed);
        }
        [Test]
        public void verifySortedByDistanceAtoZ()
        {
            Actions.ResultPageactionsA_Z("303", "alphabetical a-z");
            SearchResultsPage resultsPage = new SearchResultsPage();
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector("li.school-document:nth-child(1) > div:nth-child(1) > a:nth-child(1)")).Text == "Academies Enterprise Trust");
            Console.WriteLine(resultsPage.FirstElementPresented.Text);
           
        }
        [Test]
        public void verifySortedByDistanceZtoA()
        {
            Actions.ResultPageactions("303", "alphabetical z-a");
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector("li.school-document:nth-child(1) > div:nth-child(1) > a:nth-child(1)")).Text == "Unity Academy Trust");
            //Assert.IsTrue(Driver.driver.FindElement(By.CssSelector("li.school-document:nth-child(29) > div:nth-child(1) > a:nth-child(1)")).Text == "Academies Enterprise Trust");
        }
        [Test]
        public void verifySortedByNumOfSchoolsInArea()
        {
            Actions.ResultPageactions("303", "number of schools in search area");
        }
        [Test]
        public void verifySortedByNumOfSchholEduTrust()
        {
            Actions.ResultPageactions("303", "number of schools in academy trust");
            string numberinfirstSchool = Driver.driver.FindElement(By.CssSelector("li.school-document:nth-child(1) > div:nth-child(2) > div:nth-child(2) > span:nth-child(1)")).Text;
            string numberinSecondSchool = Driver.driver.FindElement(By.CssSelector("li.school-document:nth-child(2) > div:nth-child(2) > div:nth-child(2) > span:nth-child(1)")).Text;
            Console.WriteLine(numberinfirstSchool);
            Console.WriteLine(numberinSecondSchool);
            Console.WriteLine(Driver.driver.FindElement(By.CssSelector(".count-js")).Text);
            Assert.IsTrue(Convert.ToInt32(numberinfirstSchool) > Convert.ToInt32(numberinSecondSchool));
        }
        [Test]
        public void verifynumberofschoolsdisplayed()
        {
            Actions.SearchTrustViaLocalAuthority("303");
            SearchResultsPage resultsPage = new SearchResultsPage();
            //Actions.selectFirstSchool();
            
            Console.WriteLine("These are the results counted " + resultsPage.ResultsfromLinksCount);
            int final_results = (resultsPage.ResultsfromLinksCount);
            Console.WriteLine("These are the results displayed " + (resultsPage.Allresultsdisplayed.Text));
            Assert.IsTrue((resultsPage.Allresultsdisplayed.Text) == (final_results.ToString()));
        }
        [Test]
        [Ignore("Ignore a test")]
        public void verifyInsideSearchArea()
        {
            throw new NotImplementedException();

        }
        [Test]
        [Ignore("Ignore a test")]
        public void verifyOutSideSearchArea()
        {

            throw new NotImplementedException();
        }
        [Test]
        public void verifyviewTrustSchoolsLinks()
        {
            Actions.SearchTrustViaLocalAuthority("890");
            SearchResultsPage resultsPage = new SearchResultsPage();
            Actions.selectFirstSchoolInTrusts();
            string schooname = resultsPage.viewtrustschoolsFirstLink.Text;
            resultsPage.viewtrustschoolsFirstLink.Click();
            Thread.Sleep(1000);
            SchoolDetailPage detailpage = new SchoolDetailPage();
            Assert.IsTrue(detailpage.School_Name.Text == schooname);
        }
        [Test]
        public void verifyTrustBelongsToLink()
        {
            Actions.SearchTrustViaLocalAuthority("890");
            SearchResultsPage resultsPage = new SearchResultsPage();
            Actions.selectFirstSchoolInTrusts();
            string schooname = resultsPage.viewtrustschoolsFirstLink.Text;
            resultsPage.viewtrustschoolsFirstLink.Click();
            Thread.Sleep(1000);

        }

        [Test]
        [Ignore("Ignore a test")]
        public void verifycompaniesHouseNumberCorrect()
        {
            throw new NotImplementedException();

        }
        [Test]
        [Ignore("Ignore a test")]
        public void CopyAndPasteTrustChart()
        {
            throw new NotImplementedException();

        }

        [Test]
        public void verifyTrustsListedInAlphabeticalOrder()
        {

            Actions.ViewSchoolsInTrust();
            SearchResultsPage resultspage = new SearchResultsPage();
            resultspage.TrustSearchResultSortedByButton.Click();
            resultspage.TrustSearchResultSortedByButton.SendKeys("alphabetical a-z" + Keys.Enter);
            Thread.Sleep(2000);
            IList<IWebElement> schoolList = Driver.driver.FindElements(By.XPath("//a[contains(@href,\"/trust/index?companyNo=\")]")); // note the FindElements, plural.
            List<string> validations = new List<string>();
            foreach (IWebElement element in schoolList)
            {
                Console.WriteLine(element.Text);
                validations.Add(element.Text);
            }
            Console.WriteLine(validations);
        }

        [Test]
        public void verifyTrustsListedSchoolsAreAllOpen()
        {
            Actions.verifyTrustIsOpen();
        }
        [Test]
        public void SearchForTrustWithNameandSubmitButton()
        {
            TrustActions.TrustSearchWitNameUsingSubmitButton("5 Dimensions Trust");
            String TrustName = Driver.driver.FindElement(By.CssSelector(".heading-xlarge")).Text;
            Assert.IsTrue(TrustName.Contains("5 Dimensions Trust"));
            IWebElement ViewOnMapButton = Driver.driver.FindElement(By.CssSelector("div.litem:nth-child(1) > button:nth-child(1)"));
            Assert.IsTrue(ViewOnMapButton.Displayed);
            String NumberOfTrustsFoundText = Driver.driver.FindElement(By.CssSelector("p.summary")).Text;
            IWebElement NumberOfTrustsFoundMessage = Driver.driver.FindElement(By.CssSelector("p.summary"));
            Assert.IsTrue(NumberOfTrustsFoundMessage.Displayed);
            Assert.AreEqual(NumberOfTrustsFoundText, "1 academy trusts found");

        }
        [Test]
        public void VerifyTrustPageDetails()
        {
                    TrustActions.TrustSearchWitNameUsingFirstSuggestedName("Anthem Schools Trust");
                    Thread.Sleep(2000);
                    TrustHomePage trusthome = new TrustHomePage();
                    Console.WriteLine("This is The CompaniesHouse Number " + "" + trusthome.CompaniesHouseNumber.Text + "for " + trusthome.TrustName.Text);
                    Assert.IsTrue(trusthome.CompareWithOtherTrustsButton.Displayed);
                    Assert.IsTrue(trusthome.CompaniesHouseNumber.Displayed);
        }

        [Test]
        public void SearchForTrustWithNameUsingFirstSuggested()
        {
            TrustActions.TrustSearchWitNameUsingFirstSuggestedName("5 Dimensions Trust");
            String TrustName = Driver.driver.FindElement(By.CssSelector(".heading-xlarge")).Text;
            Assert.AreEqual(TrustName, "5 Dimensions Trust");
            IWebElement CompareWithOtherTrustsButton = Driver.driver.FindElement(By.CssSelector(".page > div:nth-child(2) > div:nth-child(1) > a:nth-child(1)"));
            Assert.IsTrue(CompareWithOtherTrustsButton.Displayed);
            String CompaniesHouseNumber = Driver.driver.FindElement(By.CssSelector(".ml-05")).Text;
            Console.WriteLine(CompaniesHouseNumber);
            Console.WriteLine(Driver.driver.Url);
            Console.WriteLine((Config.currentTestEnv + "/trust/index?companyNo=" + CompaniesHouseNumber));
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector(".ml-05")).Displayed);
            Assert.IsTrue((Driver.driver.Url) == (Config.currentTestEnv +"trust/index?companyNo="+CompaniesHouseNumber));
           


        }
        [Test]
        public void SelectSchoolsToCompare()
        {
            TrustActions.TrustSearchWitNameUsingFirstSuggestedName("5 Dimensions Trust");
            TrustHomePage trusthome = new TrustHomePage();
            trusthome.SelectSchoolsToCompareLink.Click();
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
