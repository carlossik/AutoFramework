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
    class SelfAssessmentPage
    {
        public SelfAssessmentPage()
        {
            SeleniumExtras.PageObjects.PageFactory.InitElements(Driver.driver, this);
        }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "li:nth-of-type(2) > .font-xsmall")]
        public IWebElement SADLink { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "li.govuk-breadcrumbs__list-item:nth-child(2) > a:nth-child(1)")]
        public IWebElement SchoonameBreadCrumb { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "li.govuk-breadcrumbs__list-item:nth-child(1) > a:nth-child(1)")]
        public IWebElement HomeBreadCrumb { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".govuk-details__summary-text")]
        public IWebElement ViewCharacteristicsLink { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "button.hide-in-print")]
        public IWebElement SideBySideLink { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "button.govuk-button:nth-child(2)")]
        public IWebElement EditDataButton { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".govuk-heading-xl")]
        public IWebElement SelfAssessmentBanner { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#main-content > app-sidebyside > div:nth-child(1) > div:nth-child(4) > div:nth-child(2) > button")]
        public IWebElement ResetDashboardButton { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "div.govuk-table__header:nth-child(2) > div:nth-child(3) > a:nth-child(1)")]
        public IWebElement EditScenario1Button { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "div.govuk-table__header:nth-child(2) > div:nth-child(3) > a:nth-child(3)")]
        public IWebElement RemoveScenario1Button { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "div.govuk-table__header:nth-child(3) > div:nth-child(3) > a:nth-child(1)")]
        public IWebElement EditScenario2Button { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "div.govuk-table__header:nth-child(3) > div:nth-child(3) > a:nth-child(3)")]
        public IWebElement RemoveScenario2Button { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "li.govuk-breadcrumbs__list-item:nth-child(2) > a:nth-child(1)")]
        public IWebElement backtoschooldetailpagecrumb { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "div.govuk-table__header:nth-child(2) > span:nth-child(1)")]
        public IWebElement scenario1Name { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "div.govuk-table__header:nth-child(3) > span:nth-child(1)")]
        public IWebElement scenario2Name { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "a.a-button:nth-child(1) > span:nth-child(2)")]
        public IWebElement DownloadPage { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "a.a-button:nth-child(2) > span:nth-child(2)")]
        public IWebElement PrintPage { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "a.a-button:nth-child(2) > span:nth-child(2)")]
        public IWebElement Printbutton { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".govuk-warning-text__assistive")]
        public IWebElement FinancewarningMessage { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "table.govuk-table:nth-child(3) > tbody:nth-child(3) > tr:nth-child(5) > td:nth-child(3) > span:nth-child(1) > a:nth-child(2)")]
        public IWebElement AddData_TeacherContactRatio { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "table.govuk-table:nth-child(3) > tbody:nth-child(3) > tr:nth-child(6) > td:nth-child(3) > span:nth-child(1) > a:nth-child(2)")]
        public IWebElement AddData_Predicted_percentage_pupil_number_change { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#charTable > tr:nth-child(11) > td:nth-child(3) > span:nth-child(1) > a:nth-child(2)")]
        public IWebElement AddData_Predicted_percentage_pupil_number_changeforSideBySide1 { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "table.govuk-table:nth-child(3) > tbody:nth-child(2) > tr:nth-child(5) > td:nth-child(3) > span:nth-child(1) > a:nth-child(2)")]
        public IWebElement AddData_TeacherContactRatioFirstForSideBySide { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#charTable > tr:nth-child(10) > td:nth-child(5) > span:nth-child(1) > a:nth-child(2)")]
        public IWebElement AddData_TeacherContactRatioSecondForSideBySide { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "table.govuk-table:nth-child(3) > tbody:nth-child(3) > tr:nth-child(7) > td:nth-child(3) > span:nth-child(1) > a:nth-child(2)")]
        public IWebElement AddData_Average_Class_size { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#main-content > app-sidebyside > div:nth-child(1) > app-sidebyside-table-desktop > table:nth-child(2) > tbody > tr:nth-child(1) > td:nth-child(7) > span > a")]
        public IWebElement AddData_TeachingSTAFFSecondSIDEbYsIDE { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "acceptAllCookies")]
        public IWebElement AcceptSADCookie { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "acceptAllCookiesHide")]
        public IWebElement HideSADCookie { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#charTable > tr:nth-child(6) > td:nth-child(3) > span:nth-child(1) > a:nth-child(2)")]
        public IWebElement AverageTeacherCost_add { get; set; }
       // [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "acceptAllCookiesHide")]
       // public IWebElement HideSADCookie { get; set; }
        //acceptAllCookiesHide


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
        public bool IsFileInFolder()
        {

            try
            {
                string downloadpdfile = @"C:\AutomationDownloads\Self-assessment-dashboard.pdf";
                if (File.Exists(downloadpdfile))
                {
                    return true;
                }
                else;
                return false;

                
                Console.WriteLine(File.Exists(downloadpdfile) ? "File exists." : "File does not exist.");
            }
            catch (OpenQA.Selenium.NoSuchElementException e) { }

            return false;

        }


    }





    
}
