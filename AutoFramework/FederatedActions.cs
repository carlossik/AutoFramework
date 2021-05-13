using AutoFramework.Pages.PageElements;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SFB_Test_Automation.AutoFramework.Pages;

using SFB_Test_Automation.AutoFramework.vs.AutoFramework.Helpers;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium.Firefox;
using System;

using System.Windows.Forms;
using AutoFramework;
using System.Collections;

namespace SFB_Test_Automation.AutoFramework
{
    public static class FederatedActions
    {
        public static void navigatetoFederationPage(String urn,IWebDriver driver)
        {
            Actions.schoolSearchwithLaestab(urn, driver);
            Thread.Sleep(5);
        }
        public static void createfederatedBenchmark(String urn ,IWebDriver driver)
        {
            Actions.schoolSearchwithLaestab(urn, driver);
            SchoolDetailPage detailpage = new SchoolDetailPage(driver);
            detailpage.StartAComparison.Click();
        }
        public static void gothroughfedswithoutFinance(IWebDriver driver)
        {
            URNHelper helpers = new URNHelper();
            IList urns = helpers.fedswithoutfinance;
            foreach (string urn in urns)
            {
                try
                {
                    Actions.SearchSchoolViaName(urn, driver);
                    
                    Thread.Sleep(10000);
                }
                catch (NoSuchElementException) { continue; }
            }
        }
    }

    

}
    

