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
        IWebElement lnkAllItems => Driver.FindElement(By.LinkText("All Items"));
        IWebElement lnkFavorites => Driver.FindElement(By.LinkText("Favorites"));
        IWebElement lnkTrash => Driver.FindElement(By.LinkText("Trash"));
        IWebElement lnkLogin => Driver.FindElement(By.LinkText("Login"));
        IWebElement lnkCard => Driver.FindElement(By.LinkText("Card"));
        IWebElement lnkIdentity => Driver.FindElement(By.LinkText("Identity"));
        IWebElement lnkSecureNote => Driver.FindElement(By.LinkText("Secure Note"));

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

        public void ClickAllItems()
        {
            lnkAllItems.Click();
        }

        public void ClickFavorites()
        {
            lnkFavorites.Click();
        }

        public void clickTrash()
        {
            lnkTrash.Click();
        }

        public void ClickLogin()
        {
            lnkLogin.Click();
        }

        public void ClickCard()
        {
            lnkCard.Click();
        }

        public void ClickIdentity()
        {
            lnkIdentity.Click();
        }

        public void ClickSecureNote()
        {
            lnkSecureNote.Click();
        }

        public String getURL()
        {
            String URL = Driver.Url;
            return URL;
        }
    }
}
