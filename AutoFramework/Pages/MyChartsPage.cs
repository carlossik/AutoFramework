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
using AutoFramework;

namespace SFB_Test_Automation.AutoFramework.Pages
{
    class MyChartsPage
    {
        public MyChartsPage()
        {
            SeleniumExtras.PageObjects.PageFactory.InitElements(Driver.driver, this);
        }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "#Custom > a:nth-child(1) > span:nth-child(1)")]//"//*[contains(., 'Your charts')]")]
        //[SeleniumExtras.PageObjects.CacheLookup]
        public IWebElement YourChartsTab { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#customTabSection > div > div > div > details > summary > span.summary.font-xsmall")]
        //[SeleniumExtras.PageObjects.CacheLookup]
        public IWebElement AddOrRemoveChartsLink { get; set; }
        //.criteria-details > summary:nth-child(1)


    }
}
