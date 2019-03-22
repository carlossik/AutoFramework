using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFramework.Pages;

namespace AutoFramework.Pages.PageElements
{
    class SchoolDetailPage
    {
        public SchoolDetailPage()
        {

            PageFactory.InitElements(Driver.driver, this);
        }

        

        [FindsBy(How = How.CssSelector, Using = "#benchmarkBasket > div > div > div")]
        [CacheLookup]
        public IWebElement BenchmarkBasket { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#benchmarkBasket > div > div > div > a")]
        public IWebElement EditBasket { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#benchmarkBasket > div > div > div > button")]
        public IWebElement ClearBasket { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#benchmarkControlsPlaceHolder > div.compare-buttons-panel.compare-buttons-panel--set-unset > div > button:nth-child(2) > span")]
        public IWebElement SetasDefaultSchool { get; set; }
        [FindsBy(How = How.XPath, Using = " //*[@id='benchmarkControlsPlaceHolder']/div[2]/div/a[1]/text()")]
        public IWebElement CompareWithOtherSchools { get; set; }
        [FindsBy(How = How.XPath, Using = " //*[@id='benchmarkControlsPlaceHolder']/div[2]/div/a[3]")]
        public IWebElement AddToBenchMarkBasket { get; set; }
    }

    }

