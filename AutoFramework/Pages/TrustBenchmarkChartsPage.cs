using AutoFramework;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;

namespace SFB_Test_Automation.AutoFramework.Pages
{
    public class TrustBenchmarkChartsPage
    {
        public TrustBenchmarkChartsPage()

        {
            SeleniumExtras.PageObjects.PageFactory.InitElements(Driver.driver, this);
        }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#content > div:nth-child(3) > div:nth-child(1)")]
        [SeleniumExtras.PageObjects.CacheLookup]
        public IWebElement ComparingTo_Text { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#Expenditure > a:nth-child(1)")]
        [SeleniumExtras.PageObjects.CacheLookup]
        public IWebElement ExpenditureTab { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#Income > a:nth-child(1)")]
        public IWebElement IncomeTab { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#Balance > a:nth-child(1)")]
        public IWebElement BalanceTab { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#ShowValue")]
        public IWebElement ShowValueDropDown { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "TrustCentralFinancing")]
        public IWebElement CentralFinancingDropdown { get; set; }

        
    }
}

