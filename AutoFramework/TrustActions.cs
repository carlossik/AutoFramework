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

        IAlert alert;
        IWebDriver driver;
        //All Trust actions happen here
        public static void identifyTrustsWithOneSchool(IWebDriver driver)
        {
            var results = driver.FindElements(By.ClassName("schoolsInTrust"));
            IList<IWebElement> schoolname = driver.FindElements(By.CssSelector("li.school-document:nth-child(31) > div:nth-child(1) > a:nth-child(1)"));
            IList<IWebElement> schoolLink = driver.FindElements(By.XPath("//*[@id=\"schoolResults\"]"));
            List<IWebElement> allHandles2 = new List<IWebElement>();
            IList<IWebElement> schools = driver.FindElements(By.XPath("//a[contains(@href,\"/trust/index?companyNo=\")]"));
            List<IWebElement> val = new List<IWebElement>();
            var str = new[] { schoolLink };
            var linkstouse = driver.FindElements(By.XPath("//a[contains(@href, \"/trust/index?companyNo=\")]"));
            ArrayList myvalues = new ArrayList();

        }

       
            public static void TrustPerformanceLinksViaLacode(string Lacode, IWebDriver driver)
        {
            Actions.SearchTrustViaLocalAuthority(Lacode,driver);

        }
        public static void TrustComparisonWithMultipleTrusts(IWebDriver driver)
        {

            TrustSearchWitNameUsingFirstSuggestedName("Kaleidoscope Learning Trust ",driver);
            TrustComparisonPage trustComaprison = new TrustComparisonPage(driver);
            trustComaprison.Compare_withOtherTrusts.Click();
            Thread.Sleep(100);
            //TrustComparisonPage trustComaprison = new TrustComparisonPage(driver);
            Thread.Sleep(1000);
          //  trustComaprison.Compare_withOtherTrusts.Click();
            Thread.Sleep(500);
            trustComaprison.TrustComparisonBenchMark.Click();
            trustComaprison.SelectTrustsByCharacteristicsRadioButton.Click();
            trustComaprison.TrustComparisonPageContinueButton.Click();
            TrustCharacteristicsPage tcompare = new TrustCharacteristicsPage(driver);
           // trustComaprison.SelectCharacteristicsButton.Click();
            trustComaprison.NumberOfSchoolscheckbox.Click();
            trustComaprison.MinNumOfScools.SendKeys("30");
            trustComaprison.MaxNumofschools.SendKeys("35");
            Thread.Sleep(1000);
            trustComaprison.ViewBenchMarkingChartsbutton.Click();

        }
        public static void generaltrustsearch(String trustname, IWebDriver driver)
        {
            HomePage homepage = new HomePage(driver);
            homepage.TrustTab.Click();
            homepage.trustnameRadioButton.Click();
            homepage.TrustSearchInput.Click();
            homepage.TrustSearchInput.SendKeys(trustname);
            homepage.TrustSubmitButton.Click();
            Thread.Sleep(200);
        }

        public static void TrustSearchWitNameUsingSubmitButton(String TrustNameSubmitted, IWebDriver driver)
        {
            Actions.GoHome(driver);
            HomePage homepage = new HomePage(driver);
            Thread.Sleep(100);
            homepage.TrustTab.Click();
            homepage.trustnameRadioButton.Click();
            homepage.TrustSearchInput.Click();
            homepage.TrustSearchInput.SendKeys(TrustNameSubmitted);
           // homepage.TrustSearchInput.SendKeys(Keys.Enter);

            //driver.FindElement(By.XPath("//body/div[@id='content']/div[1]/main[1]/div[1]/div[2]/div[1]/div[2]/form[1]/div[1]/fieldset[1]/div[1]/div[2]/div[1]/span[1]/div[1]/div[1]/div[1]/a[1]")).Click();
            homepage.TrustSubmitButton.Click();
            
             //strong[@class='bold-small']
            Thread.Sleep(100);
        }
        public static void TrustSearchWitNameUsingFirstSuggestedName(string TrustName, IWebDriver driver)
        {
            HomePage homepage = new HomePage(driver);
            Thread.Sleep(100);
            homepage.TrustTab.Click();
            homepage.trustnameRadioButton.Click();
            homepage.TrustSearchInput.Click();
            homepage.TrustSearchInput.SendKeys(TrustName);
            Thread.Sleep(10000);
            homepage.TrustFirstSelectionOption.Click();
            Thread.Sleep(100);
            //driver.FindElement(By.CssSelector(".bold-small")).Click();
            homepage.TrustSubmitButton.Click();
            Thread.Sleep(100);
        }
        public string   calculateNumberOfSchoolsInMat(IWebDriver driver)
        {
            TrustHomePage thomepage = new TrustHomePage(driver);
            Thread.Sleep(2000);
            thomepage.SchoolsIn1819SubmissionTab.Click();
            Thread.Sleep(200);
            String xpathbeforebefore = "//*[@id=\"schools-in-trust-accordion\"]/div[2]/div/div/div/ul/li[";
            String xpathbefore = "//*[@id=\"schools-in-trust-accordion\"]/div[3]/fieldset/div[2]/div/div/ul/li[";
            String xpathafter = "]/a";
            String numberofschools = thomepage.NumberOfSchools1819.Text;
            List<string> numberofschoolsin1819 = new List<string>();
            for (int i = 1; i <=(Int32.Parse(numberofschools)) ; i++)
            {
                IWebElement schoolsin1819 = driver.FindElement(By.XPath(xpathbeforebefore + i + xpathafter));
                Console.WriteLine(schoolsin1819.Text);
                numberofschoolsin1819.Add(schoolsin1819.Text);
            }
            int numberOfschools = numberofschoolsin1819.Count;
            Console.WriteLine("These are the number of schools"+ numberOfschools.ToString());
            return numberOfschools.ToString();
        }

        public static void ManualTrustComparison(String TrustName, IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://as-t1dv-sfb.azurewebsites.net/TrustComparison/SelectType?companyNo=9952066&matName=Portico%20Academy%20Trust");
          
            TrustComparisonPage trustComaprison = new TrustComparisonPage(driver);
            Thread.Sleep(1000);
          
            Thread.Sleep(500);
            trustComaprison.ManuallyAddTrustsRadio.Click();
            trustComaprison.TrustComparisonPageContinueButton.Click();
           
            Thread.Sleep(500);
            trustComaprison.EnterTrustforCompareNameField.SendKeys("Ark Schools");
            HomePage homepage = new HomePage(driver);
           // homepage.TrustSearchInput.SendKeys(Keys.Space);
            //homepage
          
            driver.FindElement(By.XPath("//li[@id='awesomplete_list_1_item_0']")).Click();//select the first suggested 
            Thread.Sleep(500);
            trustComaprison.ViewBenchMarkingCharts.Click();
            Thread.Sleep(500);
        }

        public static void SelectCharacteristicsToFindTrusts(String TrustName, IWebDriver driver)
        {
            TrustActions.TrustSearchWitNameUsingFirstSuggestedName(TrustName, driver);
            TrustComparisonPage trustComaprison = new TrustComparisonPage(driver);
            Thread.Sleep(1000);
            trustComaprison.Compare_withOtherTrusts.Click();
            Thread.Sleep(5);
            trustComaprison.TrustComparisonBenchMark.Click();
            trustComaprison.SelectTrustsByCharacteristicsRadioButton.Click();
            Thread.Sleep(50);
            trustComaprison.TrustComparisonPageContinueButton.Click();
            TrustCharacteristicsPage tcompare = new TrustCharacteristicsPage(driver);
            tcompare.NumberOfPupilsCheckBox.Click();
            tcompare.NumberOfPupilsFromtextBox.SendKeys("5000");
            tcompare.NumberOfPupilsTotextbox.SendKeys("5200");
            Thread.Sleep(5000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5000);
            tcompare.ViewBenchMarkChartsButton.Click();
            Thread.Sleep(5000);



        }

        public static void compareTotalIncome(String TrustName, IWebDriver driver)
        {
            TrustActions.TrustSearchWitNameUsingFirstSuggestedName(TrustName, driver);
            Thread.Sleep(2000);
            TrustHomePage trusthome = new TrustHomePage(driver);
            trusthome.IncomeTab.Click();
            trusthome.ViewAschartsButton.Click();
            IWebElement totalincome20192020 = driver.FindElement(By.CssSelector("div.charts-section__chart-container:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(2) > div:nth-child(2) > div:nth-child(2) > abbr:nth-child(1)"));
            string totalIncome2019_2020 = totalincome20192020.Text;
            Console.WriteLine("This is the total Income displayed on Trust home page " + totalIncome2019_2020);
            TrustComparisonPage trustComaprison = new TrustComparisonPage(driver);
            Thread.Sleep(1000);
            trustComaprison.Compare_withOtherTrusts.Click();
            Thread.Sleep(5);
            trustComaprison.SelectTrustsByCharacteristicsRadioButton.Click();
            Thread.Sleep(50);
            trustComaprison.TrustComparisonPageContinueButton.Click();
            TrustCharacteristicsPage tcompare = new TrustCharacteristicsPage(driver);
           
            tcompare.TotalIncomeCheckBox.Click();
            Thread.Sleep(5000);
            IWebElement trustTotalIncomeTocompare = driver.FindElement(By.CssSelector("#rc_TotalInc > div:nth-child(1) > fieldset:nth-child(1) > div:nth-child(1) > span:nth-child(2)"));
            string figureToCompare = trustTotalIncomeTocompare.Text;
            Console.WriteLine("This is the total Income displayed on Trust ComparisonPage " + figureToCompare);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5000);
            tcompare.ViewBenchMarkChartsButton.Click();
            Thread.Sleep(5000);



        }
        public static void TrustCompareWithComPanyNum(String TrustCompanyNo, IWebDriver driver)
        {
            driver.Navigate().GoToUrl(Config.currentTestEnv + "Trust/Detail?companyNo=" + TrustCompanyNo);
            TrustHomePage TrustHome = new TrustHomePage(driver);
            TrustHome.TrustStartComparison.Click();
        }
        public static void TrustSearchWithComPanyNum(String TrustCompanyNo, IWebDriver driver)
        {
            driver.Navigate().GoToUrl(Config.currentTestEnv + "Trust/Detail?companyNo=" + TrustCompanyNo);
            TrustHomePage TrustHome = new TrustHomePage(driver);
            
        }


        public String numberberofcharacteristicsDisplayed(IWebDriver driver)
        {
            List<string> numberofsenCharacteristics = new List<string>();
            String beforexpath = "sen-table > tbody:nth-child(1) > tr:nth-child(";
            String afterxpath = ") > td:nth-child(1) > span:nth-child(1)";
           
            for (int i = 1 ; i > 0; i++)
                try
                
                    {
                        Console.WriteLine(beforexpath + i + afterxpath);
                        IWebElement SenCharactristics = driver.FindElement(By.CssSelector(beforexpath + i + afterxpath));
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



        public static void getCompanyNumber(IWebDriver driver) 
        {
            URNHelper helpers = new URNHelper();
            IList trustlinks = helpers.trustlinks;
            List<string> failedTrusts = new List<string>();
            foreach (string link in trustlinks)
            {
                try
                {
                    driver.Navigate().GoToUrl(link);
                    IWebElement performanceLink = driver.FindElement(By.CssSelector("a.trust-ext-link:nth-child(1)"));
                    IWebElement getMoreInformation = driver.FindElement(By.CssSelector("a.trust-ext-link:nth-child(3)"));
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




           
        
    



