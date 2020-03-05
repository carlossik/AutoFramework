using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SFB_Test_Automation.AutoFramework.Pages
{
    class ManualPage
    {
        public ManualPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#NewSchoolName")]
        [CacheLookup]
        public IWebElement NewSchoolNameField { get; set; }
        [FindsBy(How = How.CssSelector,Using = "#SchoolOrCollegeNameId")]
        public IWebElement AddSchoolByNameRadio { get; set; }
        [FindsBy(How = How.CssSelector,Using = "#manualButton")]
        public IWebElement ContinueToBenchMarkChartsButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = "button.button:nth-child(2)")]
        public IWebElement ManualContinueButton { get; set; }
        //.tt-suggestion

        [FindsBy(How = How.CssSelector, Using = ".tt-suggestion")]
        public IWebElement FirstManualSuggestion { get; set; }



    }
}
