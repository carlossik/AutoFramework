
namespace AutoFramework.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;
    public class BestInClass
    {
        public BestInClass()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Id,Using ="radio-1")]
        [CacheLookup]
        public IWebElement QuckComparisonButton { get; set; }

        [FindsBy(How = How.Id, Using = "radio-2")]
        public IWebElement DetailComparisonButton { get; set; }

        [FindsBy(How = How.Id, Using = "radio-3")]
        public IWebElement BestInClassComparisonButton { get; set; }
        [FindsBy(How = How.CssSelector,Using = ".button")]
        public IWebElement ContinueToHigherProgressSchoolBenchmark { get; set; }

        [FindsBy(How = How.ClassName, Using = "button")]
        public IWebElement NextButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.column-one-third:nth-child(2) > a:nth-child(1)")]
        public IWebElement BackButton { get; set; }
        [FindsBy(How = How.Id,Using = "DefaultBasketSize")]
        public IWebElement DefaultChoice { get; set; }
        [FindsBy(How = How.Id, Using = "radio-1")]
        public IWebElement MaintainedSchoolsChoice { get; set; }
        [FindsBy(How = How.Id, Using = "radio-2")]
        public IWebElement AcadamiesChoice { get; set; }
        [FindsBy(How = How.Id, Using = "radio-3")]
        public IWebElement AllSchoolsChoice { get; set; }
        [FindsBy(How = How.Id, Using = "fsm")]
        public IWebElement PupilseligibleFreemeals { get; set; }
        [FindsBy(How = How.ClassName, Using = "button")]
        public IWebElement ContinueToBenchMarkChartsBurtton { get; set; }
    }
}


//ContinueToHigherProgressSchoolBenchmark