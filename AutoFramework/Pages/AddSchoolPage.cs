using AutoFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFB_Test_Automation.AutoFramework.Pages
{
   
        class AddSchool
        {
            public AddSchool(IWebDriver driver)
            {


                SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
            }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".home-link")]
            [SeleniumExtras.PageObjects.CacheLookup]
            public IWebElement BackToMainSchoolLink { get; set; }

            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "SchoolOrCollegeNameId")]
            public IWebElement AddSchoolBySchool { get; set; }

            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "TownOrCity")]
            public IWebElement AddschoolByLocation { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id,Using = "FindByNameId")]
        public IWebElement schoolinputField { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "FindSchoolByTown")]
        public IWebElement LocationinputField { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "FindSchoolManuallyByLaCodeName")]
        public IWebElement LocalAuthorityinputField { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id,Using = "FindCurrentPosition")]
        public IWebElement CurrentLocationLink { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "LaCodeName")]
            public IWebElement AddSchoolByLocalAuthority { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".back-button > a:nth-child(1)")]
            public IWebElement BackLink { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath,Using = "//div[@id='SearchByLaCodeNameFieldset']/div[2]/button[@class='button search-button' and 1]")]
        public IWebElement searchButton { get; set; }

        
            //strong.bold-small


        }
    }

