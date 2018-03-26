using BookLibrary.Selenium.Base;
using BookLibrary.Selenium.Core;
using BookLibrary.Selenium.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using Unity.Lifetime;
using Unity;

namespace BookLibrary.Selenium
{
    [Binding]
    public sealed class OrderHooks
    {
        // Reuse browser for the whole run.
        [BeforeTestRun(Order = 1)]
        public static void RegisterPages()
        {
            Console.WriteLine("BeforeTestRun");
            Driver.StartBrowser(BrowserTypes.Chrome);
            UnityContainerFactory.GetContainer().RegisterType<HomePage>(new ContainerControlledLifetimeManager());
            UnityContainerFactory.GetContainer().RegisterType<BooksPage>(new ContainerControlledLifetimeManager());
        }

        [BeforeTestRun(Order = 2)]
        public static void RegisterDriver()
        {
            Console.WriteLine("Execute BeforeTestRun- RegisterDriver");
            UnityContainerFactory.GetContainer().RegisterInstance<IWebDriver>(Driver.Browser);
        }

        // Reuse browser for the whole run.
        [AfterTestRun]
        public static void AfterTestRun()
        {
            Console.WriteLine("AfterTestRun");
            Driver.StopBrowser();
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            Console.WriteLine("BeforeFeature");
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            Console.WriteLine("AfterFeature");
        }

        [BeforeScenario]
        public void LoginUser()
        {
            Console.WriteLine("BeforeScenario");
        }

        [AfterScenario(Order = 1)]
        public void AfterScenario()
        {
            Console.WriteLine("AfterScenario");
        }

        [BeforeStep]
        public void BeforeStep()
        {
            Console.WriteLine("BeforeStep");
        }

        [AfterStep]
        public void AfterStep()
        {
            Console.WriteLine("AfterStep");
        }
    }
}
