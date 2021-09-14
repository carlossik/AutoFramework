﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFramework.Pages;
using How = SeleniumExtras.PageObjects.How;
namespace SFB_Test_Automation.AutoFramework.Pages
{
    class ContactUsPage
    {

        public ContactUsPage(IWebDriver driver)
        {


            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
        }


        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "contactUs.Name")]
        [SeleniumExtras.PageObjects.CacheLookup]
        public IWebElement Name { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "contactUs.Email")]
        public IWebElement EmailField { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "contactUs.SchoolTrustName")]
        public IWebElement SchoolOrTrustName { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "contactUs.Message")]
        public IWebElement Contactus_Message_field{ get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "button.button:nth-child(7)")]
        public IWebElement SubmitButton { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "")]
        public IWebElement SubmitMessage { get; set; }
        

        
    }
}
