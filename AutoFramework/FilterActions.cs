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
    public static class FilterActions
    {
        //public static void InitializeDriver()
        //{
        //    Driver.driver = new OpenQA.Selenium.Firefox.FirefoxDriver();
        //    Driver.driver.Navigate().GoToUrl(Config.BaseURL);
        //    Driver.driver.Manage().Window.Maximize();
        //    Driver.WaitForElementUpTo(Config.ElementsWaitingTimeout);
        //}

        public static void FilterBy1Mile()
        {
            Actions.SearchByLocationManualEntry();
            FiltersPage filters = new FiltersPage();
            filters.Filter_ByMiles.Click();
            filters.FilterBy1Mile.Click();



        }
        public static void FilterBy3Miles()
        {
            Actions.SearchByLocationManualEntry();
            FiltersPage filters = new FiltersPage();
            filters.Filter_ByMiles.Click();
            filters.FilterBy10Miles.Click();
            filters.FilterBy3Miles.Click();
        }
        public static void FilterBy5Miles()
        {
            Actions.SearchByLocationManualEntry();
            FiltersPage filters = new FiltersPage();
            filters.Filter_ByMiles.Click();
            filters.FilterBy5Miles.Click();
        }

        public static void FilterBy10Miles()
        {
            Actions.SearchByLocationManualEntry();
            FiltersPage filters = new FiltersPage();
            filters.Filter_ByMiles.Click();
            filters.FilterBy10Miles.Click();
        }

        public static void FilterBy15Miles()
        {
            Actions.SearchByLocationManualEntry();
            FiltersPage filters = new FiltersPage();
            filters.Filter_ByMiles.Click();
            filters.FilterBy15Miles.Click();
        }

        public static void FilterBy20Miles()
        {
            Actions.SearchByLocationManualEntry();
            FiltersPage filters = new FiltersPage();
            filters.Filter_ByMiles.Click();
            filters.FilterBy20Miles.Click();
        }
        public static void FilterBy25Miles()
        {
            Actions.SearchByLocationManualEntry();
            FiltersPage filters = new FiltersPage();
            filters.Filter_ByMiles.Click();
            filters.FilterBy25Miles.Click();
        }

        public static void FilterByEducationPhasePrimary()
        {
            Actions.SearchByLocationManualEntry();
            FiltersPage filters = new FiltersPage();
            filters.EducationPhase_PrimaryCheckbox.Click();

        }
        public static void selectAllEducationPhase()
        {
            Actions.SearchByLocationManualEntry();
            FiltersPage filters = new FiltersPage();
            filters.EducationPhase_SecondaryCheckbox.Click();
            filters.EducationPhase_AllThroughCheckbox.Click();
            filters.EducationPhase_NurseryCheckbox.Click();
            filters.EducationPhase_PupilReferalUnitCheckbox.Click();
            filters.EducationPhase_PrimaryCheckbox.Click();
            filters.EducationPhase_SpecialCheckbox.Click();


        }
        public static void selectAllSchoolType()
        {
            Actions.SearchByLocationManualEntry();
            FiltersPage filters = new FiltersPage();
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
        public static void SortByAlpabeticalOrderAZ()
        {
            Actions.SearchByLocationManualEntry();
            FiltersPage filters = new FiltersPage();
            filters.SortedBy.Click();
            filters.SortedBy.SendKeys("alphabetical a-z" + Keys.Enter);
            Thread.Sleep(3000);
        }

        public static void SortByAlpabeticalOrderZA()
        {
            Actions.SearchByLocationManualEntry();
            FiltersPage filters = new FiltersPage();
            filters.SortedBy.Click();
            filters.SortedBy.SendKeys("alphabetical z-a" + Keys.Enter);

            Thread.Sleep(3000);
        }


    }
}
