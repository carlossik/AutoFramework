namespace AutoFramework
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.IE;
    using OpenQA.Selenium.Support.UI;
    using Selenium;
    
    using System;
    


    public  class Driver
    {
        public static IWebDriver  driver { get; set; }

        public static void WaitForElementUpTo(int seconds = 15)

        {
            
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
        }
        

            public static void Initialize(String browser)
            {
                switch (browser.ToLower())
                {
                    case "chrome":
                        
                        Driver.driver = new ChromeDriver();
                        break;
                    case "firefox":
                        Driver.driver = new FirefoxDriver();
                        break;
                case "IE":

                    Driver.driver = new InternetExplorerDriver();
                    break;
                default:
                    Driver.driver = new ChromeDriver();
                    break;
                    //throw new NotSupportedException("Browser " + browser + " not supported");
                }
            }
      

    }
}
