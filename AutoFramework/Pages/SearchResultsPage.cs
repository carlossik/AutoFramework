using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
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
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[8]/main/div[5]/div[2]/div/div[4]/div[1]/ul/li[2]/div/div[2]/div/button[2]")]
        public IWebElement AddSecondResult { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[8]/main/div[5]/div[2]/div/div[4]/div[1]/ul/li[3]/div/div[2]/div/button[2]")]
        public IWebElement AddThirdResult { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[8]/main/div[5]/div[2]/div/div[4]/div[1]/ul/li[3]/div/div[2]/div/button[2]")]
        //public IWebElement AddThirdResult { get; set; }
        //[FindsBy(How = How.XPath, Using = "/html/body/div/div[8]/main/div[5]/div[2]/div/div[4]/div[1]/ul/li[3]/div/div[2]/div/button[2]")]
        //public IWebElement AddThirdResult { get; set; }
        //[FindsBy(How = How.XPath, Using = "/html/body/div/div[8]/main/div[5]/div[2]/div/div[4]/div[1]/ul/li[3]/div/div[2]/div/button[2]")]
        //public IWebElement AddThirdResult { get; set; }
        //[FindsBy(How = How.XPath, Using = "/html/body/div/div[8]/main/div[5]/div[2]/div/div[4]/div[1]/ul/li[3]/div/div[2]/div/button[2]")]
        //public IWebElement AddThirdResult { get; set; }
        //[FindsBy(How = How.XPath, Using = "/html/body/div/div[8]/main/div[5]/div[2]/div/div[4]/div[1]/ul/li[3]/div/div[2]/div/button[2]")]
        //public IWebElement AddThirdResult { get; set; }
        //[FindsBy(How = How.XPath, Using = "/html/body/div/div[8]/main/div[5]/div[2]/div/div[4]/div[1]/ul/li[3]/div/div[2]/div/button[2]")]
        //public IWebElement AddThirdResult { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#manualButton")]
        public IWebElement ManualButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a.button")]
        public IWebElement ViewBenchmarkChartsButton { get; set; }
        //[FindsBy(How = How.Id, Using = "schoollevel_16plus")]
        [FindsBy(How = How.CssSelector, Using = "#schoolLevel > div:nth-child(1) > fieldset:nth-child(1) > label:nth-child(8)")]
        public IWebElement Checkbox_16plus { get; set; }
        [FindsBy(How = How.CssSelector, Using = "div.pagination-container:nth-child(1) > div:nth-child(1) > div:nth-child(2) > button:nth-child(2)")]
        public IWebElement paginationSecondPage { get; set; }
        [FindsBy(How = How.PartialLinkText, Using = "3")]
        public IWebElement paginationThirdPage { get; set; }
        [FindsBy(How = How.CssSelector, Using = "div.pagination-container:nth-child(1) > div:nth-child(1) > div:nth-child(2) > button:nth-child(6)")]
        public IWebElement paginationNextButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = "div.pagination-container:nth-child(1) > div:nth-child(1) > div:nth-child(2) > button:nth-child(1)")]
        public IWebElement paginationPreviousButton { get; set; }
        [FindsBy(How = How.Id, Using = "OrderByControl")]
        public IWebElement TrustSearchResultSortedByButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "li.school-document:nth-child(1) > details:nth-child(3) > summary:nth-child(1) > span:nth-child(1)")]
        public IWebElement ViewTrustSchools { get; set; }
        [FindsBy(How = How.CssSelector,Using = "li.school-document:nth-child(1) > div:nth-child(1) > div:nth-child(1) > a:nth-child(1)")]
        public IWebElement FirstScoolLinkOnPage { get; set; }
        //public int numberofschoolsdisplayed = Driver.driver.FindElements(By.ClassName("schoolsInTrust")).Count;
        public int schoolsinlink = Driver.driver.FindElements(By.CssSelector("a[href*='/school/detail?urn=']")).Count;
        public int elementList = (Driver.driver.FindElements(By.ClassName("schoolsInTrust"))).Count;
        
        [FindsBy(How = How.Id,Using = "schoollevel_Allthrough")]
        public IWebElement SelectAllThroughsCheckbox { get; set; }




    [FindsBy(How = How.XPath,Using = "/html/body/div/div[8]/main/div[2]/div[2]/div[2]/div[2]/div[1]/ul/li[1]/details/div/table/tbody/tr[1]/td[1]/a")]
        public IWebElement viewtrustschoolsFirstLink { get; set; }


   
    }
}
