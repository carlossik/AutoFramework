using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFramework.Pages;
using How = SeleniumExtras.PageObjects.How;
using AutoFramework;

namespace SFB_Test_Automation.AutoFramework.Pages
{
    class MyChartsPage
    {
        public MyChartsPage(IWebDriver driver)
        {
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
        }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "#Custom > a:nth-child(1) > span:nth-child(1)")]//"//*[contains(., 'Your charts')]")]
        //[SeleniumExtras.PageObjects.CacheLookup]
        public IWebElement YourChartsTab { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//span[contains(text(),'Add or remove charts')]")]
        public IWebElement AddOrRemoveChartsLink { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#custom-report-accordion > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > label:nth-child(2)")]
        public IWebElement Tot_ExpenDiture_PerPupil { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "div.accordion-section:nth-child(3) > div:nth-child(2) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > label:nth-child(2)")]
        public IWebElement Staff_PerPupil { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "div.accordion-section:nth-child(3) > div:nth-child(2) > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > label:nth-child(2)")]
        public IWebElement TeachingStaff_PerPupil { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "div.accordion-section:nth-child(3) > div:nth-child(2) > div:nth-child(4) > div:nth-child(2) > div:nth-child(1) > label:nth-child(2)")]
        public IWebElement EducationSupport_PerPupil { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//body[1]/div[1]/div[4]/div[1]/main[1]/div[4]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/div[2]/div[1]/div[2]/div[1]/div[2]/div[2]/div[1]/button[1]/span[1]")]
        public IWebElement AddTotalExpenditureToCharts { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#custom-report-accordion > div:nth-child(2) > h2:nth-child(1) > a:nth-child(1) > span:nth-child(1)")]
        public IWebElement TotalExpenditureaccordion { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "div.accordion-section:nth-child(3) > h2:nth-child(1) > a:nth-child(1) > span:nth-child(1)")]
        public IWebElement Staffeaccordion { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath,Using = "//*[@id=\"Custom\"]/a")]
        public IWebElement YourChartsTabAfterAddingChart { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id,Using = "proposition-name")]
        public IWebElement sfbbacktoHomeLink { get; set; }
    }


}
