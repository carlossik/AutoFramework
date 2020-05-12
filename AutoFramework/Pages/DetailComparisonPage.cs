using AutoFramework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFB_Test_Automation.AutoFramework.Pages
{
    class DetailComparisonPage
    {
        public DetailComparisonPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "GeneralHeader")]
        public IWebElement General_Header{ get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "SenHeader")]
        public IWebElement Sen_Header { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "PerformanceHeader")]
        public IWebElement Performance_Header { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "WFHeader")]
        public IWebElement WorkForce_Header { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".submit-criteria-js")]
        public IWebElement ViewBenchMarkCharts { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".clear-criteria")]
        public IWebElement ClearAllCharacteristics { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "div.criteria-controls:nth-child(2) > a:nth-child(1)")]
        public IWebElement Back_Button { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".highlight > span:nth-child(1)")]
        public IWebElement ComparingToText { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "div.breadcrumb-item:nth-child(2) > a:nth-child(1) > span:nth-child(1)")]
        public IWebElement SchooNameLink { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector,Using = "#mainQuestion")]
        public IWebElement BodyText1 { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id,Using = "LaCodeRadio")]
        public IWebElement LAcode { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id,Using = "FindSchoolByLaCode")]
        public IWebElement Lacodefield { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id,Using = "Maintained")]
        public IWebElement MaintainedRadio { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "Academies")]
        public IWebElement AcademyRadio { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "All")]
        public IWebElement AllschoolsRadio { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "All")]
        public IWebElement AllOfEnglandRadio { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "LaCodeRadio")]
        public IWebElement LAcodeRadio { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "LaCodeRadio")]
        public IWebElement LAnameRadio { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "FindSchoolByLaCode")]
        public IWebElement LAcodeinputfield { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#FindSchoolByLaCode")]
        public IWebElement LANameinputfield { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector,Using = "#AllFieldset > div > input[type=checkbox]")]
        public IWebElement AllSchoolsExcludecheckbox { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#MaintainedFieldset > div > input[type=checkbox]")]

        public IWebElement MaintainedExcludecheckbox { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#AcademiesFieldset > div > input[type=checkbox]")]
        public IWebElement AcademiesExcludecheckbox { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id,Using = "checkbox-MinNoPupil")]
        public IWebElement NumberOfPupilsCheckBox { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "MinNoPupil")]
        public IWebElement MinNumberOfPupilsInputField { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "MaxNoPupil")]
        public IWebElement MaxNumberOfPupilsInputBox { get; set; }

       // [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "checkbox-SchoolOverallPhase")]
        //public IWebElement OverallSchoolPhaseCheckBox { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "checkbox-OverallPhase")]
        public IWebElement SchoolPhaseCheckBox { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "div.accordion-section:nth-child(2) > fieldset:nth-child(1) > div:nth-child(3) > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > span:nth-child(1) > span:nth-child(1)")]
        public IWebElement SchoolPhaseValue { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "checkbox-TypeOfEstablishment")]
        public IWebElement SchoolTypeCheckBox { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector,Using = "#countPart")]
        public IWebElement SearchResultsCount { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id,Using = "checkbox-MinPerFSM")]
        public IWebElement EligibilityFressSchoolMealsCheckBox { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "MinPerFSM")]
        public IWebElement EligibilityFressSchoolMealsfromInput { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "MaxPerFSM")]
        public IWebElement EligibilityFressSchoolMealsToInput { get; set; }
    }
}

