using AutoFramework;
using AutoFramework.Pages.PageElements;
using SFB_Test_Automation.AutoFramework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SFB_Test_Automation.AutoFramework
{
    public static class MyChartActions
    {
        public static void Gotomycharts()
        {
            DetailedComparisonActions.ExcludeschoolswithIncFinanceAcademiesAllEngland("141976", "239", "240");
            MyChartsPage chartspage = new MyChartsPage();
            BenchMarkChartPage benchmarkpage = new BenchMarkChartPage();
            benchmarkpage.YourChartsTab.Click();
            Thread.Sleep(2000);
         
        }
        public static void AddCharts()
        {
            Gotomycharts();
            MyChartsPage chartspage = new MyChartsPage();
            chartspage.AddOrRemoveChartsLink.Click();
            Thread.Sleep(2000);
                

        }

    }
}
