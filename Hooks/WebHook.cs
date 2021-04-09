using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AutomationTest.Hooks
{
    [Binding]
    public static class WebHook
    {
        public static IWebDriver driver;

        
        [BeforeScenario]
        public static void BeforeScenario()
            
        {
            driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
        }

        [AfterScenario]
        public static void AfterScenario()
        {
           //driver.Quit();
        }

       

    }
}
