using AutoFramework;
using AutoFramework.Pages.PageElements;
using NUnit.Framework;
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
        public SelfAssessmentPage(IWebDriver driver)
        {
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
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
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#charTable > tr:nth-child(6) > td:nth-child(5) > span:nth-child(1) > a:nth-child(2)")]
        public IWebElement AverageTeacherCost_add { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "//*[text() = 'Average Class size']")] //"#charTable > tbody:nth-child(3) > tr:nth-child(7) > th:nth-child(1)")]
        public IWebElement AverageClassSize { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//*[text() = 'Teacher contact ratio (less than 1)']")]
        public IWebElement TeacherContactRatio { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector,Using = ".dashboard-help-icon > img:nth-child(1)")]
        public IWebElement Add_Custom_Dashboard_Help_Icon { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".dashboard-year-help-icon > img:nth-child(1)")]
        public IWebElement Dashboard_Year_Help_Icon { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".modal-body > div:nth-child(1)")]
        public IWebElement add_custom_dashboard_help_text { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".modal-body > div:nth-child(1) > p:nth-child(1)")]
        public IWebElement dashboard_Year_help_text { get; set; }


        public String Expected_CustomDashboard_Help_Text = "The custom dashboard allows schools to plan for hypothetical or projected changes to their financial situation and see a red, amber or green (RAG) rating against it.\r\nCustom dashboards are for personal use and only visible to you. Any changes you make will be viewable on subsequent visits to this school’s dashboard unless you choose to reset them.";


        public String Expected_DashboardYear_Help_Text = "By choosing a different year banding figures are adjusted to align to that year. An 8.6% uplift has been applied to Teaching staff and average salary (including pensions) for 2019/20 and an 11.9% uplift on 2020/21 and future years.";

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "radio-1")]
        public IWebElement download_pdf_radio { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "radio-2")]
        public IWebElement download_ppt_radio { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = ".next-button")]
        public IWebElement download_Options_Next_Button { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath,Using = "//li[3]/a[@class='govuk-footer__link' and 1]")]
        public IWebElement AccessibilityLink { get; set; }

        ////a[contains(@title,'List of Users')]
        //#charTable > tbody:nth-child(3) > tr:nth-child(5) > th:nth-child(1) //Average Class size
        //#charTable > tbody:nth-child(3) > tr:nth-child(7) > th:nth-child(1)
        // [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "acceptAllCookiesHide")]
        // public IWebElement HideSADCookie { get; set; }
        //acceptAllCookiesHide


        public bool verifyFinancialYear(String laestab, IWebDriver driver)
        {

            try
            {
                Actions.schoolSearchwithLaestab(laestab,driver);
                SchoolDetailPage detailspage = new SchoolDetailPage(driver);
                String FinancialYear = driver.FindElement(By.CssSelector("div.charts-section__chart-container:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > span:nth-child(1)")).Text;
                String FinancialYearFinal = Regex.Replace(FinancialYear, @"\s+","");
                String Finalfinance = Regex.Replace(FinancialYearFinal, @"-","/");
                String FinalFinanceFigure = Regex.Replace(Finalfinance,@" ","");
                Console.WriteLine(Finalfinance);
                detailspage.StartAComparison.Click();
                TypeOfComparisonPage comparepage = new TypeOfComparisonPage(driver);
                comparepage.SelfAssessMentDashboardButton.Click();
                Actions.clearcookie(driver);
                SelfAssessmentPage assessmentpage = new SelfAssessmentPage(driver);
                Thread.Sleep(3000);
                Actions.acceptCookie(driver);
                String SadFinancialYearDisplayed = driver.FindElement(By.Id("scenarioYear")).Text;
                Console.WriteLine("This is the raw Financial Year on SAD "+ SadFinancialYearDisplayed);
                String SdFinalFinance = Regex.Replace(SadFinancialYearDisplayed,@"Dashboard year","");
                Console.WriteLine("This is first of what we display"+""+SdFinalFinance);
                Console.WriteLine("This is second of what we display"+Finalfinance);
               
                Assert.AreEqual(SdFinalFinance,FinalFinanceFigure);
                //Assert.AreEqual()
                
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return false;

        }
        public bool IsFileInFolder(string filetype)
        {

            try
            {
                if (filetype == "pdf")
                {
                    string pdfdownloadpdfile = @"C:\AutomationDownloads\Self-assessment-dashboard.pdf";
                    if (File.Exists(pdfdownloadpdfile))
                    {
                        return true;
                    }
                    else return false;
                }
                else if (filetype == "ppt")
                {
                    string pptdownloadpptfile = @"C:\AutomationDownloads\Self-assessment-dashboard.pptx";
                    if (File.Exists(pptdownloadpptfile))
                    {
                        return true;
                    }
                    else return false;
                }
                else;
                Console.WriteLine(File.Exists(filetype) ? "File exists." : "File does not exist.");
                return false;

            }
            catch (OpenQA.Selenium.NoSuchElementException e) { }
            return false;

        }
        public bool IsElementDisplayed( IWebElement element)
        {

            try
            {
                
                if (element.Displayed)
                {
                    return true;
                }
                else;
                Console.WriteLine(element.Text);
                return false;
               
            }
            catch (OpenQA.Selenium.NoSuchElementException e) { }

            return false;

        }



    }





    
}
