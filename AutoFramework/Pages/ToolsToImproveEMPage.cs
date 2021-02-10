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

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "/html/body/app-root/app-gov-uk-layout/div[2]/div/main/app-ways-to-improve/div/div/ul/li[1]/a")]
        public IWebElement UseFinancial_PlanningCheckList_Link { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "/html/body/app-root/app-gov-uk-layout/div[2]/div/main/app-ways-to-improve/div/div/ul/li[2]/a")]
        public IWebElement UseTheTop10PlanningChecksLink { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "/html/body/app-root/app-gov-uk-layout/div[2]/div/main/app-ways-to-improve/div/div/ul/li[3]/a")]
        public IWebElement UseTheToolKitLink { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".govuk-back-link")]
        public IWebElement BackToEfficiencyMetricLink { get; set; }
    }
}
