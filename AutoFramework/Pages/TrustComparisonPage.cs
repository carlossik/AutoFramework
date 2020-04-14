using AutoFramework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFB_Test_Automation.AutoFramework.Pages
{
     public class TrustComparisonPage
    {
        public TrustComparisonPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#ExistingTrusts > div:nth-child(1) > button:nth-child(3)")]
        [SeleniumExtras.PageObjects.CacheLookup]
        public IWebElement Remove_button { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector,Using = ".page > div:nth-child(2) > div:nth-child(1) > a:nth-child(1)")]
        //[SeleniumExtras.PageObjects.CacheLookup]
        public IWebElement Compare_withOtherTrusts { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector,Using = ".result-list-summary > a:nth-child(2)")]
        public IWebElement SchoolsToCompare { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector,Using = "#manualButton")]
        public IWebElement ViewBenchMarkingCharts { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "button.view-benchmark-charts:nth-child(1)")]
        public IWebElement ViewBenchMarkingChartsbutton { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".column - one - third > a:nth - child(1)")]
        public IWebElement BackButton { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "removeAllTrusts")]
        public IWebElement RemoveAllTrusts { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".tt-suggestion")]
        public IWebElement SuggestedSchool { get; set; }
        

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#EnterChars")]
        public IWebElement SelectCharacteristicsButton { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#checkbox-MinNoSchools")]
        public IWebElement NumberOfSchoolscheckbox { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#MinNoSchools")]
        public IWebElement MinNumOfScools { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#MaxNoSchools")]
        public IWebElement MaxNumofschools { get; set; }


        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".heading-xlarge")]
        public IWebElement TrustName { get; set; }




    }
}
