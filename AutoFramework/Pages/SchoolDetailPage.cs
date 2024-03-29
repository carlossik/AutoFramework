﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFramework.Pages;
using How = SeleniumExtras.PageObjects.How;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace AutoFramework.Pages.PageElements
{
    class SchoolDetailPage
    {

        public SchoolDetailPage(IWebDriver driver)
        {


            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
        }

        //a.button:nth-child(3)
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "a.govuk-button:nth-child(3)")]
        public IWebElement StartAComparison { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#benchmarkBasket > div > div > div")]
        [SeleniumExtras.PageObjects.CacheLookup]
        public IWebElement BenchmarkBasket { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#benchmarkBasket > div > div > div > a")]
        public IWebElement EditBasket { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#benchmarkBasket > div > div > div > button")]
        public IWebElement ClearBasket { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "#benchmarkControlsPlaceHolder > div.compare-buttons-panel.compare-buttons-panel--set-unset > div > button:nth-child(2) > span")]
        public IWebElement SetasDefaultSchool { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".compare-buttons-panel__button--compare")]
        public IWebElement CompareWithOtherSchools { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//span[contains(text(),'Add to benchmark set')]")]
        public IWebElement AddToBenchMarkBasket { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "button.pl-0:nth-child(2) > div:nth-child(2) > span:nth-child(1)")]
        public IWebElement AddToBenchMarkSetDetailspage { get; set; }
        //button.pl-0:nth-child(2) > div:nth-child(2) > span:nth-child(1)
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//a[@id='tab_dashboard']")]
        public IWebElement SchoolPageDashBoardTab { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//a[@id='tab_details']")]
        public IWebElement SchoolPageDetailsTab { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//a[@id='tab_finance']")]
        public IWebElement SchoolPageFinanceTab { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//a[@id='tab_workforce']")]
        public IWebElement SchoolPageWorkForceTab { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//a[contains(text(),'Is there anything wrong with this page?')]")]
        public IWebElement IsThereAnyThingWrongWithThisPagelink { get; set; }
       



        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector,Using = "#\\31 44406desktop > button:nth-child(2)")]
        public IWebElement FirstSearchItem { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//th[contains(text(),'Ofsted rating:')]")]
        public IWebElement OfstedRating { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//th[contains(text(),'Ofsted rating:')]/following-sibling::td[1]")]
        public IWebElement ActualOfstedRating { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "h1.govuk-heading-xl")]
        public IWebElement School_Name { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "SchoolLocationMap")]
        public IWebElement School_Location_Map { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".view-benchmark-charts-wrapper > a:nth-child(1)")]
        public IWebElement ViewBenchMarkCharts { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector,Using = "#manualButton")]
        public IWebElement ContinueToManualBenchMarkCharts { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//th[contains(text(),'School overall phase:')]")]
        public IWebElement SchoolOverAllPhase { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//th[contains(text(),'School phase:')]")]
        public IWebElement SchoolPhase { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//th[contains(text(),'School phase:')]/following-sibling::td[1]")]
        public IWebElement SchoolPhaseText { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = "a.button:nth-child(1)")]
        public IWebElement Compare { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = ".sfb_gtm_auto_report")]
        public IWebElement BasicComparisonReportLink { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = ".sfb_gtm_address")]
        public IWebElement Address { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = "dd.metadata-school-detail__dd:nth-child(16)")]
        public IWebElement Urn { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = ".sfb_gtm_tel")]
        public IWebElement Telephone_Number { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = ".sfb_gtm_more_info")]
        public IWebElement DataFromOtherSources { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = " .sfb_gtm_more_info")]
        public IWebElement Services { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = " dd.metadata-school-detail__dd:nth-child(29)")]
        public IWebElement Date_Of_Closure { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = "dd.metadata-school-detail__dd:nth-child(12)")]
        public IWebElement NumberOfPupils { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.XPath, Using = "//a[contains(text(),'full version')]")]
        public IWebElement QuickCompareView { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = "#sadCtrl > div > details > summary > span")]
        public IWebElement QuickCompareViewCharateristicsUsed { get; set; }
       
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = "span.twitter-typeahead:nth-child(3) > div:nth-child(4)")]
        public IWebElement FirstOptionOnSchoolsearch { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = ".govuk-list > li:nth-child(1) > a:nth-child(1)")]
        public IWebElement schooldetailnotfoundmessage { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.XPath, Using = "//th[contains(text(),\"Headteacher's name:\")]/following-sibling::td[1]")]
        public IWebElement HeadTeacher_Name { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = ".message")]
        public IWebElement SchooldetailInfoPanel { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = "#Financing")]
        public IWebElement FinanceDropdown { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = "#Financing > option:nth-child(2)")]
        public IWebElement FinanceDropdown_Trust_Only { get; set; }
       
        [SeleniumExtras.PageObjects.FindsBy(How = How.LinkText,Using = "Find and compare schools in England")]
        public IWebElement schoolPerformanceTableLink { get; set; }
       
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//*[text()=\"Self-assessment dashboard\"]")]
        public IWebElement SADLink { get; set; }
     
        [SeleniumExtras.PageObjects.FindsBy(How = How.XPath,Using = "//div[@class='combined-warnings']/p[1]")]
        public IWebElement FederationWithoutFinance { get; set; }


        [SeleniumExtras.PageObjects.FindsBy(How = How.XPath, Using = " //a[contains(text(),'Create a benchmark comparison')]")]
        public IWebElement CreateBenchMarkComparison { get; set; }
       

        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = "dd.metadata-school-detail__dd:nth-child(32) > a:nth-child(1)")]
        public IWebElement federationsLink { get; set; }
      
        
        [SeleniumExtras.PageObjects.FindsBy(How = How.XPath, Using = "/html/body/div/div[3]/div[6]/main/div[2]/div[1]/div/a")]

        public IWebElement GoTo_SADButton_For_School_without_finance { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = ".exp-total")]

        public IWebElement FinanceDisplayed { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.XPath, Using = ".//a[contains(@href, '/trust/detail?uid=')]")]

        public IWebElement CurrentTrustLinkDisplayed { get; set; }  //"/trust?companyNo=7719620


        [SeleniumExtras.PageObjects.FindsBy(How = How.XPath, Using = ".//a[contains(@href, '/trust?companyNo=')]")]

        public IWebElement CurrentTrustLinkDisplayed2 { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector,Using = ".govuk-breadcrumbs__link")]
        public IWebElement HomepageButton { get; set; }



        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector,Using = "dd.metadata-school-detail__dd:nth-child(6) > a:nth-child(1)")]
        public IWebElement LocalAuthorityLink { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.Id, Using = "Financing")]
        public IWebElement MatFinanceToggle { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.CssSelector, Using = ".list > li:nth-child(1) > a:nth-child(1)")]
        public IWebElement EfficiencyMetricLink { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.XPath, Using = "//a[contains(@href, '/trust?uid=')]")]
        public IWebElement IntrustLink { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.XPath,Using = "//a[contains(@href, '/trust?companyNo=')]")]
        public IWebElement previousTrustLink { get; set; }

        
        [SeleniumExtras.PageObjects.FindsBy(How = How.XPath,Using = "//th[contains(text(),'Academy trust:')]")]
        public IWebElement trustField { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.XPath, Using = "//th[contains(text(),'Academy trust')]/following-sibling::td[1]")]
        public IWebElement trustText { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.XPath, Using = "//a[contains(text(),'Accessibility')]")]
        public IWebElement AssessibilityLink { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.XPath, Using = "//span[contains(text(),'Teaching staff')]")]
        public IWebElement Detail_Page_SadTeachingStaff { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.XPath, Using = "//span[contains(text(),'Supply staff')]")]
        public IWebElement Detail_Page_SadSupplyStaff { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.XPath, Using = "//span[contains(text(),'Education support staff')]")]
        public IWebElement Detail_Page_SadEducationSupportStaff { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.XPath, Using = "//span[contains(text(),'Admin. and clerical staff')]")]
        public IWebElement Detail_Page_SadTAdminClericalStaff { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.XPath, Using = "//span[contains(text(),'Other staff costs')]")]
        public IWebElement Detail_Page_SadOtherStaffCosts { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.XPath, Using = "//span[contains(text(),'Premises costs')]")]
        public IWebElement Detail_Page_SadPremisesCosts { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.XPath, Using = "//span[contains(text(),'Educational supplies')")]
        public IWebElement Detail_Page_SadEducationalSupplies { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.XPath, Using = "//span[contains(text(),'Energy')]")]
        public IWebElement Detail_Page_SadEnergy { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = How.XPath, Using = "//a[contains(text(),'self-assessment dashboard')]")]
        public IWebElement Detail_Page__See_Self_Assessment_Board { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.XPath, Using = "//select[@id='WShowValue']")]
        public IWebElement workForce_DropDownLink { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.XPath, Using = "//dialog[@id='js-modal']")]
        public IWebElement workForce_Help { get; set; }

        public static string workForce_Help_text = "Show value This controls the chart value.To change it, select the relevant option from the dropdown.You can choose from the values listed below.Headcount per FTE is the number of staff employed per full time position.The higher the figure, the more part time staff and job sharing.Percentage of workforce is the percentage of the total workforce the chart grouping represents in the school. For example, teachers might make up 60% of the total school workforce.Pupils per staff role is the ratio of pupils to staff for that particular chart group – 22 pupils per total number of teachers, for example.";







        public bool  istrusttextDisplayed()
        {
            try
            {
                if (trustField.Text.Contains("Academy trust"))
                    if(trustText.Displayed)
                {
                    

                    return true;
                }
            }
            catch (OpenQA.Selenium.NoSuchElementException e) { }
            return false;
        }

        public bool IsTrustLinkDisplayed()
        {

            try
            {
             
                if ((IntrustLink.Displayed ^ previousTrustLink.Displayed))
                {
                    return true;
                }
                else 
                {
                    //Console.WriteLine("I am not sure why this is evaluating to false when it should be true?");
                   return false;
                }
                
            }
            catch (OpenQA.Selenium.NoSuchElementException e) { }
            Console.WriteLine("I am not sure why this is evaluating to false when it should be true?");
            return false;
        }
        public bool verifySADLink()
        {

            try
            {
                if (SADLink.Displayed)
                {
                    return true;
                }
                
            }
            catch (OpenQA.Selenium.NoSuchElementException e) { }

            return false;

        }

        public void clickSadLink(IWebDriver driver)
        {
            try { 

            if (SADLink.Displayed)
            {
                SADLink.Click();
                Thread.Sleep(200);
                Actions.acceptCookie(driver);
                Thread.Sleep(200);

                }
                 }
            catch (OpenQA.Selenium.NoSuchElementException e) { }

        }

        public  String compareWithGiasData(IWebDriver driver, string urn)
        {
            var giasurl = Config.giasurl + urn;
            var chromedriverpath = Config.chromedriverpath;
            var options = new ChromeOptions();
            options.AddArgument("--headless");
            driver = new ChromeDriver(chromedriverpath,options);
            driver.Navigate().GoToUrl(giasurl);
            IWebElement acceptCookie = driver.FindElement(By.CssSelector("button.govuk-button:nth-child(1)"));
            acceptCookie.Click();
            IWebElement schoolname = driver.FindElement(By.CssSelector(".govuk-heading-l"));
            var Fschoolname = (schoolname.Text).Replace("\n", "").Replace("\r", "").Replace("Establishment", "");
            Console.WriteLine(Fschoolname);
            driver.Close();
            return Fschoolname;
            


        }
        public String compareWithGiasDataHeadTeacher_Name(IWebDriver driver, string urn)
        {
            var giasurl = Config.giasurl + urn;
            var chromedriverpath = Config.chromedriverpath;
            var options = new ChromeOptions();
            options.AddArgument("--headless");
          
            driver = new ChromeDriver(chromedriverpath, options);
          
            driver.Navigate().GoToUrl(giasurl);
            //IWebElement closemodal = driver.FindElement(By.Id("gias-modal-close"));
            //closemodal.Click();
            IWebElement acceptCookie = driver.FindElement(By.CssSelector("button.govuk-button:nth-child(1)"));
            acceptCookie.Click();
            IWebElement headTeacherName = driver.FindElement(By.CssSelector("#details-summary > dl:nth-child(1) > div:nth-child(3) > dd:nth-child(2)"));
            var FheadTeacherName = (headTeacherName.Text).Replace("\n", "").Replace("\r", "").Replace("Principal", "").Replace("Mrs","").Trim();
            Console.WriteLine(FheadTeacherName);
            driver.Close();
            return FheadTeacherName;



        }

    }





}//string cleaned = example.Replace("\n", "").Replace("\r", "");

