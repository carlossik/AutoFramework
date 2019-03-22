namespace AutoFramework.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        [FindsBy(How = How.Id, Using = "Username")]
        [CacheLookup]
        public IWebElement UsernameCase { get; set; }
        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement PassWord { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='loginForm']/form/div[4]/div/input")]
        public IWebElement Submit { get; set; }
        //[FindsBy(How = How.CssSelector, Using = "#main-content > article.mh-loop-item.clearfix.post-74.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-test-cases > div.mh-loop-content.clearfix > header > h3 > a")]
        // public IWebElement UsernameCase { get; set; }
    }
}
