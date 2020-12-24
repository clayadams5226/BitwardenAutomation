using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace BitwardenAutomation.Utility
{
    public class DriverHelper
    {
        public static IWebDriver driver;

        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method InitBrowser.");
                return driver;
            }
            private set
            {
                driver = value;
            }
        }

        public static void InitBrowser()
        //TODO Make this a switch statement for different browsers.
        {
            driver = new ChromeDriver();
        }
    }
}
