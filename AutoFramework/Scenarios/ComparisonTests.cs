namespace AutoFramework
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System.Threading;
    using AutoFramework.Pages;
    using System;
    using AutoFramework.Pages.PageElements;
    using System.Diagnostics;
    using SFB_Test_Automation.AutoFramework;
    using NUnit.Framework.Interfaces;
    using SFB_Test_Automation.AutoFramework.Pages;

    [TestFixture]
    public class ComparisonTests
    {



        //[OneTimeSetUp]
        [SetUp]
        public void SetupBeforeEachTest()
        //public void Initialize()
        {


            Actions.InitializeDriver("chrome");
           // Actions.InitializeFireFoxDriver();
            //Actions.FillLoginForm();
        }

        [Test]
        [Category("QuickTests")]
        public void QuickCompare()
        {
            Actions.CallingClass.QuickCompareWithOtherSchools();
            Thread.Sleep(2000);
           
            Assert.IsTrue(Driver.driver.FindElement(By.Id("Expenditure")).Displayed);//verify that the Expenditure tab is displayed and in focus
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector(".add-schools > span:nth-child(2)")).Displayed);//verify that the Add another School by name or location is available
            //Assert.IsTrue(Driver.driver.FindElement(By.Id("CentralFinancing")).Selected);
            //Assert.IsFalse(Driver.driver.FindElement(By.Id("la")).Selected);
            //Actions.CallingClass.ContinuetoBenchmarkCharts();


        }
        //[Test]
        public void ContinueToCharts()
        {
            Actions.CallingClass.QuickCompareWithOtherSchools();
            Actions.CallingClass.ContinuetoBenchmarkCharts();
            
        }
   
        [Test]
        public void zBestInClassComparison()
        {
            Actions.CallingClass.BestInClassComparison();
            SchoolDetailPage detailspage = new SchoolDetailPage();
            BestInClass bestinclasspage = new BestInClass();
            
            Assert.IsTrue(((bestinclasspage.BasketCount).Text).Contains("16 schools"));
            //Assert.IsTrue();
            
           



        }
        [Test]
        public void TestIntepretingTheCharts()
        {
            Actions.CallingClass.InterpretingTheChartsTest();
            Assert.IsTrue(Driver.driver.Url == Config.currentTestEnv+ "Help/InterpretingCharts");
            //need to add some assertions on the links present and the order
        }
        [Test]
        public void CompareTrusts()
        {
            Actions.TrustComparison("Portswood Primary Academy Trust");
        }
        [Test]
        public void VerifySchoolPhaseAndOverAllPhase()
        {
         DetailedComparisonActions.GeneralDetailedJourney("100008");
             String TestValue = Driver.driver.FindElement(By.CssSelector("div.accordion-section:nth-child(2) > fieldset:nth-child(1) > div:nth-child(3) > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > span:nth-child(1) > span:nth-child(1)")).Text;
           SchoolDetailPage detailspage = new SchoolDetailPage();
        
            Assert.AreEqual(TestValue, "Primary (Infant and junior)");//need to change this test to parameterize the test value
           
        }

        [Test]
        public void TestToAndFromFieldsNumOfPupils()
        {
            DetailedComparisonActions.IncludeschoolswithIncFinanceAcademiesAllEngland("144407", "64", "50");
            string errorText = "'From' value can not be greater than the 'To' value";
            Assert.IsTrue(Driver.driver.PageSource.Contains(errorText));
        }
        [Test]
        [Ignore("Ignore a test")]

        public void TestToAndFromFieldsEligibilityFreeschmeals()
        {
            DetailedComparisonActions.IncludeschoolswithIncFinanceAcademiesAllEngland("144407", "64", "50");
            string errorText = "'From' value can not be greater than the 'To' value";


            Assert.IsTrue(Driver.driver.PageSource.Contains(errorText));
        }
        [Test]
        [Ignore("Ignore a test")]
        public void TestToAndFromFieldsNumOfPupilsEduNeeds()
        {
            DetailedComparisonActions.IncludeschoolswithIncFinanceAcademiesAllEngland("144407", "64", "50");
            string errorText = "'From' value can not be greater than the 'To' value";


            Assert.IsTrue(Driver.driver.PageSource.Contains(errorText));
        }
        [Test]
        [Ignore("Ignore a test")]
        public void TestToAndFromFieldsNumInSixthForm()
        {
            DetailedComparisonActions.IncludeschoolswithIncFinanceAcademiesAllEngland("144407", "64", "50");
            string errorText = "'From' value can not be greater than the 'To' value";


            Assert.IsTrue(Driver.driver.PageSource.Contains(errorText));
        }

        [Test]
        
        public void DisplayComparisonschoolsTab()
        {
            DetailedComparisonActions.IncludeschoolswithIncFinanceAcademiesAllEngland("144407", "64", "50");
            //assert to come here
        }
        [Test]
        public void detailedComparisonOptions()
        {
            
            DetailedComparisonActions.GeneralDetailedJourney("100000");
            //Assertions to follow but for now we make sure all options are clicked as a check that these buttons are available
           
          
            


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
