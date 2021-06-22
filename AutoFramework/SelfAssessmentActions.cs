using AutoFramework;
using AutoFramework.Pages.PageElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
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
        public static void navigateToSadPage(String Laestab, IWebDriver driver)
        {
            Actions.schoolSearchwithLaestab(Laestab,driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            detailspage.StartAComparison.Click();
            
            TypeOfComparisonPage comparisontype = new TypeOfComparisonPage(driver);
            comparisontype.SelfAssessMentDashboardButton.Click();
            Thread.Sleep(200);
            Actions.acceptCookie(driver);
            Thread.Sleep(2000);

        }
        public static void verifySADLink(String Laestab, IWebDriver driver)
        {
            Actions.schoolSearchwithLaestab(Laestab,driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            detailspage.StartAComparison.Click();
            TypeOfComparisonPage comparisonpage = new TypeOfComparisonPage(driver);
            comparisonpage.SelfAssessMentDashboardButton.Click();
            Actions.acceptCookie(driver);
          
            SelfAssessmentPage assessmentpage = new SelfAssessmentPage(driver);
           
            Thread.Sleep(3000);
            


        }

        public static void generate_For_School_Without_Data(String Laestab, IWebDriver driver)
        {
            Actions.schoolSearchwithLaestab(Laestab, driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            detailspage.GoTo_SADButton_For_School_without_finance.Click();
            TypeOfComparisonPage comparisonpage = new TypeOfComparisonPage(driver);
            Actions.acceptCookie(driver);
            comparisonpage.SelfAssessMentDashboardButton.Click();
            Actions.acceptCookie(driver);
            SelfAssessmentPage assessmentpage = new SelfAssessmentPage(driver);
           
            FillSADForm(driver);
            //EditSADForm(driver);
            Thread.Sleep(10000);

        }

        public static void generate_side_by_side_for_school_without_finance(String Laestab, IWebDriver driver)
        {
            generate_For_School_Without_Data(Laestab,driver);
            side_by_side_alone(driver);
            Thread.Sleep(2000);
        }
        public static void verifySADlinkforIncomplete_finance_Year(String Laestab, IWebDriver driver)
        {
            Actions.schoolSearchwithLaestab(Laestab,driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            String FinancialYear = driver.FindElement(By.CssSelector("div.charts-section__chart-container:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > span:nth-child(1)")).Text;
            Console.WriteLine(FinancialYear);
           
            //detailspage.SADLink.Click();
            Thread.Sleep(3000);
        }

        public static void ViewCharacteristics(String Laestab, IWebDriver driver)
        {
            Actions.schoolSearchwithLaestab(Laestab,driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            detailspage.StartAComparison.Click();
            TypeOfComparisonPage comparepage = new TypeOfComparisonPage(driver);
            comparepage.SelfAssessMentDashboardButton.Click();
            //detailspage.SADLink.Click();
            Thread.Sleep(2000);
            SelfAssessmentPage SADpage = new SelfAssessmentPage(driver);
            Actions.acceptCookie(driver);
            Thread.Sleep(2000);
            SADpage.ViewCharacteristicsLink.Click();
            Thread.Sleep(2000);

        }
      
        public static void ViewCharacteristicsSideBySide(String Laestab, IWebDriver driver)
        {
            
            createSideBySideScenario(Laestab,driver);
            SelfAssessmentPage SADpage = new SelfAssessmentPage(driver);
            SADpage.ViewCharacteristicsLink.Click();
            Thread.Sleep(2000);

        }
        public static void PrintSad(IWebDriver driver)
        {
            SelfAssessmentPage assessmentpage = new SelfAssessmentPage(driver);
            assessmentpage.PrintPage.Click();
            Thread.Sleep(200);
            driver.SwitchTo().ActiveElement();
            driver.FindElement(By.CssSelector("div > cr-button.cancel-button")).Click();
        }

        public static void DownloadSad(string fileformat, IWebDriver driver)
        {
            SelfAssessmentPage assessmentpage = new SelfAssessmentPage(driver);
            assessmentpage.DownloadPage.Click();
            Actions.downloadFile(fileformat,driver);
            Thread.Sleep(20000);
        }

        public static void FillSADForm(IWebDriver driver)
        {
            SadEditPage editpage = new SadEditPage(driver);
            editpage.ScenarioNameField.SendKeys("Automated Test1 Scenario");
            var selectElement = new SelectElement(editpage.YearOfScenarioField);
            selectElement.SelectByValue("2019/2020");
           
            editpage.YearOfScenarioField.Click();
            //editpage.select_default_year_of_finance.Click();
            editpage.NumberOfPupils.SendKeys("33");
            editpage.NumberOfTeachers.SendKeys("45");
            editpage.SchoolWorkForce.SendKeys("26.4");
            editpage.SeniorLeaderShip.SendKeys("26.1");
            editpage.PercenTageOfPupilsEligbleFSM.SendKeys("20");
            editpage.SchoolWorkForce.SendKeys("50");
            editpage.NumberOfTeachers.SendKeys("50");
            editpage.Total_income.SendKeys("5000000");
            editpage.Total_expenditure.SendKeys("8000000");
            
            editpage.Submit_Button.Click();
            Thread.Sleep(200);
        }
        public static void EditSideBySideView(String LAestab, IWebDriver driver)
        {
            createSideBySideScenario(LAestab,driver);
            Thread.Sleep(30000);
        }

        public static void EditSADForm(IWebDriver driver)
        {
            SadEditPage editpage = new SadEditPage(driver);
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
        public static void createSideBySideScenario(String LAestab, IWebDriver driver)
        {
            Actions.schoolSearchwithLaestab(LAestab,driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            Thread.Sleep(200);
            detailspage.StartAComparison.Click();
            TypeOfComparisonPage comparisontype = new TypeOfComparisonPage(driver);
            comparisontype.SelfAssessMentDashboardButton.Click();
            //detailspage.SADLink.Click();
             Thread.Sleep(2000);
            SelfAssessmentPage SadPage = new SelfAssessmentPage(driver);
            Thread.Sleep(200);
            Actions.acceptCookie(driver);
            Thread.Sleep(2000);
            SadPage.SideBySideLink.Click();
            Thread.Sleep(200);
            FillSADForm(driver);
            Thread.Sleep(2000);

        }
        public static void side_by_side_alone(IWebDriver driver)
        {
            SelfAssessmentPage SadPage = new SelfAssessmentPage(driver);
            Thread.Sleep(200);
            Actions.acceptCookie(driver);
            Thread.Sleep(2000);
            SadPage.SideBySideLink.Click();
            Thread.Sleep(200);
            FillSADForm(driver);
            Thread.Sleep(2000);
        }

        public static void customdashboardPage(IWebDriver driver)
        {
            SelfAssessmentPage assessmentpage = new SelfAssessmentPage(driver);
            assessmentpage.SideBySideLink.Click();
            SadEditPage editpage = new SadEditPage(driver);
            editpage.YearOfScenarioField.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Thread.Sleep(300);

        }
        public static void cancelsidebysidecreation(String LAestab, IWebDriver driver)
        {
            Actions.schoolSearchwithLaestab(LAestab,driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            Thread.Sleep(200);
            detailspage.StartAComparison.Click();
            TypeOfComparisonPage comparepage = new TypeOfComparisonPage(driver);
            comparepage.SelfAssessMentDashboardButton.Click();
            Thread.Sleep(2000);
            SelfAssessmentPage SadPage = new SelfAssessmentPage(driver);
            Thread.Sleep(200);
            Actions.acceptCookie(driver);
            SadPage.SideBySideLink.Click();
           
            Thread.Sleep(200);
            SadEditPage editpage = new SadEditPage(driver);
            editpage.Back_Link.Click();
            Thread.Sleep(200);
          
        }
        public static void gotohomepageviabreadcrumb(IWebDriver driver)
        {
            SelfAssessmentPage assessmentpage = new SelfAssessmentPage(driver);
            assessmentpage.backtoschooldetailpagecrumb.Click();
            Thread.Sleep(2000);
        }
        public static void persist(IWebDriver driver)
        {
            gotohomepageviabreadcrumb(driver);

            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            detailspage.StartAComparison.Click();
            TypeOfComparisonPage comparepage = new TypeOfComparisonPage(driver);
            comparepage.SelfAssessMentDashboardButton.Click();
            SelfAssessmentPage SadPage = new SelfAssessmentPage(driver);
            Thread.Sleep(2000);
        }
        public static void non_persistence(String LAestab, IWebDriver driver)
        {
            gotohomepageviabreadcrumb(driver);
            driver.Close();
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Config.currentTestEnv);
            driver.FindElement(By.Id("acceptAllCookies")).Click();
            driver.FindElement(By.Id("acceptAllCookiesHide")).Click();
            driver.Manage().Window.Maximize();
            driver.Navigate().Refresh();
            //Thread.Sleep(5000);
            Actions.clearPopup(driver);
            Actions.schoolSearchwithLaestab(LAestab,driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            detailspage.SADLink.Click();
            TimeSpan seconds = TimeSpan.FromSeconds(5);
            driver.Manage().Timeouts().ImplicitWait = (seconds);
            driver.FindElement(By.Id("acceptAllCookies")).Click();
            driver.FindElement(By.Id("acceptAllCookiesHide")).Click();
            Thread.Sleep(2000);
           
        }

        public static void removeScenario1(IWebDriver driver)
        {
            SelfAssessmentPage SadPage = new SelfAssessmentPage(driver);
            SadPage.RemoveScenario1Button.Click();
            Thread.Sleep(2000);
        }
        public static void removeScenario2(IWebDriver driver)
        {
            SelfAssessmentPage SadPage = new SelfAssessmentPage(driver);
            SadPage.RemoveScenario2Button.Click();
            Thread.Sleep(2000);
        }
        public static void EditScenario1(IWebDriver driver)
        {
            SelfAssessmentPage SadPage = new SelfAssessmentPage(driver);
            SadPage.EditScenario1Button.Click();
            Thread.Sleep(200);
            EditSADForm(driver);
            Thread.Sleep(20000);
        }
        public static void EditScenario2(IWebDriver driver)
        {
            SelfAssessmentPage SadPage = new SelfAssessmentPage(driver);
            SadPage.EditScenario2Button.Click();
            Thread.Sleep(2000);
        }
        public static void ResetDashBoard(IWebDriver driver)
        {
            SelfAssessmentPage SadPage = new SelfAssessmentPage(driver);
            SadPage.ResetDashboardButton.Click();
            Thread.Sleep(1000);
            SadPage.ConfirmResetButton.Click();
            Thread.Sleep(2000);
        }

        public static void SADclosedSchool(String Laestab, IWebDriver driver)// should be a closed school
        {
            Actions.schoolSearchwithLaestab(Laestab,driver);
        }
        public static void navigatebacktohomepage(IWebDriver driver)
        {
            SelfAssessmentPage SadPage = new SelfAssessmentPage(driver);
            SadPage.HomeBreadCrumb.Click();
            Thread.Sleep(2000);
        }
        public static void navigatebacktoschooldetaipage(IWebDriver driver)
        {
            SelfAssessmentPage SadPage = new SelfAssessmentPage(driver);
            SadPage.backtoschooldetailpagecrumb.Click();
            Thread.Sleep(2000);
        }
        public static void VerifyPopUps(String Laestab, IWebDriver driver)
        {
            Actions.schoolSearchwithLaestab(Laestab,driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            detailspage.StartAComparison.Click();
           
            TypeOfComparisonPage comparisontype = new TypeOfComparisonPage(driver);
            comparisontype.SelfAssessMentDashboardButton.Click();
            Thread.Sleep(300);
            SelfAssessmentPage SadPage = new SelfAssessmentPage(driver);
            Actions.acceptCookie(driver);
            Thread.Sleep(200);
            SadPage.SideBySideLink.Click();
            Thread.Sleep(300);
        }

        public static void create_sadFor_Nurseries_Prus_Specials(String Laestab, IWebElement element, String editDat, IWebDriver driver)
        {

            AddData(Laestab,element,editDat,driver);
           
        }
        public static void AddData(String Laestab,IWebElement element,String editData, IWebDriver driver)
        {
            createSideBySideScenario(Laestab,driver);
            SelfAssessmentPage SadPage = new SelfAssessmentPage(driver);
            Thread.Sleep(40);

            driver.FindElement(By.CssSelector("#charTable > tr:nth-child(6) > td:nth-child(5) > span:nth-child(1) > a:nth-child(2)")).Click();
            //element.Click();
            Thread.Sleep(400);
            SadEditPage EditPage = new SadEditPage(driver);
            Thread.Sleep(400);
            IWebElement activeField = driver.SwitchTo().ActiveElement();
            activeField.Clear();
            activeField.SendKeys(editData);
            Thread.Sleep(4);
            EditPage.SchoolWorkForce.Clear();
            Thread.Sleep(4);
            EditPage.SchoolWorkForce.SendKeys("50");
            Thread.Sleep(4);
            EditPage.NumberOfTeachers.Clear();
            Thread.Sleep(4);
            EditPage.NumberOfTeachers.SendKeys("50");
            Thread.Sleep(4);
            EditPage.Revenue_reserve.Clear();
            Thread.Sleep(4);
            EditPage.Revenue_reserve.SendKeys(editData);
            EditPage.Teacher_contact_ratio.Clear();
            EditPage.Teacher_contact_ratio.SendKeys(".5");
            Thread.Sleep(500);
            EditPage.Predicted_percentage_pupil_number_change_in_3_5_years.Clear();
            EditPage.Predicted_percentage_pupil_number_change_in_3_5_years.SendKeys(editData);
            EditPage.Spending_on_teaching_staff.SendKeys(editData);
            EditPage.Submit_Button.Click();
            Thread.Sleep(40);
        }
        public static void verifyHiddenFields(String Lacode, IWebDriver driver)
        {
            Actions.searchschoolLaCode(Lacode,driver);
            FiltersPage filters = new FiltersPage(driver);
            Thread.Sleep(500);
            filters.EducationPhase_Nursery.Click();
            filters.schoolsdisplayedLinks.Click();
            Thread.Sleep(300);
            SchoolDetailPage detailpage = new SchoolDetailPage(driver);
            detailpage.StartAComparison.Click();
            TypeOfComparisonPage comparepage = new TypeOfComparisonPage(driver);
            comparepage.SelfAssessMentDashboardButton.Click();
            //detailpage.SADLink.Click();
            Actions.acceptCookie(driver);
            Thread.Sleep(2000);
        }

       public static void ClickPopUp(IWebElement popupName)
        {
            popupName.Click();
            Thread.Sleep(2000);
        }
        

    }
   

}
