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

            Actions.InitializeDriver(Config.DriverUnderTest2);
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
            Assert.IsTrue(assessmentpage.verifyFinancialYear("100000"));
        }
        [Test]
        public void verifyschoolwithoutFullFinanceYear()
        {
            SelfAssessmentActions.verifySADlinkforIncomplete_finance_Year("101439");
            SchoolDetailPage detailspage = new SchoolDetailPage();
            Assert.IsFalse(detailspage.SADLink.Displayed);
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
            SelfAssessmentActions.PrintSad();
            SelfAssessmentPage assessmentpage = new SelfAssessmentPage();
            Assert.IsTrue(assessmentpage.Printbutton.Displayed);




        }

        [Test]
        public void TestDownloadSAD()
        {
            SelfAssessmentActions.createSideBySideScenario("2032028");
            SelfAssessmentActions.DownloadSad();
        }
        [Test]
        public void TestprintLayoutSAD()
        {
            throw new NotImplementedException();
        }
        [Test]
        public void Verify_SADlink_Displayed_ForOpenSchool()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void Verify_SADlink_Displayed_ForClosedSchool()
        {
            throw new NotImplementedException();
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
            String popupmessage = editpage.popupmessage.Text;
            Assert.IsTrue(popupmessage == "Average class sizes are a key determinant of the cost of running a school.");

        }
        [Test]
        public void VerifySpending_on_administrative_and_clerical_staffPopUp()
        {
            SelfAssessmentActions.VerifyPopUps("8792637");//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage();
            SadEditPage editpage = new SadEditPage();
            SelfAssessmentActions.ClickPopUp(editpage.Spending_on_administrative_and_clerical_staff_Popup);
            String popupmessage = editpage.popupmessage.Text;
            Assert.IsTrue(popupmessage == "Average class sizes are a key determinant of the cost of running a school.");

        }
        [Test]
        public void VerifySchool_workforcePopUp()
        {
            SelfAssessmentActions.VerifyPopUps("8792637");//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage();
            SadEditPage editpage = new SadEditPage();
            SelfAssessmentActions.ClickPopUp(editpage.School_workforce_Popup);
            String popupmessage = editpage.popupmessage.Text;
            Assert.IsTrue(popupmessage == "The total full-time equivalent count of the school's workforce for the year of the scenario.This information is used to calculate workforce and pupil to workforce ratios.");



        }
        [Test]
        public void VerifyRevenue_reservePopUp()
        {
            SelfAssessmentActions.VerifyPopUps("8792637");//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage();
            SadEditPage editpage = new SadEditPage();
            SelfAssessmentActions.ClickPopUp(editpage.Revenue_reserve_Popup);
            String popupmessage = editpage.popupmessage.Text;
            Assert.IsTrue(popupmessage == "This is the Restricted and unrestricted funds carried forward from the previous year + total income from current year – total expenditure in current year.A cumulative deficit / negative reserve is indicated by a negative result, and a cumulative surplus / positive reserve is indicated by a positive result.The risk significance of a cumulative deficit is assessed relative to the Total income. ");



        }
        [Test]
        public void VerifyPredicted_percentage_pupil_number_change_in_3_5_yearsPopUp()
        {
            SelfAssessmentActions.VerifyPopUps("8792637");//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage();
            SadEditPage editpage = new SadEditPage();
            SelfAssessmentActions.ClickPopUp(editpage.Predicted_percentage_pupil_number_change_in_3_5_years_Popup);
            String popupmessage = editpage.popupmessage.Text;
            Assert.IsTrue(popupmessage == "Average class sizes are a key determinant of the cost of running a school.");

        }
        [Test]
        public void VerifyNumberOfPupilsPopUp()
        {
            SelfAssessmentActions.VerifyPopUps("8792637");//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage();
            SadEditPage editpage = new SadEditPage();
            SelfAssessmentActions.ClickPopUp(editpage.Number_of_pupilsPopup);
            String popupmessage = editpage.popupmessage.Text;
            Assert.IsTrue(popupmessage == "Average class sizes are a key determinant of the cost of running a school.");

        }
        [Test]
        public void VerifyNumberOfTeachersPopUp()
        {
            SelfAssessmentActions.VerifyPopUps("8792637");//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage();
            SadEditPage editpage = new SadEditPage();
            SelfAssessmentActions.ClickPopUp(editpage.NumberOfTeachers_Popup);
            String popupmessage = editpage.popupmessage.Text;
            Assert.IsTrue(popupmessage == "Average class sizes are a key determinant of the cost of running a school.");

        }
        [Test]
        public void VerifyYearOfScenarioPopUp()
        {
            SelfAssessmentActions.VerifyPopUps("8792637");//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage();
            SadEditPage editpage = new SadEditPage();
            SelfAssessmentActions.ClickPopUp(editpage.YearOfScenario_Popup);
            String popupmessage = editpage.popupmessage.Text;
            Assert.IsTrue(popupmessage == "This is used to apply the correct banding ratios that may differ from year to year, e.g. Teaching staff ratios and Average salary has been adjusted with a graded uplift from years 17/18 to 19/20. It is also presented on the side by side dashboard to help users identified when two scenarios are for different years.");

        }
        [Test]
        public void VerifyTotalIncomePopUp()
        {
            SelfAssessmentActions.VerifyPopUps("8792637");//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage();
            SadEditPage editpage = new SadEditPage();
            SelfAssessmentActions.ClickPopUp(editpage.Total_income_Popup);
            String popupmessage = editpage.popupmessage.Text;
            Assert.IsTrue(popupmessage == "Average class sizes are a key determinant of the cost of running a school.");

        }
        [Test]
        public void VerifyTotalExpenditurePopUp()
        {
            SelfAssessmentActions.VerifyPopUps("8792637");//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage();
            SadEditPage editpage = new SadEditPage();
            SelfAssessmentActions.ClickPopUp(editpage.Total_expenditure_Popup);
            String popupmessage = editpage.popupmessage.Text;
            Assert.IsTrue(popupmessage == "Average class sizes are a key determinant of the cost of running a school.");

        }
        [Test]
        public void Teacher_contact_ratioPopUp()
        {
            SelfAssessmentActions.VerifyPopUps("8792637");//8792637
            SelfAssessmentPage assesmentpage = new SelfAssessmentPage();
            SadEditPage editpage = new SadEditPage();
            SelfAssessmentActions.ClickPopUp(editpage.Teacher_contact_ratio_Popup);
            String popupmessage = editpage.popupmessage.Text;
            Assert.IsTrue(popupmessage == "Average class sizes are a key determinant of the cost of running a school.");

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
