using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BookLibrary.Selenium.Base
{
    public abstract class BasePage
    {
        protected IWebDriver Driver;
        protected WebDriverWait DriverWait;

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            // wait 30 seconds.
            DriverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
        }

        public virtual string Url 
        {
            get
            {
                return string.Empty;
            }
        }

        public virtual void Open(string part = "")
        {
            if (string.IsNullOrEmpty(Url))
            {
                throw new ArgumentException("The main URL cannot be null or empty.");
            }
            Driver.Navigate().GoToUrl(string.Concat(Url, part));
        }
    }
}