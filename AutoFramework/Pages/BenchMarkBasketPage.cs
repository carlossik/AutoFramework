using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFramework.Pages;
using How = SeleniumExtras.PageObjects.How;

namespace AutoFramework.Pages.PageElements
{
    class BenchMarkBasketPage
    {
        public BenchMarkBasketPage()
        {


            SeleniumExtras.PageObjects.PageFactory.InitElements(Driver.driver, this);
        }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".back-link")]
        [SeleniumExtras.PageObjects.CacheLookup]
        public IWebElement CloseBasket { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "a.benchmarkControls")]
        public IWebElement AddSchools { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "button.benchmarkControls")]
        public IWebElement ClearBasket { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".column-one-third > a:nth-child(1)")]
        public IWebElement ViewBenchMarkingCharts { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "strong.bold-small")]
        public IWebElement benchmarkbasketmessage { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id,Using = "modal - title")]
        public IWebElement SavebenchmarkModal { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".button")]
        public IWebElement copylinktoclipboard { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "a.bold-xsmall:nth-child(5)")]
        public IWebElement emailLink { get; set; }
        //strong.bold-small

        public Boolean existsElement(String id)
        {
            try
            {
                Driver.driver.FindElement(By.Id(id));
            }
            catch (NoSuchElementException e)
            {
                return false;
            }
            return true;
        }
    }
}
