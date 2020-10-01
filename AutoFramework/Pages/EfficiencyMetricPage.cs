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
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "")]
        public IWebElement AddData_Revenue_reserveSC1 { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#reserveTable > tr:nth-child(7) > td:nth-child(7) > span:nth-child(1) > a:nth-child(2)")]
        public IWebElement AddData_Revenue_reserveSC2 { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#spendingTable > tr:nth-child(6) > td:nth-child(7) > span:nth-child(1) > a:nth-child(2)")]
        public IWebElement AddData_Teaching_staffC2 { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "")]
        public IWebElement AddData_Teaching_staffC1 { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#main-content > app-sidebyside:nth-child(2) > div:nth-child(1) > app-sidebyside-table-desktop:nth-child(5) > table:nth-child(2) > tbody:nth-child(2) > tr:nth-child(2) > td:nth-child(7) > span:nth-child(1) > a:nth-child(2)")]
        public IWebElement AddData_Supply_staffC2 { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "button.govuk-button:nth-child(3)")]
        public IWebElement BenchMarkTheseSchoolsButton { get; set; }
    }
}
