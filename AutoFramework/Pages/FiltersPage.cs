using AutoFramework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFB_Test_Automation.AutoFramework.Pages
{
	class FiltersPage
	{
        public FiltersPage()
        {

            PageFactory.InitElements(Driver.driver, this);

        }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "DistanceRadius")]
        [SeleniumExtras.PageObjects.CacheLookup]
        public IWebElement Filter_ByMiles { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector,Using = "div.govuk-option-select:nth-child(4) > div:nth-child(1) > div:nth-child(1)")]
        public IWebElement Education_Phase_Expand { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#schoolLevel > div:nth-child(1) > fieldset:nth-child(1) > label:nth-child(2)")]
        public IWebElement EducationPhase_NurseryCheckbox { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#schoolLevel > div:nth-child(1) > fieldset:nth-child(1) > label:nth-child(3)")]
        public IWebElement EducationPhase_PrimaryCheckbox { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#schoolLevel > div:nth-child(1) > fieldset:nth-child(1) > label:nth-child(4)")]
        public IWebElement EducationPhase_SecondaryCheckbox { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#schoolLevel > div:nth-child(1) > fieldset:nth-child(1) > label:nth-child(5)")]
        public IWebElement EducationPhase_AllThroughCheckbox { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#schoolLevel > div:nth-child(1) > fieldset:nth-child(1) > label:nth-child(6)")]
        public IWebElement EducationPhase_PupilReferalUnitCheckbox { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#schoolLevel > div:nth-child(1) > fieldset:nth-child(1) > label:nth-child(7)")]
        public IWebElement EducationPhase_SpecialCheckbox { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "div.govuk-option-select:nth-child(6) > div:nth-child(1) > div:nth-child(1)")]
        public IWebElement SchoolType { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#schoolType > div:nth-child(1) > fieldset:nth-child(1) > label:nth-child(2)")]
        public IWebElement SchoolType_AcademyConverter { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#schoolType > div:nth-child(1) > fieldset:nth-child(1) > label:nth-child(3)")]
        public IWebElement SchoolType_SponsorLed { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#schoolType > div:nth-child(1) > fieldset:nth-child(1) > label:nth-child(4)")]
        public IWebElement SchoolType_CommunitySchool { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#schoolType > div:nth-child(1) > fieldset:nth-child(1) > label:nth-child(5)")]
        public IWebElement SchoolType_CommunitySpecialSchool { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#schoolType > div:nth-child(1) > fieldset:nth-child(1) > label:nth-child(6)")]
        public IWebElement SchoolType_FoundationSchool { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#schoolType > div:nth-child(1) > fieldset:nth-child(1) > label:nth-child(7)")]
        public IWebElement SchoolType_FoundationSpecialSchool { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#schoolType > div:nth-child(1) > fieldset:nth-child(1) > label:nth-child(8)")]
        public IWebElement SchoolType_FreeSchool { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#schoolType > div:nth-child(1) > fieldset:nth-child(1) > label:nth-child(9)")]
        public IWebElement SchoolType_Nursery { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#schoolType > div:nth-child(1) > fieldset:nth-child(1) > label:nth-child(10)")]
        public IWebElement SchoolType_PupilReferalUnit { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#schoolType > div:nth-child(1) > fieldset:nth-child(1) > label:nth-child(11)")]
        public IWebElement SchoolType_VoluntaryAidedSchool { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector,Using = "div.govuk-option-select:nth-child(8) > div:nth-child(1) > div:nth-child(1)")]
        public IWebElement OfstedSelector { get; set; }












    }
}
