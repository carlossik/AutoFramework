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

namespace SFB_Test_Automation.AutoFramework
{
    public static class EfficiencyMetricActions
    {
        public static void GotoSchholEfficiencyMetric(String urn)
        {
            Actions.schoolSearchwithLaestab(urn);
            Thread.Sleep(2000);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.EfficiencyMetricLink.Click();
            Thread.Sleep(2000);
            Actions.acceptCookie();
            Thread.Sleep(2000);
            EfficiencyMetricIntroPage intropage = new EfficiencyMetricIntroPage();
            intropage.ContinueToEfficiencyMetricButton.Click();
            Thread.Sleep(2000);
        }

        public static void benchmarkEfficiencyMetricSchools(String urn)
        {
            GotoSchholEfficiencyMetric(urn);
            EfficiencyMetricPage MetricPage = new EfficiencyMetricPage();
            MetricPage.BenchMarkTheseSchoolsButton.Click();
        }

        public static void seeschoolrank()
        {
            EfficiencyMetricPage MetricPage = new EfficiencyMetricPage();
            MetricPage.SeeThis_SchoolRank.Click();
            Thread.Sleep(4000);
        }

        public static void createBenchMarkForEMVia30percent(String urn)
        {
            GotoSchholEfficiencyMetric(urn);
            EfficiencyMetricPage MetricPage = new EfficiencyMetricPage();
            MetricPage.BenchMarkTheseSchoolsButton.Click();
            EMbenchmarkInterpage InterPage = new EMbenchmarkInterpage();
            InterPage.CompareGaianst30Percent.Click();
            InterPage.Continue.Click();


        }

        public static void createBenchMarkForEM_Manually(String urn)
        {
            GotoSchholEfficiencyMetric(urn);
            EfficiencyMetricPage MetricPage = new EfficiencyMetricPage();
            MetricPage.BenchMarkTheseSchoolsButton.Click();
            EMbenchmarkInterpage InterPage = new EMbenchmarkInterpage();
            InterPage.ManuallySelectSchools.Click();
            InterPage.Continue.Click();
        }

        public static void navigateToToolPage(String LAESTAB)
        {
            GotoSchholEfficiencyMetric(LAESTAB);
            EfficiencyMetricPage MetricPage = new EfficiencyMetricPage();
            MetricPage.See_tools_toImprove_EM.Click();
            Thread.Sleep(500);
        }

        public static void TestEMToolLinks_PlanningChecklist(String LAESTAB)
        {
            GotoSchholEfficiencyMetric(LAESTAB);
            EfficiencyMetricPage MetricPage = new EfficiencyMetricPage();
            MetricPage.See_tools_toImprove_EM.Click();
            Thread.Sleep(500);
            ToolsToImproveEMPage emtoolspage = new ToolsToImproveEMPage();
            emtoolspage.UseFinancial_PlanningCheckList_Link.Click();
            Thread.Sleep(30000);
        }

        public static void TestEMToolLinks_Top10FinancialPlanningChecks(String LAESTAB)
        {
            GotoSchholEfficiencyMetric(LAESTAB);
            EfficiencyMetricPage MetricPage = new EfficiencyMetricPage();
            MetricPage.See_tools_toImprove_EM.Click();
            Thread.Sleep(500);
            ToolsToImproveEMPage emtoolspage = new ToolsToImproveEMPage();
            emtoolspage.UseTheTop10PlanningChecksLink.Click();
            Thread.Sleep(30000);
        }

        public static void ListSchoolDetails(String LAESTAB)
        {
            GotoSchholEfficiencyMetric(LAESTAB);
            EfficiencyMetricPage MetricPage = new EfficiencyMetricPage();
           
            MetricPage.Contact_Details_Of_Schools.Click();
            Thread.Sleep(1000);
            
        }

        public static void TestEMToolLinks_UseTheToolkit(String LAESTAB)
        {
            GotoSchholEfficiencyMetric(LAESTAB);
            EfficiencyMetricPage MetricPage = new EfficiencyMetricPage();
            MetricPage.See_tools_toImprove_EM.Click();
            Thread.Sleep(500);
            ToolsToImproveEMPage emtoolspage = new ToolsToImproveEMPage();
            emtoolspage.UseTheToolKitLink.Click();
            Thread.Sleep(300);
            Driver.driver.SwitchTo().ActiveElement();
            Thread.Sleep(30000);


        }



    }
}
