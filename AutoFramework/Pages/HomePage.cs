namespace AutoFramework.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#SchoolOrCollegeNameId")]
        [CacheLookup]
        public IWebElement School { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#FindByNameId")]
        public IWebElement Id { get; set; }
        [FindsBy(How = How.ClassName, Using = "search-button")]
        public IWebElement SearchSubmit { get; set; }
        [FindsBy(How = How.Id, Using = "FindByNameId")]
        public IWebElement SchoolsearchField { get; set; }
        [FindsBy(How = How.Id,Using = "trustNameId")]
        public IWebElement TrustTickBox { get; set; }
        [FindsBy(How = How.Id, Using = "FindByTrustName")]
        public IWebElement TrustSearchInput { get; set; }
        [FindsBy(How = How.Id, Using = "TownOrCity")]
        public IWebElement LocationButton { get; set; }
        [FindsBy(How = How.Id,Using = "FindSchoolByTown")]
        public IWebElement SearchByLocationField { get; set; }
        [FindsBy(How = How.Id,Using = "FindCurrentPosition")]
        public IWebElement UseLocationLink { get; set; }
        [FindsBy(How = How.Id,Using = "openOnlyLocation")]
        public IWebElement OpenSchoolsOnly { get; set; }





        public void ClickOnSearchButton()
        {
            SearchSubmit.Click();

        }

    }
}
