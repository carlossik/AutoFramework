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
            IList<IWebElement> linksList = Driver.driver.FindElements(By.CssSelector("a[href*='/trust/index?companyNo=']")); 
            Console.WriteLine(linksList);

            foreach (IWebElement trustlink in linksList)
                try
                {
                    trustlink.Click();
                    IWebElement performanceLink = Driver.driver.FindElement(By.ClassName("trust-ext-link"));
                    Assert.IsTrue(performanceLink.Displayed);
                    Thread.Sleep(1000);
                    Driver.driver.Navigate().Back();
                }
                catch (NoSuchElementException) { continue; }




        }

    }
}
