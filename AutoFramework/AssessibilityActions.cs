using AutoFramework;
using AutoFramework.Pages.PageElements;
using Globant.Selenium.Axe;
using NUnit.Framework;
using OpenQA.Selenium;
using SFB_Test_Automation.AutoFramework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace SFB_Test_Automation.AutoFramework
{
    class AssessibilityActions
    {
        public interface IAccessibilityRule
        {
            IEnumerable<AccessibilityViolation> Check(IWebDriver driver);
            string Description { get; }
        }

        public class AccessibilityViolation
        {
            public IWebElement Element { get; set; }
            public string Violation;
        }

        public void accessibilitytest(IWebDriver driver)
        {
            AxeResult results = driver.Analyze();

            foreach (var xyz in results.Violations)
            {
                Console.WriteLine(xyz.Impact.ToString());
                Console.WriteLine(results.Violations.ToList());
                Console.WriteLine(xyz.Description.ToString());
                Console.WriteLine(xyz.Id.ToString());

                //log.Info(xyz.Description.ToString());
                //log.Info(xyz.Id.ToString());
            }
            Assert.True(results.Violations.Length == 0, "There are accessibility violations. Please check log file");
        }


        public class AccessiblityEngine
        {
            //private IWebDriver Driver { get; set; }
            //private AccessibilityTestConfiguration Configuration { get; set; }
            //public AccessiblityEngine(IWebDriver driver, AccessibilityTestConfiguration configuration)
            //{
            //    this.Driver = driver;
            //    this.Configuration = configuration;
            //}
            //public IEnumerable<AccessibilityViolation> Check()
            //{
            //    List<AccessibilityViolation> result = new List<AccessibilityViolation>();
            //    foreach (var rule in Configuration.Rules)
            //    {
            //        result.AddRange(rule.Check(Driver));
            //    }
            //  
            //return result;
            //}
        }

    }
}
