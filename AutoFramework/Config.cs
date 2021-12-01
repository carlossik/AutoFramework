using OpenQA.Selenium;
using System;
using AutoFramework.Pages.PageElements;
using System.IO;

namespace AutoFramework
{
   
    public static class Config
    {
        public static int ElementsWaitingTimeout = 10000;
        public static string staging = "https://as-t1stg-sfb.azurewebsites.net/";
        public static string Dev = "https://as-t1dv-sfb.azurewebsites.net/";
        public static string Prodlive = "https://schools-financial-benchmarking.service.gov.uk/";
        public static string PreProd = "https://as-t1pr-sfb-preprod.azurewebsites.net/";
        public static string newenv = "https://as-t1-dv-sfb-govuk-frontend.azurewebsites.net/";
        //public static string HiddenLive = "https://as-t1pr-sfb-b.azurewebsites.net/";
        public static string currentTestEnv = staging;
        public static string firefoxlocation = "C://Users//kwaku//OneDrive//Desktop//C#//AutoFramework//bin//Debug//firefox.exe";
        public static string downloadDirectory = @"C:\AutomationDownloads\";
        public static string browserUnderTest = "chrome";
        public static string chrome_path = @"C:\Users\kwaku\OneDrive\Desktop\C#";
        public static string giasurl = "https://get-information-schools.service.gov.uk/Establishments/Establishment/Details/";
       
        //public static string FirefoxDriverUnderTest = "firefox";
       // public static string ChromeDriverUnderTest = "chrome";
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

            public static void Deleteallfiles(String myDirPath )
            {
                System.IO.DirectoryInfo myDirInfo = new DirectoryInfo(myDirPath);

                foreach (FileInfo file in myDirInfo.GetFiles())
                {
                    file.Delete();
                }
            }
            
            public static void deletefiles(String fileNames)
            {
                //foreach (string filePath in fileNames)
                    if ((System.IO.File.Exists(fileNames)))
                {
                    System.IO.File.Delete(fileNames);
                    //foreach(System.IO.FileInfo file in fileNames.GetFiles()) file.Delete();
                }
            }

        }
    }
   

}