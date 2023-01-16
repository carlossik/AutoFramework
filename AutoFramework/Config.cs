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
        public static string sadUrlPP = "https://as-t1pr-sfb-sa-preprod.azurewebsites.net";
        public static string currentTestEnv = Dev;
        public static string firefoxlocation = "C://Users//kwaku//OneDrive//Desktop//C#//AutoFramework//bin//Debug//firefox.exe";
        public static string downloadDirectory = @"C:\AutomationDownloads\";
        public static string browserUnderTest = "IE";
        public static string edgeDriverPath = @"C:\Users\kwaku\OneDrive\Desktop\C#\EdgeDriver";
        public static string chrome_path = @"C:\Users\kwaku\OneDrive\Desktop\C#";
        public static string chromedriverpath = @"C:\Users\kwaku\OneDrive\Desktop\C#\chromedriver\";
        public static string giasurl = "https://get-information-schools.service.gov.uk/Establishments/Establishment/Details/";
        public static string devapi = "https://aa-t1dv-sfb.azurewebsites.net/api/schoolstatus/";
        public static string stagingapi = " https://aa-t1stg-sfb.azurewebsites.net/api/schoolstatus/";
        public static string preprodapi = " https://as-t1pr-sfb-api-preprod.azurewebsites.net/api/schoolstatus/";
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
                    if ((System.IO.File.Exists(fileNames)))
                {
                    System.IO.File.Delete(fileNames);
                }
            }

        }
    }
   

}