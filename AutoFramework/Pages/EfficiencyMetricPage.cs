using AutoFramework;
using AutoFramework.Pages.PageElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SFB_Test_Automation.AutoFramework.Pages
{
    class EfficiencyMetricPage
    {

        public EfficiencyMetricPage()
        {
            SeleniumExtras.PageObjects.PageFactory.InitElements(Driver.driver, this);
        }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "li.govuk-breadcrumbs__list-item:nth-child(1) > a:nth-child(1)")]
        public IWebElement HomeBreadCrumb { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "li.govuk-breadcrumbs__list-item:nth-child(2) > a:nth-child(1)")]
        public IWebElement SchoolBreadCrumb { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "li.govuk-breadcrumbs__list-item:nth-child(3) > a:nth-child(1)")]
        public IWebElement Introduction_To_Efficiency_Metric_BreadCrumb { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#downloadPage")]
        public IWebElement Download_Page_Button { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "a.a-button:nth-child(2) > span:nth-child(2)")]
        public IWebElement PrintPageButton { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "button.govuk-button:nth-child(3)")]
        public IWebElement BenchMarkTheseSchoolsButton { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector,Using = "a.govuk-link:nth-child(4)")]
        public IWebElement SeeThis_SchoolRank { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//*[text()=\"See tools to improve your school's efficiency\"]")]
        public IWebElement See_tools_toImprove_EM { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".govuk-list > li:nth-child(1) > a:nth-child(1)")]
        public IWebElement How_Efficiency_Is_Calculated { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "/html/body/app-root/app-gov-uk-layout/div[2]/div/main/app-home/div/div[2]/div/ul/li[3]/a")]//"//*[text()=News]")]
        public IWebElement Contact_Details_Of_Schools { get; set; }


        //#emTableDesktop > tbody:nth-child(49) > tr:nth-child(2) > td:nth-child(1) > div:nth-child(1) > a:nth-child(1)//*[text()='match']
    }
}
