namespace AutoFramework
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System.Threading;
    using AutoFramework.Pages;
    using System;
    using AutoFramework.Pages.PageElements;




    public class Charttests
    {



        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();

            //Actions.FillLoginForm();
        }
        [Test]
        [Category("QuickTests")]
        public void QuickCompareChartsTest()
        {
            Actions.CallingClass.QuickCompareWithOtherSchools();

            Actions.CallingClass.ViewCharts();
            
        }

        [Test]
        [Category("QuickTests")]
        public void TestIncompleteFinanceCharts()
        {
            Actions.CallingClass.searchschoolwithIncompleteFinance("139619");
        }

        [Test]
        [Category("QuickTests")]
        public void DealsForSchoolsLink()
        {
            Actions.dealforswchools();
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector("div.chart-container:nth-child(4) > div:nth-child(1) > div:nth-child(3) > a:nth-child(1)")).Displayed);
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector("div.chart-container:nth-child(3) > div:nth-child(1) > div:nth-child(3) > a:nth-child(1)")).Displayed);
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector("div.chart-container:nth-child(5) > div:nth-child(1) > div:nth-child(3) > a:nth-child(1)")).Displayed);
            Assert.IsTrue(Driver.driver.FindElement(By.CssSelector("div.chart-container:nth-child(6) > div:nth-child(1) > div:nth-child(3) > a:nth-child(1)")).Displayed);
            
        }





        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
    }
