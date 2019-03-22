namespace AutoFramework
{
    using OpenQA.Selenium;
    using NUnit.Framework;

    public class LoginInvalidUsername
    {
        IAlert alert;

        public LoginInvalidUsername()
        {     
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            NavigateTo.LoginFormScenarioThroughTestCases();
        }

        
    }
}