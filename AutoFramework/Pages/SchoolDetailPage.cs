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

namespace AutoFramework.Pages.PageElements
{
    class SchoolDetailPage
    {

        public SchoolDetailPage(IWebDriver driver)
        {


            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
        }



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
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = " a.add-remove-js:nth-child(3)")]
        public IWebElement AddToBenchMarkBasket { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector,Using = "#\\31 44406desktop > button:nth-child(2)")]
        public IWebElement FirstSearchItem { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "dd.metadata-school-detail__dd:nth-child(14)")]
        public IWebElement OfstedRating { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".heading-xlarge")]
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
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = ".error-summary")]
        public IWebElement schooldetailnotfoundmessage { get; set; }
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


        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = ".exp-total")]

        public IWebElement FinanceDisplayed { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.XPath, Using = ".//a[contains(@href, '/trust?uid=')]")]

        public IWebElement CurrentTrustLinkDisplayed { get; set; }  //"/trust?companyNo=7719620


        [SeleniumExtras.PageObjects.FindsBy(How = How.XPath, Using = ".//a[contains(@href, '/trust?companyNo=')]")]

        public IWebElement CurrentTrustLinkDisplayed2 { get; set; }



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



    }





}//button

