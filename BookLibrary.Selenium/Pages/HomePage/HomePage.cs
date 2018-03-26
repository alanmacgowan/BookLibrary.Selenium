using BookLibrary.Selenium.Base;
using OpenQA.Selenium;

namespace BookLibrary.Selenium.Pages
{
    public partial class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public override string Url => "https://localhost:44386/";


    }
}