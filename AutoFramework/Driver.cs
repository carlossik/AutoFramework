namespace AutoFramework
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.Support.UI;
    using Selenium;
    
    using System;
    


    public static class Driver
    {
        public static IWebDriver driver { get; set; }

        public static void WaitForElementUpTo(int seconds = 5)

        {
            
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(seconds)); //= TimeSpan.FromSeconds(seconds);
        }
    }
}
