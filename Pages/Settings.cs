using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using BitwardenAutomation.Utility;
using OpenQA.Selenium.Interactions;


namespace BitwardenAutomation.Pages
{
    class Settings : DriverHelper
    {
        IWebElement txtName => Driver.FindElement(By.Id("name"));
        IWebElement txtHint => Driver.FindElement(By.Id("masterPasswordHint"));
        IWebElement btnSave => Driver.FindElement(By.CssSelector("body > app-root > app-user-layout > app-settings > div > div > div.col-9 > app-account > app-profile > form > button"));
        IWebElement txtChangeEmailPassword => Driver.FindElement(By.Id("masterPassword"));
        IWebElement txtNewEmail => Driver.FindElement(By.Id("newEmail"));
        IWebElement btnContinue => Driver.FindElement(By.CssSelector("body > app-root > app-user-layout > app-settings > div > div > div.col-9 > app-account > app-change-email > form > button"));
        IWebElement txtCurrentMasterPassword => Driver.FindElement(By.Id("currentMasterPassword"));
        IWebElement btnDeleteAccount => Driver.FindElement(By.CssSelector("button.btn-outline-danger:nth-child(4)"));
        IWebElement txtDeleteMasterPassword => Driver.FindElement(By.XPath("/html/body/app-root/app-user-layout/app-settings/div/div/div[2]/app-account/app-modal/app-delete-account/div/div/form/div[2]/input"));
        IWebElement btnConfirmDelete => Driver.FindElement(By.CssSelector("button.btn:nth-child(1)"));
        IWebElement btnCancel => Driver.FindElement(By.XPath("/html/body/app-root/app-user-layout/app-settings/div/div/div[2]/app-account/app-modal/app-delete-account/div/div/form/div[3]/button[2]"));

        public void ClickDeleteAccount()
        {
            btnDeleteAccount.Click();
        }
        public void ConfirmDeleteAccount()
        {

            txtDeleteMasterPassword.SendKeys("password01");
            btnConfirmDelete.Click();  
        }
    }

}
