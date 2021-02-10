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
        public FiltersPage(IWebDriver driver)
        {

            PageFactory.InitElements(driver, this);

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

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "schoollevel_Nursery")]
        public IWebElement EducationPhase_Nursery { get; set; }
        //schoollevel_Nursery
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#schoolType > div:nth-child(1) > fieldset:nth-child(1) > label:nth-child(10)")]
        public IWebElement SchoolType_PupilReferalUnit { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#schoolType > div:nth-child(1) > fieldset:nth-child(1) > label:nth-child(11)")]
        public IWebElement SchoolType_VoluntaryAidedSchool { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector,Using = "div.govuk-option-select:nth-child(8) > div:nth-child(1) > div:nth-child(1)")]
        public IWebElement OfstedSelector { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath,Using = "//*[@id=\"DistanceRadius\"]/option[2]")]
        public IWebElement FilterBy3Miles { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//*[@id=\"DistanceRadius\"]/option[1]")]
        public IWebElement FilterBy1Mile { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//*[@id=\"DistanceRadius\"]/option[3]")]
        public IWebElement FilterBy5Miles { get; set; }


        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//*[@id=\"DistanceRadius\"]/option[4]")]
        public IWebElement FilterBy10Miles { get; set; }


        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//*[@id=\"DistanceRadius\"]/option[5]")]
        public IWebElement FilterBy15Miles { get; set; }


        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//*[@id=\"DistanceRadius\"]/option[6]")]
        public IWebElement FilterBy20Miles { get; set; }


        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//*[@id=\"DistanceRadius\"]/option[7]")]
        public IWebElement FilterBy25Miles { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id,Using = "OrderByControl")]
        public IWebElement SortedBy { get; set; }
        [SeleniumExtras .PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector,Using = "div.pagination-container:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > span:nth-child(1) > span:nth-child(1)")]
        public IWebElement ResultsCount { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "/html/body/div/div[3]/div[7]/main/div[2]/div[2]/div/div/div[4]/div[1]/ul/li[1]/div/div[1]/a")]
        public IWebElement schoolsdisplayedLinks { get; set; }


                                                                                                      //div.pagination-container:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > span:nth-child(1)
    }
}
