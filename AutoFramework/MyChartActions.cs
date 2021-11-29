using AutoFramework;
using AutoFramework.Pages;
using AutoFramework.Pages.PageElements;
using OpenQA.Selenium;
using SFB_Test_Automation.AutoFramework.Pages;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SFB_Test_Automation.AutoFramework
{
    public static class MyChartActions
    {
        public static void Gotomycharts(IWebDriver driver)
        {
            DetailedComparisonActions.ExcludeschoolswithIncFinanceAcademiesAllEngland("141976", "246", "247",driver);
            MyChartsPage chartspage = new MyChartsPage(driver);
            BenchMarkChartPage benchmarkpage = new BenchMarkChartPage(driver);

            benchmarkpage.YourChartsTab.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2); ;
        }
        public static void AddCharts(IWebDriver driver)
        {
            Gotomycharts(driver);
            MyChartsPage chartspage = new MyChartsPage(driver);
            chartspage.AddTotalExpenditureToCharts.Click();
            chartspage.AddOrRemoveChartsLink.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            chartspage.TotalExpenditureaccordion.Click();
            chartspage.Staffeaccordion.Click();
            chartspage.Staff_PerPupil.Click();//add a few charts here
            chartspage.TeachingStaff_PerPupil.Click();
            chartspage.Tot_ExpenDiture_PerPupil.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }

        public static void persistCharts(IWebDriver driver)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.Navigate().GoToUrl(Config.currentTestEnv);
            HomePage home = new HomePage(driver);
            home.ViewBenchMarkChartsButton.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            MyChartsPage chartspage = new MyChartsPage(driver);
            driver.FindElement(By.CssSelector("#Custom > a:nth-child(1) > span:nth-child(1) > span:nth-child(2) > span:nth-child(1)")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Console.WriteLine(driver.FindElement(By.CssSelector("#Custom > a:nth-child(1) > span:nth-child(1) > span:nth-child(2) > span:nth-child(1)")).Text);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(35);
        }

    }
}
