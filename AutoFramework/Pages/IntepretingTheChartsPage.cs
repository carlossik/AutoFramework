using OpenQA.Selenium.Support.PageObjects;
using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoFramework;

namespace SFB_Test_Automation.AutoFramework.Pages
{
    class IntepretingTheChartsPage
    {
        public IntepretingTheChartsPage(IWebDriver driver)
        {
        
            PageFactory.InitElements(driver, this);

        }

    }
}
