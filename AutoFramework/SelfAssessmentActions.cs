using AutoFramework;
using AutoFramework.Pages.PageElements;
using OpenQA.Selenium;
using SFB_Test_Automation.AutoFramework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SFB_Test_Automation.AutoFramework
{
    class SelfAssessmentActions
    {

        public static void verifySADLink(String Laestab)
        {
            Actions.schoolSearchwithLaestab(Laestab);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            String FinancialYear = Driver.driver.FindElement(By.CssSelector("div.charts-section__chart-container:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > span:nth-child(1)")).Text;
            Console.WriteLine(FinancialYear);
            SelfAssessmentPage assessmentpage = new SelfAssessmentPage();
            detailspage.SADLink.Click();
            Thread.Sleep(300);
            String SadFinancialYearDisplayed = Driver.driver.FindElement(By.CssSelector(".govuk-heading-m")).Text;
            Console.WriteLine(SadFinancialYearDisplayed);


        }

        public static void verifySADlinkforIncomplete_finance_Year(String Laestab)
        {
            Actions.schoolSearchwithLaestab(Laestab);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            String FinancialYear = Driver.driver.FindElement(By.CssSelector("div.charts-section__chart-container:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > span:nth-child(1)")).Text;
            Console.WriteLine(FinancialYear);
           
            //detailspage.SADLink.Click();
            Thread.Sleep(3000);
        }

        public static void ViewCharacteristics(String Laestab)
        {
            Actions.schoolSearchwithLaestab(Laestab);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.SADLink.Click();
            Thread.Sleep(2000);
            SelfAssessmentPage SADpage = new SelfAssessmentPage();
            SADpage.ViewCharacteristicsLink.Click();
            Thread.Sleep(2000);

        }

        public static void ViewCharacteristicsSideBySide(String Laestab)
        {
            
            createSideBySideScenario(Laestab);
            SelfAssessmentPage SADpage = new SelfAssessmentPage();
            SADpage.ViewCharacteristicsLink.Click();
            Thread.Sleep(2000);

        }
        public static void PrintSad()
        {
            SelfAssessmentPage assessmentpage = new SelfAssessmentPage();
            assessmentpage.PrintPage.Click();
            Thread.Sleep(200);
        }

        public static void DownloadSad()
        {
            SelfAssessmentPage assessmentpage = new SelfAssessmentPage();
            assessmentpage.DownloadPage.Click();
            Thread.Sleep(2000);
        }

        public static void FillSADForm()
        {
            SadEditPage editpage = new SadEditPage();
            editpage.ScenarioNameField.SendKeys("Automated Test1 Scenario");
            editpage.YearOfScenarioField.Click();
            editpage.NumberOfPupils.SendKeys("33");
            editpage.NumberOfTeachers.SendKeys("45");
            editpage.SchoolWorkForce.SendKeys("26.4");
            editpage.SeniorLeaderShip.SendKeys("26.1");
            editpage.PercenTageOfPupilsEligbleFSM.SendKeys("20");
            editpage.Total_income.SendKeys("5000000");
            editpage.Total_expenditure.SendKeys("8000000");
            editpage.Submit_Button.Click();
            Thread.Sleep(200);
        }

        public static void EditSADForm()
        {
            SadEditPage editpage = new SadEditPage();
            editpage.ScenarioNameField.Clear();
            editpage.ScenarioNameField.SendKeys("Automated Test1 Scenario");
            editpage.YearOfScenarioField.Click();
            editpage.NumberOfPupils.Clear();
            editpage.NumberOfPupils.SendKeys("33");
            editpage.NumberOfTeachers.Clear();
            editpage.NumberOfTeachers.SendKeys("45");
            editpage.SchoolWorkForce.Clear();
            editpage.SchoolWorkForce.SendKeys("26.4");
            editpage.SeniorLeaderShip.Clear();
            editpage.SeniorLeaderShip.SendKeys("26.1");
            editpage.PercenTageOfPupilsEligbleFSM.Clear();
            editpage.PercenTageOfPupilsEligbleFSM.SendKeys("20");
            editpage.Total_income.Clear();
            editpage.Total_income.SendKeys("5000000");
            editpage.Total_expenditure.Clear();
            editpage.Total_expenditure.SendKeys("8000000");
            editpage.Submit_Button.Click();
            Thread.Sleep(200);
        }
        public static void createSideBySideScenario(String LAestab)
        {
            Actions.schoolSearchwithLaestab(LAestab);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.SADLink.Click();
            SelfAssessmentPage SadPage = new SelfAssessmentPage();
            SadPage.SideBySideLink.Click();
            Thread.Sleep(200);
            FillSADForm();
            Thread.Sleep(2000);

        }
        public static void cancelsidebysidecreation(String LAestab)
        {
            Actions.schoolSearchwithLaestab(LAestab);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.SADLink.Click();
            SelfAssessmentPage SadPage = new SelfAssessmentPage();
            SadPage.SideBySideLink.Click();
            Thread.Sleep(20000);
            SadEditPage editpage = new SadEditPage();
            editpage.Back_Link.Click();
            Thread.Sleep(2000);
            

        }
        public static void gotohomepageviabreadcrumb()
        {
            SelfAssessmentPage assessmentpage = new SelfAssessmentPage();
            assessmentpage.backtoschooldetailpagecrumb.Click();
            Thread.Sleep(2000);
        }
        public static void persist()
        {
            gotohomepageviabreadcrumb();
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.SADLink.Click();
            SelfAssessmentPage SadPage = new SelfAssessmentPage();
            Thread.Sleep(2000);
        }

        public static void removeScenario1()
        {
            SelfAssessmentPage SadPage = new SelfAssessmentPage();
            SadPage.RemoveScenario1Button.Click();
            Thread.Sleep(2000);
        }
        public static void removeScenario2()
        {
            SelfAssessmentPage SadPage = new SelfAssessmentPage();
            SadPage.RemoveScenario2Button.Click();
            Thread.Sleep(2000);
        }
        public static void EditScenario1()
        {
            SelfAssessmentPage SadPage = new SelfAssessmentPage();
            SadPage.EditScenario1Button.Click();
            Thread.Sleep(200);
            EditSADForm();
            Thread.Sleep(20000);
        }
        public static void EditScenario2()
        {
            SelfAssessmentPage SadPage = new SelfAssessmentPage();
            SadPage.EditScenario2Button.Click();
            Thread.Sleep(2000);
        }
        public static void ResetDashBoard()
        {
            SelfAssessmentPage SadPage = new SelfAssessmentPage();
            SadPage.ResetDashboardButton.Click();
            Thread.Sleep(2000);
        }

        public static void SADclosedSchool(String Laestab)// should be a closed school
        {
            Actions.schoolSearchwithLaestab(Laestab);
        }
        public static void navigatebacktohomepage()
        {
            SelfAssessmentPage SadPage = new SelfAssessmentPage();
            SadPage.HomeBreadCrumb.Click();
            Thread.Sleep(2000);
        }
        public static void navigatebacktoschooldetaipage()
        {
            SelfAssessmentPage SadPage = new SelfAssessmentPage();
            SadPage.backtoschooldetailpagecrumb.Click();
            Thread.Sleep(2000);
        }

    }
   

}
