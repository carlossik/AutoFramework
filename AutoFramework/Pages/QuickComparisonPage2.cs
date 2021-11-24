using AutoFramework;
using AutoFramework.Pages.PageElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;


namespace SFB_Test_Automation.AutoFramework.Pages
{
    class QuickComparisonPage2
    {
        public QuickComparisonPage2(IWebDriver driver)
        {
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
        }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "similarPupils")]
        public IWebElement SchoolswithSimilarAgedStudentscheckbox { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//button[contains(text(),'Continue to benchmarking charts')]")]
        public IWebElement ContinueToBenchMarkingChartButton { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//*[@id=\"scForm\"]/div[2]/div[2]/a")]
        public IWebElement BackButton { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//*[@id=\"content\"]/main/div[2]/div/div/span")]
        public IWebElement ComparingToSchoolName { get; set; }
    }
}
