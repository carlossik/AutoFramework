namespace AutoFramework
{
    using OpenQA.Selenium;
    using NUnit.Framework;

    public class TrustSearchScenarios
    {
        IAlert alert;

        public TrustSearchScenarios()
        {     
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            //NavigateTo.LoginFormScenarioThroughTestCases();
            Actions.FillLoginForm();
        }


        [Test]
        public void TrustSearch()
        {
            Actions.TrustSearch();
        }
       [Test]
        public void TrustSearchwithUrnNo()
        {
            Actions.TrustSearchWithTrustnumber();

        }





        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}