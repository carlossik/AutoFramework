using OpenQA.Selenium;
using System;
using AutoFramework.Pages.PageElements;

namespace AutoFramework
{
   
    public static class Config
    {
        public static int ElementsWaitingTimeout = 10000;
        public static string staging = "https://as-t1stg-sfb.azurewebsites.net/";
        public static string Dev = "https://as-t1dv-sfb.azurewebsites.net/";
        public static string Prodlive = "https://schools-financial-benchmarking.service.gov.uk/";
        public static string PreProd = "https://as-t1pr-sfb-preprod.azurewebsites.net/";
        //public static string HiddenLive = "https://as-t1pr-sfb-b.azurewebsites.net/";
        public static string currentTestEnv = staging;     
        public static string firefoxlocation = "C://Users//kwaku//OneDrive//Desktop//C#//AutoFramework//bin//Debug//firefox.exe";
        //public static string FirefoxDriverUnderTest = "firefox";
        public static string ChromeDriverUnderTest = "chrome";
       // public static string IEDriverUnderTest = "IE";
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
               

                 //IWebElement SearchResults = driver.FindElement(By.CssSelector("#js-search-results-info > div > p > span"));
            }
            
            public static void deletefiles(String fileName)
            {
                if ((System.IO.File.Exists(fileName)))
                {
                    System.IO.File.Delete(fileName);
                }
            }

        }
    }
   

}