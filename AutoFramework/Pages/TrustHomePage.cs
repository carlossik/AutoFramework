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
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "h1")]
        public IWebElement TrustName { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "a.govuk-button:nth-child(3)")]
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
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#IncomeTab > a:nth-child(1)")]
        public IWebElement IncomeTab { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "button.view-charts-tables:nth-child(2) > span:nth-child(2)")]
        public IWebElement ViewAschartsButton { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "a[@id='tab_dashboard']")]
        public IWebElement TrustDashboardTab { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//a[@id='tab_details']")]
        public IWebElement TrustDetailsTab { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//a[@id='tab_finance']")]
        public IWebElement TrustFinanceTab { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "span[contains(text(),'View characteristics used')]")]
        public IWebElement ViewCharacteristicsUsed { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "a[contains(text(),'self-assessment dashboard')]")]
        public IWebElement SeeSadDashboard { get; set; }
        ////body/div[@id='js-modal-page']/div[@id='content']/div[1]/main[1]/div[2]/div[1]/div[1]/a[1]
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector,Using = "a.govuk-button:nth-child(3)")]
        public IWebElement TrustStartComparison { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//a[contains(text(),'Teaching staff')]")]
        public IWebElement TeachinSgtaff { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//a[contains(text(),'Supply staff')])")]
        public IWebElement TrustSupplyStaff { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//a[contains(text(),'Education support staff')]")]
        public IWebElement TrustEducationSupportStaff { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.LinkText, Using = "Admin. and clerical staff")]
        public IWebElement TrustAdminAndClerical { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//a[contains(text(),'Other staff costs')]")]
        public IWebElement TrustOtherStaff { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//a[contains(text(),'Premises costs')]")]
        public IWebElement TrustPremisesCost{ get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.LinkText,Using = "Educational supplies")]
        public IWebElement TrustEducationalSupplies { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//a[contains(text(),'Energy')]")]
        public IWebElement TrustEnergy { get; set; }


    }
}
