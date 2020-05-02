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

namespace AutoFramework.Pages.PageElements
{
    class SchoolDetailPage
    {

        public SchoolDetailPage()
        {


            SeleniumExtras.PageObjects.PageFactory.InitElements(Driver.driver, this);
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
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = " a.add-remove-js:nth-child(4)")]
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
        [SeleniumExtras.PageObjects.FindsBy(How = How.Id, Using = "DownloadLinkText")]
        public IWebElement OneClickReportingLink { get; set; }
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
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = " dd.metadata-school-detail__dd:nth-child(28)")]
        public IWebElement Date_Of_Closure { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = "dd.metadata-school-detail__dd:nth-child(12)")]
        public IWebElement NumberOfPupils { get; set; }
        //[SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = ".govuk-box-highlight__link")]
        //public IWebElement DealsForSchools_Link { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = "span.twitter-typeahead:nth-child(3) > div:nth-child(4)")]
        public IWebElement FirstOptionOnSchoolsearch { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = ".heading-xlarge")]
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
            

        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = ".exp-total")]

        public IWebElement FinanceDisplayed { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector,Using = "dd.metadata-school-detail__dd:nth-child(6) > a:nth-child(1)")]
        public IWebElement LocalAuthorityLink { get; set; }
        //public string SchoolPhaseValue = Driver.driver.FindElement(By.CssSelector("dd.metadata-school-detail__dd:nth-child(12)")).Text;
        //public string OverallSchoolPhaseValue = Driver.driver.FindElement(By.CssSelector("dd.metadata-school-detail__dd:nth-child(10)")).Text;
        //public string newvalue = OverallSchoolPhaseValue


    }





}//button

