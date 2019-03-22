namespace AutoFramework
{
    using System;
    using AutoFramework.Pages.PageElements;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Firefox;
    using Pages;

    public static class Actions
    {
        public static void InitializeDriver()
        {
            Driver.driver = new FirefoxDriver();
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
            Driver.WaitForElementUpTo(Config.ElementsWaitingTimeout);
        }

        public static void FillLoginForm()

        {
            LoginScenarioPost loginScenario = new LoginScenarioPost();

            loginScenario.UsernameField.Clear();
            loginScenario.UsernameField.SendKeys("internal");
            loginScenario.PasswordField.Clear();
            loginScenario.PasswordField.SendKeys("sfb_19twspssc03");
            loginScenario.LoginButton.Click();
            //Driver.driver.Close();


        }

        public static void SearchSchool()

        {
            InitializeDriver();
            FillLoginForm();
            HomePage homepage = new HomePage();
            homepage.School.Click();
            homepage.SchoolsearchField.SendKeys("100000");

            homepage.ClickOnSearchButton();
            Driver.driver.Close();


        }
        public static void GetSearchText()
        {
            SearchResultsPage searchresults = new SearchResultsPage();
            var results = searchresults.SchooSearchResults.Text;
            return;


        }
        public static void TrustSearch()
        {
            InitializeDriver();
            FillLoginForm();
            HomePage homepage = new HomePage();
            homepage.TrustTickBox.Click();
            homepage.TrustSearchInput.SendKeys("Lewisham");
            Driver.driver.Close();

        }
        public static void TrustSearchWithTrustnumber()
        {
            InitializeDriver();
            FillLoginForm();
            HomePage homepage = new HomePage();
            homepage.TrustTickBox.Click();
            homepage.TrustSearchInput.SendKeys("100730");
            Driver.driver.Close();

        }
        public static void TestLinks()
        {
            InitializeDriver();
            FillLoginForm();
            SpecialElementsPage links = new SpecialElementsPage();
            //links.feedbackLink.Click();
            // Driver.driver.Navigate().Back();
            links.HelpUsingSiteLink.Click();
            Driver.driver.Navigate().Back();
            links.DataSources.Click();
            Driver.driver.Navigate().Back();
            links.IntepreTingTheChartsLinks.Click();

            Driver.driver.Close();
            //Driver.driver.Navigate().Back();

        }
        public static void verifybasket()
        {
            InitializeDriver();
            FillLoginForm();
            SearchSchool();
            SchoolDetailPage Schooldetails = new SchoolDetailPage();
            Schooldetails.AddToBenchMarkBasket.Click();
            Driver.WaitForElementUpTo(Config.ElementsWaitingTimeout);


        }
        public static void SearchViaLocation()
        {

            InitializeDriver();
            FillLoginForm();
            HomePage homepage = new HomePage();
            homepage.School.Click();
            homepage.SchoolsearchField.SendKeys("100000");

        }

    }
}
       

