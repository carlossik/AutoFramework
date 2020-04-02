


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

    //[Parallelizable]
    public class TrustSearchScenarios
    {


        public TrustSearchScenarios()
        {
        }

        [SetUp]
        public void SetupBeforeEachTest()



        {
            Actions.InitializeDriver("firefox");



        }


        [Test]

        public void TrustSearch()
        {
            TrustActions.TrustSearchWitNameUsingFirstSuggestedName("Kaleidoscope Learning Trust ");
            TrustComparisonPage trustcomparison = new TrustComparisonPage();
            string trustname = (trustcomparison.TrustName).Text;
            Assert.AreEqual(trustname, "Kaleidoscope Learning Trust");

        }
        [Test]
        public void TrustearchwithWrongname()
        {
            //todo
        }
        [Test]
        public void TrustSearchwithName()
        {
            TrustActions.TrustSearchWitNameUsingFirstSuggestedName("Brookvale Groby Learning Trust");
            TrustComparisonPage trustcomparison = new TrustComparisonPage();
            string trustname = (trustcomparison.TrustName).Text;
            Assert.AreEqual(trustname, "Brookvale Groby Learning Trust");

        }
        [Test]
        public void TrustSearchwithOneschoolinTrust()
        {
            Actions.SearchTrustViaLocalAuthority("303");
            TrustComparisonPage trustcomparison = new TrustComparisonPage();
            //select a Trust with only 1 school
            Driver.driver.FindElement(By.CssSelector("li.school-document:nth-child(3) > div:nth-child(1) > a:nth-child(1)")).Click();
            string nomatches = Driver.driver.FindElement(By.CssSelector(".heading-xlarge")).Text;
            Assert.IsTrue(nomatches == "Beths Grammer School");

            //Assert.IsFalse(nomatches;
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
            string Errormessage = Driver.driver.FindElement(By.ClassName("heading-xlarge")).Text;
            Assert.AreEqual(Errormessage, "We found no matches for \"8929778\"");
        }//We found no matches for \"8929777\"


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
            //TrustActions.TrustPerformanceLinksViaLacode("303");
            TrustActions.getCompanyNumber();

        
    
            

        }
        [Test]
        public void trustsearchViaLocation()
        {
            Actions.SearchTrustViaLocation();
            Console.WriteLine(Driver.driver.FindElement(By.CssSelector(".heading-xlarge")).Text);
           
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector(".heading-xlarge")).Text == "Academy trusts with schools operating in and near First Avenue, Bexleyheath, Kent");
            
        }
        [Test]
        public void trustsearchViaLA()
        {
            Actions.SearchTrustViaLocalAuthority("303");
            string numberOfSchools = Driver.driver.FindElement(By.CssSelector(".count-js")).Text;
            Console.WriteLine(Driver.driver.FindElement(By.CssSelector(".count-js")).Text);
            Assert.IsTrue(Convert.ToInt32(numberOfSchools) > 0);
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector(".heading-xlarge")).Text == "Academy trusts with schools operating in Bexley");
            //test company number links to gias 
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
            //Console.WriteLine(Driver.driver.FindElement(By.CssSelector("li.school-document:nth-child(1) > div:nth-child(1) > a:nth-child(1)")).Text);
            //Assert.IsTrue(Driver.driver.FindElement(By.CssSelector("li.school-document:nth-child(29) > div:nth-child(1) > a:nth-child(1)")).Text == "Woodland Academy Trust");
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
        //[Test]
        public void verifynumberofschoolsdisplayed()
        {
            Actions.SearchTrustViaLocalAuthority("303");
            SearchResultsPage resultsPage = new SearchResultsPage();
            Actions.selectFirstSchool();
            Console.WriteLine(resultsPage.elementList);
            Console.WriteLine(resultsPage.schoolsinlink);
            Assert.IsTrue(resultsPage.elementList == resultsPage.schoolsinlink);
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
            Actions.selectFirstSchool();
            string schooname = resultsPage.viewtrustschoolsFirstLink.Text;
            resultsPage.viewtrustschoolsFirstLink.Click();
            Thread.Sleep(1000);
            SchoolDetailPage detailpage = new SchoolDetailPage();
            Assert.IsTrue(detailpage.School_Name.Text == schooname);


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
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector("li.school-document:nth-child(1) > details:nth-child(3) > div:nth-child(2) > table:nth-child(1) > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(1) > a:nth-child(1)")).Text == "Hillsgrove Primary School");//verify that first school is in alphabetical order
            
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector("li.school-document:nth-child(1) > details:nth-child(3) > div:nth-child(2) > table:nth-child(1) > tbody:nth-child(2) > tr:nth-child(4) > td:nth-child(1) > a:nth-child(1)")).Text == "St Paulinus Church of England Primary School");//verify that last school is in alphabetical order
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
        public void SearchForTrustWithNameUsingFirstSuggested()
        {
            TrustActions.TrustSearchWitNameUsingFirstSuggestedName("5 Dimensions Trust");
            String TrustName = Driver.driver.FindElement(By.CssSelector(".heading-xlarge")).Text;
            Assert.AreEqual(TrustName, "5 Dimensions Trust");
            IWebElement CompareWithOtherTrustsButton = Driver.driver.FindElement(By.CssSelector(".page > div:nth-child(2) > div:nth-child(1) > a:nth-child(1)"));
            Assert.IsTrue(CompareWithOtherTrustsButton.Displayed);
            String CompaniesHouseNumber = Driver.driver.FindElement(By.CssSelector(".ml-05")).Text;
            Console.WriteLine(CompaniesHouseNumber);
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector(".ml-05")).Displayed);
            Assert.IsTrue((Driver.driver.Url) == ("https://as-t1dv-sfb.azurewebsites.net/trust/index?companyNo=" + CompaniesHouseNumber));
            Console.WriteLine(Driver.driver.Url);


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