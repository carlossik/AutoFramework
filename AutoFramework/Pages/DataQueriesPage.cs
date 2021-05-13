using AutoFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFB_Test_Automation.AutoFramework.Pages
{
    class DataQueriesPage
    {
        public DataQueriesPage(IWebDriver driver)
        {


            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
        }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "dataQuery.Name")]
        public IWebElement NameField { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "dataQuery.Email")]
        public IWebElement EmailField { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "dataQuery.SchoolTrustName")]
        public IWebElement SchoolNameField { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "dataQuery.SchoolTrustReferenceNumber")]
        public IWebElement LA_URN_CO_NUMBERField { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "dataQuery.DataQuery")]
        public IWebElement QueryInputField { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "button.button:nth-child(10)")]
        public IWebElement SubmitButton { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".heading-xlarge")]
        public IWebElement queryConfirmation { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".font-large")]
        public IWebElement referencenumberConfirmation { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".bold")]
        public IWebElement queryreferencenumber { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".error-summary-list > li:nth-child(1) > a:nth-child(1)")]
        public IWebElement EmailErrorMessage { get; set; }
        //.error-summary-list > li:nth-child(1) > a:nth-child(1)
    }
}
