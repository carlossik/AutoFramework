using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFB_Test_Automation.AutoFramework.Pages
{
    class NewSchoolDetailPage
    {
        public NewSchoolDetailPage(IWebDriver driver)
        {


            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
        }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#ComparisonSchoolsTable > thead:nth-child(1) > tr:nth-child(1) > th:nth-child(1) > div:nth-child(1)")]
        [SeleniumExtras.PageObjects.CacheLookup]
        public IWebElement SchoolTab { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "th.numeric:nth-child(2) > div:nth-child(1)")]
        public IWebElement PupilsTab { get; set; }


    }
}
