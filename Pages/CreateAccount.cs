using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using BitwardenAutomation.Utility;
namespace BitwardenAutomation.Pages
{
    class CreateAccount : DriverHelper
    {
        IWebElement txtEmail => Driver.FindElement(By.Id("email"));
        IWebElement txtName => Driver.FindElement(By.Id("name"));
        IWebElement txtMasterPassword => Driver.FindElement(By.Id("masterPassword"));
        IWebElement txtConfirmPassword => Driver.FindElement(By.Id("masterPasswordRetype"));
        IWebElement txtPasswordHint => Driver.FindElement(By.Id("hint"));

        IWebElement btnSubmit => Driver.FindElement(By.CssSelector(".btn-primary"));
        IWebElement btnCancel => Driver.FindElement(By.CssSelector("a.btn"));
        IWebElement alrtWeakYes => Driver.FindElement(By.CssSelector(".swal2-confirm"));
        IWebElement alrtWeakNo => Driver.FindElement(By.CssSelector(".swal2-cancel"));

        public void enterAccountInfo(string email, string name, string password, string hint)
        {
            txtEmail.SendKeys(email);
            txtMasterPassword.SendKeys(password);
            txtConfirmPassword.SendKeys(password);
            txtPasswordHint.SendKeys(hint);
        }

        public void ClickYesOnAlert()
        {
            alrtWeakYes.Click();
        }
        public void ClickNoOnAlert()
        {
            alrtWeakNo.Click();
        }

        public void ClickSubmit()
        {
            btnSubmit.Click();
        }

        public void clickCancel()
        {
            btnCancel.Click();
        }
    }
}
