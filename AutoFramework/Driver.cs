namespace AutoFramework
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.Support.UI;
    using Selenium;
    
    using System;
    


    public  class Driver
    {
        public static IWebDriver  driver { get; set; }

        public static void WaitForElementUpTo(int seconds = 15)

        {
            
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(seconds)); //= TimeSpan.FromSeconds(seconds);
        }
        //public class SeleniumTestFixtureBase
        //{
            //protected IWebDriver WebDriver;

            public static void Initialize(String browser)
            {
                switch (browser.ToLower())
                {
                    case "chrome":
                        //DirectoryInfo chromeDriverLocation = new DirectoryInfo(@".");
                        Driver.driver = new ChromeDriver();
                        break;
                    case "firefox":
                        Driver.driver = new FirefoxDriver();
                        break;
                    default:
                        throw new NotSupportedException("Browser " + browser + " not supported");
                }
            }
        //}

    }
}
