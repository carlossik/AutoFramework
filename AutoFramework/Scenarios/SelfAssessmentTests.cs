﻿namespace AutoFramework
{

    using AutoFramework;
using AutoFramework.Pages;
using AutoFramework.Pages.PageElements;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using SFB_Test_Automation.AutoFramework;
using SFB_Test_Automation.AutoFramework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
    using System.Threading;
    using System.Threading.Tasks;


    public class SelfAssessmentTests
    {
        IAlert alert;
        IWebDriver driver;


        [SetUp]
        public void SetupBeforeEachTest()

        {
            var testName = TestContext.CurrentContext.Test.FullName;
            Config.Credentials.deletefiles(@"C:\TEMP\" + testName + ".jpg");
            driver =  Actions.InitializeDriver(1);
        }
      
        [Test]
       
        public void Verify_School_withfullyear_Finance_has_a_self_assessmentdashboard_link()
        {
            SelfAssessmentActions.verifySADLink("2013614",driver);
            SelfAssessmentPage SADspage = new SelfAssessmentPage(driver);
            Assert.IsTrue(SADspage.SelfAssessmentBanner.Displayed);
        }

        [Test]
        public void VerifyElementsOnSadPage()
        {
            SelfAssessmentActions.verifySADLink("100000",driver);
            SelfAssessmentPage SADspage = new SelfAssessmentPage(driver);
            Assert.IsTrue(SADspage.SelfAssessmentBanner.Displayed);
            Assert.IsTrue(SADspage.HomeBreadCrumb.Displayed);
            Assert.IsTrue(SADspage.SchoonameBreadCrumb.Displayed);
            Assert.IsTrue(SADspage.SideBySideLink.Displayed);
            Assert.IsTrue(SADspage.ViewCharacteristicsLink.Displayed);
        }
        [Test]
        public void verifyLatestFinanceYear()
        {
            SelfAssessmentPage assessmentpage = new SelfAssessmentPage(driver);
            Assert.IsTrue(assessmentpage.verifyFinancialYear("141811",driver));
        }
        [Test]
        public void verifyFieldsHiddenForSchoolType()
        {
            
            
            var Lacodes = new List<string> { "207", "208", "205", "209" };
            var random = new Random();
            int index = random.Next(Lacodes.Count);
            string randomLacode = Lacodes[index]; //select a random La code from the list of La codes for the test
            SelfAssessmentActions.verifyHiddenFields(randomLacode,driver); //208 // why is 303 not displaying any nurseries
            SelfAssessmentPage assessmentpage = new SelfAssessmentPage(driver);
            Assert.IsFalse(assessmentpage.IsElementDisplayed(assessmentpage.AverageClassSize));
            Assert.IsFalse(assessmentpage.IsElementDisplayed(assessmentpage.TeacherContactRatio));
                
            
            
            
        }
        [Test]
        public void TestPersistenceOfSADonSchool()
        {
            SelfAssessmentActions.createSideBySideScenario("3032083",driver);
            SelfAssessmentActions.persist(driver);
            SelfAssessmentPage assessmentpage = new SelfAssessmentPage(driver);
            Assert.IsTrue(assessmentpage.scenario1Name.Displayed);
            Console.WriteLine(assessmentpage.scenario1Name.Text);
            Assert.IsTrue(assessmentpage.scenario2Name.Displayed);
            Console.WriteLine(assessmentpage.scenario2Name.Text);

        }
        [Test]
        public void test_non_persistence_when_cookie_cleared()
        {
            string laestab = "3032083";
            SelfAssessmentActions.createSideBySideScenario(laestab,driver);
            SelfAssessmentActions.non_persistence(laestab,driver);
            SelfAssessmentPage assessmentpage = new SelfAssessmentPage(driver);
            Assert.IsTrue(assessmentpage.SideBySideLink.Displayed);
        }
        [Test]
        public void TestCreateSideBySideView()
        {
            SelfAssessmentActions.createSideBySideScenario("2032028",driver);
            SelfAssessmentPage assessmentpage = new SelfAssessmentPage(driver);
            Assert.IsTrue(assessmentpage.ResetDashboardButton.Displayed);
        }
        [Test]
        public void TestCancelCreateSideBySideView()
        {
            SelfAssessmentActions.cancelsidebysidecreation("2032028",driver);
            SelfAssessmentPage assessmentpage = new SelfAssessmentPage(driver);
            Assert.IsTrue(assessmentpage.SideBySideLink.Displayed);
        }
        [Test]
        public void TestEditSideBySideView()
        {
            SelfAssessmentActions.createSideBySideScenario("100000",driver);
            SelfAssessmentActions.EditScenario1(driver);
            //throw new NotImplementedException();
        }
        [Test]
        public void testViewCharacteristicsLinkForSingleScenario()
        {
            SelfAssessmentActions.ViewCharacteristics("2013614",driver);
           
        }
        [Test]
        public void testViewCharacteristicsLinkForSideBySideView()
        {
            SelfAssessmentActions.ViewCharacteristicsSideBySide("2013614",driver);
            SADSideBySidePage sidebysidepage = new SADSideBySidePage(driver);
            Assert.IsTrue(sidebysidepage.sadsidebysideLondonweighingRow.Displayed);
            Assert.IsTrue(sidebysidepage.sadsidebysideNumberOfPupilsRow.Displayed);

        }
        [Test]
        public void TestResetDashBoard()
        {
            SelfAssessmentActions.createSideBySideScenario("2032028",driver);
            SelfAssessmentActions.ResetDashBoard(driver);
            SelfAssessmentPage assessmentpage = new SelfAssessmentPage(driver);
            Assert.IsTrue(assessmentpage.SideBySideLink.Displayed);

        }

        [Test]
        public void TestRemoveScenario1()
        {
            SelfAssessmentActions.createSideBySideScenario("2032028",driver);
            SelfAssessmentActions.removeScenario1(driver);
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage(driver);
            Assert.IsTrue(assesmentpage.SideBySideLink.Displayed);



        }
        [Test]
        public void TestRemoveScenario2()
        {
            SelfAssessmentActions.createSideBySideScenario("2032028",driver);
            SelfAssessmentActions.removeScenario2(driver);
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage(driver);
            Assert.IsTrue(assesmentpage.SideBySideLink.Displayed);


        }
        [Test]
        public void EditScenario1()
        {
            SelfAssessmentActions.createSideBySideScenario("2032028",driver);
            SelfAssessmentActions.EditScenario1(driver);


        }
        [Test]
        public void EditScenario2()
        {
            SelfAssessmentActions.createSideBySideScenario("2032028",driver);
            SelfAssessmentActions.EditScenario2(driver);
        
        }
        [Test]
        public void EditSideBySide()
        {
            SelfAssessmentActions.EditSideBySideView("2032028",driver);
            

        }

        [Test]
        public void Verify_ClosedSchool_Has_No_Sad_Link()
        {
            SelfAssessmentActions.SADclosedSchool("134118",driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
           Assert.IsFalse(detailspage.verifySADLink());
                
        }
        [Test]
        public void TestprintSAD()
        {
            SelfAssessmentActions.createSideBySideScenario("2032028",driver);
            //SelfAssessmentActions.PrintSad();
            SelfAssessmentPage assessmentpage = new SelfAssessmentPage(driver);
            Assert.IsTrue(assessmentpage.Printbutton.Displayed);
           



        }

        [Test]
        public void TestDownloadSAD() //Run this test with Chrome browser for now
        {
            Config.Credentials.deletefiles(@"C:\AutomationDownloads\Self-assessment-dashboard.pdf"); // removes any files from previous test runs in the download folder
            SelfAssessmentActions.createSideBySideScenario("2032028",driver);
            SelfAssessmentActions.DownloadSad(driver);
            SelfAssessmentPage assessmentpage = new SelfAssessmentPage(driver);
            Assert.IsTrue(assessmentpage.IsFileInFolder());
        }
        //[Test]
        public void TestprintLayoutSAD()
        {
            throw new NotImplementedException();
        }
        [Test]
        public void Verify_SADlink_Displayed_ForOpenSchool()
        {
            SelfAssessmentActions.SADclosedSchool("100000",driver);
            SchoolDetailPage detailpage = new SchoolDetailPage(driver);
            Assert.IsTrue(detailpage.verifySADLink());
        }

        [Test]
        public void Verify_SADlink_Displayed_ForClosedSchool()
        {
            SelfAssessmentActions.SADclosedSchool("101449",driver);
            SchoolDetailPage detailpage = new SchoolDetailPage(driver);
            Assert.IsFalse(detailpage.verifySADLink());
        }
        [Test]
        [Ignore("Ignore a test")]
        public void verifyIyb_displayed_for_all_Values()
        {
            throw new NotImplementedException();
        }
        [Test]
        public void navigateBackToschooldetailpage()
        {
            SelfAssessmentActions.createSideBySideScenario("2032028",driver);
            SelfAssessmentActions.navigatebacktoschooldetaipage(driver);
            SchoolDetailPage detailpage = new SchoolDetailPage(driver);
            Assert.IsTrue(detailpage.School_Name.Displayed);
        }

        [Test]
        public void navigateBackToHomePage()
        {
            SelfAssessmentActions.createSideBySideScenario("2032028",driver);
            SelfAssessmentActions.navigatebacktohomepage(driver);
            HomePage home = new HomePage(driver);
            Assert.IsTrue(home.TrustTab.Displayed);
        }
        [Test]
        public void verifySchoolwithPartialFinance()
        {
            SelfAssessmentActions.verifySADLink("8792637",driver);//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage(driver);
            String assessmentWarning = ((assesmentpage.FinancewarningMessage).Text);
            Assert.IsNotEmpty(assessmentWarning);
           
        }

        [Test]
        public void VerifyAverageClassSizePopUp()
        {
            SelfAssessmentActions.VerifyPopUps("8792637",driver);//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage(driver);
            SadEditPage editpage = new SadEditPage(driver);
            SelfAssessmentActions.ClickPopUp(editpage.Average_Class_size_Popup);
            String popupmessage = driver.FindElement(By.CssSelector("body > modal-container > div > div > app-edit-data-info-modal > div.modal-body > div")).Text;
            Assert.AreEqual(popupmessage , "This is the FTE number of children in your school divided by the number of classes.");

        }
        [Test]
        public void VerifySpending_on_administrative_and_clerical_staffPopUp()
        {
            SelfAssessmentActions.VerifyPopUps("8792637",driver);//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage(driver);
            SadEditPage editpage = new SadEditPage(driver);
            SelfAssessmentActions.ClickPopUp(editpage.Spending_on_administrative_and_clerical_staff_Popup);
            String popupmessage = driver.FindElement(By.CssSelector("body > modal-container > div > div > app-edit-data-info-modal > div.modal-body > div")).Text;
            Console.WriteLine(popupmessage);
            Assert.AreEqual(popupmessage, @"Spend on administrative and clerical staff includes salaries and wages (including allowances, maternity pay, employer’s contributions to National Insurance and pensions) for administrative and clerical staff employed directly by the school. This includes:
business managers and bursars
clerk to the governing body
receptionists, school secretaries
other administrative staff
telephonists, typists
IT managers
It excludes administrative and clerical staff that are not employed directly by the school and costs that are incurred as part of a service contract.
It also excludes IT teachers and staff employed to manage and support the school’s special facilities.");



        }
        [Test]
        public void VerifySchool_workforcePopUp()
        {
            SelfAssessmentActions.VerifyPopUps("8792637",driver);//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage(driver);
            SadEditPage editpage = new SadEditPage(driver);
            SelfAssessmentActions.ClickPopUp(editpage.School_workforce_Popup);
            String popupmessage = driver.FindElement(By.CssSelector("body > modal-container > div > div > app-edit-data-info-modal > div.modal-body > div")).Text;
            Console.WriteLine(popupmessage);
            Assert.AreEqual(popupmessage, @"The total full-time equivalent count of the school's workforce for the year of the dashboard.
This information is used to calculate workforce and pupil to workforce ratios.");



        }
        [Test]
        public void VerifyRevenue_reservePopUp()
        {
            SelfAssessmentActions.VerifyPopUps("8792637",driver);//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage(driver);
            SadEditPage editpage = new SadEditPage(driver);
            SelfAssessmentActions.ClickPopUp(editpage.Revenue_reserve_Popup);
            String popupmessage = driver.FindElement(By.CssSelector("body > modal-container > div > div > app-edit-data-info-modal > div.modal-body > div")).Text;
            Console.WriteLine(popupmessage);
            Assert.AreEqual(popupmessage , @"This is the Restricted and unrestricted funds carried forward from the previous year + total income from current year – total expenditure in current year.
A cumulative deficit / negative reserve is indicated by a negative result, and a cumulative surplus / positive reserve is indicated by a positive result. The risk significance of a cumulative deficit is assessed relative to the Total income.");



        }
        [Test]
        public void VerifyPredicted_percentage_pupil_number_change_in_3_5_yearsPopUp()
        {
            SelfAssessmentActions.VerifyPopUps("8792637",driver);//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage(driver);
            SadEditPage editpage = new SadEditPage(driver);
            SelfAssessmentActions.ClickPopUp(editpage.Predicted_percentage_pupil_number_change_in_3_5_years_Popup);
            String popupmessage = driver.FindElement(By.CssSelector("body > modal-container > div > div > app-edit-data-info-modal > div.modal-body > div")).Text;
            Console.WriteLine(popupmessage);
            Assert.IsTrue(popupmessage == "This is the percentage of pupils the school is expected to grow or shrink by over the next 3-5 years. A key factor determining a school’s finances is pupil numbers and schools should take this into account for financial projections and assumptions. This number cannot be lower than -100%");

        }
        [Test]
        public void VerifyNumberOfPupilsPopUp()
        {
            SelfAssessmentActions.VerifyPopUps("8792637",driver);//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage(driver);
            SadEditPage editpage = new SadEditPage(driver);
            SelfAssessmentActions.ClickPopUp(editpage.Number_of_pupilsPopup);
            String popupmessage = driver.FindElement(By.CssSelector("body > modal-container > div > div > app-edit-data-info-modal > div.modal-body > div")).Text;
            Console.WriteLine(popupmessage);
            Assert.AreEqual(popupmessage , @"The number of pupils, full time equivalent, in the school for the year of the dashboard.
This information is used to ensure the school is being compared with schools of a similar size for Primary and Secondary phase schools. It is also used to calculate ratios of pupils to teachers and pupils to all workforce.");



        }
        [Test]
        public void VerifyNumberOfTeachersPopUp()
        {
            SelfAssessmentActions.VerifyPopUps("8792637",driver);//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage(driver);
            SadEditPage editpage = new SadEditPage(driver);
            SelfAssessmentActions.ClickPopUp(editpage.NumberOfTeachers_Popup);
            String popupmessage = driver.FindElement(By.CssSelector("body > modal-container > div > div > app-edit-data-info-modal > div.modal-body > div")).Text;
            Console.WriteLine(popupmessage);
            Assert.AreEqual(popupmessage , @"The total full-time equivalent count of the school's teaching staff for the year of the dashboard. Full time equivalent number of teachers includes both classroom teachers and teachers in the leadership group. It excludes teaching assistants, non-classroom based school support staff, and auxiliary staff.This information is used to calculate average salaries, leadership ratios, and pupil to teacher ratios.");

        }
        [Test]
        public void VerifyYearOfScenarioPopUp()
        {
            SelfAssessmentActions.VerifyPopUps("8792637",driver);//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage(driver);
            SadEditPage editpage = new SadEditPage(driver);
            SelfAssessmentActions.ClickPopUp(editpage.YearOfScenario_Popup);
            String popupmessage = driver.FindElement(By.CssSelector("body > modal-container > div > div > app-edit-data-info-modal > div.modal-body > div")).Text;
            Assert.AreEqual(popupmessage, "This is used to apply the correct banding ratios that may differ from year to year, e.g. Teaching staff ratios and Average salary has been adjusted with a graded uplift from years 17/18 to 19/20. It is also presented on the custom dashboard to help users identified when two dashboards are for different years.\r\nBy choosing a different year banding figures are adjusted to align to that year. An 8.6% uplift has been applied to Teaching staff and average salary (including pensions) for 2019/20 and an 11.9% uplift on 2020/21 and future years.");

        }
        [Test]
        public void VerifyTotalIncomePopUp()
        {
            SelfAssessmentActions.VerifyPopUps("8792637",driver);//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage(driver);
            SadEditPage editpage = new SadEditPage(driver);
            SelfAssessmentActions.ClickPopUp(editpage.Total_income_Popup);
            String popupmessage = driver.FindElement(By.CssSelector("body > modal-container > div > div > app-edit-data-info-modal > div.modal-body > div")).Text;
            Assert.AreEqual(popupmessage , "This is the Total income for the school in the dashboard year, actual or predicted if future. It is a Mandatory field as it is used to calculate the annual balance, and as baseline for the percentage of annual overspend and the relative size of any strategic reserve deficit.");

        }
        [Test]
        public void VerifyTotalExpenditurePopUp()
        {
            SelfAssessmentActions.VerifyPopUps("8792637",driver);//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage(driver);
            SadEditPage editpage = new SadEditPage(driver);
            SelfAssessmentActions.ClickPopUp(editpage.Total_expenditure_Popup);
            String popupmessage = driver.FindElement(By.CssSelector("body > modal-container > div > div > app-edit-data-info-modal > div.modal-body > div")).Text;
            Console.WriteLine(popupmessage);
           
            Assert.AreEqual(popupmessage, @"This is the total expenditure for the school in the dashboard year. It is a mandatory field and should be greater than all the other spend items listed here.
It includes all the spend on the risk items plus the additional items not risk assessed in the dashboard including catering staff and supplies, water and sewerage, rent and rates, other occupation costs, special facilities, educational consultancy, professional services, auditor costs, other insurance premiums, administrative supplies, direct revenue finance, and interest charges for loan and bank.");



        }
        [Test]
        public void Teacher_contact_ratioPopUp()
        {
            SelfAssessmentActions.VerifyPopUps("8792637",driver);//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage(driver);
            SadEditPage editpage = new SadEditPage(driver);
            SelfAssessmentActions.ClickPopUp(editpage.Teacher_contact_ratio_Popup);
            String popupmessage = driver.FindElement(By.CssSelector("body > modal-container > div > div > app-edit-data-info-modal > div.modal-body > div")).Text;
            Console.WriteLine(popupmessage);
            Assert.AreEqual(popupmessage , @"For secondary schools: Teacher contact ratio = total number of teaching periods timetabled for all teachers in the school ÷ total possible number of teaching periods
The total possible number of teaching periods is equivalent to the number of teaching periods in the timetable cycle multiplied by the full time equivalent number of teachers.
Full time equivalent number of teachers includes both classroom teachers and teachers in the leadership group. It excludes teaching assistants, non-classroom based school support staff, and auxiliary staff.
For primary schools: Teacher contact ratio = total number of classes ÷ full time equivalent number of teachers
Full time equivalent number of teachers includes both classroom teachers and teachers in the leadership group. It excludes teaching assistants, non-classroom based school support staff, and auxiliary staff.
The teacher contact ratio will always be less than 1.0");


        }
        
        [Test]
        public void Add_Data_Revenue_Reserve()
        {
            SADSideBySidePage SadPage = new SADSideBySidePage(driver);
            SelfAssessmentActions.AddData("8792637", SadPage.AddData_Revenue_reserveSC2, "5000000.00",driver);
            IWebElement revenueReserveC2 = driver.FindElement(By.XPath("//*[@id=\"reserveTable\"]/tr[4]/td[4]"));
            Console.WriteLine(revenueReserveC2.Text);
            Assert.AreEqual("£5,000,000.00", revenueReserveC2.Text);
        }
        [Test]
        public void Add_Data_Teaching_Staff()
        {
            SADSideBySidePage SadPage = new SADSideBySidePage(driver);
            SelfAssessmentActions.AddData("8792637", SadPage.AddData_Teaching_staffC2, "5000000.00",driver);
            IWebElement teachingStaffSpend = driver.FindElement(By.XPath("//*[@id=\"spendingTable\"]/tr[3]/td[4]"));
            Console.WriteLine(teachingStaffSpend.Text);
            Thread.Sleep(20000);
            Assert.AreEqual(teachingStaffSpend.Text,"£5,000,000.00");
            

        }
      //[Test]
      //  public void Add_Data_Premises_costs()
      //  {

      //  }
      //  [Test]
      //  public void Add_Data_Teaching_resources()
      //  {

      //  }
      //  [Test]
      //  public void Add_Data_Energy()
      //  {

      //  }
        [Test]
        [Ignore ("Ignore this test")]
        public void Add_Data_Average_teacher_cost()
        {
            SelfAssessmentPage SadPage = new SelfAssessmentPage(driver);
            SelfAssessmentActions.AddData("138950", SadPage.AverageTeacherCost_add, "200000",driver);
            IWebElement teacherContaRatio = driver.FindElement(By.CssSelector("#charTable > tr:nth-child(10) > td:nth-child(4) > span:nth-child(1)"));
            Console.WriteLine(teacherContaRatio.Text);
        }
        [Test]
        public  void verifyYearOfDashboard_Text()
        {
            SelfAssessmentActions.navigateToSadPage("100000",driver);
            SelfAssessmentPage SadPage = new SelfAssessmentPage(driver);
            SelfAssessmentActions.ClickPopUp(SadPage.Dashboard_Year_Help_Icon);
            Assert.AreEqual(SadPage.dashboard_Year_help_text.Text, SadPage.Expected_DashboardYear_Help_Text);

        }
        [Test]
        public void VerifyKS2p8()
        {

        }
        
        [Test]
        public void Add_Data_Teacher_contact_ratio()
        {
            SelfAssessmentPage SadPage = new SelfAssessmentPage(driver);
            SelfAssessmentActions.AddData("8792637", SadPage.AddData_TeacherContactRatioSecondForSideBySide,"0.80",driver);
            IWebElement  teacherContaRatio = driver.FindElement(By.CssSelector("#charTable > tr:nth-child(10) > td:nth-child(4) > span:nth-child(1)"));
            Console.WriteLine(teacherContaRatio.Text);
            Thread.Sleep(200);
            Assert.AreEqual(teacherContaRatio.Text , "0.50");
        }
        [Test]
        public void VerifyCustomDashboardText()
        {
            SelfAssessmentActions.navigateToSadPage("100000",driver);
            SelfAssessmentPage SadPage = new SelfAssessmentPage(driver);
            SelfAssessmentActions.ClickPopUp(SadPage.Add_Custom_Dashboard_Help_Icon);
            Assert.AreEqual(SadPage.add_custom_dashboard_help_text.Text, SadPage.Expected_CustomDashboard_Help_Text);
        }

        [Test]

        public void SAdYears()
        {

            
            


        }


        [Test]
        public void Add_Data_Predicted_percentage_pupil_number_change()
        {
            SelfAssessmentPage SadPage = new SelfAssessmentPage(driver);
            SelfAssessmentActions.AddData("8792637", SadPage.AddData_Predicted_percentage_pupil_number_changeforSideBySide1, "12.666",driver);
            IWebElement Predictedpupilchangepercentage = driver.FindElement(By.XPath("//*[@id=\"charTable\"]/tr[8]/td[3]/span")); 
            Console.WriteLine(Predictedpupilchangepercentage.Text);
            Assert.AreEqual(Predictedpupilchangepercentage.Text,"12.7%");
            
            
        }

        [Test]
        public void testForDecimalPlacesOnFinanceFigures()
        {
            SelfAssessmentActions.createSideBySideScenario("100000",driver);
        }


        [TearDown]
        public void TeardownAfterEachTest()

        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                var testName = TestContext.CurrentContext.Test.FullName;
                screenshot.SaveAsFile(@"C:\TEMP\" + testName + ".jpg");
                driver.Close();
                driver.Quit();
            }
            driver.Close();
            driver.Quit();
        }



    }
}
