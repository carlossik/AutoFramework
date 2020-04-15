namespace AutoFramework
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
    using OpenQA.Selenium.Safari;
    using System;
    using OpenQA.Selenium.Remote;
    using System.Drawing;

    public  class Actions :BrowserToRunWith
    {
        

        public static void InitializeDriver(String browser)
        {
            if (browser == ("chrome"))
            {
                Driver.driver = new ChromeDriver();
                Driver.driver.Navigate().GoToUrl(Config.currentTestEnv);
                Thread.Sleep(2000);
                IWebElement AcceptCookies = Driver.driver.FindElement(By.Id("acceptAllCookies"));
                if (Driver.driver.FindElement(By.Id("acceptAllCookies")).Displayed)
                {
                    Driver.driver.FindElement(By.Id("acceptAllCookies")).Click();
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.Write("No cookies here....");
                }

                IWebElement HideCookieBanner = Driver.driver.FindElement(By.Id("acceptAllCookiesHide"));
                if (HideCookieBanner.Displayed)
                {
                    HideCookieBanner.Click();
                    Thread.Sleep(1000);
                }

                Driver.driver.Manage().Window.Maximize();
                Driver.driver.Navigate().Refresh();
                clearPopup();
                Thread.Sleep(500);
                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                
                if (Driver.driver.Url.Contains("Login"))
                {
                    Actions.FillLoginForm();
                }
                else
                {
                    Console.Write("There is no Logoin Required here....");
                }
                
            }
            else if (browser == ("firefox"))
            {
                FirefoxProfile fprof = new FirefoxProfile();
                fprof.SetPreference("geo.enabled", true);
                Driver.driver = new FirefoxDriver();

                Driver.driver.Navigate().GoToUrl(Config.currentTestEnv);
                IWebElement AcceptCookies = Driver.driver.FindElement(By.Id("acceptAllCookies"));
                AcceptCookies.Click();
                IWebElement HideCookieBanner = Driver.driver.FindElement(By.Id("acceptAllCookiesHide"));
                HideCookieBanner.Click();
                Thread.Sleep(1000);
                Driver.driver.Manage().Window.Maximize();
                Driver.driver.Navigate().Refresh();
                clearPopup();
                Thread.Sleep(500);
                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                if (Driver.driver.Url.Contains("Login"))
                {
                    Actions.FillLoginForm();
                }
                else
                {
                    Console.Write("There is no Logoin Required here....");
                }

            }
            else if (browser == ("IE"))
            {
                Driver.driver = new InternetExplorerDriver();
                Driver.driver.Navigate().GoToUrl(Config.currentTestEnv);
                Thread.Sleep(1000);
                Driver.driver.Manage().Window.Maximize();
                Driver.driver.Navigate().Refresh();
                Thread.Sleep(500);
                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                if (Driver.driver.Url.Contains("Login"))
                {
                    Actions.FillLoginForm();
                }
                else
                {
                    Console.Write("There is no Logoin Required here....");
                }

            }
        }

      
        public static void defaultsSchool()
        {
            
            Actions.CallingClass.SearchViaSchoolurn("119182");
            Thread.Sleep(100);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.SetasDefaultSchool.Click();
            Thread.Sleep(100);
            detailspage.CompareWithOtherSchools.Click();
            Thread.Sleep(100);
            String color = Driver.driver.FindElement(By.XPath("/html/body/div/div[8]/main/div/div/div/span")).GetAttribute("color");
            Console.WriteLine(color);
            Console.WriteLine(color);
        }
        public static void GoHome()
        {

            Driver.driver.Navigate().GoToUrl(Config.currentTestEnv);
        }
        public static void OnclickReportingTest()
        {
            //GoHome();
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
            loginScenario.PasswordField.SendKeys("1908@twspssc");
            loginScenario.LoginButton.Click();
        }

        public static void SearchSchoolViaName(string schoolName)

        {
            HomePage homepage = new HomePage();
            GoHome();
            homepage.School.Click();
            homepage.SchoolsearchField.SendKeys(schoolName);
            homepage.ClickOnSearchButton();
            Thread.Sleep(100);
        }
        public static void SearchSchool2(string urn)
        {
            HomePage homepage = new HomePage();
            GoHome();
            homepage.School.Click();
            homepage.SchoolsearchField.SendKeys(urn);
            homepage.ClickOnSearchButton();
            Thread.Sleep(100);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            string SchoolPhase = detailspage.SchoolPhase.Text;
            string OverallSchoolPhase = detailspage.SchoolOverAllPhase.Text;
            string newformed = OverallSchoolPhase + "(" + SchoolPhase + ")";//Primary(Infant and junior)
            Console.WriteLine(OverallSchoolPhase);
            Console.WriteLine(SchoolPhase);
            Console.WriteLine(newformed);
            Thread.Sleep(100);

        }

        public static void testmailSuccess(String emailaddress)
        {
            HomePage homepage = new HomePage();
            homepage.SchoolorTrustDataQueryLink.Click();
            DataQueriesPage queriespage = new DataQueriesPage();
            queriespage.NameField.SendKeys("Carl Fagan");
            queriespage.EmailField.SendKeys(emailaddress);
            queriespage.SchoolNameField.SendKeys("Plumcroft Primary School");
            queriespage.LA_URN_CO_NUMBERField.SendKeys("100000");
            queriespage.QueryInputField.SendKeys("This is a Test Please Ignore");
            queriespage.SubmitButton.Click();
            Thread.Sleep(2000);


        }
        public static void testmailfailure()
        {

        }
        public static void SearchClosedschool(string urn)
        {
            HomePage homepage = new HomePage();
            GoHome();
            homepage.School.Click();
            homepage.SchoolsearchField.SendKeys(urn);
            homepage.ClickOnSearchButton();
            Thread.Sleep(300);
        }
        public static void dealforswchools()
        {
            Actions.CallingClass.QuickCompareWithOtherSchools();
            Thread.Sleep(300);
            BenchMarkChartPage chartpage = new BenchMarkChartPage();

        }
        public static void clearPopup()
        {
            IWebElement closeButton = Driver.driver.FindElement(By.Id("js-modal-close"));

            if (closeButton.Displayed)
            {
                closeButton.Click();
            }
            else
            {
                Console.Write("modal not displayed here so moving on....");
            }
        }
        public static void clearcookie()
        {
            IWebElement closeCookie = Driver.driver.FindElement(By.Id("acceptAllCookies"));
            if (closeCookie.Displayed)
            { closeCookie.Click();
                Thread.Sleep(300);
                Driver.driver.Navigate().Refresh();
                Thread.Sleep(300);
                clearPopup();
                Thread.Sleep(300);
            }
            
        }
        public static void gotonewspage()

        {
            Driver.driver.Close();
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Config.currentTestEnv);
            IWebElement AcceptCookies = Driver.driver.FindElement(By.Id("acceptAllCookies"));
            AcceptCookies.Click();
            IWebElement HideCookieBanner = Driver.driver.FindElement(By.Id("acceptAllCookiesHide"));
            HideCookieBanner.Click();
            Thread.Sleep(1000);
            Driver.driver.Manage().Window.Maximize();
            Driver.driver.Navigate().Refresh();
            Thread.Sleep(1000);
            IWebElement gotonewspage = Driver.driver.FindElement(By.XPath("/html/body/dialog/div/div/div/a"));
            gotonewspage.Click();
            Thread.Sleep(100);
        }
        


        public static void AllThroughBIC(string LAname)
        {
            HomePage homepage = new HomePage();
            homepage.TrustLaCodeButton.Click();
            homepage.SchoolLacodeinputField.SendKeys(LAname);
            homepage.FirstIntellicenceSuggested.Click();
            Thread.Sleep(300);
            SearchResultsPage resultspage = new SearchResultsPage();
            resultspage.SelectAllThroughsCheckbox.Click();
            Thread.Sleep(30);
            resultspage.FirstScoolLinkOnPage.Click();
          
        }
        public static void schoolSearchwithLaestab(string LAESTAB)
        {
            HomePage homepage = new HomePage();
            Thread.Sleep(200);
            homepage.School.Click();
            homepage.SchoolsearchField.Click();
            homepage.SchoolsearchField.SendKeys(LAESTAB);
            homepage.SearchSubmit.Click();
            Thread.Sleep(300);
        }

        public static void TrustSearchWitNameUsingSubmitButton(string TrustName)
        {
            GoHome();
            HomePage homepage = new HomePage();
            Thread.Sleep(100);
            homepage.TrustTab.Click();
            homepage.trustnameRadioButton.Click();
            homepage.TrustSearchInput.Click();
            homepage.TrustSearchInput.SendKeys(TrustName);
            homepage.FirstSelectionOption.Click();
            Driver.driver.FindElement(By.CssSelector(".bold-small")).Click();
            Thread.Sleep(100);
        }
        public static void TrustSearchWithCompanynumber(string companynumber)
        {
            GoHome();
            HomePage homepage = new HomePage();
            homepage.TrustTab.Click();
            homepage.trustnameRadioButton.Click();
            homepage.TrustSearchInput.SendKeys(companynumber);
            Thread.Sleep(500);
            homepage.TrustSubmit.Click();
            Thread.Sleep(500);
        }
        public static void SearchByLocationManualEntry()
        {
            HomePage homepage = new HomePage();
            homepage.LocationButton.Click();
            homepage.SearchByLocationField.Click();
            homepage.SearchByLocationField.Clear();
            homepage.SearchByLocationField.SendKeys(Config.Credentials.PostCode.Postcode);
            homepage.LocationSearchSubmitButton.Click();
            Driver.driver.FindElement(By.CssSelector("li.document:nth-child(1) > a:nth-child(1)")).Click();
            Thread.Sleep(200);
            FiltersPage filters = new FiltersPage();
            string ResultsDisplayedInitially = (filters.ResultsCount).Text;
            Console.WriteLine(ResultsDisplayedInitially);
            Thread.Sleep(200);

        }

        public static void SearchByLocationUsingLink() //location enabling in firefox is an issue 
        {
            HomePage homepage = new HomePage();
            homepage.LocationButton.Click();
            homepage.UseLocationLink.Click();
            Thread.Sleep(300);
            homepage.LocationSearchSubmitButton.Click();
            Thread.Sleep(200);

        }
        public static void select16plus()
        {
            SearchResultsPage resultspage = new SearchResultsPage();
            resultspage.Checkbox_16plus.Click();
            Thread.Sleep(300);
            resultspage.AddFirstResult.Click();
            Thread.Sleep(300);
        }
        public static void navigatepagination()
        {
            SearchResultsPage resultspage = new SearchResultsPage();
            resultspage.paginationSecondPage.Click();
            resultspage.paginationPreviousButton.Click();
        }
        public static void addtobasketviaresultspage()
        {
            SearchByLocationManualEntry();
            SearchResultsPage resultspage = new SearchResultsPage();
            resultspage.AddFirstResult.Click();
            Thread.Sleep(200);
            resultspage.EditBasket.Click();
            Thread.Sleep(200);
            BenchMarkBasketPage basketpage = new BenchMarkBasketPage();
            Thread.Sleep(100);
            basketpage.clear_basket.Click();
            basketpage.CloseBasket.Click();

            
        }
        public static void downloadpdf()
        {
            OnclickReportingTest();
            BenchMarkChartPage benchmarkpage = new BenchMarkChartPage();
            Thread.Sleep(1000);
            benchmarkpage.DownloadPage.Click();
            Thread.Sleep(1000);
            Driver.driver.SwitchTo().Window(Driver.driver.CurrentWindowHandle);
            benchmarkpage.PDFFormat.Click();
            Thread.Sleep(1000);
            Driver.driver.SwitchTo().Window(Driver.driver.WindowHandles[0]);
            benchmarkpage.PDFFormat.SendKeys(Keys.Tab);
            benchmarkpage.PDFFormat.SendKeys(Keys.Tab);
            benchmarkpage.PDFFormat.SendKeys(Keys.Tab);
            Thread.Sleep(10000);
            Driver.driver.SwitchTo().Window(Driver.driver.WindowHandles[0]);
            Driver.driver.SwitchTo().Window(Driver.driver.CurrentWindowHandle);
            IWebElement element = Driver.driver.FindElement(By.CssSelector(".button"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver.driver;
            executor.ExecuteScript("arguments[0].scrollIntoView()", element);
            executor.ExecuteScript("arguments[0].click()", element);
            Thread.Sleep(10000);
        }
        public static void SearchTrustViaLocation()
        {
            HomePage homepage = new HomePage();
            Thread.Sleep(100);
            homepage.TrustTab.Click();
            homepage.TrustLocationButton.Click();
            homepage.TrustLocationField.SendKeys(Config.Credentials.PostCode.Postcode);
            homepage.TrustLocationSubmit.Click();
            Driver.driver.FindElement(By.CssSelector("li.document:nth-child(1) > a:nth-child(1)")).Click();
            Thread.Sleep(10000);
        }

        public static void ViewSchoolsInTrust()
        {
            SearchTrustViaLocation();
            SearchResultsPage resultsPage = new SearchResultsPage();
            resultsPage.ViewTrustSchools.Click();
            Thread.Sleep(2000);
        }
        public static void verifyTrustIsOpen()
        {
            ViewSchoolsInTrust();

        }
        public static void SearchTrustViaLocalAuthority(String LAcode)
        {
            HomePage homepage = new HomePage();
            Thread.Sleep(100);
            homepage.TrustTab.Click();
            homepage.LocalAuthoritySearchButton.Click();
            homepage.TrustLaCodeInputField.SendKeys(LAcode);
            homepage.TrustLacodeSearchButton.Click();
            Thread.Sleep(10000);
        }
        public static void selectFirstSchool()
        {
            SearchResultsPage resultsPage = new SearchResultsPage();
            resultsPage.ViewTrustSchools.Click();
            Thread.Sleep(10000);
        }
        public static void ResultPageactionsA_Z(String LAcode,string OrderBy)
        {
            SearchTrustViaLocalAuthority(LAcode);
            SearchResultsPage resultspage = new SearchResultsPage();
            resultspage.TrustSearchResultSortedByButton.Click();
            resultspage.TrustSearchResultSortedByButton.SendKeys(OrderBy + Keys.Enter);
            Thread.Sleep(2000);

        }
        public static void ResultPageactions(String LAcode, string OrderBy)
        {
            SearchTrustViaLocalAuthority(LAcode);
            SearchResultsPage resultspage = new SearchResultsPage();
            resultspage.TrustSearchResultSortedByButton.Click();
            resultspage.TrustSearchResultSortedByButton.SendKeys(OrderBy + Keys.Enter);
            Thread.Sleep(2000);

        }
        public static void downloadcsv()
        {
            OnclickReportingTest();
            BenchMarkChartPage benchmarkpage = new BenchMarkChartPage();
            benchmarkpage.Downloadata.Click();
            Thread.Sleep(1000);
        }
        public static void downloadppt()
        {
            OnclickReportingTest();
            BenchMarkChartPage benchmarkpage = new BenchMarkChartPage();
            Thread.Sleep(1000);
            benchmarkpage.DownloadPage.Click();
            Thread.Sleep(1000);
            benchmarkpage.PowerPointFormat.Click();
            IWebElement element = Driver.driver.FindElement(By.CssSelector(".button"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver.driver;
            executor.ExecuteScript("arguments[0].scrollIntoView()", element);
            Thread.Sleep(10000);
            executor.ExecuteScript("arguments[0].click()", element);
            Thread.Sleep(1000);
        }
        public static void savebenchmarkbasket()
        {
            OnclickReportingTest();
            BenchMarkChartPage benchmarkpage = new BenchMarkChartPage();
            benchmarkpage.Savebenchmarkbasket.Click();
            benchmarkpage.CopyLinkToClipboard.Click();
            Thread.Sleep(300);
        }
        public static void TrustComparison(String TrustName)
        {
            
            TrustActions.TrustSearchWitNameUsingFirstSuggestedName(TrustName);
            TrustComparisonPage trustComaprison = new TrustComparisonPage();
            Thread.Sleep(500);
            trustComaprison.Compare_withOtherTrusts.Click();
            Thread.Sleep(500);
            trustComaprison.ViewBenchMarkingCharts.Click();
            Thread.Sleep(500);
        }
          
        public class CallingClass // This will have to be refactored in future when tests are stable
        {
            public static void SearchByLaCode(string lacode)
            {
                HomePage homepage = new HomePage();
                homepage.TrustTab.Click();
                homepage.LocalAuthoritySearchButton.Click();
                Thread.Sleep(300);
                homepage.LacodeInputField.SendKeys(lacode);
                homepage.TrustLacodeSearchButton.Click();

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
                Thread.Sleep(3000);
                SearchSchoolViaName("plumcroft primary school");
                Thread.Sleep(3000);
                SchoolDetailPage Schooldetails = new SchoolDetailPage();
                SearchResultsPage resultspage = new SearchResultsPage();
                resultspage.FirstElementPresented.Click();
                Thread.Sleep(3000);
                Schooldetails.AddToBenchMarkBasket.Click();
                Thread.Sleep(300);
            }

            public static void VerifyDefaultSchoolColour(String LAEstab)
            {
                Actions.schoolSearchwithLaestab(LAEstab);
                SchoolDetailPage Schooldetails = new SchoolDetailPage();
                Schooldetails.SetasDefaultSchool.Click();
                Thread.Sleep(1000);
                Schooldetails.CompareWithOtherSchools.Click();
                Thread.Sleep(2000);
                string colortext = Driver.driver.FindElement(By.CssSelector(".highlight > span:nth-child(1)")).GetAttribute("color");
                Console.WriteLine(colortext);
                Console.Write(colortext);
            }


            public static void Verifybasketcapacity()
            {  
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


            public static void sptlinkscheck()
            {
                SchoolDetailPage Schooldetails = new SchoolDetailPage();
                URNHelper helpers = new URNHelper();
                IList urns = helpers.Urns;
                foreach (string urn in urns)
                {
                    try
                    {
                        Console.WriteLine(urn);
                        SearchSchoolViaName(urn);
                        Thread.Sleep(30);
                        Schooldetails.schoolPerformanceTableLink.Click();
                        Thread.Sleep(50);
                        Assert.IsTrue(Driver.driver.FindElement(By.CssSelector(".metadata > dd:nth-child(24)")).Text == urn);
                        Console.WriteLine(urn);
                        Console.WriteLine(Driver.driver.FindElement(By.CssSelector(".metadata > dd:nth - child(24)")).Text);
                    }
                    catch (NoSuchElementException) { continue; }
                }
            }
            public static void verifylalink()
            {
                SchoolDetailPage Schooldetails = new SchoolDetailPage();
                SearchResultsPage resultspage = new SearchResultsPage();
                URNHelper helpers = new URNHelper();
                IList urns = helpers.Urns;
                foreach (string urn in urns)
                {
                    try
                    {
                        SearchSchoolViaName(urn);

                        Schooldetails.LocalAuthorityLink.Click();
                       
                        Assert.IsTrue(Driver.driver.Url.Contains(Config.currentTestEnv + "SchoolSearch/Search?nameId=&suggestionUrn=&trustnameid=&trustsuggestionUrn=&locationorpostcode=&LocationCoordinates=&openOnly=true&lacodename="));
                    }
                    catch (NoSuchElementException) { continue; }

                }

            }
            public static void SearchViaSchoolurn( string urn)
            {
                HomePage homepage = new HomePage();
                homepage.School.Click();
                Thread.Sleep(100);
                homepage.SchoolsearchField.SendKeys(urn);
                Thread.Sleep(1000);
                homepage.ClickOnSearchButton();
                Thread.Sleep(1000);
            }
            public static void QuickCompareWithOtherSchools()
            {
              SearchViaSchoolurn("143592");
                SchoolDetailPage detailspage = new SchoolDetailPage();
                detailspage.CompareWithOtherSchools.Click();
                BestInClass bestinclass = new BestInClass();
                Thread.Sleep(200);
                bestinclass.QuckComparisonButton.Click();
                bestinclass.Continue.Click();
                bestinclass.DefaultChoice.Click();
                bestinclass.Continue.Click();
                bestinclass.MaintainedSchoolsChoice.Click();
                bestinclass.Continue.Click();
                bestinclass.ContinueToBenchMarkChartsButton.Click();
                Thread.Sleep(100);
            }
            public static void searchschoolwithIncompleteFinance(String urn)
            {
                SearchViaSchoolurn(urn);
                SchoolDetailPage detailspage = new SchoolDetailPage();
                detailspage.CompareWithOtherSchools.Click();
                BestInClass bestinclass = new BestInClass();
                bestinclass.QuckComparisonButton.Click();
                bestinclass.Continue.Click();
                bestinclass.Continue.Click();
                bestinclass.AllSchoolsChoice.Click();
                bestinclass.ContinueToBenchMarkChartsButton.Click();
                BenchMarkChartPage chartpage = new BenchMarkChartPage();
                Thread.Sleep(3000);
                IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver.driver;
                executor.ExecuteScript("document.querySelector(#chart_0 > svg:nth-child(1) > g:nth-child(2) > g:nth-child(7) > g:nth-child(17) > circle:nth-child(3))");
            }
            public static void ContinuetoBenchmarkCharts()
            {
                BestInClass bestinclass = new BestInClass();
                bestinclass.ContinueToBenchMarkChartsButton.Click();
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
                bestinclass.Continue.Click();
                Thread.Sleep(3000);
                bestinclass.ContinueToHigherProgressSchoolBenchmark.Click();
                Thread.Sleep(1000);
            }
            public static void SchoohSearchOfstedRating()
            {
                SearchViaSchoolurn("142253");
                SchoolDetailPage detailspage = new SchoolDetailPage();                              
            }
            public void ComparisonTabothercharts()
            {
                OnclickReportingTest();
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
                Thread.Sleep(3000);
                home.SchoolsearchField.SendKeys("142295");
                Thread.Sleep(200);
                home.SearchSubmit.Click();
                Thread.Sleep(1000);
                SchoolDetailPage detailspage = new SchoolDetailPage();
                detailspage.AddToBenchMarkBasket.Click();
                Thread.Sleep(1000);
            }
            public static void ClearSchools(IWebDriver driver)
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
       

