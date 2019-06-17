


namespace AutoFramework
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using SFB_Test_Automation.AutoFramework.Pages;
    using AutoFramework.Pages;
    using AutoFramework.Pages.PageElements;

    public class TrustSearchScenarios
    {
        IAlert alert;

        public TrustSearchScenarios()
        {     
        }
        
        [OneTimeSetUp]
       
        public void Initialize()
        {
            Actions.InitializeDriver();
           
            Actions.FillLoginForm();
        }


        [Test]
       
        public void TrustSearch()
        {
            Actions.TrustSearchWitName("Kaleidoscope Learning Trust ");
            TrustComparisonPage trustcomparison = new TrustComparisonPage();
            string trustname = (trustcomparison.TrustName).Text;
            Assert.AreEqual(trustname, "Kaleidoscope Learning Trust");

        }
       [Test]
        public void TrustSearchwithName()
        {
            Actions.TrustSearchWitName("Brookvale Groby Learning Trust");
            TrustComparisonPage trustcomparison = new TrustComparisonPage();
            string trustname = (trustcomparison.TrustName).Text;
            Assert.AreEqual(trustname, "Brookvale Groby Learning Trust");

        }
        [Test]
        public void TrustSearchWithCompanyNumber()
        {
            Actions.TrustSearchWithCompanynumber("8929065");
            TrustComparisonPage trustcomparison = new TrustComparisonPage();
            string trustname = (trustcomparison.TrustName).Text;
            Assert.AreEqual(trustname, "Barnwell Academy Trust");
         }


        [Test]
        public void Trustcomparison()
        {
            Actions.TrustComparison();
            TrustBenchmarkChartsPage trustcharts = new TrustBenchmarkChartsPage();
            Assert.IsTrue(trustcharts.BalanceTab.Displayed);
            Assert.IsTrue(trustcharts.ExpenditureTab.Displayed);
            Assert.IsTrue(trustcharts.IncomeTab.Displayed);
            Assert.IsTrue(trustcharts.ShowValueDropDown.Displayed);
            Assert.IsTrue(trustcharts.CentralFinancingDropdown.Displayed);

        }

        [Test]
        public void Trustcomparisonwithmorethan25schools()
        {
            Actions.TrustComparisonWithMultipleTrusts();
            TrustBenchmarkChartsPage trustcharts = new TrustBenchmarkChartsPage();
            Assert.IsTrue(trustcharts.BalanceTab.Displayed);
            Assert.IsTrue(trustcharts.ExpenditureTab.Displayed);
            Assert.IsTrue(trustcharts.IncomeTab.Displayed);
            Assert.IsTrue(trustcharts.ShowValueDropDown.Displayed);
            Assert.IsTrue(trustcharts.CentralFinancingDropdown.Displayed);

        }

       

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}