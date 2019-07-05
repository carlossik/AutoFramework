
  
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

    public static class BenchMarkActions
    {
        public static void CreateManualBenchMark()
        {
            Actions.GoHome();

            Actions.CallingClass.SearchViaSchoolurn("143592");
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass();
            bestinclass.ManualComaprisonButton.Click();
            bestinclass.NextButton.Click();
            AddSchool addschool = new AddSchool();
            addschool.AddSchoolBySchool.Click();
            addschool.schoolinputField.SendKeys("100000");
            addschool.searchButton.Click();
            SchoolDetailPage schooldetail = new SchoolDetailPage();
            Thread.Sleep(3000);
            schooldetail.AddToBenchMarkBasket.Click();
            Thread.Sleep(3000);
            schooldetail.ViewBenchMarkCharts.Click();
            Thread.Sleep(10000);




        }
        public static void CreateManualBenchMarkViaLocation()
        {
            Actions.GoHome();

            Actions.CallingClass.SearchViaSchoolurn("143592");
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
            DetailComparisonPage detatilscomparison = new DetailComparisonPage();
            

        }
        public static void refineto30schools(String urn)
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
            DetailComparisonPage detatilscomparison = new DetailComparisonPage();
            detatilscomparison.ViewBenchMarkCharts.Click();


        }
        public static void testrefinezerofound(String urn)
        {
            Actions.CallingClass.SearchViaSchoolurn(urn);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass();
            bestinclass.DetailComparisonButton.Click();
            bestinclass.NextButton.Click();
            bestinclass.MaintainedSchoolsChoice.Click();
            bestinclass.NextButton.Click();
            DetailComparisonPage details = new DetailComparisonPage();
            details.LAcode.Click();
            details.Lacodefield.SendKeys("002");
            bestinclass.NextButton.Click();
            Thread.Sleep(2000);
            details.ViewBenchMarkCharts.Click();
            Thread.Sleep(3000);



        }


    }
}
