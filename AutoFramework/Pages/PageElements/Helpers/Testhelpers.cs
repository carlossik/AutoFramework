using AutoFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System.Drawing.Imaging;
using AutoFramework.Pages.PageElements;

namespace SFB_Test_Automation.AutoFramework.Pages.PageElements.Helpers
{
   public class Testhelpers
    {
        
    
    protected IWebDriver Driver;

        protected void  UITest(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                var screenshot = Driver.TakeScreenshot();

                var filePath = "C:\\Users\\kwaku\\OneDrive\\Desktop\\C#\\AutoFramework\\AutoFramework\\Pages\\screenshot";

                //screenshot.SaveAsFile(filePath, ImageFormat.Png);

                // This would be a good place to log the exception message and
                // save together with the screenshot

                throw;
            }
        }
    }
}



