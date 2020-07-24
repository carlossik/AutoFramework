using AutoFramework;
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

            Actions.InitializeDriver(Config.DriverUnderTest1);
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
            SelfAssessmentActions.verifySADLink("2013614");
            SelfAssessmentPage SADspage = new SelfAssessmentPage();
            Assert.IsTrue(SADspage.SelfAssessmentBanner.Displayed);
            Assert.IsTrue(SADspage.EditDataButton.Displayed);
            Assert.IsTrue(SADspage.HomeBreadCrumb.Displayed);
            Assert.IsTrue(SADspage.SchoonameBreadCrumb.Displayed);
            Assert.IsTrue(SADspage.SideBySideLink.Displayed);
            Assert.IsTrue(SADspage.SideBySideLink.Displayed);
        }
        [Test]
        public void verifyLatestFinanceYear()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
        [Test]
        public void TestCreateSideBySideView()
        {
            SelfAssessmentActions.createSideBySideScenario("3032083");
        }
        [Test]
        public void TestEditSideBySideView()
        {
            throw new NotImplementedException();
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
