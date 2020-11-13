namespace AutoFramework
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
using System.Threading.Tasks;


    public class SelfAssessmentTests
    {
       

        [SetUp]
        public void SetupBeforeEachTest()

        {
            var testName = TestContext.CurrentContext.Test.FullName;
            Config.Credentials.deletefiles(@"C:\TEMP\" + testName + ".jpg");

            Actions.InitializeDriver(Config.FirefoxDriverUnderTest);
        }

        [Test]
        public void Verify_School_withfullyear_Finance_has_a_self_assessmentdashboard_link()
        {
            SelfAssessmentActions.verifySADLink("2013614");
            SelfAssessmentPage SADspage = new SelfAssessmentPage();
            Assert.IsTrue(SADspage.SelfAssessmentBanner.Displayed);
        }

        [Test]
        public void VerifyElementsOnSadPage()
        {
            SelfAssessmentActions.verifySADLink("100000");
            SelfAssessmentPage SADspage = new SelfAssessmentPage();
            Assert.IsTrue(SADspage.SelfAssessmentBanner.Displayed);
            //Assert.IsTrue(SADspage.EditDataButton.Displayed);
            Assert.IsTrue(SADspage.HomeBreadCrumb.Displayed);
            Assert.IsTrue(SADspage.SchoonameBreadCrumb.Displayed);
            Assert.IsTrue(SADspage.SideBySideLink.Displayed);
            Assert.IsTrue(SADspage.ViewCharacteristicsLink.Displayed);
        }
        [Test]
        public void verifyLatestFinanceYear()
        {

            SelfAssessmentPage assessmentpage = new SelfAssessmentPage();
            Assert.IsTrue(assessmentpage.verifyFinancialYear("141811"));
        }
        [Test]
        public void verifyschoolwithoutFullFinanceYear()
        {
            SelfAssessmentActions.verifySADlinkforIncomplete_finance_Year("101439");
            SchoolDetailPage detailspage = new SchoolDetailPage();
            Assert.IsFalse(detailspage.verifySADLink());
        }
        [Test]
        public void TestPersistenceOfSADonSchool()
        {
            SelfAssessmentActions.createSideBySideScenario("3032083");
            SelfAssessmentActions.persist();
            SelfAssessmentPage assessmentpage = new SelfAssessmentPage();
            Assert.IsTrue(assessmentpage.scenario1Name.Displayed);
            Console.WriteLine(assessmentpage.scenario1Name.Text);
            Assert.IsTrue(assessmentpage.scenario2Name.Displayed);
            Console.WriteLine(assessmentpage.scenario2Name.Text);

        }
        [Test]
        public void test_non_persistence_when_cookie_cleared()
        {
            string laestab = "3032083";
            SelfAssessmentActions.createSideBySideScenario(laestab);
            SelfAssessmentActions.non_persistence(laestab);
            SelfAssessmentPage assessmentpage = new SelfAssessmentPage();
            Assert.IsTrue(assessmentpage.SideBySideLink.Displayed);
        }
        [Test]
        public void TestCreateSideBySideView()
        {
            SelfAssessmentActions.createSideBySideScenario("2032028");
            SelfAssessmentPage assessmentpage = new SelfAssessmentPage();
            Assert.IsTrue(assessmentpage.ResetDashboardButton.Displayed);
        }
        [Test]
        public void TestCancelCreateSideBySideView()
        {
            SelfAssessmentActions.cancelsidebysidecreation("2032028");
            SelfAssessmentPage assessmentpage = new SelfAssessmentPage();
            Assert.IsTrue(assessmentpage.SideBySideLink.Displayed);
        }
        [Test]
        public void TestEditSideBySideView()
        {
            SelfAssessmentActions.createSideBySideScenario("100000");
            SelfAssessmentActions.EditScenario1();
            //throw new NotImplementedException();
        }
        [Test]
        public void testViewCharacteristicsLinkForSingleScenario()
        {
            SelfAssessmentActions.ViewCharacteristics("2013614");
           
        }
        [Test]
        public void testViewCharacteristicsLinkForSideBySideView()
        {
            SelfAssessmentActions.ViewCharacteristicsSideBySide("2013614");
            SADSideBySidePage sidebysidepage = new SADSideBySidePage();
            Assert.IsTrue(sidebysidepage.sadsidebysideLondonweighingRow.Displayed);
            Assert.IsTrue(sidebysidepage.sadsidebysideNumberOfPupilsRow.Displayed);

        }
        [Test]
        public void TestResetDashBoard()
        {
            SelfAssessmentActions.createSideBySideScenario("2032028");
            SelfAssessmentActions.ResetDashBoard();
            SelfAssessmentPage assessmentpage = new SelfAssessmentPage();
            Assert.IsTrue(assessmentpage.SideBySideLink.Displayed);

        }

        [Test]
        public void TestRemoveScenario1()
        {
            SelfAssessmentActions.createSideBySideScenario("2032028");
            SelfAssessmentActions.removeScenario1();
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage();
            Assert.IsTrue(assesmentpage.SideBySideLink.Displayed);



        }
        [Test]
        public void TestRemoveScenario2()
        {
            SelfAssessmentActions.createSideBySideScenario("2032028");
            SelfAssessmentActions.removeScenario2();
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage();
            Assert.IsTrue(assesmentpage.SideBySideLink.Displayed);


        }
        [Test]
        public void EditScenario1()
        {
            SelfAssessmentActions.createSideBySideScenario("2032028");
            SelfAssessmentActions.EditScenario1();


        }
        [Test]
        public void EditScenario2()
        {
            SelfAssessmentActions.createSideBySideScenario("2032028");
            SelfAssessmentActions.EditScenario2();
        
        }
        [Test]
        public void EditSideBySide()
        {
            SelfAssessmentActions.EditSideBySideView("2032028");
            

        }

        [Test]
        public void Verify_ClosedSchool_Has_No_Sad_Link()
        {
            SelfAssessmentActions.SADclosedSchool("134118");
            SchoolDetailPage detailspage = new SchoolDetailPage();
           Assert.IsFalse(detailspage.verifySADLink());
                
        }
        [Test]
        public void TestprintSAD()
        {
            SelfAssessmentActions.createSideBySideScenario("2032028");
            //SelfAssessmentActions.PrintSad();
            SelfAssessmentPage assessmentpage = new SelfAssessmentPage();
            Assert.IsTrue(assessmentpage.Printbutton.Displayed);
           



        }

        [Test]
        public void TestDownloadSAD()
        {
            Config.Credentials.deletefiles(@"C:\AutomationDownloads\Self-assessment-dashboard.pdf");
            SelfAssessmentActions.createSideBySideScenario("2032028");
            SelfAssessmentActions.DownloadSad();
            SelfAssessmentPage assessmentpage = new SelfAssessmentPage();
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
            SelfAssessmentActions.SADclosedSchool("100000");
            SchoolDetailPage detailpage = new SchoolDetailPage();
            Assert.IsTrue(detailpage.verifySADLink());
        }

        [Test]
        public void Verify_SADlink_Displayed_ForClosedSchool()
        {
            SelfAssessmentActions.SADclosedSchool("101449");
            SchoolDetailPage detailpage = new SchoolDetailPage();
            Assert.IsFalse(detailpage.verifySADLink());
        }
        [Test]
        public void verifyIyb_displayed_for_all_Values()
        {
            throw new NotImplementedException();
        }
        [Test]
        public void navigateBackToschooldetailpage()
        {
            SelfAssessmentActions.createSideBySideScenario("2032028");
            SelfAssessmentActions.navigatebacktoschooldetaipage();
            SchoolDetailPage detailpage = new SchoolDetailPage();
            Assert.IsTrue(detailpage.School_Name.Displayed);
        }

        [Test]
        public void navigateBackToHomePage()
        {
            SelfAssessmentActions.createSideBySideScenario("2032028");
            SelfAssessmentActions.navigatebacktohomepage();
            HomePage home = new HomePage();
            Assert.IsTrue(home.TrustTab.Displayed);
        }
        [Test]
        public void verifySchoolwithPartialFinance()
        {
            SelfAssessmentActions.verifySADLink("8792637");//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage();
            String assessmentWarning = ((assesmentpage.FinancewarningMessage).Text);
            Assert.IsNotEmpty(assessmentWarning);
           
        }

        [Test]
        public void VerifyAverageClassSizePopUp()
        {
            SelfAssessmentActions.VerifyPopUps("8792637");//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage();
            SadEditPage editpage = new SadEditPage();
            SelfAssessmentActions.ClickPopUp(editpage.Average_Class_size_Popup);
            String popupmessage = Driver.driver.FindElement(By.CssSelector("body > modal-container > div > div > app-edit-data-info-modal > div.modal-body > div")).Text;
            Assert.IsTrue(popupmessage == "Average class sizes are a key determinant of the cost of running a school.");

        }
        [Test]
        public void VerifySpending_on_administrative_and_clerical_staffPopUp()
        {
            SelfAssessmentActions.VerifyPopUps("8792637");//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage();
            SadEditPage editpage = new SadEditPage();
            SelfAssessmentActions.ClickPopUp(editpage.Spending_on_administrative_and_clerical_staff_Popup);
            String popupmessage = Driver.driver.FindElement(By.CssSelector("body > modal-container > div > div > app-edit-data-info-modal > div.modal-body > div")).Text;
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
            SelfAssessmentActions.VerifyPopUps("8792637");//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage();
            SadEditPage editpage = new SadEditPage();
            SelfAssessmentActions.ClickPopUp(editpage.School_workforce_Popup);
            String popupmessage = Driver.driver.FindElement(By.CssSelector("body > modal-container > div > div > app-edit-data-info-modal > div.modal-body > div")).Text;
            Console.WriteLine(popupmessage);
            Assert.AreEqual(popupmessage, @"The total full-time equivalent count of the school's workforce for the year of the dashboard.
This information is used to calculate workforce and pupil to workforce ratios.");



        }
        [Test]
        public void VerifyRevenue_reservePopUp()
        {
            SelfAssessmentActions.VerifyPopUps("8792637");//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage();
            SadEditPage editpage = new SadEditPage();
            SelfAssessmentActions.ClickPopUp(editpage.Revenue_reserve_Popup);
            String popupmessage = Driver.driver.FindElement(By.CssSelector("body > modal-container > div > div > app-edit-data-info-modal > div.modal-body > div")).Text;
            Console.WriteLine(popupmessage);
            Assert.AreEqual(popupmessage , @"This is the Restricted and unrestricted funds carried forward from the previous year + total income from current year – total expenditure in current year.
A cumulative deficit / negative reserve is indicated by a negative result, and a cumulative surplus / positive reserve is indicated by a positive result. The risk significance of a cumulative deficit is assessed relative to the Total income.");



        }
        [Test]
        public void VerifyPredicted_percentage_pupil_number_change_in_3_5_yearsPopUp()
        {
            SelfAssessmentActions.VerifyPopUps("8792637");//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage();
            SadEditPage editpage = new SadEditPage();
            SelfAssessmentActions.ClickPopUp(editpage.Predicted_percentage_pupil_number_change_in_3_5_years_Popup);
            String popupmessage = Driver.driver.FindElement(By.CssSelector("body > modal-container > div > div > app-edit-data-info-modal > div.modal-body > div")).Text;
            Console.WriteLine(popupmessage);
            Assert.IsTrue(popupmessage == "This is the percentage of pupils the school is expected to grow or shrink by over the next 3-5 years. A key factor determining a school’s finances is pupil numbers and schools should take this into account for financial projections and assumptions. This number cannot be lower than -100%");

        }
        [Test]
        public void VerifyNumberOfPupilsPopUp()
        {
            SelfAssessmentActions.VerifyPopUps("8792637");//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage();
            SadEditPage editpage = new SadEditPage();
            SelfAssessmentActions.ClickPopUp(editpage.Number_of_pupilsPopup);
            String popupmessage = Driver.driver.FindElement(By.CssSelector("body > modal-container > div > div > app-edit-data-info-modal > div.modal-body > div")).Text;
            Console.WriteLine(popupmessage);
            Assert.AreEqual(popupmessage , @"The number of pupils, full time equivalent, in the school for the year of the dashboard.
This information is used to ensure the school is being compared with schools of a similar size for Primary and Secondary phase schools. It is also used to calculate ratios of pupils to teachers and pupils to all workforce.");



        }
        [Test]
        public void VerifyNumberOfTeachersPopUp()
        {
            SelfAssessmentActions.VerifyPopUps("8792637");//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage();
            SadEditPage editpage = new SadEditPage();
            SelfAssessmentActions.ClickPopUp(editpage.NumberOfTeachers_Popup);
            String popupmessage = Driver.driver.FindElement(By.CssSelector("body > modal-container > div > div > app-edit-data-info-modal > div.modal-body > div")).Text;
            Console.WriteLine(popupmessage);
            Assert.AreEqual(popupmessage , @"The total full-time equivalent count of the school's teaching staff for the year of the dashboard. Full time equivalent number of teachers includes both classroom teachers and teachers in the leadership group. It excludes teaching assistants, non-classroom based school support staff, and auxiliary staff.This information is used to calculate average salaries, leadership ratios, and pupil to teacher ratios.");

        }
        [Test]
        public void VerifyYearOfScenarioPopUp()
        {
            SelfAssessmentActions.VerifyPopUps("8792637");//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage();
            SadEditPage editpage = new SadEditPage();
            SelfAssessmentActions.ClickPopUp(editpage.YearOfScenario_Popup);
            String popupmessage = Driver.driver.FindElement(By.CssSelector("body > modal-container > div > div > app-edit-data-info-modal > div.modal-body > div")).Text;
            Assert.AreEqual(popupmessage, "This is used to apply the correct banding ratios that may differ from year to year, e.g. Teaching staff ratios and Average salary has been adjusted with a graded uplift from years 17/18 to 19/20. It is also presented on the custom dashboard to help users identified when two dashboards are for different years.");

        }
        [Test]
        public void VerifyTotalIncomePopUp()
        {
            SelfAssessmentActions.VerifyPopUps("8792637");//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage();
            SadEditPage editpage = new SadEditPage();
            SelfAssessmentActions.ClickPopUp(editpage.Total_income_Popup);
            String popupmessage = Driver.driver.FindElement(By.CssSelector("body > modal-container > div > div > app-edit-data-info-modal > div.modal-body > div")).Text;
            Assert.AreEqual(popupmessage , "This is the Total income for the school in the dashboard year, actual or predicted if future. It is a Mandatory field as it is used to calculate the annual balance, and as baseline for the percentage of annual overspend and the relative size of any strategic reserve deficit.");

        }
        [Test]
        public void VerifyTotalExpenditurePopUp()
        {
            SelfAssessmentActions.VerifyPopUps("8792637");//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage();
            SadEditPage editpage = new SadEditPage();
            SelfAssessmentActions.ClickPopUp(editpage.Total_expenditure_Popup);
            
            String popupmessage = Driver.driver.FindElement(By.CssSelector("body > modal-container > div > div > app-edit-data-info-modal > div.modal-body > div")).Text;
            Console.WriteLine(popupmessage);
           
            Assert.AreEqual(popupmessage, @"This is the total expenditure for the school in the dashboard year. It is a mandatory field and should be greater than all the other spend items listed here.
It includes all the spend on the risk items plus the additional items not risk assessed in the dashboard including catering staff and supplies, water and sewerage, rent and rates, other occupation costs, special facilities, educational consultancy, professional services, auditor costs, other insurance premiums, administrative supplies, direct revenue finance, and interest charges for loan and bank.");



        }
        [Test]
        public void Teacher_contact_ratioPopUp()
        {
            SelfAssessmentActions.VerifyPopUps("8792637");//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage();
            SadEditPage editpage = new SadEditPage();
            SelfAssessmentActions.ClickPopUp(editpage.Teacher_contact_ratio_Popup);
            String popupmessage = Driver.driver.FindElement(By.CssSelector("body > modal-container > div > div > app-edit-data-info-modal > div.modal-body > div")).Text;
            Console.WriteLine(popupmessage);
            Assert.AreEqual(popupmessage , @"For secondary schools: Teacher contact ratio = total number of teaching periods timetabled for all teachers in the school ÷ total possible number of teaching periods
The total possible number of teaching periods is equivalent to the number of teaching periods in the timetable cycle multiplied by the full time equivalent number of teachers.
Full time equivalent number of teachers includes both classroom teachers and teachers in the leadership group. It excludes teaching assistants, non-classroom based school support staff, and auxiliary staff.
For primary schools: Teacher contact ratio = total number of classes ÷ full time equivalent number of teachers
Full time equivalent number of teachers includes both classroom teachers and teachers in the leadership group. It excludes teaching assistants, non-classroom based school support staff, and auxiliary staff.
The teacher contact ratio will always be less than 1.0");


        }
        [Test]
        public void Add_Data_In_year_balance()
        {
            
            //table.govuk-table:nth-child(3) > tbody:nth-child(2) > tr:nth-child(5) > td:nth-child(4) > span:nth-child(1)
            //Assert.IsTrue(teacherContaRatio.Text == "0.80");
        }
        [Test]
        public void Add_Data_Revenue_Reserve()
        {
            SADSideBySidePage SadPage = new SADSideBySidePage();
            SelfAssessmentActions.AddData("8792637", SadPage.AddData_Revenue_reserveSC2, "5000000.00");
            IWebElement revenueReserveC2 = Driver.driver.FindElement(By.CssSelector("#reserveTable > tr:nth-child(7) > td:nth-child(5)"));
            Console.WriteLine(revenueReserveC2.Text);
            Assert.AreEqual(revenueReserveC2.Text , "£5,000,000.00");
        }
        [Test]
        public void Add_Data_Teaching_Staff()
        {
            SADSideBySidePage SadPage = new SADSideBySidePage();
            SelfAssessmentActions.AddData("8792637", SadPage.AddData_Teaching_staffC2, "5000000.00");
            IWebElement teachingStaffSpend = Driver.driver.FindElement(By.CssSelector("#spendingTable > tr:nth-child(6) > td:nth-child(5)"));
            Console.WriteLine(teachingStaffSpend.Text);
            Assert.IsTrue(teachingStaffSpend.Text == "£5,000,000.00");

        }
      [Test]
        public void Add_Data_Premises_costs()
        {

        }
        [Test]
        public void Add_Data_Teaching_resources()
        {

        }
        [Test]
        public void Add_Data_Energy()
        {

        }
        [Test]
        public void Add_Data_Average_teacher_cost()
        {
            SelfAssessmentPage SadPage = new SelfAssessmentPage();
            SelfAssessmentActions.AddData("138950", SadPage.AverageTeacherCost_add, "200000");
            IWebElement teacherContaRatio = Driver.driver.FindElement(By.CssSelector("#charTable > tr:nth-child(10) > td:nth-child(4) > span:nth-child(1)"));
            Console.WriteLine(teacherContaRatio.Text);
        }
        [Test]
        public  void Add_Data_Senior_leaders_as_a_percentageofworkforce()
        {

        }
        [Test]
        public void Add_Data_Pupil_to_teacher_ratio()
        {

        }
        [Test]
        public void Add_Data_Pupil_to_adult_ratio()
        {

        }
        [Test]
        public void Add_Data_Teacher_contact_ratio()
        {
            SelfAssessmentPage SadPage = new SelfAssessmentPage();
            SelfAssessmentActions.AddData("8792637", SadPage.AddData_TeacherContactRatioSecondForSideBySide,"0.80");
            IWebElement  teacherContaRatio = Driver.driver.FindElement(By.CssSelector("#charTable > tr:nth-child(10) > td:nth-child(4) > span:nth-child(1)"));
            Console.WriteLine(teacherContaRatio.Text);
            //table.govuk-table:nth-child(3) > tbody:nth-child(2) > tr:nth-child(5) > td:nth-child(4) > span:nth-child(1)
            Assert.IsTrue(teacherContaRatio.Text == "0.80");
        }
        [Test]
        public void Add_Data_Average_Class_size()
        {

        }

        [Test]

        public void VerifyNonApplicableFields()
        {
            //Some school - TCR and Av class Not applied
             //112477 - Nursery
             //139761 - PRU
              //116640 - Special

            SelfAssessmentPage SadPage = new SelfAssessmentPage();
            SelfAssessmentActions.create_sadFor_Nurseries_Prus_Specials("112477", SadPage.AddData_TeacherContactRatio, ".65");
            


        }


        [Test]
        public void Add_Data_Predicted_percentage_pupil_number_change()
        {
            SelfAssessmentPage SadPage = new SelfAssessmentPage();
            SelfAssessmentActions.AddData("8792637", SadPage.AddData_Predicted_percentage_pupil_number_changeforSideBySide1, "12.666");
            IWebElement Predictedpupilchangepercentage = Driver.driver.FindElement(By.CssSelector("#charTable > tr:nth-child(11) > td:nth-child(2) > span:nth-child(1)"));
            Console.WriteLine(Predictedpupilchangepercentage.Text);
            Assert.IsTrue(Predictedpupilchangepercentage.Text == "12.7%");
            
        }

        [Test]
        public void testForDecimalPlacesOnFinanceFigures()
        {
            SelfAssessmentActions.createSideBySideScenario("100000");
        }


        [TearDown]
        public void TeardownAfterEachTest()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var screenshot = ((ITakesScreenshot)Driver.driver).GetScreenshot();
                var testName = TestContext.CurrentContext.Test.FullName;
                screenshot.SaveAsFile(@"C:\TEMP\" + testName + ".jpg");
                Driver.driver.Close();
                Driver.driver.Quit();
            }
            Driver.driver.Close();
            Driver.driver.Quit();
        }



    }
}
