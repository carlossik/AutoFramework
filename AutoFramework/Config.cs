using OpenQA.Selenium;
using System;
using AutoFramework.Pages.PageElements;

namespace AutoFramework
{
   
    public static class Config
    {
      

        public static int ElementsWaitingTimeout = 10000;
        public static string StagingEnv = "https://as-t1stg-sfb.azurewebsites.net/";
        public static string Dev = "https://as-t1dv-sfb.azurewebsites.net/";
        public static string Prodlive = "https://schools-financial-benchmarking.service.gov.uk/";
        public static string PreProd = "https://as-t1pp-sfb.azurewebsites.net/";
        public static string HiddenLive = "https://as-t1pr-sfb-b.azurewebsites.net/";
        public static string currentTestEnv = StagingEnv;

        public static string firefoxlocation = "C://Users//kwaku//OneDrive//Desktop//C#//AutoFramework//bin//Debug//firefox.exe";

        public static string DriverUnderTest1 = "firefox";
        public static string DriverUnderTest2 = "chrome";
        public static string DriverUnderTest3 = "IE";

        public static object AlertsTexts { get; internal set; }

        public static class Credentials
        {

            public static class QuickComparisonMessage
            {
                public static string ComapringToMessage = "Sir John Cass's Foundation Primary School";


            }

            public static class PostCode
            {
                public  static string Postcode = "DA7 5SS";

                

             }


            public  class ExpectedMessages
            {
                 IWebElement SearchResults = Driver.driver.FindElement(By.CssSelector("#js-search-results-info > div > p > span"));
                
            }
            //public class browsertotestwith
            //{
            //    string browsers = ["chrome", "IE", "firefox"];
                
            //    foreach (string browser in browsers)
            //        {get {return browsertotestwith }
            //        }

            //}


        }
    }
   

}