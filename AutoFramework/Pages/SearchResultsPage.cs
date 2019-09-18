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

        [FindsBy(How = How.CssSelector, Using = "p.summary")]
        [CacheLookup]
        public IWebElement SchoolSearchResults { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".banner__comparison-list-info-panel__edit-basket")]
        public IWebElement EditBasket { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".sticky-div__comparison-list-info-panel__clear-basket")]
        public IWebElement ClearBasket { get; set; }
        [FindsBy(How = How.CssSelector, Using = "a.button")]
        public IWebElement ViewBenchMarkCharts { get; set; }
        [FindsBy(How = How.CssSelector, Using = "a.bold-small")]
        public IWebElement FirstElementPresented { get; set; }
        [FindsBy(How = How.CssSelector, Using = "button.desktop-button:nth-child(2)")]
        public IWebElement AddFirstResult { get; set; }
        [FindsBy(How = How.CssSelector, Using = "a.button")]
        public IWebElement ViewBenchmarkChartsButton { get; set; }
        [FindsBy(How = How.Id, Using = "schoollevel_16plus")]
        public IWebElement Checkbox_16plus { get;set;}
        [FindsBy(How = How.CssSelector,Using = "div.pagination-container:nth-child(1) > div:nth-child(1) > div:nth-child(2) > a:nth-child(2)")]
        public IWebElement paginationSecondPage { get; set; }
        [FindsBy(How = How.CssSelector, Using = "div.pagination-container:nth-child(1) > div:nth-child(1) > div:nth-child(2) > a:nth-child(4)")]
        public IWebElement paginationThirdPage { get; set; }
        [FindsBy(How = How.CssSelector, Using = "div.pagination-container:nth-child(1) > div:nth-child(1) > div:nth-child(2) > a:nth-child(4)")]
        public IWebElement paginationNextButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = "div.pagination-container:nth-child(1) > div:nth-child(1) > div:nth-child(2) > a:nth-child(1)")]
        public IWebElement paginationPreviousButton { get; set; }
    }
}
