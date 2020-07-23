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

            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "li:nth-of-type(2) > .font-xsmall")]
            public IWebElement ScenarioNameField { get; set; }

            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "li.govuk-breadcrumbs__list-item:nth-child(2) > a:nth-child(1)")]
            public IWebElement YearOfScenarioField { get; set; }

            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "li.govuk-breadcrumbs__list-item:nth-child(1) > a:nth-child(1)")]
            public IWebElement NumberOfPupils { get; set; }

            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".govuk-details__summary-text")]
            public IWebElement SchoolWorkForce { get; set; }

            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "button.govuk-button:nth-child(1)")]
            public IWebElement NumberOfTeachers { get; set; }

            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "button.govuk-button:nth-child(2)")]
            public IWebElement SeniorLeaderShip { get; set; }

            [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".govuk-heading-xl")]
            public IWebElement PercenTageOfPupilsEligbleFSM { get; set; }
            //.govuk-heading-xl








        }

    
}
