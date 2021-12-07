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
using System.Linq;

namespace SFB_Test_Automation.AutoFramework
{
    public static class EfficiencyMetricActions
    {
        public static void GotoSchholEfficiencyMetric(String urn,IWebDriver driver)
        {
            Actions.schoolSearchwithLaestab(urn,driver);
            Thread.Sleep(2000);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            detailspage.StartAComparison.Click();
            TypeOfComparisonPage comparisontype = new TypeOfComparisonPage(driver);
            Thread.Sleep(2000);
            comparisontype.EfficiencyMetrictButton.Click();
            
            Thread.Sleep(2000);
            Actions.acceptEMCookie(driver);
            Thread.Sleep(2000);
            EfficiencyMetricIntroPage intropage = new EfficiencyMetricIntroPage(driver);
            intropage.ContinueToEfficiencyMetricButton.Click();
            Thread.Sleep(2000);
        }

        public static void benchmarkEfficiencyMetricSchools(String urn,IWebDriver driver)
        {
            GotoSchholEfficiencyMetric(urn,driver);
            EfficiencyMetricPage MetricPage = new EfficiencyMetricPage(driver);
            MetricPage.BenchMarkTheseSchoolsButton.Click();
        }

        public static void seeschoolrank(IWebDriver driver)
        {
            EfficiencyMetricPage MetricPage = new EfficiencyMetricPage(driver);
            MetricPage.SeeThis_SchoolRank.Click();
            Thread.Sleep(4000);
        }

        public static void createBenchMarkForEMVia30percent(String urn,IWebDriver driver)
        {
            GotoSchholEfficiencyMetric(urn,driver);
            EfficiencyMetricIntroPage intropage = new EfficiencyMetricIntroPage(driver);
            
            EfficiencyMetricPage MetricPage = new EfficiencyMetricPage(driver);
            MetricPage.BenchMarkTheseSchoolsButton.Click();
            EMbenchmarkInterpage InterPage = new EMbenchmarkInterpage(driver);
            InterPage.CompareGaianst30Percent.Click();
            InterPage.Continue.Click();


        }

        public static void createBenchMarkForEM_Manually(String urn,IWebDriver driver)
        {
            GotoSchholEfficiencyMetric(urn,driver);
            EfficiencyMetricPage MetricPage = new EfficiencyMetricPage(driver);
            MetricPage.BenchMarkTheseSchoolsButton.Click();
            EMbenchmarkInterpage InterPage = new EMbenchmarkInterpage(driver);
            InterPage.ManuallySelectSchools.Click();
            InterPage.Continue.Click();
        }

        public static void addschoolstoBasket(IWebDriver driver)
        {
            EM_ManualComparisonPage manualpage = new EM_ManualComparisonPage(driver);
            Thread.Sleep(2000);
            manualpage.AddFirstSchoolButton.Click();
            manualpage.AddSecondSchoolButton.Click();
            manualpage.AddThirdSchoolButton.Click();
            manualpage.AddFourthSchoolButton.Click();
            manualpage.AddFithSchoolButton.Click();
            manualpage.Continue_To_BenchMarkCharts.Click();

        }

        public static void filterByEM_Rank(String rank,String urn,IWebDriver driver)
        {
            createBenchMarkForEM_Manually(urn,driver);
        }
        public static void filterByEducationPhase(String educationphase, String urn,IWebDriver driver)
        {
            createBenchMarkForEM_Manually(urn,driver);
        }

        public static void filterBySchoolType(String schooltype, String urn,IWebDriver driver)
        {
            createBenchMarkForEM_Manually(urn,driver);
        }

        public static void filterByOfstedRating(String rating, String urn,IWebDriver driver)
        {
            createBenchMarkForEM_Manually(urn,driver);
        }

        public static void filterByReligiousCharacter(String character, String urn,IWebDriver driver)
        {
            createBenchMarkForEM_Manually(urn,driver);
        }


        public static void navigateToToolPage(String LAESTAB,IWebDriver driver)
        {
            GotoSchholEfficiencyMetric(LAESTAB,driver);
            EfficiencyMetricPage MetricPage = new EfficiencyMetricPage(driver);
            MetricPage.See_tools_toImprove_EM.Click();
            Thread.Sleep(500);
        }

        public static void TestEMToolLinks_PlanningChecklist(String LAESTAB,IWebDriver driver)
        {
            GotoSchholEfficiencyMetric(LAESTAB,driver);
            EfficiencyMetricPage MetricPage = new EfficiencyMetricPage(driver);
            MetricPage.See_tools_toImprove_EM.Click();
            Thread.Sleep(500);
            ToolsToImproveEMPage emtoolspage = new ToolsToImproveEMPage(driver);
            emtoolspage.UseFinancial_PlanningCheckList_Link.Click();
            Thread.Sleep(30000);
        }
        public static void clickonallLinks(IWebDriver driver)
        {
           
        IList<IWebElement> EMschools = driver.FindElements(By.XPath("//a[contains(@href, '/school/detail?urn=')]"));
            foreach (IWebElement element in EMschools)
            {
                try

                {
                    element.Click();
                    Thread.Sleep(1000);
                    driver.Navigate().Back();
                    driver.Navigate().Refresh();
                    Thread.Sleep(1000);
                    Console.WriteLine(element.Text);

                }
                catch (StaleElementReferenceException) { continue; }
            }
        }

        public static void TestEMToolLinks_Top10FinancialPlanningChecks(String LAESTAB,IWebDriver driver)
        {
            GotoSchholEfficiencyMetric(LAESTAB,driver);
            EfficiencyMetricPage MetricPage = new EfficiencyMetricPage(driver);
            MetricPage.See_tools_toImprove_EM.Click();
            Thread.Sleep(500);
            ToolsToImproveEMPage emtoolspage = new ToolsToImproveEMPage(driver);
            emtoolspage.UseTheTop10PlanningChecksLink.Click();
            Thread.Sleep(1000);
                
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Thread.Sleep(300);
        }

        public static void TestEMToolLinks_Use_The_ToolKit(String LAESTAB, IWebDriver driver)
        {
            GotoSchholEfficiencyMetric(LAESTAB, driver);
            EfficiencyMetricPage MetricPage = new EfficiencyMetricPage(driver);
            MetricPage.See_tools_toImprove_EM.Click();
            Thread.Sleep(500);
            ToolsToImproveEMPage emtoolspage = new ToolsToImproveEMPage(driver);
            emtoolspage.UseTheToolKitLink.Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Thread.Sleep(300);
        }


        public static void ListSchoolDetails(String LAESTAB,IWebDriver driver)
        {
            GotoSchholEfficiencyMetric(LAESTAB,driver);
            EfficiencyMetricPage MetricPage = new EfficiencyMetricPage(driver);
            MetricPage.Contact_Details_Of_Schools.Click();
            Thread.Sleep(1000);
            
        }

        public static void TestEMToolLinks_UseTheToolkit(String LAESTAB,IWebDriver driver)
        {
            GotoSchholEfficiencyMetric(LAESTAB,driver);
            EfficiencyMetricPage MetricPage = new EfficiencyMetricPage(driver);
            MetricPage.See_tools_toImprove_EM.Click();
            Thread.Sleep(500);
            ToolsToImproveEMPage emtoolspage = new ToolsToImproveEMPage(driver);
            emtoolspage.UseTheToolKitLink.Click();
            Thread.Sleep(50000);
            driver.SwitchTo().ActiveElement();
            Thread.Sleep(300);


        }



    }
}
