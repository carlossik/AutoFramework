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
        public TrustHomePage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".heading-xlarge")]
        public IWebElement TrustName { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//*[contains(., 'Compare with other trusts')]")]
        public IWebElement CompareWithOtherTrustsButton  {get; set;}
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".ml-05")]
        public IWebElement CompaniesHouseNumber  { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "a.trust-ext-link:nth-child(1)")]
        public IWebElement DataFromOtherServicesMat_Link  {get; set;}
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "a.trust-ext-link:nth-child(3)")]
        public IWebElement DataFromOtherServicesGet_MoreInfoLink { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".result-list-summary > span:nth-child(1)")]
        public IWebElement NumberOfAcaDemies { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".result-list-summary > a:nth-child(3)")]
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

    }
}
