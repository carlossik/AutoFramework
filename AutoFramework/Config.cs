using OpenQA.Selenium;
using System;
using AutoFramework.Pages.PageElements;

namespace AutoFramework
{
   
    public static class Config
    {
        //public static string schoolname = Driver.driver.FindElement(By.XPath("/html/body/div/main/h1")).Text;

        public static int ElementsWaitingTimeout = 10;
        public static string BaseURL = "https://as-t1dv-sfb.azurewebsites.net/";
       

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







        }
    }


}