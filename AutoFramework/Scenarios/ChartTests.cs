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









        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
    }
