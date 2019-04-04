namespace AutoFramework
{
    using AutoFramework.Pages.PageElements;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using Pages;
    using SFB_Test_Automation.AutoFramework.Pages;
    using SFB_Test_Automation.AutoFramework.vs.AutoFramework.Helpers;
    using System.Collections.Generic;
    using System.Threading;

    public static class Actions
    {
        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
            Driver.driver.Manage().Window.Maximize();
            Driver.WaitForElementUpTo(Config.ElementsWaitingTimeout);
        }
        public static void GoHome()
        {
            //string url = null;
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
        }

        public static void FillLoginForm()

        {
            LoginScenarioPost loginScenario = new LoginScenarioPost();

            loginScenario.UsernameField.Clear();
            loginScenario.UsernameField.SendKeys("internal");
            loginScenario.PasswordField.Clear();
            loginScenario.PasswordField.SendKeys("sfb_19twspssc03");
            loginScenario.LoginButton.Click();
        }

        public static void SearchSchool()

        {
            HomePage homepage = new HomePage();
            GoHome();
            homepage.School.Click();
            homepage.SchoolsearchField.SendKeys("143811");
            homepage.ClickOnSearchButton();
            Thread.Sleep(3000);


        }
        public static void SearchSchool2()

        {
            HomePage homepage = new HomePage();
            GoHome();
            homepage.School.Click();
            homepage.SchoolsearchField.SendKeys("100000");
            homepage.ClickOnSearchButton();
            Thread.Sleep(3000);


        }
        public static void GetSearchText()
        {
            SearchResultsPage searchresults = new SearchResultsPage();
            var results = searchresults.SchooSearchResults.Text;
            return;
        }
        public static void TrustSearch()
        {
            HomePage homepage = new HomePage();
            homepage.TrustTickBox.Click();
            homepage.TrustSearchInput.SendKeys("Lewisham");
        }
        public static void TrustSearchWithTrustnumber()
        {
            HomePage homepage = new HomePage();
            homepage.TrustTickBox.Click();
            homepage.TrustSearchInput.SendKeys("8929065");
            Thread.Sleep(5000);
            homepage.TrustSubmit.Click();
            Thread.Sleep(5000);
        }
        public static void SearchByLocation()
        {
            HomePage homepage = new HomePage();
            GoHome();
            homepage.LocationButton.Click();
            //homepage.UseLocationLink.Click();
            Thread.Sleep(100);
            homepage.SearchByLocationField.Click();
            homepage.SearchByLocationField.Clear();
            homepage.SearchByLocationField.SendKeys(Config.Credentials.PostCode.Postcode);
            Thread.Sleep(2000);
            homepage.LocationSearchSubmitButton.Click();
            Driver.driver.FindElement(By.CssSelector("li.document:nth-child(1) > a:nth-child(1)")).Click();
            Thread.Sleep(2000);

        }
        public static void FillBasket()
        {

        }
        public static void TrustComparison()
        {
            TrustSearchWithTrustnumber();
            TrustComparisonPage trustComaprison = new TrustComparisonPage();
            Thread.Sleep(2000);
            trustComaprison.Compare_withOtherTrusts.Click();

        }
        

        public class CallingClass // This will have to be refactored in future when tests are stable
        {

            UrnHelper myUrns = new UrnHelper();

            public void GetList()
            {
                List<string> calledList = myUrns.GetList();
                ///More code here...
                int count = 0;
                foreach (string urn in calledList)
                {
                    HomePage homepage = new HomePage();
                    GoHome();
                    homepage.School.Click();
                    homepage.SchoolsearchField.SendKeys(urn);
                    homepage.ClickOnSearchButton();
                    SchoolDetailPage Schooldetails = new SchoolDetailPage();
                    Schooldetails.AddToBenchMarkBasket.Click();
                    //Thread.Sleep(3000);
                }

            }
            public static void SearchByLaCode()
            {
                HomePage homepage = new HomePage();
                GoHome();
                homepage.LcalAuthoritySearchButton.Click();
                homepage.LacodeInputField.Click();
                homepage.LacodeInputField.Clear();
                homepage.LacodeInputField.SendKeys("GreenWich");
                homepage.LacodeSearchButton.Click();

            }
            public static void TestLinks()
            {

                SpecialElementsPage links = new SpecialElementsPage();
                GoHome();
                //links.HomeLink.Click();
                links.HelpUsingSiteLink.Click();
                links.HomeLink.Click();
                //Driver.driver.Navigate().Back();
                links.DataSources.Click();
                links.HomeLink.Click();
                //Driver.driver.Navigate().Back();
                links.IntepreTingTheChartsLinks.Click();
                links.HomeLink.Click();
            }
            public static void AcceptAlert()
            {
                IAlert alert = Driver.driver.SwitchTo().Alert();
                alert.Accept();
            }
            public static void Verifybasket()
            {
                SearchSchool();
                SchoolDetailPage Schooldetails = new SchoolDetailPage();
                Schooldetails.AddToBenchMarkBasket.Click();
                //Schooldetails.BenchmarkBasket.Click();
                Thread.Sleep(3000);
                SpecialElementsPage specialElements = new SpecialElementsPage();
                specialElements.HomeLink.Click();
            }
            public static void SearchViaSchool()
            {
                HomePage homepage = new HomePage();
                Actions.GoHome();
                homepage.School.Click();
                homepage.SchoolsearchField.SendKeys("100000");
                homepage.ClickOnSearchButton();
                Thread.Sleep(2000);
            }
            public static void QuickCompareWithOtherSchools()
            {
                SearchViaSchool();
                SchoolDetailPage detailspage = new SchoolDetailPage();
                detailspage.CompareWithOtherSchools.Click();
                BestInClass bestinclass = new BestInClass();
                Thread.Sleep(2000);
                bestinclass.QuckComparisonButton.Click();
                bestinclass.NextButton.Click();
                bestinclass.DefaultChoice.Click();
                bestinclass.NextButton.Click();
                bestinclass.MaintainedSchoolsChoice.Click();
                bestinclass.NextButton.Click();
                Thread.Sleep(1000);

            }
            public static void ContinuetoBenchmarkCharts()
            {
                BestInClass bestinclass = new BestInClass();
                bestinclass.ContinueToBenchMarkChartsBurtton.Click();
                Thread.Sleep(3000);
            }

            public static void BestInClassComparison()
            {
                SearchViaSchool();
                SchoolDetailPage detailspage = new SchoolDetailPage();
                detailspage.CompareWithOtherSchools.Click();
                BestInClass bestinclass = new BestInClass();
                bestinclass.BestInClassComparisonButton.Click();
                bestinclass.ContinueToHigherProgressSchoolBenchmark.Click();
                Thread.Sleep(5000);//should be removed once stable
                bestinclass.NextButton.Click();
                Thread.Sleep(50000);//to be removed
            }
            public static void SchoohSearchOfstedRating()
            {
                SearchViaSchool();
                SchoolDetailPage detailspage = new SchoolDetailPage();
                //detailspage.OfstedRating.Text();

                //Thread.Sleep(5000);//should be removed once stable

                Thread.Sleep(5000);//to be removed
            }
            public static void SchoolMap()
            {
                SearchViaSchool();
                SchoolDetailPage detailspage = new SchoolDetailPage();
                Assert.IsTrue(detailspage.School_Location_Map.Displayed);

            }
            public static void ViewBenchMarkChartsButton()
            {
                SearchSchool();
                SchoolDetailPage Schooldetails = new SchoolDetailPage();
                Schooldetails.AddToBenchMarkBasket.Click();

            }

            public static void IsButtonPresent()

            {
                SchoolDetailPage Schooldetails = new SchoolDetailPage();
                SearchSchool();
                Schooldetails.AddToBenchMarkBasket.Click();
                SearchSchool2();
                Schooldetails.AddToBenchMarkBasket.Click();
                Thread.Sleep(3000);
                Schooldetails.ViewBenchMarkCharts.Click();

            }

            public static void InterpretingTheChartsTest()
            {
                SpecialElementsPage links = new SpecialElementsPage();
                GoHome();
                links.IntepreTingTheChartsLinks.Click();

            }


        }
    }
}
       

