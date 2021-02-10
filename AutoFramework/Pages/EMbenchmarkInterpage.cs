using AutoFramework;
using AutoFramework.Pages.PageElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SFB_Test_Automation.AutoFramework.Pages
{
    class EMbenchmarkInterpage
    {

        public EMbenchmarkInterpage(IWebDriver driver)
        {
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
        }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "top-schools")]
        public IWebElement CompareGaianst30Percent { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "manual")]
        public IWebElement ManuallySelectSchools { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".govuk-grid-column-full > button:nth-child(1)")]
        public IWebElement Continue { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = ".govuk-link--no-visited-state")]
        public IWebElement BackButton { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "li.govuk-breadcrumbs__list-item:nth-child(1) > a:nth-child(1)")]
        public IWebElement HomeBreadCrumb { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "li.govuk-breadcrumbs__list-item:nth-child(2) > a:nth-child(1)")]
        public IWebElement SchoolBreadCrumb { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "li.govuk-breadcrumbs__list-item:nth-child(3) > a:nth-child(1)")]
        public IWebElement Introduction_To_Efficiency_Metric_BreadCrumb { get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "li.govuk-breadcrumbs__list-item:nth-child(4) > a:nth-child(1)")]
        public IWebElement EfficiencyMetricBreadCrumb { get; set; }
    }
}
