using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutoFramework.Pages
{
    public class SearchResultsPage
    {
        public SearchResultsPage()
         {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div/main/h1")]
        [CacheLookup]
        public  IWebElement SchooSearchResults { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".banner__comparison-list-info-panel__edit-basket")]
        public IWebElement EditBasket { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".sticky-div__comparison-list-info-panel__clear-basket")]
        public IWebElement ClearBasket { get; set; }
        [FindsBy(How = How.CssSelector, Using = "a.button")]
        public IWebElement ViewBenchMarkCharts { get; set; }
        [FindsBy(How = How.CssSelector, Using = "a.bold-small")]
        public IWebElement FirstElementPresented { get; set; }
        [FindsBy(How = How.XPath,Using = "/html/body/div/main/div[2]/div[2]/div[4]/div[1]/div/ul/li[1]/div/div[2]/div/button[2]")]
        public IWebElement AddFirstResult { get; set; }
        [FindsBy(How = How.CssSelector ,Using = "a.button")]
        public IWebElement ViewBenchmarkChartsButton { get; set; }
    }
}
