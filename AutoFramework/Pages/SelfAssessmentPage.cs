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
    class SelfAssessmentPage
    {
        public SelfAssessmentPage()
        {
            SeleniumExtras.PageObjects.PageFactory.InitElements(Driver.driver, this);
        }
    
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector,Using = "li:nth-of-type(2) > .font-xsmall")]
        public IWebElement SADLink { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "li.govuk-breadcrumbs__list-item:nth-child(2) > a:nth-child(1)")]
        public IWebElement SchoonameBreadCrumb { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector,Using = "li.govuk-breadcrumbs__list-item:nth-child(1) > a:nth-child(1)")]
        public IWebElement HomeBreadCrumb { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".govuk-details__summary-text")]
        public IWebElement ViewCharacteristicsLink { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "button.govuk-button:nth-child(1)")]
        public IWebElement SideBySideLink { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "button.govuk-button:nth-child(2)")]
        public IWebElement EditDataButton{ get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".govuk-heading-xl")]
        public IWebElement SelfAssessmentBanner { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#main-content > app-sidebyside > div:nth-child(1) > div:nth-child(4) > div:nth-child(2) > button")]
        public IWebElement ResetDashboardButton { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "th.pb-3:nth-child(2) > div:nth-child(3) > a:nth-child(1)")]
        public IWebElement EditScenario1Button { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "th.pb-3:nth-child(2) > div:nth-child(3) > a:nth-child(3)")]
        public IWebElement RemoveScenario1Button { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "th.pb-3:nth-child(3) > div:nth-child(3) > a:nth-child(1)")]
        public IWebElement EditScenario2Button { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "th.pb-3:nth-child(3) > div:nth-child(3) > a:nth-child(3)")]
        public IWebElement RemoveScenario2Button { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "li.govuk-breadcrumbs__list-item:nth-child(2) > a:nth-child(1)")]
        public IWebElement backtoschooldetailpagecrumb { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "th.pb-3:nth-child(2) > span:nth-child(1)")]
        public IWebElement scenario1Name { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "th.pb-3:nth-child(3) > span:nth-child(1)")]
        public IWebElement scenario2Name { get; set; }
        //th.pb-3:nth-child(2) > span:nth-child(1)
        //th.pb-3:nth-child(2) > div:nth-child(3) > a:nth-child(1)
        //.govuk-heading-xl


        public bool verifyFinancialYear(String laestab)
        {
            
                try
                {
                    Actions.schoolSearchwithLaestab(laestab);
                    SchoolDetailPage detailspage = new SchoolDetailPage();
                    String FinancialYear = Driver.driver.FindElement(By.CssSelector("div.charts-section__chart-container:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > span:nth-child(1)")).Text;
                    String FinancialYearFinal = Regex.Replace(FinancialYear, @"\s+", "");
                    String Finalfinance = Regex.Replace(FinancialYearFinal, @"-", "/");
                    Console.WriteLine(Finalfinance);
                    detailspage.SADLink.Click();
                    SelfAssessmentPage assessmentpage = new SelfAssessmentPage();
                    Thread.Sleep(300);
                    String SadFinancialYearDisplayed = Driver.driver.FindElement(By.CssSelector(".govuk-heading-m")).Text;
                    String SdFinalFinance = Regex.Replace(SadFinancialYearDisplayed, @" submitted data", "");
                    Console.WriteLine(SdFinalFinance);
                    if (Finalfinance == SdFinalFinance)
                    {
                        return true;
                    }
                    else
                        return false;
                }

                catch (OpenQA.Selenium.NoSuchElementException e) { }

                return false;
            
        }






    }
}
