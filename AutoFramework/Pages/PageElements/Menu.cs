namespace AutoFramework.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class Menu
    {
        public Menu()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

      

    }
}
