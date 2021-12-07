using AutoFramework;
using AutoFramework.Pages.PageElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SFB_Test_Automation.AutoFramework.Pages
{
    class ToolsToImproveEMPage
    {

        public ToolsToImproveEMPage(IWebDriver driver)
        {
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
        }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//a[contains(text(),'Use the financial planning checklist')]")]
        public IWebElement UseFinancial_PlanningCheckList_Link { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//a[contains(text(),'Use the top 10 financial planning checks')]")]
        public IWebElement UseTheTop10PlanningChecksLink { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//a[contains(text(),'Use the toolkit')]")]
        public IWebElement UseTheToolKitLink { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//a[contains(text(),'Back')]")]
        public IWebElement BackToEfficiencyMetricLink { get; set; }
    }
}
