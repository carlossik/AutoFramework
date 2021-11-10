﻿namespace AutoFramework.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;
    using System;

    public class HomePage
    {
        public HomePage(IWebDriver driver)
        {

            PageFactory.InitElements(driver, this);

        }
        [FindsBy(How = How.XPath, Using = "//*[@id=\"js - search - results - info\"]/div/p/span")]
        [CacheLookup]
        public IWebElement SearchResults { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#SchoolOrCollegeNameId")]

        [CacheLookup]
        public IWebElement School { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#FindByNameId")]
        public IWebElement Id { get; set; }
        [FindsBy(How = How.ClassName, Using = "search-button")]
        public IWebElement SearchSubmit { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#FindByNameId")]
        public IWebElement SchoolsearchField { get; set; }
        [FindsBy(How = How.Id, Using = "trustNameId")]
        public IWebElement TrustTickBox { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#FindByTrustName")]
        public IWebElement TrustSearchInput { get; set; }
        [FindsBy(How = How.Id, Using = "TownOrCity")]
        public IWebElement LocationButton { get; set; }
        [FindsBy(How = How.Id, Using = "FindSchoolByTown")]
        public IWebElement SearchByLocationField { get; set; }
        [FindsBy(How = How.Id, Using = "FindCurrentPosition")]
        public IWebElement UseLocationLink { get; set; }
        [FindsBy(How = How.Id, Using = "openOnlyLocation")]
        public IWebElement OpenSchoolsOnly { get; set; }
        [FindsBy(How = How.CssSelector, Using = "button.govuk-button:nth-child(7)")]
        public IWebElement LocationSearchSubmitButton { get; set; }
        [FindsBy(How = How.Id, Using = "TrustLaCodeName")]
        public IWebElement LocalAuthorityTrustSearchButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@id='FindSchoolByLaCodeName']")]
        public IWebElement LacodeInputField { get; set; }
        [FindsBy(How = How.Id, Using = "LaCodeName")]
        public IWebElement LacodeSearchButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#SearchByTrustNameFieldset > div:nth-child(1) > button:nth-child(5)")]
        public IWebElement TrustSubmitButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#TrustSearchByTownFieldset > div:nth-child(3) > button")]
        public IWebElement TrustLocationSubmit { get; set; }
        [FindsBy(How = How.Id, Using = "TrustTab")]
        public IWebElement TrustTab { get; set; }
        [FindsBy(How = How.Id, Using = "trustNameId")]
        public IWebElement trustnameRadioButton { get; set; }
        [FindsBy(How = How.Id, Using = "TrustTownOrCity")]
        public IWebElement TrustLocationButton { get; set; }
        [FindsBy(How = How.Id, Using = "FindTrustByTown")]
        public IWebElement TrustLocationField { get; set; }
        [FindsBy(How = How.Id, Using = "LaCodeName")]
        public IWebElement TrustLaCodeButton { get; set; }
        [FindsBy(How = How.Id, Using = "FindTrustByLaCodeName")]
        public IWebElement TrustLaCodeInputField { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#TrustSearchByLaCodeNameFieldset > div:nth-child(1) > div:nth-child(3) > button:nth-child(3)")]
        public IWebElement TrustLacodeSearchButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#FindSchoolByLaCodeName")]
        public IWebElement SchoolLacodeinputField { get; set; }
        [FindsBy(How = How.Id, Using = "LaCodeName")]
        public IWebElement SchoolLacodeButton { get; set; }
        [FindsBy(How = How.CssSelector,Using = "button.govuk-button:nth-child(6)")]
        public IWebElement LAcodesearchSubmitButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".tt-suggestion > a:nth-child(1)")]
        public IWebElement FirstIntellicenceSuggested { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#NoDefaultTab > a:nth-child(1)")]
        public IWebElement NoDefaultSchoolTab { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Do you have a school or trust data query?')]")]
        public IWebElement SchoolorTrustDataQueryLink { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".tt-suggestion")]
        public IWebElement FirstSelectionOption { get; set; }
        [FindsBy(How = How.CssSelector,Using = "div.tt-suggestion:nth-child(2) > a:nth-child(1)")]
        public IWebElement secondSelectionOption { get; set; }
        [FindsBy(How = How.CssSelector, Using = "button.img-button:nth-child(2)")]
        public IWebElement SetasDefaultSchool { get; set; }
        [FindsBy(How = How.CssSelector, Using = "button.img-button:nth-child(1) > span:nth-child(2)")]
        public IWebElement UnSetasDefaultSchool { get; set; }
        [FindsBy(How = How.Id,Using = "FindSchoolManuallyByTown")]
        public IWebElement SearchLocationManually { get; set; }
        [FindsBy(How = How.CssSelector,Using = "[href *= 'News']")]
        public IWebElement NewsLink { get; set; }
        [FindsBy(How = How.CssSelector,Using = "details.mb-1 > summary:nth-child(1) > span:nth-child(1)")]
        public IWebElement SenSpecialCharacteristicsLink { get; set; }
        [FindsBy(How = How.Id, Using = "openOnlyName")]
        public IWebElement IncludeSchoolsCheckbox { get; set; }
        [FindsBy(How = How.CssSelector,Using = ".footer-meta-inner > ul:nth-child(2) > li:nth-child(1) > a:nth-child(1)")]
        public IWebElement cookies_footer { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Contact')]")]
        public IWebElement contactUs_footer { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".error-summary-list > li:nth-child(1) > a:nth-child(1)")]
        public IWebElement schoolsearchErrormessage { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".view-benchmark-charts-wrapper > a:nth-child(1)")]
        public IWebElement ViewBenchMarkChartsButton { get; set; }
        
        [FindsBy(How = How.XPath,Using = "//div[@class='footer-meta-inner']/ul[1]/li[3]/a[1]")]
        public IWebElement AccessibilityLink { get; set; }

        public void ClickOnSearchButton()
        {
            SearchSubmit.Click();

        }

        public bool CheckBasketEmpty(IWebDriver driver)
        {
            try
            {
                var editbasketLink = driver.FindElement(By.CssSelector(".banner__comparison-list-info-panel__edit-basket"));
                bool basketNotEmpty = editbasketLink.Displayed;
                Console.WriteLine(basketNotEmpty);
                return basketNotEmpty;
            }

            catch (OpenQA.Selenium.NoSuchElementException e) { }
            return false;
        }
    
    
        public void emptybasketBeforeTesting(IWebDriver driver)
        {
           
            if (CheckBasketEmpty(driver))
            {
                var editbasketLink = driver.FindElement(By.CssSelector(".banner__comparison-list-info-panel__edit-basket"));
                editbasketLink.Click();
                var clearBasket = driver.FindElement(By.CssSelector("button.benchmarkControls"));
                clearBasket.Click();
                var closeBasket = driver.FindElement(By.CssSelector(".back-link"));
                closeBasket.Click();
            }
            else
            {
                Console.WriteLine("Nothig to clear here. Baskets are empty");
            }
            
        }


    }
}

