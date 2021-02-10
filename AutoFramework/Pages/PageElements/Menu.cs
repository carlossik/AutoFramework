namespace AutoFramework.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class Menu
    {
        public Menu(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

      

    }
}
