namespace AutoFramework.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class LoginScenarioPost
    {
        public LoginScenarioPost()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            PageFactory.InitElements(Driver.driver, this);
#pragma warning restore CS0618 // Type or member is obsolete
        }

        [FindsBy(How = How.Id, Using = "Username")]
        public IWebElement UsernameField { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.XPath, Using = " /html/body/main/div/div/section/form/div[4]/div/input")]

        public IWebElement LoginButton { get; set; }
    }
}
