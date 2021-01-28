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
using AutoFramework;

namespace SFB_Test_Automation.AutoFramework.Scenarios
{
    [TestFixture]
    class ErrorMessagesTests
    {

        [SetUp]
        public void SetupBeforeEachTest()

        {
            var testName = TestContext.CurrentContext.Test.FullName;
            Config.Credentials.deletefiles(@"C:\TEMP\" + testName + ".jpg");
            Actions.InitializeDriver(Config.FirefoxDriverUnderTest);

        }
        [Test]
        public void SchoolsearchwrongURNorLAESTAB()
        {

            Actions.schoolSearchwithLaestab("113456");//we send a wrong laestab to invoke the error
            HomePage home = new HomePage();
            Assert.AreEqual(home.schoolsearchErrormessage.Text, "Enter a school name, URN or LAESTAB to start a search (minimum 3 characters)");
        }
        [Test]
        public void SchoolsearchLocationError()
        {

            Actions.SearchByLocationUsingPostcode(" ");//we send an empty message to verify the results
            HomePage home = new HomePage();
            Assert.AreEqual(home.schoolsearchErrormessage.Text, "Enter a school name, URN or LAESTAB to start a search (minimum 3 characters)");
        }

        [Test]
        public void SchoolsearPostcodeError()
        {

            Actions.SearchByLocationUsingPostcode(" ");//we send an empty message to verify the results
            HomePage home = new HomePage();
            Assert.AreEqual(home.schoolsearchErrormessage.Text, "Enter a postcode, town or street to start a search (minimum 2 characters)");
        }

        [Test]
        public void SchoolsearchLAError()
        {

            Actions.searchschoolLaCode(" ");//we send an empty message to verify the results
            HomePage home = new HomePage();
            Assert.AreEqual(home.schoolsearchErrormessage.Text, "Enter a local authority name or LA code to start a search (minimum 2 characters)");
        }

       

        [Test]
        public void trustsearchwithnameError()
        {

            TrustActions.generaltrustsearch(" ");//we send an empty message to verify the results
            HomePage home = new HomePage();
            Assert.AreEqual(home.schoolsearchErrormessage.Text, "Enter a trust name or Companies House number to start a search (minimum 3 characters)");
        }

        [Test]
        public void TrustsearchLAError()
        {

            Actions.SearchTrustViaLocalAuthority(" ");//we send an empty message to verify the results
            HomePage home = new HomePage();
            Assert.AreEqual(home.schoolsearchErrormessage.Text, "Enter a local authority name or LA code to start a search (minimum 2 characters)");

        }

        [Test]
        public void quickcompareErrorMessaging()
        {

            Actions.SearchClosedschoolUrn(" ");//we send an empty message to verify the results
            HomePage home = new HomePage();
            Assert.AreEqual(home.schoolsearchErrormessage.Text, "Enter a school name, URN or LAESTAB to start a search (minimum 3 characters)");
        }

        [Test]
        public void DetailComparisonError()
        {

            Actions.SearchClosedschoolUrn(" ");//we send an empty message to verify the results
            HomePage home = new HomePage();
            Assert.AreEqual(home.schoolsearchErrormessage.Text, "Enter a school name, URN or LAESTAB to start a search (minimum 3 characters)");
        }

        [Test]
        public void ManualComparisonError()
        {

            Actions.SearchClosedschoolUrn(" ");//we send an empty message to verify the results
            HomePage home = new HomePage();
            Assert.AreEqual(home.schoolsearchErrormessage.Text, "Enter a school name, URN or LAESTAB to start a search (minimum 3 characters)");
        }

        [Test]
        public void Add_custom_dashboardError()
        {

            Actions.SearchClosedschoolUrn(" ");//we send an empty message to verify the results
            HomePage home = new HomePage();
            Assert.AreEqual(home.schoolsearchErrormessage.Text, "Enter a school name, URN or LAESTAB to start a search (minimum 3 characters)");
        }





        [TearDown]
        public void TeardownAfterEachTest()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var screenshot = ((ITakesScreenshot)Driver.driver).GetScreenshot();
                var testName = TestContext.CurrentContext.Test.FullName;
                screenshot.SaveAsFile(@"C:\TEMP\" + testName + ".jpg");
                //Driver.driver.Close();
                Driver.driver.Quit();
            }
           // Driver.driver.Close();
            Driver.driver.Quit();
        }
    }
}
