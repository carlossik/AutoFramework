﻿namespace AutoFramework
{
    using AutoFramework.Pages.PageElements;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using Pages;
    using SFB_Test_Automation.AutoFramework.Pages;
    using SFB_Test_Automation.AutoFramework.vs.AutoFramework.Helpers;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.IE;
    using System;

    public static class Actions
    {
       
        
        public static void InitializeDriver()
        {

           



            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Config.currentTestEnv);
            Driver.driver.Manage().Window.Maximize();
            //Driver.driver.Manage().Cookies.DeleteAllCookies();
            Driver.WaitForElementUpTo(Config.ElementsWaitingTimeout);
        }

       

        public static void GoHome()
        {
            
            
            Driver.driver.Navigate().GoToUrl(Config.currentTestEnv);
        }
        public static void  OnclickReportingTest()
        {
            GoHome();
            CallingClass.SearchViaSchoolurn("119182");
            SchoolDetailPage Schooldetails = new SchoolDetailPage();
            Schooldetails.OneClickReportingLink.Click();
            Thread.Sleep(2000);
            }
        public static void OnclickReportingLondonTest(string LondonSchool)
        {
            GoHome();
            CallingClass.SearchViaSchoolurn(LondonSchool);
            SchoolDetailPage Schooldetails = new SchoolDetailPage();
            Schooldetails.OneClickReportingLink.Click();
            Thread.Sleep(2000);
            BenchMarkChartPage oneclickpage = new BenchMarkChartPage();
            oneclickpage.ViewCharacteristicsUsed.Click();
            Thread.Sleep(2000);

        }
        public static void OnclickReportingNonLondonTest(string NonLondonSchool)
        {
            GoHome();
            CallingClass.SearchViaSchoolurn(NonLondonSchool);
            SchoolDetailPage Schooldetails = new SchoolDetailPage();
            Schooldetails.OneClickReportingLink.Click();
            BenchMarkChartPage oneclickpage = new BenchMarkChartPage();
            oneclickpage.ViewCharacteristicsUsed.Click();
            Thread.Sleep(2000);
        }
        public static void FlipBetweenCharts()
        {
            OnclickReportingTest();
            BenchMarkChartPage benchpage = new BenchMarkChartPage();
            benchpage.ViewAsTables.Click();
            Thread.Sleep(2000);
            Assert.IsTrue(benchpage.ViewAsCharts.Displayed);
            benchpage.ViewAsCharts.Click();
            Thread.Sleep(2000);
            Assert.IsTrue(benchpage.ViewAsTables.Displayed);
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

        public static void SearchSchoolViaName(string schoolName)

        {
            HomePage homepage = new HomePage();
            GoHome();
            homepage.School.Click();
            homepage.SchoolsearchField.SendKeys(schoolName);
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

        public static void SearchClosedschool(string urn)
        {
            HomePage homepage = new HomePage();
            GoHome();
            homepage.School.Click();
            homepage.SchoolsearchField.SendKeys(urn);
            homepage.ClickOnSearchButton();
            Thread.Sleep(3000);
        }
        public static void dealforswchools()
        {
            Actions.CallingClass.QuickCompareWithOtherSchools();
            Thread.Sleep(30000);
            BenchMarkChartPage chartpage = new BenchMarkChartPage();
            //chartpage.DealforSchoolsLink.Click();

        }

        public static void GetSearchText()
        {
            SearchResultsPage searchresults = new SearchResultsPage();
            var results = searchresults.SchooSearchResults.Text;
            return;
        }
        public static void schoolSearchwithLaestab(string LAESTAB)
        {
            GoHome();
            HomePage homepage = new HomePage();
            homepage.School.Click();
            homepage.SchoolsearchField.Click();
            //Thread.Sleep(2000);
            homepage.SchoolsearchField.SendKeys(LAESTAB);
            //Thread.Sleep(3000);
            homepage.SearchSubmit.Click();
            Thread.Sleep(3000);
        }

        public static void TrustSearchWitName(string TrustName)
        {
            GoHome();
            HomePage homepage = new HomePage();
            Thread.Sleep(100);
            homepage.TrustTickBox.Click();
            homepage.TrustSearchInput.SendKeys(TrustName);
            homepage.TrustSubmit.Click();
            Driver.driver.FindElement(By.CssSelector(".bold-small")).Click();
            Thread.Sleep(100);
        }
        public static void TrustSearchWithCompanynumber(string companynumber)
        {
            GoHome();
            HomePage homepage = new HomePage();
            homepage.TrustTickBox.Click();
            homepage.TrustSearchInput.SendKeys(companynumber);
            Thread.Sleep(5000);
            homepage.TrustSubmit.Click();
            Thread.Sleep(5000);
        }
        public static void SearchByLocationManualEntry()
        {
            HomePage homepage = new HomePage();
            GoHome();
            homepage.LocationButton.Click();
            //homepage.UseLocationLink.Click();
            //Thread.Sleep(100);
            homepage.SearchByLocationField.Click();
            homepage.SearchByLocationField.Clear();
            homepage.SearchByLocationField.SendKeys(Config.Credentials.PostCode.Postcode);
            //Thread.Sleep(2000);
            homepage.LocationSearchSubmitButton.Click();
            Driver.driver.FindElement(By.CssSelector("li.document:nth-child(1) > a:nth-child(1)")).Click();
            Thread.Sleep(2000);

        }

        public static void SearchByLocationUsingLink()
        {
            HomePage homepage = new HomePage();
            GoHome();
            homepage.LocationButton.Click();
            homepage.UseLocationLink.Click();
            Thread.Sleep(300);
           
            homepage.LocationSearchSubmitButton.Click();
           
            Thread.Sleep(200);

        }
        public static void downloadpdf()
        {
            OnclickReportingTest();
            BenchMarkChartPage benchmarkpage = new BenchMarkChartPage();
            Thread.Sleep(1000);
            benchmarkpage.DownloadPdf.Click();
            Thread.Sleep(1000);

        }
        public static void downloadcsv()
        {
            OnclickReportingTest();
            BenchMarkChartPage benchmarkpage = new BenchMarkChartPage();
            benchmarkpage.Downloadbenchmarkdata_CSV.Click();
            Thread.Sleep(1000);
        }
        public static void savebenchmarkbasket()
        {
            OnclickReportingTest();
            BenchMarkChartPage benchmarkpage = new BenchMarkChartPage();
            benchmarkpage.Savebenchmarkbasket.Click();
            Thread.Sleep(1000);
        }
        public static void TrustComparison()
        {
            //GoHome();
            TrustSearchWitName("Kaleidoscope Learning Trust ");
            TrustComparisonPage trustComaprison = new TrustComparisonPage();

            trustComaprison.Compare_withOtherTrusts.Click();
            Thread.Sleep(500);
            trustComaprison.ViewBenchMarkingCharts.Click();
            Thread.Sleep(500);

        }
            
        public static void TrustComparisonWithMultipleTrusts()
        {
            GoHome();
            TrustSearchWitName("Kaleidoscope Learning Trust ");
            TrustComparisonPage trustComaprison = new TrustComparisonPage();
            trustComaprison.Compare_withOtherTrusts.Click();
            Thread.Sleep(100);
            trustComaprison.SelectCharacteristicsButton.Click();
            trustComaprison.NumberOfSchoolscheckbox.Click();
            trustComaprison.MinNumOfScools.SendKeys("30");
            trustComaprison.MaxNumofschools.SendKeys("35");
            Thread.Sleep(1000);
            trustComaprison.ViewBenchMarkingChartsbutton.Click();
            

        }
        

        public class CallingClass // This will have to be refactored in future when tests are stable
        {

           

           
            public static void SearchByLaCode(string lacode)
            {
                HomePage homepage = new HomePage();
                GoHome();
                homepage.LcalAuthoritySearchButton.Click();
                homepage.LacodeInputField.Click();
                homepage.LacodeInputField.Clear();
                homepage.LacodeInputField.SendKeys(lacode);
                homepage.LacodeSearchButton.Click();

            }
            public static void TestHelpUsingSiteLinks()
            {

                SpecialElementsPage links = new SpecialElementsPage();
                GoHome();
                links.HelpUsingSiteLink.Click();
                Thread.Sleep(1000);
            }
            public static void TestDatasourcesLink()
            {
                SpecialElementsPage links = new SpecialElementsPage();
                links.DataSources.Click();
                Thread.Sleep(1000);
                
                
            }
            public static void TestIntepreTingTheChartsLinks()
            {
                SpecialElementsPage links = new SpecialElementsPage();
                links.IntepreTingTheChartsLinks.Click();
                Thread.Sleep(1000);
            }
            
            public static void AcceptAlert()
            {
                IAlert alert = Driver.driver.SwitchTo().Alert();
                alert.Accept();
            }
            public static void Verifybasket()
            {
                GoHome();
                SearchSchoolViaName("plumcroft primary school");
                Thread.Sleep(3000);
                SchoolDetailPage Schooldetails = new SchoolDetailPage();
                
                SearchResultsPage resultspage = new SearchResultsPage();
                resultspage.FirstElementPresented.Click();
                Thread.Sleep(3000);
                Schooldetails.AddToBenchMarkBasket.Click();
                Thread.Sleep(3000);
               
               }
            public static void Verifybasketcapacity()
            {
                GoHome();
                SchoolDetailPage Schooldetails = new SchoolDetailPage();
                SearchResultsPage resultspage = new SearchResultsPage();
                URNHelper helpers = new URNHelper();
                IList urns = helpers.Urns;
               
                    foreach (string urn in urns) {
                    try
                    {
                        SearchSchoolViaName(urn);

                        Schooldetails.AddToBenchMarkBasket.Click();
                        Thread.Sleep(10000);
                    }
                    catch (NoSuchElementException ){ continue; }                       

                    }


                    
                
                }

            public static void SearchViaSchoolurn( string urn)
            {
                GoHome();
                HomePage homepage = new HomePage();
                
                homepage.School.Click();
                homepage.SchoolsearchField.SendKeys(urn);
                homepage.ClickOnSearchButton();
                Thread.Sleep(1000);
            }
            public static void QuickCompareWithOtherSchools()
            {
               
                //Actions.GoHome();
                
                SearchViaSchoolurn("143592");
                SchoolDetailPage detailspage = new SchoolDetailPage();
                detailspage.CompareWithOtherSchools.Click();
                BestInClass bestinclass = new BestInClass();
                Thread.Sleep(200);
                bestinclass.QuckComparisonButton.Click();
                bestinclass.NextButton.Click();
                bestinclass.DefaultChoice.Click();
                bestinclass.NextButton.Click();
                bestinclass.MaintainedSchoolsChoice.Click();
                bestinclass.NextButton.Click();
                bestinclass.ContinueToBenchMarkChartsBurtton.Click();
                Thread.Sleep(100);

            }
            public static void searchschoolwithIncompleteFinance(String urn)
            {
                SearchViaSchoolurn(urn);
                //Assert.IsTrue(Driver.driver.FindElement(By.CssSelector(".combined-warnings")).Text.Contains("This school doesn't have a complete set of financial data for this period "));
                SchoolDetailPage detailspage = new SchoolDetailPage();
                detailspage.CompareWithOtherSchools.Click();
               
                BestInClass bestinclass = new BestInClass();
                bestinclass.QuckComparisonButton.Click();
                bestinclass.NextButton.Click();
                bestinclass.NextButton.Click();
                bestinclass.AllSchoolsChoice.Click();
                bestinclass.NextButton.Click();
                bestinclass.ContinueToBenchMarkChartsBurtton.Click();
                BenchMarkChartPage chartpage = new BenchMarkChartPage();
                Thread.Sleep(3000);
                IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver.driver;
                //executor.ExecuteScript("arguments[0].click();", chartpage.KanesHillPrimarySch);
                executor.ExecuteScript("document.querySelector(#chart_0 > svg:nth-child(1) > g:nth-child(2) > g:nth-child(7) > g:nth-child(17) > circle:nth-child(3))");
                //chartpage.KanesHillPrimarySch.SendKeys(Keys.Return);






            }
            public static void ContinuetoBenchmarkCharts()
            {
                BestInClass bestinclass = new BestInClass();
                bestinclass.ContinueToBenchMarkChartsBurtton.Click();
                Thread.Sleep(100);
            }
            public static void ViewCharts()
            {
                ContinuetoBenchmarkCharts();
                BestInClass bestinclass = new BestInClass();
                bestinclass.YourChartTab.Click();
                Thread.Sleep(1000);

            }

            public static void BestInClassComparison()
            {
                GoHome();
                SearchViaSchoolurn("125271");
                Thread.Sleep(2000);
                SchoolDetailPage detailspage = new SchoolDetailPage();
                Thread.Sleep(3);
                detailspage.CompareWithOtherSchools.Click();
                Thread.Sleep(3000);
                BestInClass bestinclass = new BestInClass();
                bestinclass.BestInClassComparisonButton.Click();
                Thread.Sleep(3000);
                bestinclass.ContinueToHigherProgressSchoolBenchmark.Click();
                Thread.Sleep(3000);
                bestinclass.NextButton.Click();
                Thread.Sleep(3000);

            }
            public static void SchoohSearchOfstedRating()
            {
                SearchViaSchoolurn("142253");
                SchoolDetailPage detailspage = new SchoolDetailPage();
                                             
            }
            public static void SchoolMap()
            {
                GoHome();
                SearchViaSchoolurn("131030");
                SchoolDetailPage detailspage = new SchoolDetailPage();
                Assert.IsTrue(detailspage.School_Location_Map.Displayed);

            }
            public static void ViewBenchMarkChartsButton()
            {
                SearchSchoolViaName("Oswald Road Primary School");
                SchoolDetailPage Schooldetails = new SchoolDetailPage();
                Schooldetails.AddToBenchMarkBasket.Click();

            }

            public static void IsButtonPresent()

            {
                GoHome();
                SchoolDetailPage Schooldetails = new SchoolDetailPage();
                SearchSchoolViaName("Oswald Road Primary School");
                SearchResultsPage resultspage = new SearchResultsPage();
                resultspage.FirstElementPresented.Click();
                Schooldetails.AddToBenchMarkBasket.Click();
                Thread.Sleep(3000);
                CallingClass.SearchViaSchoolurn("100000");
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
            public static void AddSchools()
            {
                
                Verifybasket();
                SchoolDetailPage detailpage = new SchoolDetailPage();
                
                detailpage.EditBasket.Click();
                BenchMarkBasketPage basketpage = new BenchMarkBasketPage();
                basketpage.AddSchools.Click();
                HomePage home = new HomePage();
                home.School.Click();
                home.SchoolsearchField.SendKeys("100000");
                home.SearchSubmit.Click();

                Thread.Sleep(1000);
                SchoolDetailPage detailspage = new SchoolDetailPage();
                detailspage.AddToBenchMarkBasket.Click();
                Thread.Sleep(1000);

            }
            public static void ClearSchools()
            {
                Verifybasket();
                SchoolDetailPage detailpage = new SchoolDetailPage();
                detailpage.EditBasket.Click();
                BenchMarkBasketPage basketpage = new BenchMarkBasketPage();
                basketpage.ClearBasket.Click();
                Thread.Sleep(1000);

            }
            public static void addanotherschoolvianameorlocationlink()
            {
                QuickCompareWithOtherSchools();
                BenchMarkChartPage chartpage = new BenchMarkChartPage();
                Thread.Sleep(2000);
                chartpage.AddanotherschoolLink.Click();

            }



        }
    }
}
       

