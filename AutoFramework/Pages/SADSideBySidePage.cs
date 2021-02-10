using AutoFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFB_Test_Automation.AutoFramework.Pages
{
    class SADSideBySidePage
    {
        public SADSideBySidePage(IWebDriver driver)
        {
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
        }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "")]
        public IWebElement AddData_Revenue_reserveSC1 { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#reserveTable > tr:nth-child(7) > td:nth-child(7) > span:nth-child(1) > a:nth-child(2)")]
        public IWebElement AddData_Revenue_reserveSC2 { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#spendingTable > tr:nth-child(6) > td:nth-child(7) > span:nth-child(1) > a:nth-child(2)")]
        public IWebElement AddData_Teaching_staffC2 { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "")]
        public IWebElement AddData_Teaching_staffC1 { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#main-content > app-sidebyside:nth-child(2) > div:nth-child(1) > app-sidebyside-table-desktop:nth-child(5) > table:nth-child(2) > tbody:nth-child(2) > tr:nth-child(2) > td:nth-child(7) > span:nth-child(1) > a:nth-child(2)")]
        public IWebElement AddData_Supply_staffC2 { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "")]
        public IWebElement AddData_Education_support_staffC1 { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#main-content > app-sidebyside:nth-child(2) > div:nth-child(1) > app-sidebyside-table-desktop:nth-child(5) > table:nth-child(2) > tbody:nth-child(2) > tr:nth-child(3) > td:nth-child(7) > span:nth-child(1) > a:nth-child(2)")]
        public IWebElement AddData_Education_support_staffC2 { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "")]
        public IWebElement AddData_Administrative_and_clerical_staffc1 { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#main-content > app-sidebyside:nth-child(2) > div:nth-child(1) > app-sidebyside-table-desktop:nth-child(5) > table:nth-child(2) > tbody:nth-child(2) > tr:nth-child(4) > td:nth-child(7) > span:nth-child(1) > a:nth-child(2)")]
        public IWebElement AddData_Administrative_and_clerical_staffc2 { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "")]
        public IWebElement AddData_Other_StaffCostsC1 { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#main-content > app-sidebyside:nth-child(2) > div:nth-child(1) > app-sidebyside-table-desktop:nth-child(5) > table:nth-child(2) > tbody:nth-child(2) > tr:nth-child(5) > td:nth-child(7) > span:nth-child(1) > a:nth-child(2)")]
        public IWebElement AddData_Other_StaffCostsC2 { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "")]
        public IWebElement AddData_Premises_costsC1 { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#main-content > app-sidebyside:nth-child(2) > div:nth-child(1) > app-sidebyside-table-desktop:nth-child(5) > table:nth-child(2) > tbody:nth-child(2) > tr:nth-child(6) > td:nth-child(7) > span:nth-child(1) > a:nth-child(2)")]
        public IWebElement AddData_Premises_costsC2 { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "")]
        public IWebElement AddData_TeacherResourcesC1 { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#main-content > app-sidebyside:nth-child(2) > div:nth-child(1) > app-sidebyside-table-desktop:nth-child(5) > table:nth-child(2) > tbody:nth-child(2) > tr:nth-child(7) > td:nth-child(7) > span:nth-child(1) > a:nth-child(2)")]
        public IWebElement AddData_TeacherResourcesC2 { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "")]
        public IWebElement AddData_Energyc1 { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "tr.govuk-table__row:nth-child(8) > td:nth-child(7) > span:nth-child(1) > a:nth-child(2)")]
        public IWebElement AddData_Energyc2 { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "")]
        public IWebElement AddData_Average_teacher_costC1 { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "table.govuk-table:nth-child(3) > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(5) > span:nth-child(1) > a:nth-child(2)")]
        public IWebElement AddData_Average_teacher_costC2 { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "table.govuk-table:nth-child(3) > tbody:nth-child(2) > tr:nth-child(5) > td:nth-child(3) > span:nth-child(1) > a:nth-child(2)")]
        public IWebElement AddData_Teacher_contact_ratioC1 { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "table.govuk-table:nth-child(3) > tbody:nth-child(2) > tr:nth-child(5) > td:nth-child(5) > span:nth-child(1) > a:nth-child(2)")]
        public IWebElement AddData_Teacher_contact_ratioC2 { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "table.govuk-table:nth-child(3) > tbody:nth-child(2) > tr:nth-child(6) > td:nth-child(3) > span:nth-child(1) > a:nth-child(2)")]
        public IWebElement AddData_PredictedPercentageC1 { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "table.govuk-table:nth-child(3) > tbody:nth-child(2) > tr:nth-child(6) > td:nth-child(5) > span:nth-child(1) > a:nth-child(2)")]
        public IWebElement AddData_PredictedPercentageC2 { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "table.govuk-table:nth-child(3) > tbody:nth-child(2) > tr:nth-child(7) > td:nth-child(3) > span:nth-child(1) > a:nth-child(2)")]
        public IWebElement AddData_Average_Class_sizeC1 { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "table.govuk-table:nth-child(3) > tbody:nth-child(2) > tr:nth-child(7) > td:nth-child(5) > span:nth-child(1) > a:nth-child(2)")]
        public IWebElement AddData_Average_Class_sizeC2 { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#criteriaTable > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(1)")]
        public IWebElement sadsidebysideSchoolPhase { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#criteriaTable > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(4)")]
        public IWebElement sadsidebysscenario2Primary { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#criteriaTable > tr:nth-child(8) > th:nth-child(1)")]
        public IWebElement sadsidebysideLondonweighingRow{ get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#criteriaTable > tr:nth-child(9) > th:nth-child(1)")]
        public IWebElement sadsidebysideNumberOfPupilsRow { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#criteriaTable > tbody:nth-child(2) > tr:nth-child(4)")]
        public IWebElement sadsidebysideFSMRow { get; set; }
       

    }
}
