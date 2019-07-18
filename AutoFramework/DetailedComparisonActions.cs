﻿using AutoFramework;
using AutoFramework.Pages;
using AutoFramework.Pages.PageElements;
using NUnit.Framework;
using SFB_Test_Automation.AutoFramework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SFB_Test_Automation.AutoFramework
{
    public static class DetailedComparisonActions
    {
        public static void  verifysearchnumbers()
        {
            DetailComparisonPage detailpage = new DetailComparisonPage();
            string resultsnumbers = detailpage.SearchResultsCount.Text;
            int resultsdisplayed = int.Parse(resultsnumbers);
            if (resultsdisplayed < 31)
            {
                
            }
            

        }
        public static void ExcludeschoolswithIncFinanceMaintainedAllEngland(String urn)
        {
            Actions.CallingClass.SearchViaSchoolurn(urn);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass();
            bestinclass.DetailComparisonButton.Click();
            bestinclass.NextButton.Click();
            DetailComparisonPage detailpage = new DetailComparisonPage();
            detailpage.MaintainedRadio.Click();
            //Thread.Sleep(30000);
            //detailpage.Excludecheckbox.Click();
            bestinclass.NextButton.Click();
            detailpage.AllOfEnglandRadio.Click();
            bestinclass.NextButton.Click();
           
            detailpage.General_Header.Click();
            detailpage.NumberOfPupilsCheckBox.Click();
            detailpage.MinNumberOfPupilsInputField.SendKeys("64");
            detailpage.MaxNumberOfPupilsInputBox.SendKeys("64");
            Thread.Sleep(1000);
            string resultsnumbers = detailpage.SearchResultsCount.Text;
            int resultsdisplayed = int.Parse(resultsnumbers);
            Assert.IsTrue(resultsdisplayed < 31);
            detailpage.ViewBenchMarkCharts.Click();

           

            

        }
        public static void ExcludeschoolswithIncFinanceAllSchoolsAllEngland(String urn)
        {
            Actions.CallingClass.SearchViaSchoolurn(urn);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass();
            bestinclass.DetailComparisonButton.Click();
            bestinclass.NextButton.Click();
            DetailComparisonPage detailpage = new DetailComparisonPage();
            detailpage.AllschoolsRadio.Click();
            Thread.Sleep(3000);
            //detailpage.Excludecheckbox.Click();
            bestinclass.NextButton.Click();
            Thread.Sleep(3000);
            detailpage.AllOfEnglandRadio.Click();
            Thread.Sleep(3000);
            //detailpage.Lacodefield.SendKeys("879");
            bestinclass.NextButton.Click();

            detailpage.General_Header.Click();
            detailpage.NumberOfPupilsCheckBox.Click();
            detailpage.MinNumberOfPupilsInputField.SendKeys("64");
            detailpage.MaxNumberOfPupilsInputBox.SendKeys("79");
            Thread.Sleep(3000);
            detailpage.ViewBenchMarkCharts.Click();
        }
        public static void IncludeschoolswithIncFinanceMaintainedAllEngland(String urn)
        {
            Actions.CallingClass.SearchViaSchoolurn(urn);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass();
            bestinclass.DetailComparisonButton.Click();
            bestinclass.NextButton.Click();
            DetailComparisonPage detailpage = new DetailComparisonPage();
            detailpage.MaintainedRadio.Click();
            //Thread.Sleep(300);
            detailpage.MaintainedExcludecheckbox.Click();
            bestinclass.NextButton.Click();
            detailpage.AllOfEnglandRadio.Click();
            bestinclass.NextButton.Click();

            detailpage.General_Header.Click();
            detailpage.NumberOfPupilsCheckBox.Click();
            detailpage.MinNumberOfPupilsInputField.SendKeys("64");
            detailpage.MaxNumberOfPupilsInputBox.SendKeys("64");
            Thread.Sleep(7000);
            detailpage.ViewBenchMarkCharts.Click();
            Thread.Sleep(5000);


        }
        public static void IncludeschoolswithIncFinanceAcademiesAllEngland(String urn, String minpupils, String maxpupils)
        {
            Actions.CallingClass.SearchViaSchoolurn(urn);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass();
            bestinclass.DetailComparisonButton.Click();
            bestinclass.NextButton.Click();
            DetailComparisonPage detailpage = new DetailComparisonPage();
            detailpage.AcademyRadio.Click();
            //Thread.Sleep(300);
            detailpage.AcademiesExcludecheckbox.Click();
            bestinclass.NextButton.Click();
            detailpage.AllOfEnglandRadio.Click();
            bestinclass.NextButton.Click();

            detailpage.General_Header.Click();
            detailpage.NumberOfPupilsCheckBox.Click();
            detailpage.MinNumberOfPupilsInputField.SendKeys(minpupils);
            detailpage.MaxNumberOfPupilsInputBox.SendKeys(maxpupils);
            Thread.Sleep(4000);
            detailpage.ViewBenchMarkCharts.Click();
        }
        public static void IncludechoolswithIncFinanceAllSchoolsAllEngland(String urn)
        {
            Actions.CallingClass.SearchViaSchoolurn(urn);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass();
            bestinclass.DetailComparisonButton.Click();
            bestinclass.NextButton.Click();
            DetailComparisonPage detailpage = new DetailComparisonPage();
            detailpage.AllschoolsRadio.Click();
            //Thread.Sleep(30000);
            detailpage.AllSchoolsExcludecheckbox.Click();
            //Thread.Sleep(30000);
            bestinclass.NextButton.Click();
            detailpage.AllOfEnglandRadio.Click();
            //detailpage.Lacodefield.SendKeys("879");
            bestinclass.NextButton.Click();

            detailpage.General_Header.Click();
            detailpage.NumberOfPupilsCheckBox.Click();
            detailpage.MinNumberOfPupilsInputField.SendKeys("221.15");
            Thread.Sleep(6000);
            detailpage.MaxNumberOfPupilsInputBox.SendKeys("221.5");
            Thread.Sleep(6000);
            detailpage.ViewBenchMarkCharts.Click();
            Thread.Sleep(5000);
        }
        public static void ExcludeschoolswithIncFinanceMaintainedLaCode(String urn)
        {
            Actions.CallingClass.SearchViaSchoolurn(urn);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass();
            bestinclass.DetailComparisonButton.Click();
            bestinclass.NextButton.Click();
            DetailComparisonPage detailpage = new DetailComparisonPage();
            detailpage.MaintainedRadio.Click();
            //Thread.Sleep(30000);
            //detailpage.Excludecheckbox.Click();
            bestinclass.NextButton.Click();
            detailpage.LAcode.Click();
            detailpage.Lacodefield.SendKeys("879");
            bestinclass.NextButton.Click();

            detailpage.General_Header.Click();
            detailpage.NumberOfPupilsCheckBox.Click();
            detailpage.MinNumberOfPupilsInputField.SendKeys("200");
            detailpage.MaxNumberOfPupilsInputBox.SendKeys("750");
            Thread.Sleep(1000);
            detailpage.ViewBenchMarkCharts.Click();
        }
        public static void ExcludeschoolswithIncFinanceAcademiesLaCode(String urn)
        {
            Actions.CallingClass.SearchViaSchoolurn(urn);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass();
            bestinclass.DetailComparisonButton.Click();
            bestinclass.NextButton.Click();
            DetailComparisonPage detailpage = new DetailComparisonPage();
            detailpage.AcademyRadio.Click();
            //Thread.Sleep(30000);
            //detailpage.Excludecheckbox.Click();
            bestinclass.NextButton.Click();
            detailpage.LAcode.Click();
            detailpage.Lacodefield.SendKeys("879");
            bestinclass.NextButton.Click();

            detailpage.General_Header.Click();
            detailpage.NumberOfPupilsCheckBox.Click();
            detailpage.MinNumberOfPupilsInputField.SendKeys("64");
            detailpage.MaxNumberOfPupilsInputBox.SendKeys("79");
            Thread.Sleep(1000);
            detailpage.ViewBenchMarkCharts.Click();
        }
        public static void ExcludeschoolswithIncFinanceAllSchoolsLaCode(String urn)
        {
            Actions.CallingClass.SearchViaSchoolurn(urn);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass();
            bestinclass.DetailComparisonButton.Click();
            bestinclass.NextButton.Click();
            DetailComparisonPage detailpage = new DetailComparisonPage();
            detailpage.AllschoolsRadio.Click();
            //Thread.Sleep(30000);
            //detailpage.Excludecheckbox.Click();
            bestinclass.NextButton.Click();
            detailpage.LAcode.Click();
            detailpage.Lacodefield.SendKeys("879");
            bestinclass.NextButton.Click();

            detailpage.General_Header.Click();
            detailpage.NumberOfPupilsCheckBox.Click();
            detailpage.MinNumberOfPupilsInputField.SendKeys("64");
            detailpage.MaxNumberOfPupilsInputBox.SendKeys("79");
            Thread.Sleep(1000);
            detailpage.ViewBenchMarkCharts.Click();
        }
        public static void IncludeschoolswithIncFinanceMaintainedLaCode(String urn,String lacode,String minnumpupils,String maxnumpupils)
        {
            Actions.CallingClass.SearchViaSchoolurn(urn);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass();
            bestinclass.DetailComparisonButton.Click();
            bestinclass.NextButton.Click();
            DetailComparisonPage detailpage = new DetailComparisonPage();
            detailpage.MaintainedRadio.Click();
            //Thread.Sleep(30000);
            detailpage.MaintainedExcludecheckbox.Click();
            //Thread.Sleep(30000);
            bestinclass.NextButton.Click();
            detailpage.LAcodeRadio.Click();
            detailpage.Lacodefield.SendKeys(lacode);
            bestinclass.NextButton.Click();

            detailpage.General_Header.Click();
            detailpage.NumberOfPupilsCheckBox.Click();
            detailpage.MinNumberOfPupilsInputField.SendKeys(minnumpupils);
            Thread.Sleep(6000);
            detailpage.MaxNumberOfPupilsInputBox.SendKeys(maxnumpupils);
            Thread.Sleep(2000);
            detailpage.ViewBenchMarkCharts.Click();
        }
        public static void IncludeschoolswithIncFinanceAcademiesLaCode(String urn,String lacode,String minpupils,String maxpupils)
        {
            Actions.CallingClass.SearchViaSchoolurn(urn);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass();
            bestinclass.DetailComparisonButton.Click();
            bestinclass.NextButton.Click();
            DetailComparisonPage detailpage = new DetailComparisonPage();
            detailpage.AcademyRadio.Click();
            //Thread.Sleep(300);
            detailpage.AcademiesExcludecheckbox.Click();
            bestinclass.NextButton.Click();
            detailpage.LAcodeRadio.Click();
            detailpage.LAcodeinputfield.SendKeys(lacode);
            bestinclass.NextButton.Click();

            detailpage.General_Header.Click();
            detailpage.NumberOfPupilsCheckBox.Click();
            detailpage.MinNumberOfPupilsInputField.SendKeys(minpupils);
            detailpage.MaxNumberOfPupilsInputBox.SendKeys(maxpupils);
            Thread.Sleep(4000);
            detailpage.ViewBenchMarkCharts.Click();
            Thread.Sleep(4000);

        }
        public static void IncludechoolswithIncFinanceAllSchoolsLaCode(String urn)
        {
            Actions.CallingClass.SearchViaSchoolurn(urn);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass();
            bestinclass.DetailComparisonButton.Click();
            bestinclass.NextButton.Click();
            DetailComparisonPage detailpage = new DetailComparisonPage();
            detailpage.AllschoolsRadio.Click();
            //Thread.Sleep(30000);
            detailpage.AllSchoolsExcludecheckbox.Click();
            //Thread.Sleep(30000);
            bestinclass.NextButton.Click();
            detailpage.LAcodeRadio.Click();
            detailpage.Lacodefield.SendKeys("879");
            bestinclass.NextButton.Click();

            detailpage.General_Header.Click();
            detailpage.NumberOfPupilsCheckBox.Click();
            detailpage.MinNumberOfPupilsInputField.SendKeys("221.15");
            Thread.Sleep(6000);
            detailpage.MaxNumberOfPupilsInputBox.SendKeys("240");
            Thread.Sleep(2000);
            detailpage.ViewBenchMarkCharts.Click();
        }
        public static void ExcludeschoolswithIncFinanceMaintainedLaName(String urn)

        {
            Actions.CallingClass.SearchViaSchoolurn(urn);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass();
            bestinclass.DetailComparisonButton.Click();
            bestinclass.NextButton.Click();
            DetailComparisonPage detailpage = new DetailComparisonPage();
            detailpage.MaintainedRadio.Click();
            //Thread.Sleep(30000);
            //detailpage.Excludecheckbox.Click();
            bestinclass.NextButton.Click();
            detailpage.LAnameRadio.Click();
            detailpage.LANameinputfield.SendKeys("Greenwich");
            bestinclass.NextButton.Click();

            detailpage.General_Header.Click();
            detailpage.NumberOfPupilsCheckBox.Click();
            detailpage.MinNumberOfPupilsInputField.SendKeys("719");
            detailpage.MaxNumberOfPupilsInputBox.SendKeys("1200");
            Thread.Sleep(1000);
            detailpage.ViewBenchMarkCharts.Click();

        }
        public static void ExcludeschoolswithIncFinanceAcademiesLaName(String urn)
        {
            Actions.CallingClass.SearchViaSchoolurn(urn);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass();
            bestinclass.DetailComparisonButton.Click();
            bestinclass.NextButton.Click();
            DetailComparisonPage detailpage = new DetailComparisonPage();
            detailpage.AcademyRadio.Click();
            //Thread.Sleep(30000);
            //detailpage.Excludecheckbox.Click();
            bestinclass.NextButton.Click();
            detailpage.LAnameRadio.Click();
            detailpage.LANameinputfield.SendKeys("Bexley");
            bestinclass.NextButton.Click();

            detailpage.General_Header.Click();
            detailpage.NumberOfPupilsCheckBox.Click();
            detailpage.MinNumberOfPupilsInputField.SendKeys("719");
            detailpage.MaxNumberOfPupilsInputBox.SendKeys("1200");
            Thread.Sleep(1000);
            detailpage.ViewBenchMarkCharts.Click();
        }
        public static void ExcludeschoolswithIncFinanceAcademiesAllEngland(String urn, String minnumpupils, String maxnumpupils)
        {
            Actions.CallingClass.SearchViaSchoolurn(urn);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass();
            bestinclass.DetailComparisonButton.Click();
            bestinclass.NextButton.Click();
            DetailComparisonPage detailpage = new DetailComparisonPage();
            detailpage.AcademyRadio.Click();
            
            bestinclass.NextButton.Click();
            detailpage.AllOfEnglandRadio.Click();
            
            bestinclass.NextButton.Click();

            detailpage.General_Header.Click();
            detailpage.NumberOfPupilsCheckBox.Click();
            detailpage.MinNumberOfPupilsInputField.SendKeys(minnumpupils);
            Thread.Sleep(3000);
            detailpage.MaxNumberOfPupilsInputBox.SendKeys(maxnumpupils);
            Thread.Sleep(5000);
            detailpage.ViewBenchMarkCharts.Click();
            Thread.Sleep(5000);

        }
        public static void IncludeschoolswithIncFinanceMaintainedLaName(String urn, String laname, String minnumpupils, String maxnumpupils)
        {
            Actions.CallingClass.SearchViaSchoolurn(urn);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass();
            bestinclass.DetailComparisonButton.Click();
            bestinclass.NextButton.Click();
            DetailComparisonPage detailpage = new DetailComparisonPage();
            detailpage.MaintainedRadio.Click();
            //Thread.Sleep(30000);
            detailpage.MaintainedExcludecheckbox.Click();
            //Thread.Sleep(30000);
            bestinclass.NextButton.Click();
            detailpage.LAnameRadio.Click();
            detailpage.LANameinputfield.SendKeys(laname);
            bestinclass.NextButton.Click();

            detailpage.General_Header.Click();
            detailpage.NumberOfPupilsCheckBox.Click();
            detailpage.MinNumberOfPupilsInputField.SendKeys(minnumpupils);
            Thread.Sleep(6000);
            detailpage.MaxNumberOfPupilsInputBox.SendKeys(maxnumpupils);
            Thread.Sleep(2000);
            detailpage.ViewBenchMarkCharts.Click();
        }
        public static void IncludeschoolswithIncFinanceAcademiesLaName(String urn,String laname,String minpupils,String maxpupils)
        {
            Actions.CallingClass.SearchViaSchoolurn(urn);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass();
            bestinclass.DetailComparisonButton.Click();
            bestinclass.NextButton.Click();
            DetailComparisonPage detailpage = new DetailComparisonPage();
            detailpage.AcademyRadio.Click();
            //Thread.Sleep(300);
            detailpage.AcademiesExcludecheckbox.Click();
            bestinclass.NextButton.Click();
            detailpage.LAnameRadio.Click();
            detailpage.LANameinputfield.SendKeys(laname);
            bestinclass.NextButton.Click();

            detailpage.General_Header.Click();
            detailpage.NumberOfPupilsCheckBox.Click();
            detailpage.MinNumberOfPupilsInputField.SendKeys(minpupils);
            detailpage.MaxNumberOfPupilsInputBox.SendKeys(maxpupils);
            Thread.Sleep(4000);
            detailpage.ViewBenchMarkCharts.Click();
            Thread.Sleep(4000);


        }
        public static void IncludechoolswithIncFinanceAllSchoolsLaName(String urn,String laname,String minpupils,String maxpupils)
        {
            Actions.CallingClass.SearchViaSchoolurn(urn);
            SchoolDetailPage detailspage = new SchoolDetailPage();
            detailspage.CompareWithOtherSchools.Click();
            BestInClass bestinclass = new BestInClass();
            bestinclass.DetailComparisonButton.Click();
            bestinclass.NextButton.Click();
            DetailComparisonPage detailpage = new DetailComparisonPage();
            detailpage.AllschoolsRadio.Click();
            //Thread.Sleep(30000);
            detailpage.AllSchoolsExcludecheckbox.Click();
            //Thread.Sleep(30000);
            bestinclass.NextButton.Click();
            detailpage.LAnameRadio.Click();
            detailpage.LANameinputfield.SendKeys(laname);
            bestinclass.NextButton.Click();

            detailpage.General_Header.Click();
            detailpage.NumberOfPupilsCheckBox.Click();
            detailpage.MinNumberOfPupilsInputField.SendKeys(minpupils);
            Thread.Sleep(6000);
            detailpage.MaxNumberOfPupilsInputBox.SendKeys(maxpupils);
            Thread.Sleep(2000);
            detailpage.ViewBenchMarkCharts.Click();
        }
       



    }
}