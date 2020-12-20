using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using BitwardenAutomation.Utility;
namespace BitwardenAutomation.Pages
{
    class VaultPage : DriverHelper
    {
           

        public String getURL()
        {
            String URL = Driver.Url;
            return URL;
        }
    }
}
