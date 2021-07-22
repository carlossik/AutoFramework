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
    using System.Linq;

    public  class Actions :BrowserToRunWith
    {
        public static IWebDriver InitializeDriver(int second)
        {
          

           var ChromeOptions = new ChromeOptions();
          
           ChromeOptions.AddArgument("--use-fake-ui-for-media-stream");
           ChromeOptions.AddArgument("--disable-user-media-security=true");
           var downloadDirectory = (@"C:\AutomationDownloads");
           ChromeOptions.AddUserProfilePreference("download.default_directory", downloadDirectory);
           ChromeOptions.AddUserProfilePreference("download.prompt_for_download", false);
           IWebDriver driver = new ChromeDriver(ChromeOptions);
           //IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(Config.currentTestEnv);
            TimeSpan seconds = TimeSpan.FromSeconds(second);
            driver.Manage().Timeouts().ImplicitWait = seconds;
            IWebElement AcceptCookies = driver.FindElement(By.Id("acceptAllCookies"));
            if (driver.FindElement(By.Id("acceptAllCookies")).Displayed)
            {
                driver.FindElement(By.Id("acceptAllCookies")).Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                Thread.Sleep(2000);
            }
            else
            {
                Console.Write("No cookies here....");
            }

            IWebElement HideCookieBanner = driver.FindElement(By.Id("acceptAllCookiesHide"));
            if (HideCookieBanner.Displayed)
            {
                HideCookieBanner.Click();
                Thread.Sleep(1000);
            }

            driver.Manage().Window.Maximize();
            driver.Navigate().Refresh();
            clearPopup(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            if (driver.Url.Contains("Login"))
            {
                Actions.FillLoginForm(driver);
            }
            else
            {
                Console.Write("There is no Logoin Required here....");
            }


            return driver;
        }
        //public static IWebDriver InitializeDriver(string browser)
        //{
        //    if (browser == "chrome")
        //    {
        //        var ChromeOptions = new ChromeOptions();
        //        var downloadDirectory = (@"C:\AutomationDownloads");
        //        var clipboardException = new Dictionary<string, object> { { "[*.]" + Config.currentTestEnv + "," + "*", new Dictionary<string, object> { { "last_modified", DateTimeOffset.Now.ToUnixTimeMilliseconds() }, { "setting", 1 } } } };
        //        ChromeOptions.AddUserProfilePreference("profile.content_settings.exceptions.clipboard", clipboardException);
        //        ChromeOptions.AddUserProfilePreference("download.default_directory", downloadDirectory);
        //        ChromeOptions.AddUserProfilePreference("download.prompt_for_download", false);
        //        ChromeOptions.AddUserProfilePreference("disable-popup-blocking", "true");
        //        ChromeOptions.AddArgument("--use-fake-ui-for-media-stream");
        //        ChromeOptions.AddArgument("--disable-user-media-security=true");

        //        IWebDriver driver = new ChromeDriver(ChromeOptions);
        //        //TimeSpan seconds = TimeSpan.FromSeconds();
        //        driver.Navigate().GoToUrl(Config.currentTestEnv);
        //        // driver.Manage().Timeouts().ImplicitWait = seconds;
        //        IWebElement AcceptCookies = driver.FindElement(By.Id("acceptAllCookies"));
        //        if (driver.FindElement(By.Id("acceptAllCookies")).Displayed)
        //        {
        //            driver.FindElement(By.Id("acceptAllCookies")).Click();
        //            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        //            Thread.Sleep(2000);
        //        }
        //        else
        //        {
        //            Console.Write("No cookies here....");
        //        }

        //        IWebElement HideCookieBanner = driver.FindElement(By.Id("acceptAllCookiesHide"));
        //        if (HideCookieBanner.Displayed)
        //        {
        //            HideCookieBanner.Click();
        //            Thread.Sleep(1000);
        //        }

        //        driver.Manage().Window.Maximize();
        //        driver.Navigate().Refresh();
        //        clearPopup(driver);
        //        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        //        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        //        if (driver.Url.Contains("Login"))
        //        {
        //            Actions.FillLoginForm(driver);
        //        }
        //        else
        //        {
        //            Console.Write("There is no Logoin Required here....");
        //        }



        //        //}
        //        //else if (browser == ("firefox"))

        //        //{
        //        //    FirefoxProfile fprof = new FirefoxProfile();
        //        //    fprof.SetPreference("geo.enabled", true);
        //        //    var firefoxOptions = new FirefoxOptions();

        //        //    var downloadDirectory = (@"C:\AutomationDownloads");

        //        //    IWebDriver driver = new FirefoxDriver();

        //        //    driver.Navigate().GoToUrl(Config.currentTestEnv);
        //        //    IWebElement AcceptCookies = driver.FindElement(By.Id("acceptAllCookies"));
        //        //    AcceptCookies.Click();
        //        //    IWebElement HideCookieBanner = driver.FindElement(By.Id("acceptAllCookiesHide"));
        //        //    HideCookieBanner.Click();
        //        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        //        //    driver.Manage().Window.Maximize();
        //        //    driver.Navigate().Refresh();
        //        //    clearPopup(driver);
        //        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5); 
        //        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        //        //    if (driver.Url.Contains("Login"))
        //        //    {
        //        //        Actions.FillLoginForm(driver);
        //        //    }
        //        //    else
        //        //    {
        //        //        Console.Write("There is no Logoin Required here....");
        //        //    }
        //        //    return driver;
        //        //}
        //        //else if (browser == ("IE"))

        //        //{

        //        //    IWebDriver driver = new InternetExplorerDriver();
        //        //    DesiredCapabilities capabilities = new DesiredCapabilities();
        //        //    driver.Navigate().GoToUrl(Config.currentTestEnv);
        //        //    IWebElement AcceptCookies = driver.FindElement(By.Id("acceptAllCookies"));
        //        //    if (AcceptCookies.Displayed)
        //        //    { AcceptCookies.Click(); }
        //        //    IWebElement HideCookieBanner = driver.FindElement(By.Id("acceptAllCookiesHide"));
        //        //    if (HideCookieBanner.Displayed)
        //        //    { HideCookieBanner.Click(); }

        //        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
        //        //    driver.Manage().Window.Maximize();
        //        //    driver.Navigate().Refresh();
        //        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
        //        //    driver.Manage().Window.Maximize();
        //        //    if (driver.Url.Contains("Login"))
        //        //    {
        //        //        Actions.FillLoginForm(driver);
        //        //    }
        //        //    else
        //        //    {
        //        //        Console.Write("There is no Logoin Required here....");
        //        //    }
        //        //    return driver;

        //        //    //HomePage page = new HomePage(driver);
        //        //    //if (page.CheckBasketEmpty().ToString() == "True")
        //        //    //{ page.emptybasketBeforeTesting(); }
        //        //    ////page.emptybasketBeforeTesting();
        //        //    //driver.Navigate().Refresh();
        //        //    //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);


        //        //}

        //        return driver;
        //}
        //}

        public static void defaultsSchool(IWebDriver driver)
        {
            
            Actions.CallingClass.SearchViaSchoolurn("100000",driver);
            Thread.Sleep(100);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            Thread.Sleep(100);
            detailspage.SetasDefaultSchool.Click();
            Thread.Sleep(100);
            detailspage.CompareWithOtherSchools.Click();
            Thread.Sleep(100);
            String color = driver.FindElement(By.ClassName("bold-small")).GetAttribute("color");
            Console.WriteLine(color);
            Console.WriteLine(color);
        }
        public static void GoHome(IWebDriver driver)
        {

            driver.Navigate().GoToUrl(Config.currentTestEnv);
        }

        public static void quickcompareSpecialSchoolWithSimilar(String LAESTAB, IWebDriver driver)
        {
            CallingClass.SearchViaSchoolurn(LAESTAB,driver);// must be a special school
            SchoolDetailPage detailpage = new SchoolDetailPage(driver);
            detailpage.StartAComparison.Click();
            TypeOfComparisonPage comparisontype = new TypeOfComparisonPage(driver);
            comparisontype.CreateabenchmarkComparisonButton.Click();
            BestInClass bestinclass = new BestInClass(driver);
            bestinclass.QuickcompareforspecialsSchools.Click();
            bestinclass.Continue.Click();
            QuickComparisonPage2 specialspage2 = new QuickComparisonPage2(driver);
            specialspage2.SchoolswithSimilarAgedStudentscheckbox.Click();// we select the schools with similar aged pupils here
            specialspage2.ContinueToBenchMarkingChartButton.Click();
            Thread.Sleep(2000);
        }

        public static void quickcompareSpecialSchoolWithoutSimilar(String LAESTAB, IWebDriver driver)
        {
            CallingClass.SearchViaSchoolurn(LAESTAB,driver);// must be a special school
            SchoolDetailPage detailpage = new SchoolDetailPage(driver);
            detailpage.StartAComparison.Click();
            TypeOfComparisonPage comparisontype = new TypeOfComparisonPage(driver);
            comparisontype.CreateabenchmarkComparisonButton.Click();
            BestInClass bestinclass = new BestInClass(driver);
           
            bestinclass.QuickcompareforspecialsSchools.Click();
            bestinclass.Continue.Click();
            QuickComparisonPage2 specialspage2 = new QuickComparisonPage2(driver);
            
            specialspage2.ContinueToBenchMarkingChartButton.Click();
            Thread.Sleep(2000);
        }

        public static void viewcharacteristicsOnChartPage(IWebDriver driver)
        {
            BenchMarkChartPage chartpage = new BenchMarkChartPage(driver);
            chartpage.ViewCharacteristicsUsed.Click();
            Thread.Sleep(3000);
        }

        public static void OnclickReportingTest(IWebDriver driver)
        {
            
            CallingClass.QuickCompareWithOtherSchools("119182",driver);
            SchoolDetailPage Schooldetails = new SchoolDetailPage(driver);
            //Schooldetails.StartAComparison.Click();
            //Schooldetails.quick;
            //Thread.Sleep(2000);
        }
        public static void selectNursery(String LaCode, IWebDriver driver)
        {
            searchSchoolViaLaCode(LaCode,driver);
            FiltersPage filters = new FiltersPage(driver);
            filters.EducationPhase_NurseryCheckbox.Click();
            filters.schoolsdisplayedLinks.Click();
            Thread.Sleep(2000);


        }
        public static void OnclickReportingLondonTest(string LondonSchool,IWebDriver driver)
        {
            GoHome( driver);
            CallingClass.SearchViaSchoolurn(LondonSchool,driver);
            SchoolDetailPage Schooldetails = new SchoolDetailPage(driver);
            Schooldetails.StartAComparison.Click();
            Schooldetails.BasicComparisonReportLink.Click();
            //Schooldetails.BasicComparisonReportLink.Click();
            Thread.Sleep(2000);
            BenchMarkChartPage oneclickpage = new BenchMarkChartPage(driver);
            oneclickpage.ViewCharacteristicsUsed.Click();
            Thread.Sleep(2000);

        }

        public static void OnclickReportingNonLondonTest(string NonLondonSchool, IWebDriver driver)
        {
            
            CallingClass.SearchViaSchoolurn(NonLondonSchool,driver);
            SchoolDetailPage Schooldetails = new SchoolDetailPage(driver);
            Schooldetails.StartAComparison.Click();
            //Schooldetails.BasicComparisonReportLink.Click();
            Schooldetails.BasicComparisonReportLink.Click();
            BenchMarkChartPage oneclickpage = new BenchMarkChartPage(driver);
            oneclickpage.ViewCharacteristicsUsed.Click();
            Thread.Sleep(2000);
        }
        public static void FlipBetweenCharts(IWebDriver driver)
        {
            OnclickReportingTest(driver);
            BenchMarkChartPage benchpage = new BenchMarkChartPage(driver);
            benchpage.ViewAsTables.Click();
            Thread.Sleep(2000);
            Assert.IsTrue(benchpage.ViewAsCharts.Displayed);
            benchpage.ViewAsCharts.Click();
            Thread.Sleep(2000);
            Assert.IsTrue(benchpage.ViewAsTables.Displayed);
        }

        public static void FillLoginForm(IWebDriver driver)

        {
            LoginScenarioPost loginScenario = new LoginScenarioPost(driver);
            loginScenario.UsernameField.Clear();
            loginScenario.UsernameField.SendKeys("internal");
            loginScenario.PasswordField.Clear();
            loginScenario.PasswordField.SendKeys("1908@twspssc");
            loginScenario.LoginButton.Click();
        }

        public static void SearchSchoolViaName(string schoolName,IWebDriver driver)

        {
            HomePage homepage = new HomePage(driver);
            GoHome(driver);
            homepage.School.Click();
            homepage.SchoolsearchField.SendKeys(schoolName);
            homepage.ClickOnSearchButton();
            Thread.Sleep(100);
        }
        public static void SearchSchool2(string urn,IWebDriver driver)
        {
            HomePage homepage = new HomePage(driver);
            GoHome(driver);
            homepage.School.Click();
            homepage.SchoolsearchField.SendKeys(urn);
            homepage.ClickOnSearchButton();
            Thread.Sleep(100);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            string SchoolPhase = detailspage.SchoolPhase.Text;
            string OverallSchoolPhase = detailspage.SchoolOverAllPhase.Text;
            string newformed = OverallSchoolPhase + "(" + SchoolPhase + ")";//Primary(Infant and junior)
            Console.WriteLine(OverallSchoolPhase);
            Console.WriteLine(SchoolPhase);
            Console.WriteLine(newformed);
            Thread.Sleep(100);

        }

        public static void testmailSuccess(String emailaddress, IWebDriver driver)
        {
            HomePage homepage = new HomePage(driver);
            homepage.SchoolorTrustDataQueryLink.Click();
            Thread.Sleep(100);
            DataQueriesPage queriespage = new DataQueriesPage(driver);
            queriespage.NameField.SendKeys("Carl Fagan");
            queriespage.EmailField.SendKeys(emailaddress);
            queriespage.SchoolNameField.SendKeys("Plumcroft Primary School");
            queriespage.LA_URN_CO_NUMBERField.SendKeys("100000");
            queriespage.QueryInputField.SendKeys("This is a Test Please Ignore");
            queriespage.SubmitButton.Click();
            Thread.Sleep(2000);


        }

        public List<String>  collect_aLL_Elements(IWebDriver driver)
        {
           
            List<IWebElement> schlist = new List<IWebElement>(driver.FindElements(By.XPath(("//a[contains(@href,'/school/detail?urn=')]"))));
            List<string> AuthorList = new List<string>();
            foreach (IWebElement element in schlist)
            {
                //Console.WriteLine(element.GetAttribute("href"));
                // element.Click();
                //((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
                //driver.SwitchTo().Window(driver.WindowHandles.Last());
                AuthorList.Add(element.GetAttribute("href"));
                //driver.Navigate().GoToUrl(element.GetAttribute("href"));
                //Thread.Sleep(10000000);
                //SchoolDetailPage detailpage = new SchoolDetailPage(driver);
                ////driver.Navigate().Back();
                
            }
            Console.WriteLine(AuthorList);
            return AuthorList;
        }



        public static void verify_schools_after_search(IWebDriver driver,IList resultlist)
        {
            IList schoollist = resultlist;
            foreach (IWebElement school in schoollist)

            {
                try
                {
                    Console.WriteLine(school.Text);
                   
                    SchoolDetailPage detailPage = new SchoolDetailPage(driver);
                    //Assert.IsTrue(detailPage.School_Name.Displayed);
                    //driver.Navigate().Back();
                    //Thread.Sleep(1000);

                }
                catch (NoSuchElementException) { continue; }
                //{ Assert.Fail }
            }
        }

        public static void testExcludeIncludeCheckboxSchName(string urn, IWebDriver driver)
        {
            HomePage homepage = new HomePage(driver);
            homepage.School.Click();
            homepage.SchoolsearchField.SendKeys(urn);
            homepage.IncludeSchoolsCheckbox.Click();
            Thread.Sleep(2000);
        }
        public static void SearchClosedschoolLAEstab(string LAestab, IWebDriver driver)
        {
            HomePage homepage = new HomePage(driver);
           
            homepage.School.Click();
            homepage.IncludeSchoolsCheckbox.Click();
            homepage.SchoolsearchField.SendKeys(LAestab);
            //homepage.secondSelectionOption.Click();
            homepage.ClickOnSearchButton();
            Thread.Sleep(300);
        }
        public static void SearchClosedschoolName(string schoolname, IWebDriver driver)
        {
            HomePage homepage = new HomePage(driver);

            homepage.School.Click();
            homepage.IncludeSchoolsCheckbox.Click();
            homepage.SchoolsearchField.SendKeys(schoolname);
            homepage.secondSelectionOption.Click();
            //homepage.ClickOnSearchButton();
            Thread.Sleep(300);
        }
        public static void SearchClosedschoolUrn(string urn, IWebDriver driver)
        {
            HomePage homepage = new HomePage(driver);

            homepage.School.Click();
            homepage.IncludeSchoolsCheckbox.Click();
            homepage.SchoolsearchField.SendKeys(urn);
            //homepage.secondSelectionOption.Click();
            homepage.ClickOnSearchButton();
            Thread.Sleep(300);
        }
        public static void dealforswchools(String LAESTAB, IWebDriver driver)
        {
            Actions.CallingClass.QuickCompareWithOtherSchools(LAESTAB,driver);
            Thread.Sleep(300);
            BenchMarkChartPage chartpage = new BenchMarkChartPage(driver);

        }
        public static void clearPopup(IWebDriver driver)
        {
            try
            {
                IWebElement closeButton = driver.FindElement(By.Id("js-modal-close"));

                if (closeButton.Displayed)
                {
                    closeButton.Click();
                }
                else
                {
                    Console.Write("modal not displayed here so moving on....");
                }
            }
            catch (NoSuchElementException e)
            {
                Console.Write("modal not displayed here so moving on....");
            }


        }
        public static void clearcookie(IWebDriver driver)
        {
            IWebElement closeCookie = driver.FindElement(By.Id("acceptAllCookies"));
            if (closeCookie.Displayed)
            { closeCookie.Click();
                Thread.Sleep(300);
                driver.Navigate().Refresh();
                Thread.Sleep(300);
                clearPopup(driver);
                Thread.Sleep(300);
            }

            
        }
        public static void gotonewspage(IWebDriver driver)

        {
            Thread.Sleep(1000);
            HomePage home = new HomePage(driver);
            home.NewsLink.Click();
            Thread.Sleep(100);
        }
        public static void acceptCookie(IWebDriver driver)
        {
            try
            {

                IWebElement closeCookie = driver.FindElement(By.Id("acceptAllCookies"));
                if (closeCookie.Displayed)
                {
                    closeCookie.Click();
                    Thread.Sleep(300);
                    //driver.Navigate().Refresh();
                    Thread.Sleep(300);
                }
            }
            catch (NoSuchElementException)
            {
                
            }
           
            
            }


            public static void gotonewspagefrombanner(IWebDriver driver)
        {
            driver.Close();
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Config.currentTestEnv);

            Thread.Sleep(1000);
            driver.Manage().Window.Maximize();
            IWebElement AcceptCookies = driver.FindElement(By.Id("acceptAllCookies"));
     
            Thread.Sleep(1000);

            //driver.Navigate().Refresh();
            Thread.Sleep(1000);
            IWebElement gotonewspage = driver.FindElement(By.XPath("/html/body/dialog/div/div/div/a"));
            gotonewspage.Click();
        }





        public static void AllThroughBIC(string LAname, IWebDriver driver)
        {
            HomePage homepage = new HomePage(driver);
            homepage.TrustLaCodeButton.Click();
            homepage.SchoolLacodeinputField.SendKeys(LAname);
            homepage.FirstIntellicenceSuggested.Click();
            homepage.LAcodesearchSubmitButton.Click();
            Thread.Sleep(300);
            SearchResultsPage resultspage = new SearchResultsPage(driver);
            resultspage.SelectAllThroughsCheckbox.Click();
            Thread.Sleep(30);
            resultspage.FirstScoolLinkOnPage.Click();
          
        }
        public static void NavigateToComparisonPage(IWebDriver driver)
        {
            SchoolDetailPage detailpage = new SchoolDetailPage(driver);
            detailpage.StartAComparison.Click();
            Thread.Sleep(3000);
        }
        public static void schoolSearchwithLaestab(string LAESTAB, IWebDriver driver)
        {
            HomePage homepage = new HomePage(driver);
            Thread.Sleep(200);
            homepage.School.Click();
            homepage.SchoolsearchField.Click();
            homepage.SchoolsearchField.SendKeys(LAESTAB);
            homepage.SearchSubmit.Click();
            Thread.Sleep(300);
        }

        public static void schoolsearchforSpecialSchool(string LAESTAB, IWebDriver driver)
        {
            HomePage homepage = new HomePage( driver);
            Thread.Sleep(200);
            homepage.School.Click();
            homepage.SchoolsearchField.Click();
            homepage.SchoolsearchField.SendKeys(LAESTAB);
            homepage.SearchSubmit.Click();
            Thread.Sleep(300);
            homepage.SenSpecialCharacteristicsLink.Click();
            Thread.Sleep(2000);
        }
      

        public static void TrustSearchWitNameUsingSubmitButton(string TrustName,IWebDriver driver)
        {
            GoHome(driver);
            HomePage homepage = new HomePage(driver);
            Thread.Sleep(100);
            homepage.TrustTab.Click();
            homepage.trustnameRadioButton.Click();
            homepage.TrustSearchInput.Click();
            homepage.TrustSearchInput.SendKeys(TrustName);
            homepage.FirstSelectionOption.Click();
            driver.FindElement(By.CssSelector(".bold-small")).Click();
            Thread.Sleep(100);
        }
        public static void TrustSearchWithCompanynumber(string companynumber,IWebDriver driver)
        {
            GoHome(driver);
            HomePage homepage = new HomePage(driver);
            homepage.TrustTab.Click();
            homepage.trustnameRadioButton.Click();
            homepage.TrustSearchInput.SendKeys(companynumber);
            Thread.Sleep(500);
            homepage.TrustSubmitButton.Click();
            Thread.Sleep(500);
        }
        public static void SearchByLocationUsingPostcode(string postcode, IWebDriver driver)
        {
            HomePage homepage = new HomePage(driver);
            homepage.LocationButton.Click();
            homepage.SearchByLocationField.Click();
            homepage.SearchByLocationField.SendKeys(postcode);
            try
            {
                if (homepage.FirstIntellicenceSuggested.Displayed)
                {
                    homepage.FirstIntellicenceSuggested.Click();
                    homepage.LocationSearchSubmitButton.Click();
                }
                else
                    homepage.LocationSearchSubmitButton.Click();
            }
            catch (NoSuchElementException)
            {
                homepage.LocationSearchSubmitButton.Click();
            }
            //homepage.FirstIntellicenceSuggested.Click();
            //homepage.LocationSearchSubmitButton.Click();
            //homepage.FirstSelectionOption.Click();
            Thread.Sleep(200);
            FiltersPage filters = new FiltersPage(driver);
            Thread.Sleep(200);

        }

        public static void AddAnotherSchoolManually(IWebDriver driver)
        {
            HomePage homepage = new HomePage(driver);
            homepage.LocationButton.Click();
            homepage.SearchLocationManually.Click();
            //homepage.SearchByLocationField.Clear();
            homepage.SearchLocationManually.SendKeys(Config.Credentials.PostCode.Postcode);
            homepage.LocationSearchSubmitButton.Click();
            driver.FindElement(By.CssSelector("li.document:nth-child(1) > a:nth-child(1)")).Click();
            Thread.Sleep(200);
            FiltersPage filters = new FiltersPage(driver);
            string ResultsDisplayedInitially = (filters.ResultsCount).Text;
            Console.WriteLine(ResultsDisplayedInitially);
            Thread.Sleep(200);
        }

        public static void SearchByLocationUsingLink(IWebDriver driver) //location enabling in firefox is an issue 
        {
            HomePage homepage = new HomePage(driver);
            homepage.LocationButton.Click();
            homepage.UseLocationLink.Click();
            Thread.Sleep(300);
            homepage.LocationSearchSubmitButton.Click();
            Thread.Sleep(200);

        }
        public static void select16plus(IWebDriver driver)
        {
            SearchResultsPage resultspage = new SearchResultsPage(driver);
            resultspage.Checkbox_16plus.Click();
            Thread.Sleep(300);
            resultspage.AddFirstResult.Click();
            Thread.Sleep(300);
        }
        public static void navigatepagination(IWebDriver driver)
        {
            SearchResultsPage resultspage = new SearchResultsPage(driver);
            resultspage.paginationSecondPage.Click();
            resultspage.paginationPreviousButton.Click();
        }
        public static void addtobasketviaresultspage(string postcode, IWebDriver driver)
        {
            SearchByLocationUsingPostcode(postcode,driver);
            SearchResultsPage resultspage = new SearchResultsPage(driver);
            resultspage.AddFirstResult.Click();
            Thread.Sleep(200);
            resultspage.EditBasket.Click();
            Thread.Sleep(200);
            BenchMarkBasketPage basketpage = new BenchMarkBasketPage(driver);
            Thread.Sleep(100);
            basketpage.clear_basket.Click();
            Thread.Sleep(2000);
            basketpage.backButton.Click();
            //Console.WriteLine(driver.Title);

        }
        public static void calculateSpecialSchoolSenCharacteristics(IWebDriver driver)
        {
            IList sencharacteristics = driver.FindElements(By.XPath("//tr/td[1]/span[1]"));
        }
        public static void downloadpdf(IWebDriver driver)
        {
            OnclickReportingTest(driver);
            BenchMarkChartPage benchmarkpage = new BenchMarkChartPage(driver);
            Thread.Sleep(1000);
            benchmarkpage.DownloadPage.Click();
            Thread.Sleep(1000);
            driver.SwitchTo().Window(driver.CurrentWindowHandle);
            benchmarkpage.PDFFormat.Click();
            Thread.Sleep(1000);
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            benchmarkpage.PDFFormat.SendKeys(Keys.Tab);
            benchmarkpage.PDFFormat.SendKeys(Keys.Tab);
            benchmarkpage.PDFFormat.SendKeys(Keys.Tab);
            Thread.Sleep(10000);
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            driver.SwitchTo().Window(driver.CurrentWindowHandle);
            IWebElement element = driver.FindElement(By.CssSelector(".button"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].scrollIntoView()", element);
            executor.ExecuteScript("arguments[0].click()", element);
            Thread.Sleep(10000);
        }
        public static void SearchTrustViaLocation(IWebDriver driver)
        {
            HomePage homepage = new HomePage(driver);
            Thread.Sleep(100);
            homepage.TrustTab.Click();
            homepage.TrustLocationButton.Click();
            homepage.TrustLocationField.SendKeys(Config.Credentials.PostCode.Postcode);
            homepage.TrustLocationField.SendKeys(Keys.Enter);
            //homepage.TrustLocationSubmit.Click();
           driver.FindElement(By.CssSelector("li.document:nth-child(1) > a:nth-child(1)")).Click();
            Thread.Sleep(10000);
        }

        public static void ViewSchoolsInTrust(IWebDriver driver)
        {
            SearchTrustViaLocation(driver);
            SearchResultsPage resultsPage = new SearchResultsPage(driver);
            Console.WriteLine(driver.FindElement(By.CssSelector("li.school-document:nth-child(1) > details:nth-child(3) > div:nth-child(2) > table:nth-child(1) > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(1) > a:nth-child(1)")).Text);
            Console.WriteLine(driver.FindElement(By.CssSelector("li.school-document:nth-child(1) > details:nth-child(3) > div:nth-child(2) > table:nth-child(1) > tbody:nth-child(2) > tr:nth-child(4) > td:nth-child(1) > a:nth-child(1)")).Text);

            //resultsPage.ViewTrustSchools.Click();
            Thread.Sleep(2000);
        }
        public static void verifyTrustIsOpen(IWebDriver driver)
        {
            ViewSchoolsInTrust(driver);

        }
        public static void searchSchoolViaLaCode(string lacode, IWebDriver driver)
        {
            HomePage homepage = new HomePage(driver);
            homepage.LacodeSearchButton.Click();
            homepage.LacodeSearchButton.Click();
            homepage.LacodeInputField.SendKeys(lacode);
            Thread.Sleep(2000);
        }
        public static void SearchTrustViaLocalAuthority(String LAcode, IWebDriver driver)
        {
            HomePage homepage = new HomePage(driver);
            Thread.Sleep(100);
            homepage.TrustTab.Click();
            homepage.LocalAuthorityTrustSearchButton.Click();
            homepage.TrustLaCodeInputField.SendKeys(LAcode);
            homepage.TrustLacodeSearchButton.Click();
            Thread.Sleep(10000);
        }
        public static void selectFirstSchoolInTrusts(IWebDriver driver)
        {
            SearchResultsPage resultsPage = new SearchResultsPage(driver);
            resultsPage.ViewTrustSchools.Click();
            Thread.Sleep(10000);
        }
        public static void ResultPageactionsA_Z(String LAcode,string OrderBy, IWebDriver driver)
        {
            SearchTrustViaLocalAuthority(LAcode,driver);
            SearchResultsPage resultspage = new SearchResultsPage(driver);
            resultspage.TrustSearchResultSortedByButton.Click();
            //if (Config.FirefoxDriverUnderTest == "firefox")
            //{
            //    resultspage.TrustSearchResultSortedByButton.SendKeys(OrderBy + Keys.Enter);
            //}
            resultspage.TrustSearchResultSortedByButton.SendKeys(OrderBy + Keys.Enter);
            //resultspage.TrustSearchResultSortedByButton.SendKeys(OrderBy + Keys.Enter);
            Thread.Sleep(2000);

        }
        public static void ResultPageactions(String LAcode, string OrderBy, IWebDriver driver)
        {
            SearchTrustViaLocalAuthority(LAcode,driver);
            SearchResultsPage resultspage = new SearchResultsPage(driver);
            resultspage.TrustSearchResultSortedByButton.Click();
            resultspage.TrustSearchResultSortedByButton.SendKeys(OrderBy + Keys.Enter);
            Thread.Sleep(2000);

        }
        public static void downloadFile(string fileType,IWebDriver driver)
        {
            driver.SwitchTo().ActiveElement();
            if (fileType == "pdf")
            {
                driver.SwitchTo().ActiveElement();
                
                IWebElement download_pdf_radio = driver.FindElement(By.Id("pdf-format"));
                IWebElement downloadButton = driver.FindElement(By.XPath("/html/body/modal-container/div/div/div[2]/div/button"));
                download_pdf_radio.Click();
                downloadButton.Click();
            }
            else if (fileType == "ppt")
            {
                driver.SwitchTo().ActiveElement();
                IWebElement download_ppt_radio = driver.FindElement(By.Id("ppt-format"));
                IWebElement downloadbutton = driver.FindElement(By.XPath("/html/body/modal-container/div/div/div[2]/div/button"));
                download_ppt_radio.Click();
               downloadbutton.Click();
            }
        }

        public static void downloadcsv(IWebDriver driver)
        {
            OnclickReportingTest(driver);
            BenchMarkChartPage benchmarkpage = new BenchMarkChartPage(driver);
            benchmarkpage.Downloadata.Click();
            //Thread.Sleep(1000);
        }
        public static void downloadppt(IWebDriver driver)
        {
            OnclickReportingTest(driver);
            BenchMarkChartPage benchmarkpage = new BenchMarkChartPage(driver);
            Thread.Sleep(1000);
            benchmarkpage.DownloadPage.Click();
            Thread.Sleep(1000);
            benchmarkpage.PowerPointFormat.Click();
            IWebElement element = driver.FindElement(By.CssSelector(".button"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].scrollIntoView()", element);
            Thread.Sleep(10000);
            executor.ExecuteScript("arguments[0].click()", element);
            Thread.Sleep(1000);
        }
        public static void savebenchmarkbasket(IWebDriver driver)
        {
            OnclickReportingTest(driver);
            BenchMarkChartPage benchmarkpage = new BenchMarkChartPage(driver);
            benchmarkpage.Savebenchmarkbasket.Click();
            benchmarkpage.CopyLinkToClipboard.Click();
            Thread.Sleep(300);
        }
        public static void searchschoolLaCode(String Lacode, IWebDriver driver)
        {
            HomePage homepage = new HomePage(driver);
           
            homepage.School.Click();
            homepage.SchoolLacodeButton.Click();
            homepage.SchoolLacodeinputField.SendKeys(Lacode);
            homepage.LacodeSearchButton.Click();
            Thread.Sleep(100);

        }

        //public static void ManualTrustComparison(String TrustName,IWebDriver driver)
        //{
            
        //    TrustActions.TrustSearchWitNameUsingFirstSuggestedName(TrustName,driver);
        //    TrustComparisonPage trustComaprison = new TrustComparisonPage(driver);
        //    Thread.Sleep(1000);
        //    trustComaprison.Compare_withOtherTrusts.Click();
        //    Thread.Sleep(500);
        //    trustComaprison.ManuallyAddTrustsRadio.Click();
        //    trustComaprison.TrustComparisonPageContinueButton.Click();
        //    //trustComaprison.EnterTrustForComparisonOption.Click();
        //    Thread.Sleep(500);
        //    trustComaprison.EnterTrustforCompareNameField.SendKeys("Ark Schools");
        //   // trustComaprison.EnterTrustforCompareNameField.SendKeys(Keys.Enter);
        //    driver.FindElement(By.CssSelector(".tt-suggestion > a:nth-child(1)")).Click();//select the first suggested 
        //    Thread.Sleep(500);
        //    trustComaprison.ViewBenchMarkingCharts.Click();
        //    Thread.Sleep(500);
        //}

        //public static void SelectCharacteristicsToFindTrusts(String TrustName,IWebDriver driver)
        //{
        //    TrustActions.TrustSearchWitNameUsingFirstSuggestedName(TrustName, driver);
        //    TrustComparisonPage trustComaprison = new TrustComparisonPage(driver);
        //    Thread.Sleep(1000);
        //    trustComaprison.Compare_withOtherTrusts.Click();
        //    Thread.Sleep(500);
        //    trustComaprison.SelectTrustsByCharacteristicsRadioButton.Click();
        //    trustComaprison.TrustComparisonPageContinueButton.Click();


        //}
          
        public class CallingClass // This will have to be refactored in future when tests are stable
        {
            public static void SearchByLaCode(string lacode, IWebDriver driver)
            {
                HomePage homepage = new HomePage(driver);
                homepage.TrustTab.Click();
                homepage.LocalAuthorityTrustSearchButton.Click();
                Thread.Sleep(300);
                homepage.LacodeInputField.SendKeys(lacode);
                homepage.TrustLacodeSearchButton.Click();

            }
            public static void TestHelpUsingSiteLinks(IWebDriver driver)
            {
                SpecialElementsPage links = new SpecialElementsPage(driver);
                GoHome(driver);
                links.HelpUsingSiteLink.Click();
                Thread.Sleep(1000);
            }
            public static void TestDatasourcesLink(IWebDriver driver)

            {
                SpecialElementsPage links = new SpecialElementsPage(driver);
                links.DataSources.Click();
                Thread.Sleep(1000);
            }
            public static void TestIntepreTingTheChartsLinks(IWebDriver driver)
            {
                SpecialElementsPage links = new SpecialElementsPage(driver);
                links.IntepreTingTheChartsLinks.Click();
                Thread.Sleep(1000);
            }
            
            public static void AcceptAlert(IWebDriver driver)
            {
                IAlert alert = driver.SwitchTo().Alert();
                alert.Accept();
            }
            public static void Verifybasket(IWebDriver driver)
            {
                Thread.Sleep(3000);
                SearchSchoolViaName("plumcroft ",driver);
                Thread.Sleep(3000);
                SchoolDetailPage Schooldetails = new SchoolDetailPage(driver);
                SearchResultsPage resultspage = new SearchResultsPage(driver);
                resultspage.FirstElementPresented.Click();
                Thread.Sleep(3000);
                Schooldetails.AddToBenchMarkBasket.Click();
                Thread.Sleep(300);
            }

            public static void VerifyDefaultSchoolColour(String LAEstab,IWebDriver driver)
            {
                Actions.schoolSearchwithLaestab(LAEstab,driver);
                SchoolDetailPage Schooldetails = new SchoolDetailPage(driver);
                Schooldetails.SetasDefaultSchool.Click();
                Thread.Sleep(1000);
                Schooldetails.CompareWithOtherSchools.Click();
                Thread.Sleep(2000);
                string colortext = driver.FindElement(By.CssSelector(".highlight > span:nth-child(1)")).GetAttribute("color");
                Console.WriteLine(colortext);
                Console.Write(colortext);
            }


            public static void Verifybasketcapacity(IWebDriver driver)
            {  
                SchoolDetailPage Schooldetails = new SchoolDetailPage(driver);
                SearchResultsPage resultspage = new SearchResultsPage(driver);
                URNHelper helpers = new URNHelper();
                IList urns = helpers.Urns;
                    foreach (string urn in urns) {
                    try
                    {
                        SearchSchoolViaName(urn,driver);                  
                        Schooldetails.AddToBenchMarkBasket.Click();
                        Thread.Sleep(10000);
                    }
                    catch (NoSuchElementException ){ continue; }                       
                    }

                }


            public static List<string> collectSchools (IWebDriver driver)
            {
                SchoolDetailPage Schooldetails = new SchoolDetailPage(driver);
                SearchResultsPage resultspage = new SearchResultsPage(driver);
                List<string> schoolurls = new List<string>();
                List<IWebElement> schlist = new List<IWebElement>(driver.FindElements(By.XPath(("//a[contains(@href,'/school/detail?urn=')]"))));
           
                foreach (IWebElement schl in schlist)
                {
                    try
                    {
                        Console.WriteLine(schl.GetAttribute("href"));
                        schoolurls.Add(schl.GetAttribute("href"));
                        return schoolurls;
                    }
                    catch (NoSuchElementException) { continue; }

                    
                }
                return schoolurls;
            }

            public static void verifyschoolLA(IWebDriver driver)
            {
                List<string> schoolurls = Actions.CallingClass.collectSchools(driver);
                foreach (string url in schoolurls)
                {
                    driver.Navigate().GoToUrl(url);

                }
            }


            public static void sptlinkscheck(IWebDriver driver)
            {
                SchoolDetailPage Schooldetails = new SchoolDetailPage(driver);
                URNHelper helpers = new URNHelper();
                IList urns = helpers.Urns;
                foreach (string urn in urns)
                {
                    try
                    {
                        //Console.WriteLine(urn);
                        SearchSchoolViaName(urn,driver);
                        Thread.Sleep(30);
                        //Schooldetails.schoolPerformanceTableLink.Click();
                        Thread.Sleep(50);
                       
                    }
                    catch (NoSuchElementException) {Console.WriteLine("There may be an issue with this school" + ""+ urn); continue; }
                }
            }
            public static void verifylalink(IWebDriver driver)
            {
                SchoolDetailPage Schooldetails = new SchoolDetailPage(driver);
                SearchResultsPage resultspage = new SearchResultsPage(driver);
                URNHelper helpers = new URNHelper();
                IList urns = helpers.Urns;
                foreach (string urn in urns)
                {
                    try
                    {
                        SearchSchoolViaName(urn,driver);

                        Schooldetails.LocalAuthorityLink.Click();
                       
                        Assert.IsTrue(driver.Url.Contains(Config.currentTestEnv + "SchoolSearch/Search?nameId=&suggestionUrn=&trustnameid=&trustsuggestionUrn=&locationorpostcode=&LocationCoordinates=&openOnly=true&lacodename="));
                    }
                    catch (NoSuchElementException) { continue; }

                }

            }
            public static void SearchViaSchoolurn( string urn, IWebDriver driver)
            {
                HomePage homepage = new HomePage(driver);
                homepage.School.Click();
                Thread.Sleep(100);
                homepage.SchoolsearchField.SendKeys(urn);
                Thread.Sleep(1000);
                homepage.ClickOnSearchButton();
                Thread.Sleep(1000);
                
            }
            public static void QuickCompareWithOtherSchools(String Laestab, IWebDriver driver)
            {
              SearchViaSchoolurn(Laestab,driver);//"143592"
                SchoolDetailPage detailspage = new SchoolDetailPage(driver);
                detailspage.StartAComparison.Click();
               
                TypeOfComparisonPage comparisontype = new TypeOfComparisonPage(driver);
                comparisontype.CreateabenchmarkComparisonButton.Click();
                BestInClass bestinclass = new BestInClass(driver);
                Thread.Sleep(200);
                bestinclass.QuckComparisonButton.Click();
                bestinclass.Continue.Click();
                bestinclass.MaintainedSchoolsChoice.Click();
                bestinclass.Continue.Click();
                //bestinclass.MaintainedSchoolsChoice.Click();
                //Thread.Sleep(50000);
                bestinclass.page2of2ContinueButton.Click();
                Thread.Sleep(100);
            }
            public static void QuickCompareWithSpecialSchools(String Laestab, IWebDriver driver)
            {
                SearchViaSchoolurn(Laestab,driver);//"143592"
                SchoolDetailPage detailspage = new SchoolDetailPage(driver);
                //SchoolDetailPage detailspage = new SchoolDetailPage(driver);
                detailspage.StartAComparison.Click();
                //detailspage.CompareWithOtherSchools.Click();
                TypeOfComparisonPage comparisontype = new TypeOfComparisonPage(driver);
                comparisontype.CreateabenchmarkComparisonButton.Click();
               // detailspage.CompareWithOtherSchools.Click();
                BestInClass bestinclass = new BestInClass(driver);
                Thread.Sleep(200);
                bestinclass.QuckComparisonButton.Click();
                QuickComparisonPage2 specialsquickpage = new QuickComparisonPage2(driver);
                specialsquickpage.SchoolswithSimilarAgedStudentscheckbox.Click();
                specialsquickpage.ContinueToBenchMarkingChartButton.Click();
                Thread.Sleep(3000);
                
            }

            public static void searchschoolwithIncompleteFinance(String urn,IWebDriver driver)
            {
                SearchViaSchoolurn(urn,driver);
                SchoolDetailPage detailspage = new SchoolDetailPage(driver);
                detailspage.CompareWithOtherSchools.Click();
                BestInClass bestinclass = new BestInClass(driver);
                bestinclass.QuckComparisonButton.Click();
                bestinclass.Continue.Click();
                bestinclass.Continue.Click();
                bestinclass.AllSchoolsChoice.Click();
                bestinclass.ContinueToBenchMarkChartsButton.Click();
                BenchMarkChartPage chartpage = new BenchMarkChartPage(driver);
                Thread.Sleep(3000);
                IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
                executor.ExecuteScript("document.querySelector(#chart_0 > svg:nth-child(1) > g:nth-child(2) > g:nth-child(7) > g:nth-child(17) > circle:nth-child(3))");
            }
            public static void ContinuetoBenchmarkCharts(IWebDriver driver)
            {
                BestInClass bestinclass = new BestInClass(driver);
                bestinclass.ContinueToBenchMarkChartsButton.Click();
                Thread.Sleep(100);
            }
            public static void ViewCharts(IWebDriver driver)
            {
                ContinuetoBenchmarkCharts(driver);
                BestInClass bestinclass = new BestInClass(driver);
                bestinclass.YourChartTab.Click();
                Thread.Sleep(1000);
            }

            public static void BestInClassComparison(IWebDriver driver)
            {
                GoHome(driver);
                SearchViaSchoolurn("125271",driver);
                Thread.Sleep(2000);
                SchoolDetailPage detailspage = new SchoolDetailPage(driver);
                Thread.Sleep(3);
                detailspage.StartAComparison.Click();
                TypeOfComparisonPage comparisontype = new TypeOfComparisonPage(driver);
                comparisontype.HighestprogressSchoolsComparisonButton.Click();
               
                BestInClass bestinclass = new BestInClass(driver);
                acceptCookie(driver);
               
                Thread.Sleep(3000);
                bestinclass.ContinueToHigherProgressSchoolBenchmark.Click();
                Thread.Sleep(1000);
            }
            public static void SchoohSearchOfstedRating(IWebDriver driver)
            {
                SearchViaSchoolurn("142253",driver);
                SchoolDetailPage detailspage = new SchoolDetailPage(driver);                              
            }
            public void ComparisonTabothercharts(IWebDriver driver)
            {
                OnclickReportingTest(driver);
            }
            public static void SchoolMap(IWebDriver driver)
            {
                GoHome(driver);
                SearchViaSchoolurn("131030",driver);
                SchoolDetailPage detailspage = new SchoolDetailPage(driver);
                Assert.IsTrue(detailspage.School_Location_Map.Displayed);
            }
            public static void ViewBenchMarkChartsButton(IWebDriver driver)
            {
                SearchSchoolViaName("Oswald Road Primary School",driver);
                SchoolDetailPage Schooldetails = new SchoolDetailPage(driver);
                Schooldetails.AddToBenchMarkBasket.Click();
            }

            public static void IsButtonPresent(IWebDriver driver)
            {
                GoHome(driver);
                SchoolDetailPage Schooldetails = new SchoolDetailPage(driver);
                SearchSchoolViaName("Oswald Road Primary School",driver);
                SearchResultsPage resultspage = new SearchResultsPage(driver);
                resultspage.FirstElementPresented.Click();
                Schooldetails.AddToBenchMarkBasket.Click();
                Thread.Sleep(3000);
                CallingClass.SearchViaSchoolurn("100000",driver);
                Schooldetails.AddToBenchMarkBasket.Click();
                Thread.Sleep(3000);
                Schooldetails.ViewBenchMarkCharts.Click();

            }

            public static void InterpretingTheChartsTest(IWebDriver driver)
            {
                SpecialElementsPage links = new SpecialElementsPage(driver);
                GoHome(driver);
                links.IntepreTingTheChartsLinks.Click();
            }
            public static void AddSchools(IWebDriver driver)
            {
                Verifybasket(driver);
                SchoolDetailPage detailpage = new SchoolDetailPage(driver);
                detailpage.EditBasket.Click();
                Thread.Sleep(3000);
                BenchMarkBasketPage basketpage = new BenchMarkBasketPage(driver);
              
                driver.FindElement(By.CssSelector("a.benchmarkControls")).Click();//need to create a new class for manual benchmark page
                
                HomePage home = new HomePage(driver);
                home.School.Click();
                Thread.Sleep(3000);
                home.SchoolsearchField.SendKeys("100231");
                Thread.Sleep(200);
                home.SearchSubmit.Click();
                Thread.Sleep(1000);
                SchoolDetailPage detailspage = new SchoolDetailPage(driver);
                detailspage.AddToBenchMarkBasket.Click();
                Thread.Sleep(1000);
            }
            public static void ClearSchools(IWebDriver driver)
            {
                Verifybasket(driver);
                SchoolDetailPage detailpage = new SchoolDetailPage(driver);
                detailpage.EditBasket.Click();
                BenchMarkBasketPage basketpage = new BenchMarkBasketPage(driver);
                basketpage.ClearBasket.Click();
                Thread.Sleep(1000);
            }
            public static void addanotherschoolvianameorlocationlink(IWebDriver driver)
            {
                QuickCompareWithOtherSchools("2032471",driver);
                BenchMarkChartPage chartpage = new BenchMarkChartPage(driver);
                Thread.Sleep(2000);
                chartpage.AddanotherschoolLink.Click();
            }

            public String numberberofcharacteristicsDisplayed(IWebDriver driver)
            {
                List<string> numberofsenCharacteristics = new List<string>();
                String beforexpath = "//*[@id=\"content\"]/main/div[2]/div[1]/details/div/table/tbody/tr[";
                String afterxpath = "]/td[1]/span";
                for (int i = 1; i > 0; i++)
                {
                    IWebElement SenCharactristics = driver.FindElement(By.XPath(beforexpath + i + afterxpath));
                    numberofsenCharacteristics.Add(SenCharactristics.Text);
                    
                    
                }
                return numberofsenCharacteristics.Count.ToString();
                    
            }

           

        }
    }
}
       

