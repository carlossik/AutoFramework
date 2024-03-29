﻿using System;
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
        public ManualPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#NewSchoolName")]
        [CacheLookup]
        public IWebElement NewSchoolNameField { get; set; }
        [FindsBy(How = How.CssSelector,Using = "#SchoolOrCollegeNameId")]
        public IWebElement AddSchoolByNameRadio { get; set; }
        [FindsBy(How = How.CssSelector,Using = "#manualButton")]
        public IWebElement ContinueToBenchMarkChartsButton { get; set; }
        [FindsBy(How = How.Name, Using = "searchtype")]
        public IWebElement ManualContinueButton { get; set; }
        //.tt-suggestion

        [FindsBy(How = How.CssSelector, Using = "#awesomplete_list_1_item_0")]
        public IWebElement FirstManualSuggestion { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#awesomplete_list_2_item_0")]
        public IWebElement SecondManualSuggestion { get; set; }
        [FindsBy(How = How.Id,Using = "displayNew")]
        public IWebElement AddAnotherSchoolLink { get; set; }

        [FindsBy(How = How.CssSelector,Using = "div.govuk-grid-row:nth-child(2) > button:nth-child(3)")]
        public IWebElement RemoveSchoolButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".remove-school")]
        public IWebElement RemoveSchoolButton2 { get; set; }

        [FindsBy(How = How.Id,Using = "ExistingSchools")]
        public IWebElement RemoveAll_SchoolButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='NewSchoolName']")]
        public IWebElement SecondSchoolAddField { get; set; }
        [FindsBy(How = How.XPath, Using = "school_2")]
        public IWebElement ThirdschoolAddField { get; set; }
        [FindsBy(How = How.XPath, Using = "school_3")]
        public IWebElement FourthSchoolAddField { get; set; }


    }
}
