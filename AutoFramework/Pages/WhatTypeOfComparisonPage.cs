using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFB_Test_Automation.AutoFramework.Pages
{
    class TypeOfComparisonPage
    {
        public TypeOfComparisonPage(IWebDriver driver)
        {


            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
        }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#compareColumn > ul:nth-child(4) > li:nth-child(1) > a:nth-child(1)")]
        [SeleniumExtras.PageObjects.CacheLookup]
        public IWebElement CreateabenchmarkComparisonButton { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".sfb_gtm_auto_report")]
        public IWebElement BasicBenchMarkReportButton { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#efficiencyMetricLink > a:nth-child(1)")]
        public IWebElement EfficiencyMetrictButton { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#progressColumn > ul:nth-child(4) > li:nth-child(2) > a:nth-child(1)")]
        public IWebElement BestInClassReportButton { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "[href *= 'self-assessment']")]//".sfb_gtm_sad_from_Academies")]
        public IWebElement SelfAssessMentDashboardButton { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector,Using = "#progressColumn > ul:nth-child(4) > li:nth-child(1) > a:nth-child(1)")]
        public IWebElement HighestprogressSchoolsComparisonButton { get; set; }


    }
}
