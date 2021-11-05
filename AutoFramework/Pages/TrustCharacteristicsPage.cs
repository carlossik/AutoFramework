using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using AutoFramework.Pages;
using How = SeleniumExtras.PageObjects.How;

namespace SFB_Test_Automation.AutoFramework.Pages
{
    public class TrustCharacteristicsPage
    {
        public TrustCharacteristicsPage(IWebDriver driver)
        {

            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
        }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//span[@class='bold-xsmall']")]
        //[SeleniumExtras.PageObjects.CacheLookup]
        public IWebElement ComparingTo_School { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//input[@id='checkbox-MinNoPupil']")]
        public IWebElement NumberOfPupilsCheckBox { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//input[@id='MinNoPupil']")]
        public IWebElement NumberOfPupilsFromtextBox { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//input[@id='MaxNoPupil']")]
        public IWebElement NumberOfPupilsTotextbox{ get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//input[@id='checkbox-MinNoSchools']")]
        public IWebElement NumberOfSchoolsCheckbox { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//input[@id='MinNoSchools']")]
        public IWebElement MinimumNumbewrOfSchoolsTextBox { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "//input[@id='MaxNoSchools']")]
        public IWebElement MaxiMunNumberOfSchoolsTextBox { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "checkbox-MinTotalInc")]
        public IWebElement TotalIncomeCheckBox { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "MinTotalInc")]
        public IWebElement MinimumTotalIncomeTextBox { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "MaxTotalInc")]
        public IWebElement MaxiMunTotalIncomeTextBox { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "checkbox-SchoolOverallPhase")]
        public IWebElement SchoolPhaseCheckBox { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "SchoolOverallPhase0")]
        public IWebElement PrimaryCheckBox { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "SchoolOverallPhase1")]
        public IWebElement SecondaryCheckBox { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "SchoolOverallPhase2")]
        public IWebElement SpecialRadioButton { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "SchoolOverallPhase3")]
        public IWebElement PeopleReferalUnitRadio { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "SchoolOverallPhase4")]
        public IWebElement AlternativeProvisionRadioButton { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "SchoolOverallPhase5")]
        public IWebElement AllThroughRadioButton { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "SchoolOverallPhase6")]
        public IWebElement CrossPhaseRadioButton { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "sbmt_button")]
        public IWebElement ViewBenchMarkChartsButton { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//button[@class='clear-criteria js-clear-criteria link-button font-xsmall']")]
        public IWebElement ClearCharacteristicsButton { get; set; }




    }
}
