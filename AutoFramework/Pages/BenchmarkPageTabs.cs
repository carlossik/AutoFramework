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
    class BenchmarkPageTabs
    {
        public BenchmarkPageTabs(IWebDriver driver)
        {


            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
        }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#ComparisonSchoolsTable > thead:nth-child(1) > tr:nth-child(1) > th:nth-child(1) > div:nth-child(1)")]
        [SeleniumExtras.PageObjects.CacheLookup]
        public IWebElement SchoolTab { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "th.numeric:nth-child(2) > div:nth-child(1)")]
        public IWebElement PupilsTab { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "th.numeric:nth-child(3) > div:nth-child(1)")]
        public IWebElement PhaseOfEducationTab { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "th.numeric:nth-child(4) > div:nth-child(1)")]
        public IWebElement OfStedRatingTab { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "/html/body/div/div[9]/main/div[4]/div/div/div[3]/div/div/table[1]/thead/tr/th[6]/div")]
        public IWebElement Progress8Tab { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#ProgressScoresTable > thead:nth-child(1) > tr:nth-child(1) > th:nth-child(2) > div:nth-child(1)")]
        public IWebElement LocalAuthority  { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#ProgressScoresTable > thead:nth-child(1) > tr:nth-child(1) > th:nth-child(3) > div:nth-child(1)")]
        public IWebElement BICPupils { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#ProgressScoresTable > thead:nth-child(1) > tr:nth-child(1) > th:nth-child(4) > div:nth-child(1)")]
        public IWebElement BICFSM  { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#ProgressScoresTable > thead:nth-child(1) > tr:nth-child(1) > th:nth-child(5) > div:nth-child(1)")]
        public IWebElement BICEHCP { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#ProgressScoresTable > thead:nth-child(1) > tr:nth-child(1) > th:nth-child(6) > div:nth-child(1)")]
        public IWebElement BICExpenditureperPupil { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "th.tablesorter-header:nth-child(7) > div:nth-child(1)")]
        public IWebElement BICUrbanRural  { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "th.numeric:nth-child(8) > div:nth-child(1)")]
        public IWebElement BICProgress8 { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#ProgressScoresTable > thead:nth-child(1) > tr:nth-child(1) > th:nth-child(1) > div:nth-child(1)")]
        public IWebElement BICSchool { get; set; }

        //a.benchmarkControls


    }
}
