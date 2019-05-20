
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



        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#PdfLink > span:nth-child(2)")]
        [SeleniumExtras.PageObjects.CacheLookup]
        public IWebElement DownloadPdf { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#DownloadLinkText")]
        public IWebElement Downloadbenchmarkdata_CSV { get;set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#content > div.charts-section > div.grid-row > div > button.view-charts-tables.tables.no-underline.link-button.font-xsmall > span")]
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

        //.criteria-details > summary:nth-child(1) > span:nth-child(1)
        //#criteriaTable > tbody:nth-child(2) > tr:nth-child(9) > td:nth-child(1)
        //#criteriaTable > tbody:nth-child(2) > tr:nth-child(9) > td:nth-child(2)
        //#criteriaTable > tbody:nth-child(2) > tr:nth-child(9) > td:nth-child(3)

    }





}
























