using AutoFramework;
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
    class EfficiencyMetricIntroPage
    {
        public EfficiencyMetricIntroPage(IWebDriver driver)
        {
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
        }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "li.govuk-breadcrumbs__list-item:nth-child(1) > a:nth-child(1)")]
        public IWebElement HomeBreadCrumb { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "li.govuk-breadcrumbs__list-item:nth-child(2) > a:nth-child(1)")]
        public IWebElement SchoolBreadCrumb { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "div.govuk-grid-row:nth-child(4) > div:nth-child(1) > button:nth-child(1)")]
        public IWebElement ContinueToEfficiencyMetricButton { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".govuk-link--no-visited-state")]
        public IWebElement BackButton { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//button[contains(text(),'Accept additional cookies')]")]
        public IWebElement AcceptCookie { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//a[contains(text(),'Hide this message')]")]
        public IWebElement HideMessage { get; set; }

       
        public  void AcceptAndHide(IWebDriver driver)
        {
            try
            {

                if (AcceptCookie.Displayed)
                {
                    AcceptCookie.Click();
                    //Thread.Sleep(200);
                   // HideMessage.Click();
                   // Thread.Sleep(200);

                }
            }
            catch (OpenQA.Selenium.NoSuchElementException e) { }

        }
    }
}
