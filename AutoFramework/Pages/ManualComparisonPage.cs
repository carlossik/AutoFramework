using AutoFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFB_Test_Automation.AutoFramework.Pages
{
    class EM_ManualComparisonPage
    {
        public EM_ManualComparisonPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "li.school-list__item:nth-child(1) > div:nth-child(1) > div:nth-child(2) > button:nth-child(1)")]
        [CacheLookup]
        public IWebElement AddFirstSchoolButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "li.school-list__item:nth-child(2) > div:nth-child(1) > div:nth-child(2) > button:nth-child(1)")]
        public IWebElement AddSecondSchoolButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "li.school-list__item:nth-child(3) > div:nth-child(1) > div:nth-child(2) > button:nth-child(1)")]
        public IWebElement AddThirdSchoolButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "li.school-list__item:nth-child(4) > div:nth-child(1) > div:nth-child(2) > button:nth-child(1)")]
        public IWebElement AddFourthSchoolButton { get; set; }
        //.tt-suggestion

        [FindsBy(How = How.CssSelector, Using = "li.school-list__item:nth-child(5) > div:nth-child(1) > div:nth-child(2) > button:nth-child(1)")]
        public IWebElement AddFithSchoolButton { get; set; }

        [FindsBy(How = How.CssSelector,Using = ".govuk-grid-column-one-third > app-ranks-filter:nth-child(2) > div:nth-child(1) > fieldset:nth-child(1) > legend:nth-child(1) > h3:nth-child(1)")]
        public IWebElement Efficiency_Metric_RankDropdown { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".govuk-grid-column-one-third > app-phase-filter:nth-child(3) > div:nth-child(1) > fieldset:nth-child(1) > legend:nth-child(1) > h3:nth-child(1)")]
        public IWebElement Education_PhaseDropdown { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".govuk-grid-column-one-third > app-type-filter:nth-child(4) > div:nth-child(1) > fieldset:nth-child(1) > legend:nth-child(1) > h3:nth-child(1)")]
        public IWebElement School_TypeDropdown { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".govuk-grid-column-one-third > app-ofsted-filter:nth-child(5) > div:nth-child(1) > fieldset:nth-child(1) > legend:nth-child(1) > h3:nth-child(1)")]
        public IWebElement Ofsted_Rating_Dropdown { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".govuk-grid-column-one-third > app-religion-filter:nth-child(6) > div:nth-child(1) > fieldset:nth-child(1) > legend:nth-child(1) > h3:nth-child(1)")]
        public IWebElement Religious_character_Dropdown { get; set; }

        [FindsBy(How = How.Id, Using = "filterRank-0")]
        public IWebElement EfficiencyMetric_Rank1 { get; set; }

        [FindsBy(How = How.Id, Using = "filterRank-1")]
        public IWebElement EfficiencyMetric_Rank2 { get; set; }

        [FindsBy(How = How.Id, Using = "filterRank-2")]
        public IWebElement EfficiencyMetric_Rank3 { get; set; }

        [FindsBy(How = How.Id, Using = "filterRank-3")]
        public IWebElement EfficiencyMetric_Rank4 { get; set; }

        [FindsBy(How = How.Id, Using = "filterRank-4")]
        public IWebElement EfficiencyMetric_Rank5 { get; set; }

        [FindsBy(How = How.Id, Using = "filterRank-5")]
        public IWebElement EfficiencyMetric_Rank6 { get; set; }

        [FindsBy(How = How.Id, Using = "filterRank-6")]
        public IWebElement EfficiencyMetric_Rank7 { get; set; }

        [FindsBy(How = How.Id, Using = "filterRank-7")]
        public IWebElement EfficiencyMetric_Rank8 { get; set; }

        [FindsBy(How = How.Id, Using = "filterRank-8")]
        public IWebElement EfficiencyMetric_Rank9 { get; set; }

        [FindsBy(How = How.Id, Using = "filterRank-9")]
        public IWebElement EfficiencyMetric_Rank10 { get; set; }

        [FindsBy(How = How.Id, Using = "filterPhase-0")]
        public IWebElement EducationPhase_Secondary { get; set; }

        [FindsBy(How = How.Id, Using = "filterPhase-1")]
        public IWebElement EducationPhase_All_Through { get; set; }

        [FindsBy(How = How.Id, Using = "filterType-0")]
        public IWebElement School_Type_AcademyConverter { get; set; }

        [FindsBy(How = How.Id, Using = "filterType-1")]
        public IWebElement School_Type_AcademySponsorLed { get; set; }

        [FindsBy(How = How.Id, Using = "filterOfsted-0")]
        public IWebElement Ofsted_Rating_Not_Rated { get; set; }

        [FindsBy(How = How.Id, Using = "filterOfsted-1")]
        public IWebElement Ofsted_Rating_OutStanding { get; set; }

        [FindsBy(How = How.Id, Using = "filterOfsted-2")]
        public IWebElement Ofsted_Rating_Good { get; set; }

        [FindsBy(How = How.Id, Using = "filterOfsted-3")]
        public IWebElement Ofsted_Rating_RequiresImprovement { get; set; }

        [FindsBy(How = How.Id, Using = "filterOfsted-4")]
        public IWebElement Ofsted_Rating_Inadequate { get; set; }

        [FindsBy(How = How.Id, Using = "sort")]
        public IWebElement Sorted_By_Dropdown { get; set; }

        [FindsBy(How = How.CssSelector, Using = " button.govuk-button:nth-child(3)")]
        public IWebElement Continue_To_BenchMarkCharts { get; set; }

       
        //Religious Character to be done 

        //filterRank-0

    }
}
