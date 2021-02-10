using AutoFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFB_Test_Automation.AutoFramework.Pages
{
   public class ComparingSimilarSchoolsPage
    {
        public ComparingSimilarSchoolsPage(IWebDriver driver)
        {
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
        }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#radio-1")]
        public IWebElement ReplaceCurrentBasket { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#radio-2")]
        public IWebElement AddToExistingBasket { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "div.column-one-third:nth-child(1) > button:nth-child(1)")]
        public IWebElement ContinueButton { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".link-button")]
        public IWebElement BackButton { get; set; }


        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".error-message")]
        public IWebElement ErrorMessage { get; set; }
        

    }
}
