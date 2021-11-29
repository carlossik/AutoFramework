using AutoFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFB_Test_Automation.AutoFramework.Pages
{
    public class ReplaceCurrentBenchmarkbasketPage
    {
        public ReplaceCurrentBenchmarkbasketPage(IWebDriver driver)
        {
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
        }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".button")]
        public IWebElement Viewbenchmarkbasket { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//a[contains(text(),'Cancel')]")]
        public IWebElement Cancelt { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//button[contains(text(),'Replace benchmark set')]")]
        public IWebElement ReplaceBasket { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "div.govuk-grid-column-one-third:nth-child(1) > button:nth-child(1)")]
        public IWebElement ContinueButton { get; set; }
        //div.govuk-grid-column-one-third:nth-child(1) > button:nth-child(1)
    }
}