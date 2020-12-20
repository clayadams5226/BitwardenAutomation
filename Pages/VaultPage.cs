using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using BitwardenAutomation.Utility;

namespace BitwardenAutomation.Pages
{
    class VaultPage : DriverHelper
    {
        IWebElement lnkSend => Driver.FindElement(By.LinkText("Send"));
        IWebElement lnkTools => Driver.FindElement(By.LinkText("Tools"));
        IWebElement lnkSettings => Driver.FindElement(By.LinkText("Settings"));



        public String getURL()
        {
            String URL = Driver.Url;
            return URL;
        }
    }
}
