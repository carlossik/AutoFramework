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
    class NoDefaultPage
    {
        public NoDefaultPage()
        {


            SeleniumExtras.PageObjects.PageFactory.InitElements(Driver.driver, this);
        }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "radio-2")]
        [SeleniumExtras.PageObjects.CacheLookup]
        public IWebElement DetailComparisonButton { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "radio-4")]
        public IWebElement ManualComparisonButton { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "div.column-one-third:nth-child(1) > button:nth-child(1)")]
        public IWebElement ContinueButton { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "Maintained")]
        public IWebElement MainTainedSchoolsButton { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "Academies")]
        public IWebElement AcademiesButton { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = ".button")]
        public IWebElement Page1ContinueButton { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "div.column-one-third:nth-child(2) > a:nth-child(1)")]
        public IWebElement Page1BackButton { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "All")]
        public IWebElement AllSchoolsButton { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "excludePartialMaintained")]
        public IWebElement ExcludeIncompleteButton { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id,Using = "SchoolOrCollegeNameId")]
        public IWebElement addschoolsbynameradio { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "TownOrCity")]
        public IWebElement addschoolsbyLocationradio { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "LaCodeName")]
        public IWebElement addschoolsbyLocalAuthorityradio { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "FindCurrentPosition")]
        public IWebElement useLocationLink { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#SearchByTownFieldset > div:nth-child(4) > button:nth-child(3)")]
        public IWebElement SearchSubmitButton { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "FindSchoolManuallyByTown")]
        public IWebElement AddSchoolsbyLocationTextField { get; set; }
        //FindSchoolManuallyByTown
    }
}



