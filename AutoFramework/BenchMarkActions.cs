
  
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
    using System.Linq;

    public static class BenchMarkActions
    {
        public static void CreateManualBenchMarkViaName(String urn,IWebDriver driver)
        {

            Actions.CallingClass.SearchViaSchoolurn(urn, driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            detailspage.StartAComparison.Click();
            TypeOfComparisonPage comparisontype = new TypeOfComparisonPage(driver);
            comparisontype.CreateabenchmarkComparisonButton.Click();
            BestInClass bestinclass = new BestInClass(driver);
            bestinclass.ManualComaprisonButton.Click();
            bestinclass.Continue.Click();
            Thread.Sleep(200);
            ManualPage manualaddition = new ManualPage(driver);
            manualaddition.AddSchoolByNameRadio.Click();
            manualaddition.ManualContinueButton.Click();
            manualaddition.NewSchoolNameField.SendKeys("Plumcroft Primary School"); //+ OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(2000);
            manualaddition.FirstManualSuggestion.Click();
            Thread.Sleep(200);
            manualaddition.ContinueToBenchMarkChartsButton.Click();
            Thread.Sleep(300);

        }

        public static void RemoveAllSchools(IWebDriver driver)
        {
           
            String beforexpath = "//*[@id=\"ExistingSchools\"]/div[";
            String afterxpath = "]/button";
            for (int i = 1; i > 0; i++)
            {
                IWebElement RemoveButton = driver.FindElement(By.XPath(beforexpath + i + afterxpath));
                RemoveButton.Click();


            }


        }
        public static void removeSchoolFromManualList(String urn, IWebDriver driver)
        {
            Actions.CallingClass.SearchViaSchoolurn(urn, driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            detailspage.StartAComparison.Click();
            TypeOfComparisonPage comparisontype = new TypeOfComparisonPage(driver);
            comparisontype.CreateabenchmarkComparisonButton.Click();
            //detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass(driver);
            bestinclass.ManualComaprisonButton.Click();
            bestinclass.Continue.Click();
            Thread.Sleep(200);
            ManualPage manualaddition = new ManualPage(driver);
            manualaddition.AddSchoolByNameRadio.Click();
            manualaddition.ManualContinueButton.Click();
            manualaddition.NewSchoolNameField.SendKeys("Plumcroft Primary School"); //+ OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(2000);
            manualaddition.FirstManualSuggestion.Click();
            manualaddition.AddAnotherSchoolLink.Click();
            manualaddition.SecondSchoolAddField.SendKeys("Bannockburn Primary School");
            manualaddition.FirstManualSuggestion.Click();
            manualaddition.RemoveSchoolButton.Click();
            Thread.Sleep(4000);
            manualaddition.RemoveSchoolButton2.Click();
            Thread.Sleep(400);
            //need to refactor this to account for all selections in the future. Current architecture only allows for just two schools to be removed
        }

        public static void CreateManualBenchMarkViaLocation(String urn, IWebDriver driver)
        {
            //Actions.GoHome();

            Actions.CallingClass.SearchViaSchoolurn(urn,driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass(driver);
            bestinclass.ManualComaprisonButton.Click();
            bestinclass.Continue.Click();
            Actions.AddAnotherSchoolManually(driver);
            SearchResultsPage resultspage = new SearchResultsPage(driver);
            //resultspage.FirstElementPresented.Click();
            Thread.Sleep(200);
            resultspage.AddFirstResult.Click();
            Thread.Sleep(2000);
            //resultspage.ViewBenchmarkChartsButton.Click();
            resultspage.ManualChartsButton.Click();
                

        }
        public static void CreateManualBenchMarkviaLACode(String Lacode, IWebDriver driver)
        {
            Actions.GoHome(driver);

            Actions.CallingClass.SearchViaSchoolurn("143592",driver);
           
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            detailspage.StartAComparison.Click();
            TypeOfComparisonPage comparisontype = new TypeOfComparisonPage(driver);
            comparisontype.CreateabenchmarkComparisonButton.Click();
            BestInClass bestinclass = new BestInClass(driver);
            bestinclass.ManualComaprisonButton.Click();
            bestinclass.Continue.Click();
            AddSchool addschool = new AddSchool(driver);
            addschool.AddSchoolByLocalAuthority.Click();
            addschool.LocalAuthorityinputField.SendKeys(Lacode);
            addschool.searchButton.Click();
            SchoolDetailPage schooldetail = new SchoolDetailPage(driver);
            Thread.Sleep(30);
            schooldetail.FirstSearchItem.Click();
            Thread.Sleep(30);
            schooldetail.ContinueToManualBenchMarkCharts.Click();
            Thread.Sleep(100);
           }
        public static void CreateBenchmarkViaDetailComparison(String urn, IWebDriver driver)
        {
            Actions.CallingClass.SearchViaSchoolurn(urn,driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            detailspage.StartAComparison.Click();
            TypeOfComparisonPage comparisontype = new TypeOfComparisonPage(driver);
            comparisontype.CreateabenchmarkComparisonButton.Click();
            BestInClass bestinclass = new BestInClass(driver);
            bestinclass.DetailComparisonButton.Click();
            bestinclass.Continue.Click();
            bestinclass.MaintainedSchoolsChoice.Click();
            bestinclass.Continue.Click();
            Thread.Sleep(200);
            bestinclass.AllOfEngland.Click();
            bestinclass.Continue.Click();
            Thread.Sleep(200);
            DetailComparisonPage detatilscomparison = new DetailComparisonPage(driver);
            detatilscomparison.ViewBenchMarkCharts.Click();

            Thread.Sleep(200);

        }
        public static void refineto30schools(String urn, IWebDriver driver)
        {
            Actions.CallingClass.SearchViaSchoolurn(urn,driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            detailspage.StartAComparison.Click();
            TypeOfComparisonPage comparisontype = new TypeOfComparisonPage(driver);
            comparisontype.CreateabenchmarkComparisonButton.Click();
            BestInClass bestinclass = new BestInClass(driver);
            bestinclass.DetailComparisonButton.Click();
            Thread.Sleep(20);
            bestinclass.Continue.Click();
            bestinclass.MaintainedSchoolsChoice.Click();
            Thread.Sleep(20);
            bestinclass.Continue.Click();        
            DetailComparisonPage detatilscomparison = new DetailComparisonPage(driver);
            Thread.Sleep(3000);

            bestinclass.AllOfEngland.Click();
            bestinclass.WhereShouldTheComparisonComeFromcontbutton.Click();
            Thread.Sleep(3000);

          
            detatilscomparison.ViewBenchMarkCharts.Click();
            Thread.Sleep(3000);
           
        }
        public static void testrefinezerofound(String urn, IWebDriver driver)
        {
            Actions.CallingClass.SearchViaSchoolurn(urn,driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            detailspage.StartAComparison.Click();
            TypeOfComparisonPage comparisontype = new TypeOfComparisonPage(driver);
            comparisontype.CreateabenchmarkComparisonButton.Click();

            BestInClass bestinclass = new BestInClass(driver);
            bestinclass.DetailComparisonButton.Click();                  
            bestinclass.Continue.Click();
            DetailComparisonPage details = new DetailComparisonPage(driver);
            bestinclass.MaintainedSchoolsChoice.Click();
            bestinclass.Continue.Click();
            details.LAcode.Click();
            details.Lacodefield.SendKeys("202");
            bestinclass.Continue.Click();
             details.ViewBenchMarkCharts.Click();
             }

        public static void createbenchmarkviadefault(string urn, IWebDriver driver)
        {
            Actions.CallingClass.SearchViaSchoolurn(urn, driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            detailspage.StartAComparison.Click();
            TypeOfComparisonPage comparisontype = new TypeOfComparisonPage(driver);
            comparisontype.CreateabenchmarkComparisonButton.Click();
            BestInClass bestinclass = new BestInClass(driver);
            bestinclass.QuckComparisonButton.Click();
            bestinclass.Continue.Click();
            bestinclass.MaintainedSchoolsChoice.Click();
            bestinclass.Continue.Click();
            bestinclass.page2of2ContinueButton.Click();
           
        }
        public static void costoffinance(IWebDriver driver)
        {
            BenchMarkChartPage benchchartpage = new BenchMarkChartPage(driver);
            benchchartpage.TotalExpenditureDropdown.Click();
            benchchartpage.costOfFinance.Click();
            Thread.Sleep(30000);
            

        }
        public static void PercentageOfTotal(IWebDriver driver)
        {
            BenchMarkChartPage benchchartpage = new BenchMarkChartPage(driver);
            benchchartpage.PercenTageOfTotalOption.Click();
            benchchartpage.IncomeTab.Click();
            Thread.Sleep(3000);
        }

        public static void NavigateToBestInClassComparisonSchoolsTab(IWebDriver driver)
        {
            BenchMarkChartPage benchchartpage = new BenchMarkChartPage(driver);
            benchchartpage.BestInClassComparisonSchoolsTab.Click();
            Thread.Sleep(4000);
        }
        public static void NavigateToOtherComparisonSchoolsTab(IWebDriver driver)
        {
            BenchMarkChartPage benchchartpage = new BenchMarkChartPage(driver);
            benchchartpage.OtherComparisonSchoolsTab.Click();
            Thread.Sleep(1000);
        }
        public static void PasteCopiedClipboardText(IWebDriver driver)
        {  
            string myURL = System.Windows.Forms.Clipboard.GetText(TextDataFormat.Text);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.Navigate().GoToUrl(Config.currentTestEnv);

            ((IJavaScriptExecutor)driver).ExecuteScript("navigator.clipboard.readText().then(text => window.location.replace(text));");
            Console.WriteLine("This is the copied clipboard data"+myURL);
            Thread.Sleep(500);
           
            
            Thread.Sleep(2000);
        }
        public static void getclipboardTextmaximum(IWebDriver driver)
        {          
            driver.Navigate().GoToUrl(Config.currentTestEnv +"BenchmarkCharts/GenerateFromSavedBasket?urns=123422-123445-119464-142078-139804-134117-139927-114033-122258-111668-114110-119534-139806-141358-117833-111393-143953-142014-111718-112806-116123-120492-114270-139511-111301-141121-140505-112705-120479-134214-145789");
        }
        public static void addschoolvianameorlocationlink(IWebDriver driver)
        {
            BenchMarkChartPage benchchartpage = new BenchMarkChartPage(driver);
            Thread.Sleep(5000);
            benchchartpage.AddanotherschoolLink.Click();
        }

        public static void createBenchmarkforSpecials(String specialSchool, IWebDriver driver)
        {
            Actions.CallingClass.SearchViaSchoolurn(specialSchool,driver);
            SchoolDetailPage detailspage = new SchoolDetailPage(driver);
            detailspage.StartAComparison.Click();
            TypeOfComparisonPage comparisontype = new TypeOfComparisonPage(driver);
            comparisontype.CreateabenchmarkComparisonButton.Click();
            BestInClass bestinclass = new BestInClass(driver);
            bestinclass.QuckComparison_For_Specials_Button.Click();
            bestinclass.Continue.Click();
            bestinclass.ContinueForSpecials.Click();
            Thread.Sleep(2000);
        }


        public static void CopyAndPasteChart(IWebDriver driver)
        {
            BenchMarkChartPage benchchartpage = new BenchMarkChartPage(driver);
            benchchartpage.Savebenchmarkbasket.Click();
            IWebElement linktocopy = driver.FindElement(By.Id("saveUrl"));
            string copiedchart = linktocopy.GetAttribute("value");
            Console.WriteLine(copiedchart);
            linktocopy.Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.Navigate().GoToUrl(copiedchart);

        }

    }
}
