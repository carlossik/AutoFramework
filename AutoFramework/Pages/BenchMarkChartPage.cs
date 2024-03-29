﻿
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

        public BenchMarkChartPage(IWebDriver driver)
        {


            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
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
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "Custom")]
        public IWebElement YourChartsTab { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "button[aria-label=\"Add Total Expenditure to Your Charts\"]")]
        public IWebElement AddTotalExpenditureToCharts { get; set; }
        // button[aria-label="Add Total Expenditure to Your Charts"]

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath,Using = ".//span[contains(text(),'Add another school by name or location')]")]
        public IWebElement AddanotherschoolLink { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id,Using = "ChartGroup")]
        public IWebElement TotalExpenditureDropdown { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#ChartGroup > option:nth-child(7)")]
        public IWebElement costOfFinance { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath,Using = "//a[@id='tab_bestInClassTabSection']")]
        public IWebElement BestInClassComparisonSchoolsTab { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#ComparisonSchools > a:nth-child(1)")]
        public IWebElement OtherComparisonSchoolsTab { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector,Using = "#ShowValue > option:nth-child(4)")]
        public IWebElement PercenTageOfTotalOption { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#ComparisonSchools > a:nth-child(1)")]
        public IWebElement ComparisonSchool_Tab { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".banner__comparison-list-info-panel__count")]
        public IWebElement NumberOfitemsInBasket { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "js-modal-close")]
        public IWebElement closeLinkCopiedPopUp { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "radio-1")]
        public IWebElement download_pdf_radio { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "radio-2")]
        public IWebElement download_ppt_radio { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = ".next-button")]
        public IWebElement download_Options_Next_Button { get; set; }
        //.next-button






        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "button.link-button:nth-child(5)")]
         public IWebElement backToViewCharacteristicsUsed { get; set; }
        



        private Boolean existsElement(String id, IWebDriver driver)
        {
            try
            {
                driver.FindElement(By.Id(id));
            }
            catch (NoSuchElementException e)
            {
                return false;
            }
            return true;
        }


       


    }




}
























