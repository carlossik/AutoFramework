namespace AutoFramework.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class SpecialElementsPage
    {
        public SpecialElementsPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
          [FindsBy(How = How.CssSelector, Using = ".font16-ext-link")]
        [CacheLookup]
        public IWebElement feedbackLink { get; set; }
        [FindsBy(How = How.CssSelector, Using = "html.no-details body.js-enabled div.header-content div.header-content__dynamic-header.hide-in-print button.header-content__dynamic-header__button.js-dismiss-dynamic-header.a-button.underline")]
        public IWebElement HideMessageLink { get; set; }
        [FindsBy(How = How.CssSelector, Using = "li.guidance__list__item:nth-child(1) > a:nth-child(1)")]
        public IWebElement HelpUsingSiteLink { get; set; }
        [FindsBy(How = How.CssSelector, Using = "li.guidance__list__item:nth-child(2) > a:nth-child(1)")]
        public IWebElement IntepreTingTheChartsLinks { get; set; }

        [FindsBy(How = How.CssSelector, Using = "li.guidance__list__item:nth-child(3) > a:nth-child(1)")]
        public IWebElement DataSources { get; set; }

        [FindsBy(How =How.XPath,Using = "/html/body/div/main/h1")]
        public IWebElement SchoolName { get; set; }

        [FindsBy(How =How.ClassName,Using = "home-link")]
        public IWebElement HomeLink { get; set; }
    }
    public static class SchoolNameText
        
    {
        public static string schooltext = "Sir John Cass's Foundation Primary School";
        
    }
    public  class getSchoolName

    {
        public string SchoolName = Driver.driver.FindElement(By.XPath("/html/body/div/main/h1")).Text;

    }


}
    

//li.guidance__list__item:nth-child(1) > a:nth-child(1)