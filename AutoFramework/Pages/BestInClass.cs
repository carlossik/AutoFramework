
namespace AutoFramework.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;
    using System.Collections.Generic;

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
        [FindsBy(How = How.Id, Using = "radio-4")]
        public IWebElement ManualComaprisonButton { get; set; }

        [FindsBy(How = How.CssSelector,Using = ".button")]
        public IWebElement ContinueToHigherProgressSchoolBenchmark { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.column-one-third:nth-child(1) > button:nth-child(1)")]
        public IWebElement Continue { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.column-one-third:nth-child(2) > a:nth-child(1)")]
        public IWebElement BackButton { get; set; }
        [FindsBy(How = How.Id,Using = "DefaultBasketSize")]
        public IWebElement DefaultChoice { get; set; }
        [FindsBy(How = How.Id, Using = "Maintained")]
        public IWebElement MaintainedSchoolsChoice { get; set; }
        [FindsBy(How = How.Id, Using = "radio-2")]
        public IWebElement AcadamiesChoice { get; set; }
        [FindsBy(How = How.Id, Using = "All")]
        public IWebElement AllSchoolsChoice { get; set; }
        [FindsBy(How = How.Id, Using = "fsm")]
        public IWebElement PupilseligibleFreemeals { get; set; }
        [FindsBy(How = How.ClassName, Using = "button submit-criteria-js submit mr-2")]
        public IWebElement ContinueToBenchMarkChartsButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = "button.link-button:nth-child(4)")]
        public IWebElement EditComparison_Link { get; set; }
        [FindsBy(How = How.CssSelector,Using = "#comparing > span:nth-child(3)")]
        public IWebElement comparing_to_text { get; set; }
        [FindsBy(How = How.CssSelector,Using = ".criteria-details > summary:nth-child(1) > span:nth-child(1)")]
        public IWebElement ViewCharacteristicsUsed { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#Expenditure > a:nth-child(1)")]
        public IWebElement ExpenditureTab { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#Income > a:nth-child(1)")]
        public IWebElement IncomeTab { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#Balance > a:nth-child(1)")]
        public IWebElement BalanceTab { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#Workforce > a:nth-child(1)")]
        public IWebElement WorkForceTab { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".custom > span:nth-child(1)")]
        public IWebElement YourChartTab { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#BestInClass > a:nth-child(1)")]
        public IWebElement ComparisonSchoolsTab { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".banner__comparison-list-info-panel__count")]
        public IWebElement BasketCount { get; set; }
        //[FindsBy(How = How.CssSelector, Using = ".banner__comparison-list-info-panel__count")]
        //public IWebElement BasketCount { get; set; }

        //IList<string> all = new List<string>();
        //foreach(var IWebElement in Driver.driver.FindElements(By.))
        
        //foreach(var element in driver.FindElements(By.ClassName("comments"));

}

    //[Find]
}



