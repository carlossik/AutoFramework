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




    // [Parallelizable]
    public class TrustSearchScenarios
    {

        IAlert alert;
        IWebDriver driver;


        [SetUp]

        public void SetupBeforeEachTest()

        {
            var testName = TestContext.CurrentContext.Test.FullName;
            Config.Credentials.deletefiles(@"C:\TEMP\" + testName + ".jpg");
            driver = Actions.InitializeDriver(1);



        }

        [Test]

        public void TrustSearch()
        {

            TrustActions.TrustSearchWitNameUsingFirstSuggestedName("Kaleidoscope Learning Trust ", driver);
            TrustComparisonPage trustcomparison = new TrustComparisonPage(driver);
            string trustname = (trustcomparison.TrustName).Text;
            string expectedName = driver.FindElement(By.TagName("h1")).Text;
            Assert.AreEqual(trustname, expectedName);
        }
        [Test]

        public void TrustearchwithWrongname()
        {
            //todo
        }
        [Test]

        public void TrustSearchwithName()
        {
            TrustActions.TrustSearchWitNameUsingFirstSuggestedName("Brookvale Groby Learning Trust", driver);
            TrustComparisonPage trustcomparison = new TrustComparisonPage(driver);
            string trustname = (trustcomparison.TrustName).Text;
            string expectedName = driver.FindElement(By.CssSelector("h1")).Text;
            Assert.AreEqual(trustname, expectedName);
        }
        [Test]

        public void TrustSearchwithOneschoolinTrust()
        {
            Actions.SearchTrustViaLocalAuthority("303", driver);
            TrustActions.identifyTrustsWithOneSchool(driver);
            //todo assertions
        }
        [Test]
        public void TrustSearchWithCompanyNumber()
        {
            Actions.TrustSearchWithCompanynumber("8929065", driver);
            TrustComparisonPage trustcomparison = new TrustComparisonPage(driver);
            string trustname = (trustcomparison.TrustName).Text;
            Assert.AreEqual(trustname, "Barnwell Academy Trust");
        }
        [Test]
        public void TrustSearchWithwrongcompanynumber()
        {
            Actions.TrustSearchWithCompanynumber("8929778", driver);
            TrustComparisonPage trustcomparison = new TrustComparisonPage(driver);
            string Errormessage = driver.FindElement(By.XPath("//a[contains(text(),\"We couldn't find any trusts matching your search c\")]")).Text;
            Assert.AreEqual(Errormessage, "We couldn't find any trusts matching your search criteria");
        }


        [Test]
        public void Trustcomparison()
        {
            TrustActions.ManualTrustComparison("Harvey Academy", driver);
            TrustBenchmarkChartsPage trustcharts = new TrustBenchmarkChartsPage(driver);
            Assert.IsTrue(trustcharts.BalanceTab.Displayed);
            Assert.IsTrue(trustcharts.ExpenditureTab.Displayed);
            Assert.IsTrue(trustcharts.IncomeTab.Displayed);
            Assert.IsTrue(trustcharts.ShowValueDropDown.Displayed);
            Assert.IsTrue(trustcharts.CentralFinancingDropdown.Displayed);
        }

        [Test]
        public void TrustcomparisonForNoDataSchool()
        {
            Actions.TrustSearchWithCompanynumber("8133360", driver);
            TrustComparisonPage trustcomparepage = new TrustComparisonPage(driver);
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
            TrustActions.TrustComparisonWithMultipleTrusts(driver);
            TrustBenchmarkChartsPage trustcharts = new TrustBenchmarkChartsPage(driver);
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

            TrustActions.getCompanyNumber(driver);
        }

        [Test]

        public void trustsearchViaLocation()
        {
            Actions.SearchTrustViaLocation(driver);
            Console.WriteLine(driver.FindElement(By.TagName("h1")).Text);
            Assert.AreEqual(driver.FindElement(By.CssSelector("h1")).Text, "Academy trusts with schools operating in and near First Avenue, Bexley, Bexleyheath, DA7, Kent");
        }
        [Test]
        public void trustsearchViaLA()
        {
            Actions.SearchTrustViaLocalAuthority("303", driver);
            string numberOfSchools = driver.FindElement(By.CssSelector(".count-js")).Text;
            Console.WriteLine(driver.FindElement(By.CssSelector(".count-js")).Text);
            Assert.IsTrue(Convert.ToInt32(numberOfSchools) > 0);
            Assert.IsTrue(driver.FindElement(By.TagName("h1")).Text == "Academy trusts with schools operating in Bexley");

        }
        [Test]
        public void verifyCompaniesHouseNumberOnTrustLASearchResults()
        {
            Actions.SearchTrustViaLocalAuthority("303", driver);
            Assert.IsTrue(driver.FindElement(By.CssSelector("li.school-document:nth-child(1) > div:nth-child(2) > div:nth-child(1) > a:nth-child(1)")).Displayed);
        }
        [Test]
        public void verifySortedByDistanceAtoZ()
        {
            Actions.ResultPageactionsA_Z("303", "alphabetical a-z", driver);
            SearchResultsPage resultsPage = new SearchResultsPage(driver);
            Assert.AreEqual(driver.FindElement(By.CssSelector("li.school-document:nth-child(1) > div:nth-child(1) > a:nth-child(1)")).Text, "Academies Enterprise Trust");
            //Console.WriteLine(resultsPage.FirstElementPresented.Text);

        }
        [Test]
        public void verifySortedByDistanceZtoA()
        {
            Actions.ResultPageactions("303", "alphabetical z-a", driver);
            Assert.IsTrue(driver.FindElement(By.CssSelector("li.school-document:nth-child(1) > div:nth-child(1) > a:nth-child(1)")).Text == "Unity Academy Trust");
            //Assert.IsTrue(driver.FindElement(By.CssSelector("li.school-document:nth-child(29) > div:nth-child(1) > a:nth-child(1)")).Text == "Academies Enterprise Trust");
        }
        [Test]
        public void verifySortedByNumOfSchoolsInArea()
        {
            Actions.ResultPageactions("303", "number of schools in search area", driver);
        }
        [Test]
        public void verifySortedByNumOfSchholEduTrust()
        {
            Actions.ResultPageactions("303", "number of schools in academy trust", driver);
            string numberinfirstSchool = driver.FindElement(By.CssSelector("li.school-document:nth-child(1) > div:nth-child(2) > div:nth-child(2) > span:nth-child(1)")).Text;
            string numberinSecondSchool = driver.FindElement(By.CssSelector("li.school-document:nth-child(2) > div:nth-child(2) > div:nth-child(2) > span:nth-child(1)")).Text;
            Console.WriteLine(numberinfirstSchool);
            Console.WriteLine(numberinSecondSchool);
            Console.WriteLine(driver.FindElement(By.CssSelector(".count-js")).Text);
            Assert.IsTrue(Convert.ToInt32(numberinfirstSchool) > Convert.ToInt32(numberinSecondSchool));
        }
        [Test]
        public void verifynumberofschoolsdisplayed()
        {
            Actions.SearchTrustViaLocalAuthority("303", driver);
            SearchResultsPage resultsPage = new SearchResultsPage(driver);
            //Actions.selectFirstSchool();

            Console.WriteLine("These are the results counted " + resultsPage.numberofschoolsdisplayedTrusts(driver));
            int final_results = resultsPage.numberofschoolsdisplayedTrusts(driver);
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
        [Ignore("Ignore a test")]
        public void verifyviewTrustSchoolsLinks()
        {
            Actions.SearchTrustViaLocalAuthority("890", driver);
            SearchResultsPage resultsPage = new SearchResultsPage(driver);
            Actions.selectFirstSchoolInTrusts(driver);
            string schooname = resultsPage.viewtrustschoolsFirstLink.Text;
            resultsPage.viewtrustschoolsFirstLink.Click();
            Thread.Sleep(1000);
            SchoolDetailPage detailpage = new SchoolDetailPage(driver);
            Assert.IsTrue(detailpage.School_Name.Text == schooname);
        }
        [Test]
        [Ignore("Ignore a test")]
        public void verifyTrustBelongsToLink()
        {
            Actions.SearchTrustViaLocalAuthority("890", driver);
            SearchResultsPage resultsPage = new SearchResultsPage(driver);
            Actions.selectFirstSchoolInTrusts(driver);
            string schooname = resultsPage.viewtrustschoolsFirstLink.Text;
            resultsPage.viewtrustschoolsFirstLink.Click();
            Thread.Sleep(1000);

        }

        [Test]
        [Ignore("Ignore a test")]

        public void verifyMATHistoricalTabs()
        {
            Actions.TrustSearchWithCompanynumber("7554121", driver);//must be a MAT
            TrustHomePage thome = new TrustHomePage(driver);
            Assert.IsTrue(thome.SchoolsCurrentlyInTrustTab.Displayed);
            Assert.IsTrue(thome.SchoolsIn1819SubmissionTab.Displayed);
            Assert.IsTrue(thome.TrustHistoryTab.Displayed);

        }
        [Test]
        public void verifynumberOfSchoolsInTrust()
        {
            Actions.TrustSearchWithCompanynumber("8084557", driver);//must be a MAT
            TrustActions tactions = new TrustActions();
            TrustHomePage thome = new TrustHomePage(driver);
            //Assert.AreEqual(tactions.calculateNumberOfSchoolsInMat(driver), thome.NumberOfSchools1819.Text);

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

            Actions.ViewSchoolsInTrust(driver);
            SearchResultsPage resultspage = new SearchResultsPage(driver);
            resultspage.TrustSearchResultSortedByButton.Click();
            resultspage.TrustSearchResultSortedByButton.SendKeys("alphabetical a-z" + Keys.Enter);
            Thread.Sleep(2000);
            IList<IWebElement> schoolList = driver.FindElements(By.XPath("//a[contains(@href,\"/trust/index?companyNo=\")]")); // note the FindElements, plural.
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
            Actions.verifyTrustIsOpen(driver);
        }
        [Test]
        public void SearchForTrustWithNameandSubmitButton()
        {
            TrustActions.TrustSearchWitNameUsingSubmitButton("5 Dimensions Trust", driver);
            String TrustName = driver.FindElement(By.CssSelector("h1.govuk-heading-xl")).Text;
            Assert.IsTrue(TrustName.Contains("5 Dimensions Trust"));

        }
        [Test]
        public void VerifyTrustPageDetails()
        {
            TrustActions.TrustSearchWitNameUsingFirstSuggestedName("Anthem Schools Trust", driver);
            Thread.Sleep(2000);
            TrustHomePage trusthome = new TrustHomePage(driver);
            Console.WriteLine("This is The CompaniesHouse Number " + "" + trusthome.CompaniesHouseNumber.Text + "for " + trusthome.TrustName.Text);
            Assert.IsTrue(trusthome.CompareWithOtherTrustsButton.Displayed);
            trusthome.TrustDetailsTab.Click();
            Assert.IsTrue(trusthome.CompaniesHouseNumber.Displayed);
        }

        [Test]
        //[Ignore("Ignore a test")]
        public void VerifyElementsOnDashboard()
        {
            TrustActions.TrustSearchWitNameUsingSubmitButton("9809895", driver);
            TrustActions.verifyTrustDashboardLinks(driver);




        }

        [Test]
        public void CompareTrustViaCharacteristics()
        {
            TrustActions.SelectCharacteristicsToFindTrusts(" 5 Dimensions Trust", driver);
        }

        [Test]
        [Ignore("Ignore a test")]
        public void SearchForTrustWithNameUsingFirstSuggested()
        {
            TrustActions.TrustSearchWitNameUsingFirstSuggestedName("5 Dimensions Trust", driver);
            String TrustName = driver.FindElement(By.CssSelector("h1.govuk-heading-xl")).Text;
            Assert.AreEqual(TrustName, "5 Dimensions Trust");
            IWebElement CompareWithOtherTrustsButton = driver.FindElement(By.PartialLinkText("Start a comparis"));
            Assert.IsTrue(CompareWithOtherTrustsButton.Displayed);
            String CompaniesHouseNumber = driver.FindElement(By.XPath("//dd[1]")).Text;
            Console.WriteLine(CompaniesHouseNumber);
            Console.WriteLine(driver.Url);
            Console.WriteLine(Config.currentTestEnv + "Trust?companyNo=" + CompaniesHouseNumber);
            Assert.IsTrue(driver.FindElement(By.XPath("//dd[1]")).Displayed);
            Assert.IsTrue((driver.Url) == (Config.currentTestEnv + "Trust?companyNo=" + CompaniesHouseNumber));

            //https://as-t1stg-sfb.azurewebsites.net/Trust?companyNo=

        }
        [Test]
        public void SelectSchoolsToCompare()
        {
            TrustActions.ManualTrustComparison("5 Dimensions Trust", driver);
            //TrustActions.TrustSearchWitNameUsingFirstSuggestedName("5 Dimensions Trust");
            TrustHomePage trusthome = new TrustHomePage(driver);
        }

        [Test]
        public void verify_School_in_SAT()
        {

            Actions.schoolSearchwithLaestab("137427", driver);

            SchoolDetailPage detailpage = new SchoolDetailPage(driver);
            Assert.IsTrue(detailpage.CurrentTrustLinkDisplayed.Displayed);
            detailpage.SchoolPageFinanceTab.Click();
            Thread.Sleep(2000);
            Assert.IsTrue(detailpage.FinanceDropdown_Trust_Only.Displayed);

        }

        [Test]
        public void verify_School_MovedTo_MAT_From_SAT()
        {
            Actions.schoolSearchwithLaestab("135587", driver);
            SchoolDetailPage detailpage = new SchoolDetailPage(driver);
            Assert.IsTrue(detailpage.CurrentTrustLinkDisplayed.Displayed);
        }
        [Test]
        public void verify_School_movedFrom_MAT_To_SAT()
        {
            Actions.schoolSearchwithLaestab("137353", driver);
            SchoolDetailPage detailpage = new SchoolDetailPage(driver);

            IWebElement SATstatement = detailpage.trustText;
            Assert.IsTrue(SATstatement.Text == "Single academy trust");

        }

        [Test]
        [Ignore("This test requires example school which we dont have")]
        public void verify_School_MovedFrom_MAT_Tonew_MAT()
        {
            throw new NotImplementedException();// now test school identified for the test
            Actions.schoolSearchwithLaestab("137427", driver);

            SchoolDetailPage detailpage = new SchoolDetailPage(driver);
            Assert.IsTrue(detailpage.FinanceDropdown_Trust_Only.Displayed);
        }
        [Test]
        public void verifyTrustlinkWithCompanyNumber()
        {
            Actions.schoolSearchwithLaestab("137353", driver);
            SchoolDetailPage detailpage = new SchoolDetailPage(driver);
            Assert.IsTrue((detailpage.istrusttextDisplayed()));
            //Assert.IsTrue(detailpage.MatFinanceToggle.Displayed);
        }

        [Test]
        public void verifyTrustlinkWithUID()
        {
            Actions.schoolSearchwithLaestab("3032073", driver);
            SchoolDetailPage detailpage = new SchoolDetailPage(driver);
            Assert.IsTrue(detailpage.istrusttextDisplayed());
            // Assert.IsTrue(detailpage.MatFinanceToggle.Displayed);
        }


        [Test]
        [Ignore("This test requires example school which we dont have")]
        public void verifyTrustPre_post16_Funding()
        {
            Actions.verifyTrustPrePost16Value(driver);
            var prepost16Funding = driver.FindElement(By.CssSelector("#table_for_chart_35001 > div:nth-child(1) > table:nth-child(1) > tbody:nth-child(3) > tr:nth-child(5) > td:nth-child(2)"));
            Console.WriteLine(prepost16Funding.Text);
            var finalvalue = prepost16Funding.Text;//.Replace("£", "").Replace("m", "");
            Console.WriteLine("This is the Final Value " + finalvalue);
        }

        [Test]
        public void MAT_with_1_or_moreSchls()
        {
            TrustActions.TrustCompareWithComPanyNum("5112090", driver);
            Assert.IsTrue(driver.FindElement(By.XPath("//h1[contains(text(),'What type of comparison would you like?')]")).Displayed);


        }

        [Test]
        public void MAT_with_0or_Schls()
        {
            TrustActions.TrustCompareWithComPanyNum("9702333", driver);
            Assert.IsTrue(driver.FindElement(By.XPath("//h1[contains(text(),'Select comparison type')]")).Displayed);
        }
        [Test]
        public void VerifyLinksToOtherServices()
        {
            URNHelper helpers = new URNHelper();
            IList urns = helpers.trustsUrns;
            IList<string> FailingTrusts = new List<string>();
            foreach (string urn in urns)
            {
                try
                {
                        var Trusturl = Config.currentTestEnv + "Trust/Detail?companyNo=" + urn;
                        driver.Navigate().GoToUrl(Trusturl);
                         TrustHomePage TrustHome = new TrustHomePage(driver);
                          TrustHome.TrustDashboardTab.Click();
                          Assert.IsTrue(driver.FindElement(By.XPath("//h3[contains(text(),'Related services')]")).Displayed);
                           Assert.IsTrue(driver.FindElement(By.LinkText("Find and compare schools in England")).Displayed);
                           Assert.IsTrue(driver.FindElement(By.LinkText("Get information about schools")).Displayed);
                           Assert.IsTrue(driver.FindElement(By.LinkText("Statistics at DfE")).Displayed);
                           Assert.IsTrue(driver.FindElement(By.LinkText("Explore education statistics")).Displayed);
                            TrustHome.TrustDetailsTab.Click();
                             Assert.IsTrue(driver.FindElement(By.XPath("//dt[contains(text(),\"View this trust's data on other services:\")]")).Displayed);               

                }
                catch (NoSuchElementException e)

                {
                    continue;
                }

            }
            if (FailingTrusts.Count == 0)
            {
                Assert.Pass();
            }
            else
            {
                Console.WriteLine("These schools Failed the test" + (FailingTrusts));
                Assert.Fail();
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
               driver.Close();
                driver.Quit();

                foreach (var process in System.Diagnostics.Process.GetProcessesByName("geckodriver"))
                {
                    process.Kill();
                }
            }
            driver.Close();
            driver.Quit();
        }
    }
}
