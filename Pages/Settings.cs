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
        IWebElement txtnewMasterPassword => Driver.FindElement(By.Name("NewMasterPasswordHash"));
        IWebElement txtconfirmNewPassword => Driver.FindElement(By.Name("MasterPasswordRetype"));
        IWebElement cbRotateKeys => Driver.FindElement(By.Id("rotateEncKey"));
        IWebElement btnChangeMasterPassword => Driver.FindElement(By.CssSelector("body > app-root > app-user-layout > app-settings > div > div > div.col-9 > app-account > app-change-password > form > button"));
        IWebElement txtEncryptionKeyPassword => Driver.FindElement(By.Id("kdfMasterPassword"));
        IWebElement ddlKDFAlgorithm => Driver.FindElement(By.Id("kdf"));
        IWebElement txtIterations => Driver.FindElement(By.Id("kdfIterations"));
        IWebElement btnChangeKDF => Driver.FindElement(By.CssSelector("body > app-root > app-user-layout > app-settings > div > div > div.col-9 > app-account > app-change-kdf > form > button"));
        IWebElement btnViewAPI => Driver.FindElement(By.CssSelector("body > app-root > app-user-layout > app-settings > div > div > div.col-9 > app-account > button:nth-child(11)"));
        IWebElement btnRoateAPI => Driver.FindElement(By.CssSelector("body > app-root > app-user-layout > app-settings > div > div > div.col-9 > app-account > button:nth-child(12)"));
        IWebElement btnDeauthorize => Driver.FindElement(By.CssSelector("body > app-root > app-user-layout > app-settings > div > div > div.col-9 > app-account > div.card.border-danger > div > button:nth-child(2)"));
        IWebElement btnPurge => Driver.FindElement(By.CssSelector("body > app-root > app-user-layout > app-settings > div > div > div.col-9 > app-account > div.card.border-danger > div > button:nth-child(3)"));
        IWebElement btnDeleteAccount => Driver.FindElement(By.CssSelector("button.btn-outline-danger:nth-child(4)"));
        IWebElement txtDeleteMasterPassword => Driver.FindElement(By.XPath("/html/body/app-root/app-user-layout/app-settings/div/div/div[2]/app-account/app-modal/app-delete-account/div/div/form/div[2]/input"));
        IWebElement btnConfirmDelete => Driver.FindElement(By.CssSelector("button.btn:nth-child(1)"));
        IWebElement btnCancel => Driver.FindElement(By.XPath("/html/body/app-root/app-user-layout/app-settings/div/div/div[2]/app-account/app-modal/app-delete-account/div/div/form/div[3]/button[2]"));


        public void ClickDeleteAccount()
        {
            btnDeleteAccount.Click();
        }
        public void ConfirmDeleteAccount(string password)
        {

            txtDeleteMasterPassword.SendKeys(password);
            btnConfirmDelete.Click();  
        }
    }

}
