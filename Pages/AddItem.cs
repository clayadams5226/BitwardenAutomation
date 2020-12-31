using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using BitwardenAutomation.Utility;

namespace BitwardenAutomation.Pages
{
    class AddItem : DriverHelper
    {
        IWebElement ddlType => Driver.FindElement(By.Id("type"));
        IWebElement txtName => Driver.FindElement(By.Id("name"));
        IWebElement ddlFolder => Driver.FindElement(By.Id("folder"));
        IWebElement txtUsername => Driver.FindElement(By.Id("loginUsername"));
        IWebElement txtPassword => Driver.FindElement(By.Id("loginPassword"));
        IWebElement txtTOTP => Driver.FindElement(By.Id("loginTotp"));
        IWebElement txtURI1 => Driver.FindElement(By.CssSelector("#loginUri0"));
        IWebElement lnkNewURI => Driver.FindElement(By.LinkText("New URI"));
        IWebElement ddlMatchDetection => Driver.FindElement(By.CssSelector("#loginUriMatch0"));
        IWebElement txtNotes => Driver.FindElement(By.Id("notes"));
        IWebElement lnkNewCustomField => Driver.FindElement(By.LinkText("New Custom Field"));
        IWebElement ddlCustomField => Driver.FindElement(By.Id("addFieldType"));
        IWebElement btnSave => Driver.FindElement(By.CssSelector("body > app-root > app-user-layout > app-vault > app-modal > app-vault-add-edit > div > div > form > div.modal-footer > button.btn.btn-primary.btn-submit.ng-star-inserted"));
        IWebElement btnCancel => Driver.FindElement(By.CssSelector("body > app-root > app-user-layout > app-vault > app-modal > app-vault-add-edit > div > div > form > div.modal-footer > button.btn.btn-outline-secondary"));
        public void ClickSave()
        {
            btnSave.Click();
        }
        public void ClickCancel()
        {
            btnCancel.Click();
        }
    }
}
