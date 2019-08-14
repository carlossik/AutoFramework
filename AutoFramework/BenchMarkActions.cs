
  
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
            Actions.GoHome();

            Actions.CallingClass.SearchViaSchoolurn(urn);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass();
            bestinclass.ManualComaprisonButton.Click();
            bestinclass.NextButton.Click();
            bestinclass.NextButton.Click();

            ManualPage manualaddition = new ManualPage();
            manualaddition.AddSchoolByNameRadio.Click();
            manualaddition.NewSchoolNameField.SendKeys("plumcroft Primary School");
            //addschool.schoolinputField.SendKeys("100000");
            //addschool.searchButton.Click();
            SchoolDetailPage schooldetail = new SchoolDetailPage();
            Thread.Sleep(3000);
            schooldetail.AddToBenchMarkBasket.Click();
            Thread.Sleep(3000);
            schooldetail.ViewBenchMarkCharts.Click();
            Thread.Sleep(10000);




        }
        public static void CreateManualBenchMarkViaLocation(String urn)
        {
            Actions.GoHome();

            Actions.CallingClass.SearchViaSchoolurn(urn);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass();
            bestinclass.ManualComaprisonButton.Click();
            bestinclass.NextButton.Click();
            Actions.SearchByLocationUsingLink();
            SearchResultsPage resultspage = new SearchResultsPage();
            //resultspage.FirstElementPresented.Click();
            Thread.Sleep(2000);
            resultspage.AddFirstResult.Click();
            Thread.Sleep(2000);
            resultspage.ViewBenchmarkChartsButton.Click();
                

        }
        public static void CreateManualBenchMarkviaLACode()
        {
            Actions.GoHome();

            Actions.CallingClass.SearchViaSchoolurn("143592");
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass();
            bestinclass.ManualComaprisonButton.Click();
            bestinclass.NextButton.Click();
            AddSchool addschool = new AddSchool();
            addschool.AddSchoolByLocalAuthority.Click();
            addschool.schoolinputField.SendKeys("303");
            addschool.searchButton.Click();
            SchoolDetailPage schooldetail = new SchoolDetailPage();
            Thread.Sleep(3000);
            schooldetail.AddToBenchMarkBasket.Click();
            Thread.Sleep(3000);
            schooldetail.ViewBenchMarkCharts.Click();
            Thread.Sleep(10000);
           }
        public static void CreateBenchmarkViaDetailComparison(String urn)
        {
            Actions.CallingClass.SearchViaSchoolurn(urn);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass();
            bestinclass.DetailComparisonButton.Click();
            bestinclass.NextButton.Click();
            bestinclass.MaintainedSchoolsChoice.Click();
            bestinclass.NextButton.Click();
            Thread.Sleep(200);
            bestinclass.NextButton.Click();
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
            bestinclass.NextButton.Click();
            bestinclass.MaintainedSchoolsChoice.Click();
            Thread.Sleep(20);
            bestinclass.NextButton.Click();
                       
            DetailComparisonPage detatilscomparison = new DetailComparisonPage();
            Thread.Sleep(3000);
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
                                 
            bestinclass.NextButton.Click();
            
            DetailComparisonPage details = new DetailComparisonPage();
            
            bestinclass.NextButton.Click();
            details.LAcode.Click();
            details.Lacodefield.SendKeys("002");
            bestinclass.NextButton.Click();
             details.ViewBenchMarkCharts.Click();
                    }
        public static void createbenchmarkviadefault(string urn)
        {
            Actions.CallingClass.SearchViaSchoolurn(urn);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass();
            bestinclass.QuckComparisonButton.Click();

            bestinclass.NextButton.Click();

            bestinclass.DefaultChoice.Click();

            bestinclass.NextButton.Click();
           
            bestinclass.AllSchoolsChoice.Click();
            
            bestinclass.NextButton.Click();

            bestinclass.ContinueToBenchMarkChartsButton.Click();
            Thread.Sleep(30);
        }
        public static void costoffinance()
        {
            BenchMarkChartPage benchchartpage = new BenchMarkChartPage();
            benchchartpage.TotalExpenditureDropdown.Click();
           
            benchchartpage.costOfFinance.Click();
            Thread.Sleep(3000);
            

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
