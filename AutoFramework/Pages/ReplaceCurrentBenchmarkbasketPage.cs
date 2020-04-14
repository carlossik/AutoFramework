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
        public ReplaceCurrentBenchmarkbasketPage()
        {
            SeleniumExtras.PageObjects.PageFactory.InitElements(Driver.driver, this);
        }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".button")]
        public IWebElement Viewbenchmarkbasket { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".column-one-third > a:nth-child(1)")]
        public IWebElement Cancelt { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".next-button > button:nth-child(1)")]
        public IWebElement ReplaceBasket { get; set; }
    }
}