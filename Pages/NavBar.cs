using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using BitwardenAutomation.Utility;

namespace BitwardenAutomation.Pages
{
    class NavBar : DriverHelper
    {
        IWebElement lnkVault => Driver.FindElement(By.LinkText("My Vault"));
        IWebElement lnkSend => Driver.FindElement(By.LinkText("Send"));
        IWebElement lnkTools => Driver.FindElement(By.LinkText("Tools"));
        IWebElement lnkSettings => Driver.FindElement(By.LinkText("Settings"));
        IWebElement ddlProfile => Driver.FindElement(By.Id("nav-profile"));
        IWebElement ddlMyAccount => Driver.FindElement(By.LinkText("My Account"));
        IWebElement ddlGetHelp => Driver.FindElement(By.LinkText("Get Help"));
        IWebElement ddlGetTheApps => Driver.FindElement(By.CssSelector("body > app-root > app-user-layout > app-navbar > nav > div > ul > li > div > a:nth-child(5)"));
        IWebElement ddlLockNow => Driver.FindElement(By.CssSelector("body > app-root > app-user-layout > app-navbar > nav > div > ul > li > div > button:nth-child(7)"));
        IWebElement ddlLogOut => Driver.FindElement(By.CssSelector("body > app-root > app-user-layout > app-navbar > nav > div > ul > li > div > button:nth-child(8)"));
        public void ClickMyVault()
        {
            lnkVault.Click();
        }
        public void CickSend()
        {
            lnkSend.Click();
        }

        public void ClickTools()
        {
            lnkTools.Click();
        }

        public void ClickSettings()
        {
            lnkSettings.Click();
        }
        public void ClickMyAccount()
        {
            ddlProfile.Click();
            ddlMyAccount.Click();
        }

        public void ClickGetHelp()
        {
            ddlProfile.Click();
            ddlGetHelp.Click();
        }

        public void ClickGetApps()
        {
            ddlProfile.Click();
            ddlGetTheApps.Click();
        }

        public void ClickLockNow()
        {
            ddlProfile.Click();
            ddlLockNow.Click();
        }

        public void ClickLogOut()
        {
            ddlProfile.Click();
            ddlLogOut.Click();
        }
    }
}
