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
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//select[@id='DistanceRadius']")]
        [SeleniumExtras.PageObjects.CacheLookup]
        public IWebElement Filter_ByMiles { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector,Using = "div.govuk-option-select:nth-child(4) > div:nth-child(1) > div:nth-child(1)")]
        public IWebElement Education_Phase_Expand { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//label[contains(text(),'Nursery')]")]
        public IWebElement EducationPhase_NurseryCheckbox { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//label[contains(text(),'Primary')]")]
        public IWebElement EducationPhase_PrimaryCheckbox { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#schoolLevel > div:nth-child(1) > fieldset:nth-child(1) > div:nth-child(2) > div:nth-child(2) > label:nth-child(2)")]
        public IWebElement EducationPhase_SecondaryCheckbox { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#schoolLevel > div:nth-child(1) > fieldset:nth-child(1) > div:nth-child(2) > div:nth-child(3) > label:nth-child(2)")]
        public IWebElement EducationPhase_AllThroughCheckbox { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#schoolLevel > div:nth-child(1) > fieldset:nth-child(1) > div:nth-child(2) > div:nth-child(4) > label:nth-child(2)")]
        public IWebElement EducationPhase_PupilReferalUnitCheckbox { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#schoolLevel > div:nth-child(1) > fieldset:nth-child(1) > div:nth-child(2) > div:nth-child(5) > label:nth-child(2)")]
        public IWebElement EducationPhase_SpecialCheckbox { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "div.govuk-option-select:nth-child(6) > div:nth-child(1) > div:nth-child(1)")]
        public IWebElement SchoolType { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//label[contains(text(),'Academy converter')]")]// "schooltype_Academyconverter")]
        public IWebElement SchoolType_AcademyConverter { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//label[contains(text(),'Academy sponsor led')]")]
        public IWebElement SchoolType_SponsorLed { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//label[contains(text(),'Community school')]")]
        public IWebElement SchoolType_CommunitySchool { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//label[contains(text(),'Community special school')]")]
        public IWebElement SchoolType_CommunitySpecialSchool { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//label[contains(text(),'Foundation school')]")]
        public IWebElement SchoolType_FoundationSchool { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#schoolType > div:nth-child(1) > fieldset:nth-child(1) > label:nth-child(7)")]
        public IWebElement SchoolType_FoundationSpecialSchool { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//label[contains(text(),'Free school')]")]
        public IWebElement SchoolType_FreeSchool { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//label[contains(text(),'Free school special')]")]
        public IWebElement SchoolType_FreeSchool_special { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "div.govuk-checkboxes__item:nth-child(9) > label:nth-child(2)")]
        public IWebElement SchoolType_Nursery { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.TagName, Using = "label")]
        public IWebElement EducationPhase_Nursery { get; set; }
        //schoollevel_Nursery
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//body/div[@id='js-modal-page']/div[@id='cookie-overlay-wrapper']/div[@id='content']/main[1]/div[2]/div[1]/div[1]/details[1]/div[1]/div[1]/form[1]/div[6]/div[2]/div[1]/fieldset[1]/div[1]/div[9]/label[1]")]
        public IWebElement SchoolType_PupilReferalUnit { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//label[contains(text(),'Voluntary aided school')]")]
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

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "li.school-document:nth-child(1) > div:nth-child(1) > div:nth-child(1) > a:nth-child(1)")]
        public IWebElement schoolsdisplayedLinks { get; set; }


                                                                                                      //div.pagination-container:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > span:nth-child(1)
    }
}
