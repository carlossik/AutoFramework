using AutoFramework;
using OpenQA.Selenium;
using System;
using System.Collections;
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
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "div.govuk-grid-row:nth-child(6) > div:nth-child(1) > button:nth-child(1)")]
            public IWebElement Submit_Button { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.ClassName, Using = "govuk-back-link")]
            public IWebElement Back_Link { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector,Using = "#help-scenarioTerm > img:nth-child(1)")]
            public IWebElement YearOfScenario_Popup { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#help-numberOfPupils > img:nth-child(1)")]
            public IWebElement Number_of_pupilsPopup { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#help-schoolWorkforce > img:nth-child(1)")]
            public IWebElement School_workforce_Popup { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#help-numberOfTeachers > img:nth-child(1)")]
            public IWebElement NumberOfTeachers_Popup { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "fieldset.govuk-fieldset:nth-child(2) > div:nth-child(5) > label:nth-child(1) > img:nth-child(1)")]
            public IWebElement Senior_leadership_Popup { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#help-teacherContactRatio > img:nth-child(1)")]
            public IWebElement Teacher_contact_ratio_Popup { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#help-predictedPupil > img:nth-child(1)")]
            public IWebElement Predicted_percentage_pupil_number_change_in_3_5_years_Popup { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#help-averageClassSize > img:nth-child(1)")]
            public IWebElement Average_Class_size_Popup { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#help-totalIncome > img:nth-child(1)")]
            public IWebElement Total_income_Popup { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#help-totalExpenditure > img:nth-child(1)")]
            public IWebElement Total_expenditure_Popup { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#help-rr > img:nth-child(1)")]
            public IWebElement Revenue_reserve_Popup { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "fieldset.govuk-fieldset:nth-child(4) > div:nth-child(2) > label:nth-child(1) > img:nth-child(1)")]
            public IWebElement Spending_on_teaching_staff_Popup { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "fieldset.govuk-fieldset:nth-child(4) > div:nth-child(3) > label:nth-child(1) > img:nth-child(1)")]
            public IWebElement Spending_on_supply_staff_Popup { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "fieldset.govuk-fieldset:nth-child(4) > div:nth-child(4) > label:nth-child(1) > img:nth-child(1)")]
            public IWebElement Spending_on_education_support_staff_Popup { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#help-adminStaff > img:nth-child(1)")]
            public IWebElement Spending_on_administrative_and_clerical_staff_Popup { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "fieldset.govuk-fieldset:nth-child(4) > div:nth-child(6) > label:nth-child(1) > img:nth-child(1)")]
            public IWebElement Spending_on_other_staff_costs_Popup { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "fieldset.govuk-fieldset:nth-child(4) > div:nth-child(7) > label:nth-child(1) > img:nth-child(1)")]
            public IWebElement Spending_on_premises_costs_Popup { get; set; }
            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "fieldset.govuk-fieldset:nth-child(4) > div:nth-child(8) > label:nth-child(1) > img:nth-child(1)")]
            public IWebElement Spending_on_teaching_resources_Popup { get; set; }

            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "fieldset.govuk-fieldset:nth-child(4) > div:nth-child(9) > label:nth-child(1) > img:nth-child(1)")]
            public IWebElement Spending_on_energy_Popup { get; set; }

            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".pull-right > span:nth-child(1)")]
            public IWebElement modalcloseButton { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".modal-body > div:nth-child(1) > p:nth-child(1)")]
        public IWebElement popupmessage { get; set; }
        //.pull-right > span:nth-child(1)











        //.govuk-heading-xl








    }

    
}
