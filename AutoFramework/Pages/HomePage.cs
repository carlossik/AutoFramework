﻿namespace AutoFramework.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;
    using System;

    public class HomePage
    {
        private String URL = "https://as-t1dv-sfb.azurewebsites.net/";
        public HomePage()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            PageFactory.InitElements(Driver.driver, this);
#pragma warning restore CS0618 // Type or member is obsolete
        }

        [FindsBy(How = How.CssSelector, Using = "#SchoolOrCollegeNameId")]
        [CacheLookup]
        public IWebElement School { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#FindByNameId")]
        public IWebElement Id { get; set; }
        [FindsBy(How = How.ClassName, Using = "search-button")]
        public IWebElement SearchSubmit { get; set; }
        [FindsBy(How = How.Id, Using = "FindByNameId")]
        public IWebElement SchoolsearchField { get; set; }
        [FindsBy(How = How.Id,Using = "trustNameId")]
        public IWebElement TrustTickBox { get; set; }
        [FindsBy(How = How.Id, Using = "FindByTrustName")]
        public IWebElement TrustSearchInput { get; set; }
        [FindsBy(How = How.Id, Using = "TownOrCity")]
        public IWebElement LocationButton { get; set; }
        [FindsBy(How = How.Id,Using = "FindSchoolByTown")]
        public IWebElement SearchByLocationField { get; set; }
        [FindsBy(How = How.Id,Using = "FindCurrentPosition")]
        public IWebElement UseLocationLink { get; set; }
        [FindsBy(How = How.Id,Using = "openOnlyLocation")]
        public IWebElement OpenSchoolsOnly { get; set; }
        [FindsBy(How = How.CssSelector,Using = "#SearchByTownFieldset > div:nth-child(4) > button:nth-child(3)")]
        public IWebElement LocationSearchSubmitButton { get; set; }
        [FindsBy(How = How.Id, Using = "LaCodeName")]
        public IWebElement LcalAuthoritySearchButton { get; set; }
        [FindsBy(How = How.Id,Using = "FindSchoolByLaCodeName")]
        public IWebElement LacodeInputField { get; set; }
        [FindsBy(How = How.CssSelector,Using = "#SearchByLaCodeNameFieldset > div:nth-child(3) > button")]
        public IWebElement LacodeSearchButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#SearchByTrustNameFieldset > button:nth-child(4)")]
        public IWebElement TrustSubmit { get; set; }



        public void ClickOnSearchButton()
        {
            SearchSubmit.Click();

        }

    }
}
