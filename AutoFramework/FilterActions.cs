using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoFramework
{
    using AutoFramework.Pages.PageElements;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using Pages;
    using SFB_Test_Automation.AutoFramework.Pages;
    using SFB_Test_Automation.AutoFramework.vs.AutoFramework.Helpers;
    using System.Collections.Generic;
    using System.Threading;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.Support.UI;

    public static class FilterActions
    {
        

        public static void FilterBy1Mile(string postcode, IWebDriver driver)
        {
            Actions.SearchByLocationUsingPostcode(postcode,driver);
            FiltersPage filters = new FiltersPage(driver);
            filters.Filter_ByMiles.Click();
            filters.FilterBy1Mile.Click();



        }
        public static void FilterBy3Miles(string postcode, IWebDriver driver)
        {
            Actions.SearchByLocationUsingPostcode(postcode,driver);
            FiltersPage filters = new FiltersPage(driver);
            filters.Filter_ByMiles.Click();
            filters.FilterBy10Miles.Click();
            filters.FilterBy3Miles.Click();
        }
        public static void FilterBy5Miles(string postcode, IWebDriver driver)
        {
            Actions.SearchByLocationUsingPostcode(postcode,driver);
            FiltersPage filters = new FiltersPage(driver);
            
            filters.Filter_ByMiles.Click();
            filters.FilterBy5Miles.Click();
            Thread.Sleep(1000);
            
        }

        public static void FilterBy10Miles(string postcode, IWebDriver driver)
        {
            Actions.SearchByLocationUsingPostcode(postcode,driver);
            FiltersPage filters = new FiltersPage(driver);
            filters.Filter_ByMiles.Click();
            filters.FilterBy10Miles.Click();
        }

        public static void FilterBy15Miles(string postcode, IWebDriver driver)
        {
            Actions.SearchByLocationUsingPostcode(postcode,driver);
            FiltersPage filters = new FiltersPage(driver);
            filters.Filter_ByMiles.Click();
            filters.FilterBy15Miles.Click();
        }

        public static void FilterBy20Miles(string postcode, IWebDriver driver)
        {
            Actions.SearchByLocationUsingPostcode(postcode,driver);
            FiltersPage filters = new FiltersPage(driver);
            filters.Filter_ByMiles.Click();
            filters.FilterBy20Miles.Click();
        }
        public static void FilterBy25Miles(string postcode, IWebDriver driver)
        {
            Actions.SearchByLocationUsingPostcode(postcode,driver);
            FiltersPage filters = new FiltersPage(driver);
            filters.Filter_ByMiles.Click();
            filters.FilterBy25Miles.Click();
        }

        public static void FilterByEducationPhasePrimary(string postcode, IWebDriver driver)
        {
            Actions.SearchByLocationUsingPostcode(postcode,driver);
            FiltersPage filters = new FiltersPage(driver);
            filters.EducationPhase_PrimaryCheckbox.Click();
            Thread.Sleep(3000);

        }
        public static void selectAllEducationPhase(string postcode, IWebDriver driver)
        {
            Actions.SearchByLocationUsingPostcode(postcode,driver);
            FiltersPage filters = new FiltersPage(driver);
            filters.EducationPhase_SecondaryCheckbox.Click();
            filters.EducationPhase_AllThroughCheckbox.Click();
            filters.EducationPhase_NurseryCheckbox.Click();
            filters.EducationPhase_PupilReferalUnitCheckbox.Click();
            filters.EducationPhase_PrimaryCheckbox.Click();
            filters.EducationPhase_SpecialCheckbox.Click();


        }
        public static void selectAllSchoolType(string postcode,IWebDriver driver)
        {
            Actions.SearchByLocationUsingPostcode(postcode,driver);
            FiltersPage filters = new FiltersPage(driver);
            filters.SchoolType.Click();
            filters.SchoolType_AcademyConverter.Click();
            filters.SchoolType_SponsorLed.Click();
            filters.SchoolType_CommunitySchool.Click();
            filters.SchoolType_CommunitySpecialSchool.Click();
            filters.SchoolType_FoundationSchool.Click();
            filters.SchoolType_FoundationSpecialSchool.Click();
            filters.SchoolType_FreeSchool.Click();
            filters.SchoolType_Nursery.Click();
            filters.SchoolType_PupilReferalUnit.Click();
            filters.SchoolType_VoluntaryAidedSchool.Click();

        }
        public static void SortByAlpabeticalOrderAZ(string postcode, IWebDriver driver)
        {
            Actions.SearchByLocationUsingPostcode(postcode,driver);
            FiltersPage filters = new FiltersPage(driver);
            //filters.SortedBy.Click();
            IWebElement SortedByDropDownElement = driver.FindElement(By.Id("OrderByControl"));
            //SortedByDropDownElement.Click();
            SelectElement SelectanOption = new SelectElement(SortedByDropDownElement);
            SelectanOption.SelectByValue("EstablishmentName asc");
            //filters.SortedBy.SendKeys("alphabetical a-z" + Keys.Enter);
            Thread.Sleep(3000);
        }

        public static void SortByAlpabeticalOrderZA(string postcode, IWebDriver driver)
        {
            Actions.SearchByLocationUsingPostcode(postcode,driver);
            FiltersPage filters = new FiltersPage(driver);
            IWebElement SortedByDropDownElement = driver.FindElement(By.Id("OrderByControl"));
            //SortedByDropDownElement.Click();
            SelectElement SelectanOption = new SelectElement(SortedByDropDownElement);
            SelectanOption.SelectByValue("EstablishmentName desc");
            //filters.SortedBy.SendKeys("alphabetical a-z" + Keys.Enter);
            Thread.Sleep(3000);
            //filters.SortedBy.Click();
            //Thread.Sleep(3000);
            //filters.SortedBy.SendKeys("alphabetical z-a" + Keys.Enter);
            //if (Config.DriverUnderTest == "firefox")
            //{
            //    filters.SortedBy.SendKeys("alphabetical z-a" + Keys.Enter);
            //}
            //Thread.Sleep(3000);
            ////filters.SortedBy.SendKeys("alphabetical z-a" + Keys.Enter);
            //Thread.Sleep(3000);
            ////filters.SortedBy.SendKeys("alphabetical z-a" + Keys.Enter);
            //Thread.Sleep(3000);
        }


    }
}
