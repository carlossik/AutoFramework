using System;
using System.Collections;
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
        public SearchResultsPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
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
        [FindsBy(How = How.CssSelector, Using = "#\\31 42295desktop > button:nth-child(2)")]
        public IWebElement AddFirstResult { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[8]/main/div[5]/div[2]/div/div[4]/div[1]/ul/li[2]/div/div[2]/div/button[2]")]
        public IWebElement AddSecondResult { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[8]/main/div[5]/div[2]/div/div[4]/div[1]/ul/li[3]/div/div[2]/div/button[2]")]
        public IWebElement AddThirdResult { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[8]/main/div[5]/div[2]/div/div[4]/div[1]/ul/li[3]/div/div[2]/div/button[2]")]
        public IWebElement searchresults { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#manualButton")]
        public IWebElement ManualButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = "a.button")]
        public IWebElement ViewBenchmarkChartsButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#manualButton")]
        public IWebElement ManualChartsButton { get; set; }
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
        [FindsBy(How = How.CssSelector, Using = "li.school-document:nth-child(1) > div:nth-child(1) > div:nth-child(1) > a:nth-child(1)")]
        public IWebElement FirstScoolLinkOnPage { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".count-js")]
        public IWebElement Allresultsdisplayed { get; set; }
        [FindsBy(How = How.Id, Using = "schoollevel_Secondary")]
        public IWebElement secondaryschool_checkbox { get; set; }
        [FindsBy(How = How.CssSelector, Using = "div.govuk-option-select:nth-child(4) > div:nth-child(1) > div:nth-child(1)")]
        public IWebElement EducationPhase_checkbox { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".add-all")]
        public IWebElement AddAllToBasket_Button { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id=\"schoollevel_Allthrough\"]")]
        public IWebElement SelectAllThroughsCheckbox { get; set; }
        [FindsBy(How = How.CssSelector, Using = "[href *= '/school/detail?urn=']")]
        public IWebElement viewtrustschoolsFirstLink { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".view-benchmark-charts-wrapper > button:nth-child(1)")]
        public IWebElement viewbenchmarkchartsResultsPage { get; set; }
        [FindsBy(How = How.CssSelector, Using = "")]
        public IWebElement schoolsDisplayed { get; set; }

        [FindsBy(How = How.ClassName, Using = "schoolsInTrust")]
        public IWebElement results { get; set; }


        public int resultsfromLinksCountTrusts(IWebDriver driver)
        {
            IList<IWebElement> elementList = driver.FindElements(By.XPath("//a[contains(@href,\"/trust/index?companyNo=\")]")); // note the FindElements, plural.

            return elementList.Count;
        }

        public int numberofschoolsdisplayedTrusts(IWebDriver driver)
        {
            IList numberofschools = (driver.FindElements(By.ClassName("schoolsInTrust"))); // note the FindElements, plural.

            return numberofschools.Count;
        }

        public IList schoolsListed_On_resultspage(IWebDriver driver)
        {
            IList numberofschools = (driver.FindElements(By.XPath("//a[contains(@href,\"/school/detail?urn=\")]")));
           
            Console.WriteLine(numberofschools);
            return numberofschools;
            
        }
        public static void clickonallelements(IWebDriver driver)
        {
            IList<IWebElement> all = driver.FindElements(By.XPath("//a[contains(@href,\"/school/detail?urn=\")]"));

            String[] allText = new String[all.Count];
            int i = 0;
            foreach (IWebElement element in all)
            {
                allText[i++] = element.Text;
                Console.WriteLine(allText);
            }
        }

        


    //public void LoopLink(IWebDriver driver)
    //{
    //    int count = LinkElements.Count;

    //    for (int i = 0; i < count; i++)
    //    {
    //        //driver.FindElements(By.XPath("//a[contains(@href,\"/school/detail?urn=\")]"))[i].Click();
    //        driver.FindElement(By.XPath("//a[@href='/school/detail?urn=']")).Click();
    //        //some ways to come back to the previous page
    //    }

    //}



}

}
