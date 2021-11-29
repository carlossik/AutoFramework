using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFramework.Pages;
using How = SeleniumExtras.PageObjects.How;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace AutoFramework.Pages.PageElements
{
    class SchoolDetailPage
    {

        public SchoolDetailPage(IWebDriver driver)
        {


            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
        }

        //a.button:nth-child(3)
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "a.govuk-button:nth-child(3)")]
        public IWebElement StartAComparison { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#benchmarkBasket > div > div > div")]
        [SeleniumExtras.PageObjects.CacheLookup]
        public IWebElement BenchmarkBasket { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#benchmarkBasket > div > div > div > a")]
        public IWebElement EditBasket { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#benchmarkBasket > div > div > div > button")]
        public IWebElement ClearBasket { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#benchmarkControlsPlaceHolder > div.compare-buttons-panel.compare-buttons-panel--set-unset > div > button:nth-child(2) > span")]
        public IWebElement SetasDefaultSchool { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".compare-buttons-panel__button--compare")]
        public IWebElement CompareWithOtherSchools { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//span[contains(text(),'Add to benchmark set')]")]
        public IWebElement AddToBenchMarkBasket { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "button.pl-0:nth-child(2) > div:nth-child(2) > span:nth-child(1)")]
        public IWebElement AddToBenchMarkSetDetailspage { get; set; }
        //button.pl-0:nth-child(2) > div:nth-child(2) > span:nth-child(1)

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector,Using = "#\\31 44406desktop > button:nth-child(2)")]
        public IWebElement FirstSearchItem { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "dd.metadata-school-detail__dd:nth-child(14)")]
        public IWebElement OfstedRating { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "h1.govuk-heading-xl")]
        public IWebElement School_Name { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "SchoolLocationMap")]
        public IWebElement School_Location_Map { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".view-benchmark-charts-wrapper > a:nth-child(1)")]
        public IWebElement ViewBenchMarkCharts { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector,Using = "#manualButton")]
        public IWebElement ContinueToManualBenchMarkCharts { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "dd.metadata-school-detail__dd:nth-child(10)")]
        public IWebElement SchoolOverAllPhase { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "dd.metadata-school-detail__dd:nth-child(12)")]
        public IWebElement SchoolPhase { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = "a.button:nth-child(1)")]
        public IWebElement Compare { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = ".sfb_gtm_auto_report")]
        public IWebElement BasicComparisonReportLink { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = ".sfb_gtm_address")]
        public IWebElement Address { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = "dd.metadata-school-detail__dd:nth-child(16)")]
        public IWebElement Urn { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = ".sfb_gtm_tel")]
        public IWebElement Telephone_Number { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = ".sfb_gtm_more_info")]
        public IWebElement DataFromOtherSources { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = " .sfb_gtm_more_info")]
        public IWebElement Services { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = " dd.metadata-school-detail__dd:nth-child(29)")]
        public IWebElement Date_Of_Closure { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = "dd.metadata-school-detail__dd:nth-child(12)")]
        public IWebElement NumberOfPupils { get; set; }
        //[SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = ".govuk-box-highlight__link")]
        //public IWebElement DealsForSchools_Link { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = "span.twitter-typeahead:nth-child(3) > div:nth-child(4)")]
        public IWebElement FirstOptionOnSchoolsearch { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = ".govuk-list > li:nth-child(1) > a:nth-child(1)")]
        public IWebElement schooldetailnotfoundmessage { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = "dd.metadata-school-detail__dd:nth-child(22)")]
        public IWebElement HeadTeacher_Name { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = ".message")]
        public IWebElement SchooldetailInfoPanel { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = "#Financing")]
        public IWebElement FinanceDropdown { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = "#Financing > option:nth-child(2)")]
        public IWebElement FinanceDropdown_Trust_Only { get; set; }
        //[SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector,Using = "dd.metadata-school-detail__dd:nth-child(12)")]
        //public IWebElement SchoolPhase { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector,Using = "a.spt_link_js")]
        public IWebElement schoolPerformanceTableLink { get; set; }
        //[SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = ".list > li:nth-child(2) > a:nth-child(1)")]
        //public IWebElement SADLink { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//*[text()=\"Self-assessment dashboard\"]")]
        public IWebElement SADLink { get; set; }
        ///html/body/div/div[3]/div[7]/main/div[1]/div[2]/aside/ul/li[2]/a
        [SeleniumExtras.PageObjects.FindsBy(How = How.XPath,Using = "//div[@class='combined-warnings']/p[1]")]
        public IWebElement FederationWithoutFinance { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = "dd.metadata-school-detail__dd:nth-child(32) > a:nth-child(1)")]
        public IWebElement federationsLink { get; set; }
        //dd.metadata-school-detail__dd:nth-child(32) > a:nth-child(1)
        
        [SeleniumExtras.PageObjects.FindsBy(How = How.XPath, Using = "/html/body/div/div[3]/div[6]/main/div[2]/div[1]/div/a")]

        public IWebElement GoTo_SADButton_For_School_without_finance { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = ".exp-total")]

        public IWebElement FinanceDisplayed { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.XPath, Using = ".//a[contains(@href, '/trust?uid=')]")]

        public IWebElement CurrentTrustLinkDisplayed { get; set; }  //"/trust?companyNo=7719620


        [SeleniumExtras.PageObjects.FindsBy(How = How.XPath, Using = ".//a[contains(@href, '/trust?companyNo=')]")]

        public IWebElement CurrentTrustLinkDisplayed2 { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector,Using = ".govuk-breadcrumbs__link")]
        public IWebElement HomepageButton { get; set; }



        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector,Using = "dd.metadata-school-detail__dd:nth-child(6) > a:nth-child(1)")]
        public IWebElement LocalAuthorityLink { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.Id, Using = "Financing")]
        public IWebElement MatFinanceToggle { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = ".list > li:nth-child(1) > a:nth-child(1)")]
        public IWebElement EfficiencyMetricLink { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.XPath, Using = "//a[contains(@href, '/trust?uid=')]")]
        public IWebElement IntrustLink { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.XPath,Using = "//a[contains(@href, '/trust?companyNo=')]")]
        public IWebElement previousTrustLink { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector,Using = "dt.metadata-school-detail__dt:nth-child(31)")]
        public IWebElement trustText { get; set; }


        [SeleniumExtras.PageObjects.FindsBy(How = How.XPath, Using = "//div[@class='footer-meta-inner']/ul[1]/li[2]/a[1]")]
        public IWebElement AssessibilityLink { get; set; }

        //By.xpath("//*[text()='Academy trust']"));
        public bool  istrusttextDisplayed()
        {
            try
            {
                if (trustText.Text.Contains("Academy trust"))
                {
                    return true;
                }
            }
            catch (OpenQA.Selenium.NoSuchElementException e) { }
            return false;
        }

        public bool IsTrustLinkDisplayed()
        {

            try
            {
                //bool useduid = IntrustLink.Displayed;
                //bool usedcompno = previousTrustLink.Displayed;
                //bool result = useduid || usedcompno;
                if ((IntrustLink.Displayed ^ previousTrustLink.Displayed))
                {
                    return true;
                }
                else 
                {
                    //Console.WriteLine("I am not sure why this is evaluating to false when it should be true?");
                   return false;
                }
                
            }
            catch (OpenQA.Selenium.NoSuchElementException e) { }
            Console.WriteLine("I am not sure why this is evaluating to false when it should be true?");
            return false;
        }
        public bool verifySADLink()
        {

            try
            {
                if (SADLink.Displayed)
                {
                    return true;
                }
                
            }
            catch (OpenQA.Selenium.NoSuchElementException e) { }

            return false;

        }

        public void clickSadLink(IWebDriver driver)
        {
            try { 

            if (SADLink.Displayed)
            {
                SADLink.Click();
                Thread.Sleep(200);
                Actions.acceptCookie(driver);
                Thread.Sleep(200);

                }
                 }
            catch (OpenQA.Selenium.NoSuchElementException e) { }

        }

        public  String compareWithGiasData(IWebDriver driver, string urn)
        {
            var giasurl = Config.giasurl + urn;
            var chromedriverpath = Config.chrome_path;
            var options = new ChromeOptions();
            options.AddArgument("--headless");
            driver = new ChromeDriver( options);
            driver.Navigate().GoToUrl(giasurl);
            IWebElement closemodal = driver.FindElement(By.Id("gias-modal-close"));
            closemodal.Click();
            IWebElement acceptCookie = driver.FindElement(By.CssSelector("button.govuk-button:nth-child(1)"));
            acceptCookie.Click();
            IWebElement schoolname = driver.FindElement(By.CssSelector(".govuk-heading-l"));
            var Fschoolname = (schoolname.Text).Replace("\n", "").Replace("\r", "").Replace("Establishment", "");
            Console.WriteLine(Fschoolname);
            driver.Close();
            return Fschoolname;
            


        }
        public String compareWithGiasDataHeadTeacher_Name(IWebDriver driver, string urn)
        {
            var giasurl = Config.giasurl + urn;
            var chromedriverpath = Config.chrome_path;
            var options = new ChromeOptions();
            options.AddArgument("--headless");
            var firefoxdriverpath = Config.firefoxlocation;
            var firefoxOptions = new FirefoxOptions();
            firefoxOptions.AddArguments("--headless");

            //driver = new ChromeDriver(chromedriverpath, options);
            driver = new FirefoxDriver(firefoxOptions);
            driver.Navigate().GoToUrl(giasurl);
            IWebElement closemodal = driver.FindElement(By.Id("gias-modal-close"));
            closemodal.Click();
            IWebElement acceptCookie = driver.FindElement(By.CssSelector("button.govuk-button:nth-child(1)"));
            acceptCookie.Click();
            IWebElement headTeacherName = driver.FindElement(By.CssSelector("#details-summary > dl:nth-child(1) > div:nth-child(3) > dd:nth-child(2)"));
            var FheadTeacherName = (headTeacherName.Text).Replace("\n", "").Replace("\r", "").Replace("Principal", "").Trim();
            Console.WriteLine(FheadTeacherName);
            driver.Close();
            return FheadTeacherName;



        }

    }





}//string cleaned = example.Replace("\n", "").Replace("\r", "");

