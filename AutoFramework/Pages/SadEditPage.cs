using AutoFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFB_Test_Automation.AutoFramework.Pages
{
     class SadEditPage
    {
        
        
            public SadEditPage()
            {
                SeleniumExtras.PageObjects.PageFactory.InitElements(Driver.driver, this);
            }

            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "scenario-name")]
            public IWebElement ScenarioNameField { get; set; }

            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "scenario-term")]
            public IWebElement YearOfScenarioField { get; set; }

            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "number-pupils")]
            public IWebElement NumberOfPupils { get; set; }

            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "school-workforce")]
            public IWebElement SchoolWorkForce { get; set; }

            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "number-teachers")]
            public IWebElement NumberOfTeachers { get; set; }

            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "senior-leadership")]
            public IWebElement SeniorLeaderShip { get; set; }

            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "fsm")]
            public IWebElement PercenTageOfPupilsEligbleFSM { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "tcr")]
            public IWebElement Teacher_contact_ratio { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "ppl")]
            public IWebElement Predicted_percentage_pupil_number_change_in_3_5_years  { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "acs")]
            public IWebElement Average_Class_size { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "total-income")]
            public IWebElement Total_income  { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "total-expenditure")]
            public IWebElement Total_expenditure  { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "rr")]
            public IWebElement Revenue_reserve  { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "ts")]
            public IWebElement Spending_on_teaching_staff  { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "ss")]
            public IWebElement Spending_on_supply_staff { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "ess")]
            public IWebElement Spending_on_education_support_staff { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "acs")]
            public IWebElement Spending_on_administrative_and_clerical_staff  { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "osc")]
            public IWebElement Spending_on_other_staff_costs { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "prc")]
            public IWebElement Spending_on_premises_costs { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "tr")]
            public IWebElement Spending_on_teaching_resources  { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "en")]
            public IWebElement Spending_on_energy { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".govuk-button")]
            public IWebElement Submit_Button { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "a.govuk-link:nth-child(2)")]
            public IWebElement Back_Link { get; set; }
            //.govuk-heading-xl








    }

    
}
