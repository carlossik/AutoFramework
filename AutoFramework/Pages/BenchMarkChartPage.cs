
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
    class BenchMarkChartPage
    {

        public BenchMarkChartPage()
        {


            SeleniumExtras.PageObjects.PageFactory.InitElements(Driver.driver, this);
        }



        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#PdfLinkText")]
        [SeleniumExtras.PageObjects.CacheLookup]
        public IWebElement DownloadPage { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#DownloadLinkText")]
        public IWebElement Downloadata { get;set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "button.view-charts-tables:nth-child(2) > span:nth-child(2)")]
        public IWebElement ViewAsTables { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "button.view-charts-tables:nth-child(1) > span:nth-child(2)")]
        public IWebElement ViewAsCharts { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".criteria-details > summary:nth-child(1) > span:nth-child(1)")]
        public IWebElement ViewCharacteristicsUsed { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#criteriaTable > tbody:nth-child(2) > tr:nth-child(9) > td:nth-child(1)")]
        public IWebElement LondonWeighting { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#criteriaTable > tbody:nth-child(2) > tr:nth-child(9) > td:nth-child(2)")]
        public IWebElement DefaultSchoolValueLondonweighting { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#criteriaTable > tbody:nth-child(2) > tr:nth-child(9) > td:nth-child(3)")]
        public IWebElement ComparisonCriteriaLondonweighting { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#SaveLink > span:nth-child(2)")]
        public IWebElement Savebenchmarkbasket { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "BCHeader")]
        public IWebElement PageTitle { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector,Using = "#chart_0 > svg:nth-child(1) > g:nth-child(2) > g:nth-child(7) > g:nth-child(17) > circle:nth-child(3)")]
        public IWebElement KanesHillPrimarySch { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector,Using = "[href=https://www.gov.uk/government/publications/deals-for-schools/deals-for-schools]")]
        public IWebElement DealforSchoolsLink { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "clip-button")]
        public IWebElement CopyLinkToClipboard { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector,Using = "#radio-1")]
        public IWebElement PDFFormat { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#radio-2")]
        public IWebElement PowerPointFormat { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".button")]
        public IWebElement DownloadButton { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "div.column-one-third:nth-child(2) > button:nth-child(1)")]
        public IWebElement CancellButton { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#Expenditure > a:nth-child(1)")]
        public IWebElement ExpenditureTab { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#Income > a:nth-child(1)")]
        public IWebElement IncomeTab { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#Balance > a:nth-child(1)")]
        public IWebElement BalanceTab { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#Workforce > a:nth-child(1)")]
        public IWebElement WorkForceTab { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".custom > span:nth-child(1)")]
        public IWebElement YourChartsTab { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector,Using = "#benchmarkBasket > div > div > div > a.add-schools > span")]
        public IWebElement AddanotherschoolLink { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id,Using = "ChartGroup")]
        public IWebElement TotalExpenditureDropdown { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#ChartGroup > option:nth-child(7)")]
        public IWebElement costOfFinance { get; set; }

        //public IWebDriver hitEnter = Driver.driver.FindElement(By.CssSelector(".button")).SendKeys(Keys.Enter)
        
        
        
        

        private Boolean existsElement(String id)
        {
            try
            {
                Driver.driver.FindElement(By.Id(id));
            }
            catch (NoSuchElementException e)
            {
                return false;
            }
            return true;
        }
           

    }




}
























