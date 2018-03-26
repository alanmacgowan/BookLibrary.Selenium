using BookLibrary.Selenium.Base;
using OpenQA.Selenium;

namespace BookLibrary.Selenium.Pages
{
    public partial class BooksPage : BasePage
    {
        public BooksPage(IWebDriver driver) : base(driver)
        {
        }

        public override string Url => "https://localhost:44386/Book";

    }
}