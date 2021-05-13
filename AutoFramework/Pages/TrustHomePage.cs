using AutoFramework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFB_Test_Automation.AutoFramework.Pages
{
    class TrustHomePage
    {
        public TrustHomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".heading-xlarge")]
        public IWebElement TrustName { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//a[@class='button start-button hide-in-print']")]
        public IWebElement CompareWithOtherTrustsButton  {get; set;}
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//dd[1]")]
        public IWebElement CompaniesHouseNumber  { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "a.trust-ext-link:nth-child(1)")]
        public IWebElement DataFromOtherServicesMat_Link  {get; set;}
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "a.trust-ext-link:nth-child(3)")]
        public IWebElement DataFromOtherServicesGet_MoreInfoLink { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".result-list-summary > span:nth-child(1)")]
        public IWebElement NumberOfAcaDemies { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//*[@id=\"content\"]/main/div[1]/div[1]/a/text()")]
        public IWebElement SelectSchoolsToCompareLink { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".resultListPanel > summary:nth-child(1) > span:nth-child(1)")]
        public IWebElement ViewAllacademiesLink { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "a.no-underline")]
        public IWebElement DownloadDataForTrustLink { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".active > button:nth-child(1)")]
        public IWebElement ExpenditureTab { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = ".negative-balance")]
        public IWebElement InYearBalanceValue  { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = ".inc-total")]
        public IWebElement IncomeValue { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "div.column-third:nth-child(1) > div:nth-child(1) > h2:nth-child(1)")]
        public IWebElement ExpenditureValue { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "CurrentHeader")]
        public IWebElement SchoolsCurrentlyInTrustTab { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "LatestTermHeader")]
        public IWebElement SchoolsIn1819SubmissionTab { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "HistoryTermHeader")]
        public IWebElement TrustHistoryTab { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "span.bold:nth-child(3)")]
        public IWebElement NumberOfSchools1819 { get; set; }
        
        //span.bold:nth-child(3)

        //CurrentHeader

    }
}
