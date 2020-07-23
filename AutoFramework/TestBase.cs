using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace SFB_Test_Automation
{
    [TestFixture(typeof(FirefoxDriver))]
    [TestFixture(typeof(ChromeDriver))]
    [TestFixture(typeof(InternetExplorerDriver))]

    public class TestBase
    {
        public static IWebDriver driver;

        public void Setup(String browsername)
        {
            switch (browsername.ToLower())
            {
                case "chrome":

                    driver = new ChromeDriver();
                    break;
                case "firefox":
                    driver = new FirefoxDriver();
                    break;
                case "IE":

                    driver = new InternetExplorerDriver();
                    break;

                default:
                    driver = new ChromeDriver();
                    break;
                    //throw new NotSupportedException("Browser " + browser + " not supported");
            }
    }
        [TearDown]
        public void CleanUp()

        {
            driver.Close();
            driver.Quit();
        }

    }
}
