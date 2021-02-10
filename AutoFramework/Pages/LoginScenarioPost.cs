namespace AutoFramework.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class LoginScenarioPost
    {
        public LoginScenarioPost(IWebDriver driver)
        {
#pragma warning disable CS0618 // Type or member is obsolete
            PageFactory.InitElements(driver, this);
#pragma warning restore CS0618 // Type or member is obsolete
        }

        [FindsBy(How = How.Id, Using = "Username")]
        public IWebElement UsernameField { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.CssSelector, Using = " .btn")]

        public IWebElement LoginButton { get; set; }
    }
}
