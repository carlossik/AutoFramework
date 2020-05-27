
  
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
        public static void CreateManualBenchMarkViaName(String urn)
        {
            

            Actions.CallingClass.SearchViaSchoolurn(urn);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass();
            bestinclass.ManualComaprisonButton.Click();
            bestinclass.Continue.Click();
            //bestinclass.NextButton.Click();
            Thread.Sleep(200);
            ManualPage manualaddition = new ManualPage();
            manualaddition.AddSchoolByNameRadio.Click();
            manualaddition.ManualContinueButton.Click();

            manualaddition.NewSchoolNameField.SendKeys("Plumcroft Primary School"); //+ OpenQA.Selenium.Keys.Enter);
            manualaddition.FirstManualSuggestion.Click();
            //manualaddition.NewSchoolNameField.SendKeys( OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(200);
            manualaddition.ContinueToBenchMarkChartsButton.Click();
            
            Thread.Sleep(300);




        }
        public static void CreateManualBenchMarkViaLocation(String urn)
        {
            //Actions.GoHome();

            Actions.CallingClass.SearchViaSchoolurn(urn);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass();
            bestinclass.ManualComaprisonButton.Click();
            bestinclass.Continue.Click();
            Actions.AddAnotherSchoolManually();
            SearchResultsPage resultspage = new SearchResultsPage();
            //resultspage.FirstElementPresented.Click();
            Thread.Sleep(200);
            resultspage.AddFirstResult.Click();
            Thread.Sleep(2000);
            //resultspage.ViewBenchmarkChartsButton.Click();
            resultspage.ManualChartsButton.Click();
                

        }
        public static void CreateManualBenchMarkviaLACode(String Lacode)
        {
            Actions.GoHome();

            Actions.CallingClass.SearchViaSchoolurn("143592");
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass();
            bestinclass.ManualComaprisonButton.Click();
            bestinclass.Continue.Click();
            AddSchool addschool = new AddSchool();
            addschool.AddSchoolByLocalAuthority.Click();
            addschool.LocalAuthorityinputField.SendKeys(Lacode);
            addschool.searchButton.Click();
            SchoolDetailPage schooldetail = new SchoolDetailPage();
            Thread.Sleep(3000);
            schooldetail.FirstSearchItem.Click();
            Thread.Sleep(3000);
            schooldetail.ContinueToManualBenchMarkCharts.Click();
            Thread.Sleep(10000);
           }
        public static void CreateBenchmarkViaDetailComparison(String urn)
        {
            Actions.CallingClass.SearchViaSchoolurn(urn);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass();
            bestinclass.DetailComparisonButton.Click();
            bestinclass.Continue.Click();
            bestinclass.MaintainedSchoolsChoice.Click();
            bestinclass.Continue.Click();
            Thread.Sleep(200);
            bestinclass.Continue.Click();
            Thread.Sleep(200);
            DetailComparisonPage detatilscomparison = new DetailComparisonPage();
          
        }
        public static void refineto30schools(String urn)
        {
            Actions.CallingClass.SearchViaSchoolurn(urn);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass();
            bestinclass.DetailComparisonButton.Click();
            Thread.Sleep(20);
            bestinclass.Continue.Click();
            bestinclass.MaintainedSchoolsChoice.Click();
            Thread.Sleep(20);
            bestinclass.Continue.Click();        
            DetailComparisonPage detatilscomparison = new DetailComparisonPage();
            Thread.Sleep(3000);
            bestinclass.WhereShouldTheComparisonComeFromcontbutton.Click();
            detatilscomparison.ViewBenchMarkCharts.Click();
            Thread.Sleep(3000);
           
        }
        public static void testrefinezerofound(String urn)
        {
            Actions.CallingClass.SearchViaSchoolurn(urn);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass();
            bestinclass.DetailComparisonButton.Click();                  
            bestinclass.Continue.Click();
            DetailComparisonPage details = new DetailComparisonPage();
            bestinclass.Continue.Click();
            details.LAcode.Click();
            details.Lacodefield.SendKeys("202");
            bestinclass.Continue.Click();
             details.ViewBenchMarkCharts.Click();
             }

        public static void createbenchmarkviadefault(string urn)
        {
            Actions.CallingClass.SearchViaSchoolurn(urn);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass();
            bestinclass.QuckComparisonButton.Click();
            bestinclass.Continue.Click();
            bestinclass.Continue.Click();
            bestinclass.page2of2ContinueButton.Click();
           
        }
        public static void costoffinance()
        {
            BenchMarkChartPage benchchartpage = new BenchMarkChartPage();
            benchchartpage.TotalExpenditureDropdown.Click();
            benchchartpage.costOfFinance.Click();
            Thread.Sleep(30000);
            

        }
        public static void PercentageOfTotal()
        {
            BenchMarkChartPage benchchartpage = new BenchMarkChartPage();
            benchchartpage.PercenTageOfTotalOption.Click();
            benchchartpage.IncomeTab.Click();
            Thread.Sleep(3000);
        }

        public static void NavigateToBestInClassComparisonSchoolsTab()
        {
            BenchMarkChartPage benchchartpage = new BenchMarkChartPage();
            benchchartpage.BestInClassComparisonSchoolsTab.Click();
            Thread.Sleep(4000);
        }
        public static void NavigateToOtherComparisonSchoolsTab()
        {
            BenchMarkChartPage benchchartpage = new BenchMarkChartPage();
            benchchartpage.OtherComparisonSchoolsTab.Click();
            Thread.Sleep(1000);
        }
        public static void getclipboardText()
        {  
            string myURL = Clipboard.GetText();
            Driver.driver.Navigate().GoToUrl(Config.currentTestEnv+"BenchmarkCharts/GenerateFromSavedBasket?urns=125249-116423-141874-144929-137598-126473-141341-112399-115775-136311-112936-145124-138920-138478-135620");
            Thread.Sleep(20);
        }
        public static void getclipboardTextmaximum()
        {          
            Driver.driver.Navigate().GoToUrl(Config.currentTestEnv +"BenchmarkCharts/GenerateFromSavedBasket?urns=123422-123445-119464-142078-139804-134117-139927-114033-122258-111668-114110-119534-139806-141358-117833-111393-143953-142014-111718-112806-116123-120492-114270-139511-111301-141121-140505-112705-120479-134214-145789");
        }
        public static void addschoolvianameorlocationlink()
        {
            BenchMarkChartPage benchchartpage = new BenchMarkChartPage();
            benchchartpage.AddanotherschoolLink.Click();
        }

    }
}
