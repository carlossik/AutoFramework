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
    using System.Linq;
    using SFB_Test_Automation;
    using OpenQA.Selenium.Support.PageObjects;

    class TrustActions : TestBase
    {
        //All Trust actions happen here
        public static void identifyTrustsWithOneSchool()
        {
            var results = Driver.driver.FindElements(By.ClassName("schoolsInTrust"));
            IList<IWebElement> schoolname = Driver.driver.FindElements(By.CssSelector("li.school-document:nth-child(31) > div:nth-child(1) > a:nth-child(1)"));
            IList<IWebElement> schoolLink = Driver.driver.FindElements(By.XPath("//*[@id=\"schoolResults\"]"));
            List<IWebElement> allHandles2 = new List<IWebElement>();
            IList<IWebElement> schools = Driver.driver.FindElements(By.XPath("//a[contains(@href,\"/trust/index?companyNo=\")]"));
            List<IWebElement> val = new List<IWebElement>();
            var str = new[] { schoolLink };
            var linkstouse = Driver.driver.FindElements(By.XPath("//a[contains(@href, \"/trust/index?companyNo=\")]"));
            ArrayList myvalues = new ArrayList();

        }

       
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
        public static void generaltrustsearch(String trustname)
        {
            HomePage homepage = new HomePage();
            homepage.TrustTab.Click();
            homepage.trustnameRadioButton.Click();
            homepage.TrustSearchInput.Click();
            homepage.TrustSearchInput.SendKeys(trustname);
            homepage.TrustSubmitButton.Click();
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
            homepage.TrustSubmitButton.Click();
            Driver.driver.FindElement(By.CssSelector(".bold-small")).Click();
            Thread.Sleep(100);
        }
        public static void TrustSearchWitNameUsingFirstSuggestedName(string TrustName)
        {
            HomePage homepage = new HomePage();
            Thread.Sleep(100);
            homepage.TrustTab.Click();
            homepage.trustnameRadioButton.Click();
            homepage.TrustSearchInput.Click();
            homepage.TrustSearchInput.SendKeys(TrustName);
            homepage.FirstSelectionOption.Click();
            //Driver.driver.FindElement(By.CssSelector(".bold-small")).Click();
            Thread.Sleep(100);
        }
        public string   calculateNumberOfSchoolsInMat()
        {
            TrustHomePage thomepage = new TrustHomePage();
            Thread.Sleep(2000);
            thomepage.SchoolsIn1819SubmissionTab.Click();
            //IWebElement element = Driver.driver.FindElement(By.Id("LatestTermHeader"));
            //IList numberofschoolsin1819 = element.FindElements(By.XPath(".//a[contains(@href, '\"/school/detail?urn=\"')]"));//(".//a"));
            //int numberOfschools = numberofschoolsin1819.Count;
            //Console.WriteLine("These are the number of schools" + numberOfschools.ToString());
            //return numberOfschools.ToString();
            Thread.Sleep(200);
            String xpathbefore = "//*[@id=\"schools-in-trust-accordion\"]/div[3]/fieldset/div[2]/div/div/ul/li[";
            String xpathafter = "]/a";
            String numberofschools = thomepage.NumberOfSchools1819.Text;
            List<string> numberofschoolsin1819 = new List<string>();
            for (int i = 1; i <=(Int32.Parse(numberofschools)) ; i++)
            {
                IWebElement schoolsin1819 = Driver.driver.FindElement(By.XPath(xpathbefore + i + xpathafter));
                Console.WriteLine(schoolsin1819.Text);
                numberofschoolsin1819.Add(schoolsin1819.Text);
            }
            int numberOfschools = numberofschoolsin1819.Count;
            Console.WriteLine("These are the number of schools"+ numberOfschools.ToString());
            return numberOfschools.ToString();

            

        }

        public String numberberofcharacteristicsDisplayed()
        {
            List<string> numberofsenCharacteristics = new List<string>();
            String beforexpath = "sen-table > tbody:nth-child(1) > tr:nth-child(";
            String afterxpath = ") > td:nth-child(1) > span:nth-child(1)";
           
            for (int i = 1 ; i > 0; i++)
                try
                
                    {
                        Console.WriteLine(beforexpath + i + afterxpath);
                        IWebElement SenCharactristics = Driver.driver.FindElement(By.CssSelector(beforexpath + i + afterxpath));
                        numberofsenCharacteristics.Add(SenCharactristics.Text);
                        Console.WriteLine(SenCharactristics.Text);
                   
                }
                   
                   catch (NoSuchElementException e)
                {
                    Console.WriteLine(numberofsenCharacteristics.Count.ToString());
                    return numberofsenCharacteristics.Count.ToString();
                    
                }
            Console.WriteLine(numberofsenCharacteristics.Count.ToString());
            return numberofsenCharacteristics.Count.ToString();
        }



        public static void getCompanyNumber() 
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
            Console.WriteLine(failedTrusts);
        }

    }    
 }




           
        
    



