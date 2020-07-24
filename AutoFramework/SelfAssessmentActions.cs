using AutoFramework;
using AutoFramework.Pages.PageElements;
using OpenQA.Selenium;
using SFB_Test_Automation.AutoFramework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            Thread.Sleep(3000);
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
            Thread.Sleep(200000);
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
            
        }
    }
}
