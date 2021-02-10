
  
    namespace AutoFramework
    {
    using AutoFramework.Pages.PageElements;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using Pages;
    using SFB_Test_Automation.AutoFramework.Pages;
    using SFB_Test_Automation.AutoFramework.vs.AutoFramework.Helpers;
    using System.Collections.Generic;
    using System.Threading;
    using OpenQA.Selenium.Firefox;
    using System;
    
    using System.Windows.Forms;

    public static class BenchMarkActions
    {
        public static void CreateManualBenchMarkViaName(String urn,IWebDriver driver)
        {
            

            Actions.CallingClass.SearchViaSchoolurn(urn,driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass(driver);
            bestinclass.ManualComaprisonButton.Click();
            bestinclass.Continue.Click();
            //bestinclass.NextButton.Click();
            Thread.Sleep(200);
            ManualPage manualaddition = new ManualPage(driver);
            manualaddition.AddSchoolByNameRadio.Click();
            manualaddition.ManualContinueButton.Click();

            manualaddition.NewSchoolNameField.SendKeys("Plumcroft Primary School"); //+ OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(2000);
            manualaddition.FirstManualSuggestion.Click();
            //manualaddition.NewSchoolNameField.SendKeys( OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(200);
            manualaddition.ContinueToBenchMarkChartsButton.Click();
            
            Thread.Sleep(300);




        }
        public static void CreateManualBenchMarkViaLocation(String urn, IWebDriver driver)
        {
            //Actions.GoHome();

            Actions.CallingClass.SearchViaSchoolurn(urn,driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass(driver);
            bestinclass.ManualComaprisonButton.Click();
            bestinclass.Continue.Click();
            Actions.AddAnotherSchoolManually(driver);
            SearchResultsPage resultspage = new SearchResultsPage(driver);
            //resultspage.FirstElementPresented.Click();
            Thread.Sleep(200);
            resultspage.AddFirstResult.Click();
            Thread.Sleep(2000);
            //resultspage.ViewBenchmarkChartsButton.Click();
            resultspage.ManualChartsButton.Click();
                

        }
        public static void CreateManualBenchMarkviaLACode(String Lacode, IWebDriver driver)
        {
            Actions.GoHome(driver);

            Actions.CallingClass.SearchViaSchoolurn("143592",driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass(driver);
            bestinclass.ManualComaprisonButton.Click();
            bestinclass.Continue.Click();
            AddSchool addschool = new AddSchool(driver);
            addschool.AddSchoolByLocalAuthority.Click();
            addschool.LocalAuthorityinputField.SendKeys(Lacode);
            addschool.searchButton.Click();
            SchoolDetailPage schooldetail = new SchoolDetailPage(driver);
            Thread.Sleep(30);
            schooldetail.FirstSearchItem.Click();
            Thread.Sleep(30);
            schooldetail.ContinueToManualBenchMarkCharts.Click();
            Thread.Sleep(100);
           }
        public static void CreateBenchmarkViaDetailComparison(String urn, IWebDriver driver)
        {
            Actions.CallingClass.SearchViaSchoolurn(urn,driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass(driver);
            bestinclass.DetailComparisonButton.Click();
            bestinclass.Continue.Click();
            bestinclass.MaintainedSchoolsChoice.Click();
            bestinclass.Continue.Click();
            Thread.Sleep(200);
            bestinclass.AllOfEngland.Click();
            bestinclass.Continue.Click();
            Thread.Sleep(200);
            DetailComparisonPage detatilscomparison = new DetailComparisonPage(driver);
            detatilscomparison.ViewBenchMarkCharts.Click();

            Thread.Sleep(200);

        }
        public static void refineto30schools(String urn, IWebDriver driver)
        {
            Actions.CallingClass.SearchViaSchoolurn(urn,driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass(driver);
            bestinclass.DetailComparisonButton.Click();
            Thread.Sleep(20);
            bestinclass.Continue.Click();
            bestinclass.MaintainedSchoolsChoice.Click();
            Thread.Sleep(20);
            bestinclass.Continue.Click();        
            DetailComparisonPage detatilscomparison = new DetailComparisonPage(driver);
            Thread.Sleep(3000);

            bestinclass.AllOfEngland.Click();
            bestinclass.WhereShouldTheComparisonComeFromcontbutton.Click();
            Thread.Sleep(3000);

          
            detatilscomparison.ViewBenchMarkCharts.Click();
            Thread.Sleep(3000);
           
        }
        public static void testrefinezerofound(String urn, IWebDriver driver)
        {
            Actions.CallingClass.SearchViaSchoolurn(urn,driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass(driver);
            bestinclass.DetailComparisonButton.Click();                  
            bestinclass.Continue.Click();
            DetailComparisonPage details = new DetailComparisonPage(driver);
            bestinclass.MaintainedSchoolsChoice.Click();
            bestinclass.Continue.Click();
            details.LAcode.Click();
            details.Lacodefield.SendKeys("202");
            bestinclass.Continue.Click();
             details.ViewBenchMarkCharts.Click();
             }

        public static void createbenchmarkviadefault(string urn, IWebDriver driver)
        {
            Actions.CallingClass.SearchViaSchoolurn(urn,driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass(driver);
            bestinclass.QuckComparisonButton.Click();
            bestinclass.Continue.Click();
            bestinclass.MaintainedSchoolsChoice.Click();
            bestinclass.Continue.Click();
            bestinclass.page2of2ContinueButton.Click();
           
        }
        public static void costoffinance(IWebDriver driver)
        {
            BenchMarkChartPage benchchartpage = new BenchMarkChartPage(driver);
            benchchartpage.TotalExpenditureDropdown.Click();
            benchchartpage.costOfFinance.Click();
            Thread.Sleep(30000);
            

        }
        public static void PercentageOfTotal(IWebDriver driver)
        {
            BenchMarkChartPage benchchartpage = new BenchMarkChartPage(driver);
            benchchartpage.PercenTageOfTotalOption.Click();
            benchchartpage.IncomeTab.Click();
            Thread.Sleep(3000);
        }

        public static void NavigateToBestInClassComparisonSchoolsTab(IWebDriver driver)
        {
            BenchMarkChartPage benchchartpage = new BenchMarkChartPage(driver);
            benchchartpage.BestInClassComparisonSchoolsTab.Click();
            Thread.Sleep(4000);
        }
        public static void NavigateToOtherComparisonSchoolsTab(IWebDriver driver)
        {
            BenchMarkChartPage benchchartpage = new BenchMarkChartPage(driver);
            benchchartpage.OtherComparisonSchoolsTab.Click();
            Thread.Sleep(1000);
        }
        public static void PasteCopiedClipboardText(IWebDriver driver)
        {  
            string myURL = System.Windows.Forms.Clipboard.GetText(TextDataFormat.Text);
           
            ((IJavaScriptExecutor)driver).ExecuteScript("navigator.clipboard.readText().then(text => window.location.replace(text));");
            Console.WriteLine("This is the copied clipboard data"+myURL);
            Thread.Sleep(500);
           
            
            Thread.Sleep(2000);
        }
        public static void getclipboardTextmaximum(IWebDriver driver)
        {          
            driver.Navigate().GoToUrl(Config.currentTestEnv +"BenchmarkCharts/GenerateFromSavedBasket?urns=123422-123445-119464-142078-139804-134117-139927-114033-122258-111668-114110-119534-139806-141358-117833-111393-143953-142014-111718-112806-116123-120492-114270-139511-111301-141121-140505-112705-120479-134214-145789");
        }
        public static void addschoolvianameorlocationlink(IWebDriver driver)
        {
            BenchMarkChartPage benchchartpage = new BenchMarkChartPage(driver);
            benchchartpage.AddanotherschoolLink.Click();
        }

        public static void createBenchmarkforSpecials(String specialSchool, IWebDriver driver)
        {
            Actions.CallingClass.SearchViaSchoolurn(specialSchool,driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass(driver);
            bestinclass.QuckComparison_For_Specials_Button.Click();
            bestinclass.Continue.Click();
           // bestinclass.MaintainedSchoolsChoice.Click();
            bestinclass.ContinueForSpecials.Click();
           // bestinclass.page2of2ContinueButton.Click();
            Thread.Sleep(2000);
        }

        public static void CopyChart(IWebDriver driver)
        {
            BenchMarkChartPage benchchartpage = new BenchMarkChartPage(driver);
            benchchartpage.Savebenchmarkbasket.Click();
            benchchartpage.CopyLinkToClipboard.Click();
           string linkurl =  benchchartpage.CopyLinkToClipboard.GetAttribute("save-url-input");
            Console.WriteLine(linkurl);
            driver.FindElement(By.CssSelector("div.save-modal-js:nth-child(2) > a:nth-child(1)")).Click();
            
        }

    }
}
