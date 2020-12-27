using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using BitwardenAutomation.Utility;

namespace BitwardenAutomation.Pages
{
    class Settings : DriverHelper
    {
        IWebElement btnDeleteAccount => Driver.FindElement(By.CssSelector("button.btn-outline-danger:nth-child(4)"));
        IWebElement txtMasterPassword => Driver.FindElement(By.XPath("//*[@id=\"masterPassword\"]"));
        IWebElement btnConfirmDelete => Driver.FindElement(By.CssSelector("button.btn:nth-child(1)"));

        public void ClickDeleteAccount()
        {
            btnDeleteAccount.Click();
        }
        public void ConfirmDeleteAccount(string password)
        {

            txtMasterPassword.SendKeys("password01");
            btnConfirmDelete.Click();
            
        }
    }

}
