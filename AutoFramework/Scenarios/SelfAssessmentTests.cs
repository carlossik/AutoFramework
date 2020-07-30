using AutoFramework;
using AutoFramework.Pages;
using AutoFramework.Pages.PageElements;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using SFB_Test_Automation.AutoFramework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFB_Test_Automation.AutoFramework.Scenarios
{
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
        public void TestCreateSideBySideView()
        {
            SelfAssessmentActions.createSideBySideScenario("2032028");
            SelfAssessmentPage assessmentpage = new SelfAssessmentPage();
            Assert.IsTrue(assessmentpage.ResetDashboardButton.Displayed);
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


        }
        [Test]
        public void TestRemoveScenario2()
        {
            SelfAssessmentActions.createSideBySideScenario("2032028");
            SelfAssessmentActions.removeScenario2();


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
