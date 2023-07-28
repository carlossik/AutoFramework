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
        public static string currentTestEnv = Prodlive;
        public static string firefoxlocation = "";
        public static string downloadDirectory = @"";
        public static string browserUnderTest = "IE";
        public static string edgeDriverPath = @"";
        public static string chrome_path = @"";
        public static string chromedriverpath = @"";
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
                public  static string Postcode = "me7 2qp";
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
