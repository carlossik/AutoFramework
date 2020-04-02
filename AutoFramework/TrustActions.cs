namespace AutoFramework
{
    using AutoFramework.Pages.PageElements;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using Pages;
    using SFB_Test_Automation.AutoFramework.Pages;
    using SFB_Test_Automation.AutoFramework.vs.AutoFramework.Helpers;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.IE;
    using OpenQA.Selenium.Safari;
    using System;
    using OpenQA.Selenium.Remote;

    class TrustActions
    {
        //All Trust actions happen here
        public static void TrustPerformanceLinksViaLacode(string Lacode)
        {
            Actions.SearchTrustViaLocalAuthority(Lacode);

        }
        public static void TrustComparisonWithMultipleTrusts()
        {
            
            TrustSearchWitNameUsingFirstSuggestedName("Kaleidoscope Learning Trust ");
            TrustComparisonPage trustComaprison = new TrustComparisonPage();
            trustComaprison.Compare_withOtherTrusts.Click();
           Thread.Sleep(100);
            trustComaprison.SelectCharacteristicsButton.Click();
            trustComaprison.NumberOfSchoolscheckbox.Click();
            trustComaprison.MinNumOfScools.SendKeys("30");
            trustComaprison.MaxNumofschools.SendKeys("35");
            Thread.Sleep(1000);
            trustComaprison.ViewBenchMarkingChartsbutton.Click();


        }
        public static void TrustSearchWitNameUsingSubmitButton(String TrustNameSubmitted)
        {
            Actions.GoHome();
            HomePage homepage = new HomePage();
            Thread.Sleep(100);
            homepage.TrustTab.Click();
            homepage.trustnameRadioButton.Click();
            homepage.TrustSearchInput.Click();
            homepage.TrustSearchInput.SendKeys(TrustNameSubmitted);
            
            homepage.TrustSubmit.Click();
            Driver.driver.FindElement(By.CssSelector(".bold-small")).Click();
            Thread.Sleep(100);
        }
        public static void TrustSearchWitNameUsingFirstSuggestedName(string TrustName)
        {
            Actions.GoHome();
            HomePage homepage = new HomePage();
            Thread.Sleep(100);
            homepage.TrustTab.Click();
            homepage.trustnameRadioButton.Click();
            homepage.TrustSearchInput.Click();
            homepage.TrustSearchInput.SendKeys(TrustName);
            homepage.FirstSelectionOption.Click();
            
            Driver.driver.FindElement(By.CssSelector(".bold-small")).Click();
            Thread.Sleep(100);
        }
        //public static void TrustComparisonWithMultipleTrusts()
        //{
        //    Actions.GoHome();
        //    TrustSearchWitNameUsingFirstSuggestedName("Kaleidoscope Learning Trust ");
        //    TrustComparisonPage trustComaprison = new TrustComparisonPage();
        //    trustComaprison.Compare_withOtherTrusts.Click();
        //    Thread.Sleep(100);
        //    trustComaprison.SelectCharacteristicsButton.Click();
        //    trustComaprison.NumberOfSchoolscheckbox.Click();
        //    trustComaprison.MinNumOfScools.SendKeys("30");
        //    trustComaprison.MaxNumofschools.SendKeys("35");
        //    Thread.Sleep(1000);
        //    trustComaprison.ViewBenchMarkingChartsbutton.Click();


        //}
        public static void  getCompanyNumber()
        {

            URNHelper helpers = new URNHelper();
            IList trustlinks = helpers.trustlinks;
            List<string> failedTrusts = new List<string>();
            foreach (string link in trustlinks)

            {
                try
                {
                    Driver.driver.Navigate().GoToUrl(link);
                    
                    IWebElement performanceLink = Driver.driver.FindElement(By.CssSelector("a.trust-ext-link:nth-child(1)"));
                    IWebElement getMoreInformation = Driver.driver.FindElement(By.CssSelector("a.trust-ext-link:nth-child(3)"));
                    if (!(performanceLink.Displayed && getMoreInformation.Displayed))
                    {
                        failedTrusts.Add(link);
                    }
                   
                        Thread.Sleep(10000);
                }
                
                catch (NoSuchElementException) { continue; }
               
                
            }
            Console.WriteLine(failedTrusts.Count);


        }
    }
}
