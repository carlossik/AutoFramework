namespace AutoFramework
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System.Threading;
    using AutoFramework.Pages;
    using System;
    using AutoFramework.Pages.PageElements;
    



    public class ComparisonTests
    {

       

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            
            //Actions.FillLoginForm();
        }

        [Test]
        [Category("QuickTests")]
        public void QuickCompare()
        {
            Actions.CallingClass.QuickCompareWithOtherSchools();
           
            Assert.IsTrue(Driver.driver.FindElement(By.Id("fsm")).Selected);
            Assert.IsTrue(Driver.driver.FindElement(By.Id("sen")).Selected);
            Assert.IsTrue(Driver.driver.FindElement(By.Id("eal")).Selected);
            Assert.IsFalse(Driver.driver.FindElement(By.Id("la")).Selected);
            Actions.CallingClass.ContinuetoBenchmarkCharts();
            //Actions.GoHome();

        }
        //[Test]
        public void ContinueToCharts()
        {
            Actions.CallingClass.QuickCompareWithOtherSchools();
            Actions.CallingClass.ContinuetoBenchmarkCharts();
            
        }
   
        [Test]
        public void zBestInClassComparison()
        {
            Actions.CallingClass.BestInClassComparison();
            SchoolDetailPage detailspage = new SchoolDetailPage();
            BestInClass bestinclasspage = new BestInClass();
            //System.Diagnostics.Debug.Print((bestinclasspage.comparing_to_text).Text);
            //System.Diagnostics.Debug.Print((detailspage.School_Name).Text);
            //Assert.IsTrue(((bestinclasspage.comparing_to_text).Text).Contains(" Plumcroft Primary School "));
                


            
        }
        [Test]
        public void TestIntepretingTheCharts()
        {
            Actions.CallingClass.InterpretingTheChartsTest();
            //need to add some assertions on the links present and the order
        }
        [Test]
        public void CompareTrusts()
        {
            Actions.TrustComparison();
        }
        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}
