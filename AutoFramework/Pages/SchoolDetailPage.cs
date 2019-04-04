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
    class SchoolDetailPage
    {
       
        public SchoolDetailPage()
        {


            SeleniumExtras.PageObjects.PageFactory.InitElements(Driver.driver, this);
        }

       

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#benchmarkBasket > div > div > div")]
        [SeleniumExtras.PageObjects.CacheLookup]
        public IWebElement BenchmarkBasket { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#benchmarkBasket > div > div > div > a")]
        public IWebElement EditBasket { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#benchmarkBasket > div > div > div > button")]
        public IWebElement ClearBasket { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#benchmarkControlsPlaceHolder > div.compare-buttons-panel.compare-buttons-panel--set-unset > div > button:nth-child(2) > span")]
        public IWebElement SetasDefaultSchool { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "a.button:nth-child(1)")]
        public IWebElement CompareWithOtherSchools { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = " //*[@id='benchmarkControlsPlaceHolder']/div[2]/div/a[3]")]
        public IWebElement AddToBenchMarkBasket { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#content > div:nth-child(3) > div:nth-child(1) > div > dl > dd:nth-child(16) > span.rating-text")]
        public IWebElement OfstedRating { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector,Using = "/#content > h1")]
        public IWebElement School_Name {get; set;}
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "SchoolLocationMap")]
        public IWebElement School_Location_Map { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector,Using = ".view-benchmark-charts-wrapper > a:nth-child(1)")]
        public IWebElement ViewBenchMarkCharts { get; set; }
        //[SeleniumExtras.PageObjects.FindsBy(How =How.ClassName,Using = "button compare-buttons-panel__button--compare")]
        //public IWebElement Compare { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = "a.button:nth-child(1)")]
        public IWebElement Compare { get; set; }

        
    }
   
   



}

