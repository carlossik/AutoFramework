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
        public BenchMarkBasketPage(IWebDriver driver)
        {


            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
        }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".back-link")]
        //[SeleniumExtras.PageObjects.CacheLookup]
        public IWebElement CloseBasket { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.ClassName, Using = "benchmarkControls")]
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
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".add-schools > span:nth-child(2)")]
        public IWebElement add_schools { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "button.benchmarkControls")]//"/html/body/div/div[8]/main/div[2]/div/div[1]/div/button")]
        public IWebElement clear_basket { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "/html/body/div/div[7]/div/div/a/span")]
        public IWebElement close_basket { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector,Using= ".govuk-back-link")]
        public IWebElement backButton{ get; set; }

        //a.benchmarkControls

        public Boolean existsElement(String id, IWebDriver driver)
        {
            try
            {
                driver.FindElement(By.Id(id));
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            return true;
        }
    }
}
