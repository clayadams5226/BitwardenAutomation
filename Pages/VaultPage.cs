using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using BitwardenAutomation.Utility;
using OpenQA.Selenium.Support.UI;

namespace BitwardenAutomation.Pages
{
    class VaultPage : DriverHelper
    {
        IWebElement lnkAllItems => Driver.FindElement(By.LinkText("All Items"));
        IWebElement lnkFavorites => Driver.FindElement(By.LinkText("Favorites"));
        IWebElement lnkTrash => Driver.FindElement(By.LinkText("Trash"));
        IWebElement lnkLogin => Driver.FindElement(By.LinkText("Login"));
        IWebElement lnkCard => Driver.FindElement(By.LinkText("Card"));
        IWebElement lnkIdentity => Driver.FindElement(By.LinkText("Identity"));
        IWebElement lnkSecureNote => Driver.FindElement(By.LinkText("Secure Note"));

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
    }
}
