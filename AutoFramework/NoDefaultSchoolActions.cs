﻿using AutoFramework.Pages;
using SFB_Test_Automation.AutoFramework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SFB_Test_Automation.AutoFramework
{
    public static class NoDefaultSchoolActions
    {
        public static void detailedComparisonExcludeMaintained()
        {
            HomePage home = new HomePage();
            home.NoDefaultSchoolTab.Click();
            NoDefaultPage nodefault = new NoDefaultPage();
            nodefault.DetailComparisonButton.Click();
            nodefault.ContinueButton.Click();
            //Thread.Sleep(1000);
            nodefault.MainTainedSchoolsButton.Click();
            nodefault.ContinueButton.Click();
            nodefault.AllSchoolsButton.Click();
            nodefault.ContinueButton.Click();
            Thread.Sleep(100);
            DetailComparisonPage detailpage = new DetailComparisonPage();
            detailpage.General_Header.Click();
            detailpage.NumberOfPupilsCheckBox.Click();
            detailpage.MinNumberOfPupilsInputField.SendKeys("500");
            Thread.Sleep(6000);
            detailpage.MaxNumberOfPupilsInputBox.SendKeys("508");
            Thread.Sleep(2000);
            detailpage.ViewBenchMarkCharts.Click();

        }
        public static void detailedComparisonIncludeMaintained()
        {
            HomePage home = new HomePage();
            home.NoDefaultSchoolTab.Click();
            NoDefaultPage nodefault = new NoDefaultPage();
            nodefault.DetailComparisonButton.Click();
            nodefault.ContinueButton.Click();
          
            nodefault.MainTainedSchoolsButton.Click();
            nodefault.ExcludeIncompleteButton.Click();
            nodefault.ContinueButton.Click();
            nodefault.AllSchoolsButton.Click();
            nodefault.ContinueButton.Click();
            Thread.Sleep(100);
            DetailComparisonPage detailpage = new DetailComparisonPage();
            detailpage.General_Header.Click();
            detailpage.EligibilityFressSchoolMealsCheckBox.Click();
            detailpage.EligibilityFressSchoolMealsfromInput.SendKeys("20.99");
            Thread.Sleep(6000);
            detailpage.EligibilityFressSchoolMealsToInput.SendKeys("21");
            Thread.Sleep(2000);
            detailpage.ViewBenchMarkCharts.Click();
        }
        public static void ManualComparisonByLocation()
        {
            HomePage home = new HomePage();
            home.NoDefaultSchoolTab.Click();
            NoDefaultPage nodefault = new NoDefaultPage();
            nodefault.ManualComparisonButton.Click();
            nodefault.ContinueButton.Click();
            nodefault.addschoolsbyLocationradio.Click();
            Thread.Sleep(300);
            //nodefault.useLocationLink.Click();
            nodefault.AddSchoolsbyLocationTextField.SendKeys("DA7 5SS");
            Thread.Sleep(3000);
            nodefault.SearchSubmitButton.Click();
            Thread.Sleep(300);
            SearchResultsPage resultspage = new SearchResultsPage();
            resultspage.FirstElementPresented.Click();
                    
            Thread.Sleep(3000);
        }
        public static void ManualComparisonByName()
        {
            HomePage home = new HomePage();
            home.NoDefaultSchoolTab.Click();
            NoDefaultPage nodefault = new NoDefaultPage();
            nodefault.ManualComparisonButton.Click();
            nodefault.ContinueButton.Click();

            //nodefault.MainTainedSchoolsButton.Click();
            //nodefault.ExcludeIncompleteButtonMaintained.Click();
            //nodefault.ContinueButton.Click();
            //nodefault.AllSchoolsButton.Click();
            //nodefault.ContinueButton.Click();
            //Thread.Sleep(100);
            //DetailComparisonPage detailpage = new DetailComparisonPage();
            //detailpage.General_Header.Click();
            //detailpage.EligibilityFressSchoolMealsCheckBox.Click();
            //detailpage.EligibilityFressSchoolMealsfromInput.SendKeys("20.99");
            //Thread.Sleep(6000);
            //detailpage.EligibilityFressSchoolMealsToInput.SendKeys("21");
            //Thread.Sleep(2000);
            //detailpage.ViewBenchMarkCharts.Click();
        }
        public static void ManualComparisonByLA()
        {
            
            

            //nodefault.MainTainedSchoolsButton.Click();
            //nodefault.ExcludeIncompleteButtonMaintained.Click();
            //nodefault.ContinueButton.Click();
            //nodefault.AllSchoolsButton.Click();
            //nodefault.ContinueButton.Click();
            //Thread.Sleep(100);
            //DetailComparisonPage detailpage = new DetailComparisonPage();
            //detailpage.General_Header.Click();
            //detailpage.EligibilityFressSchoolMealsCheckBox.Click();
            //detailpage.EligibilityFressSchoolMealsfromInput.SendKeys("20.99");
            //Thread.Sleep(6000);
            //detailpage.EligibilityFressSchoolMealsToInput.SendKeys("21");
            //Thread.Sleep(2000);
            //detailpage.ViewBenchMarkCharts.Click();
        }
    }
}
