using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using BitwardenAutomation.Utility;

namespace BitwardenAutomation.Pages
{
    class LoginPage : DriverHelper
    {
        IWebElement txtEmail => Driver.FindElement(By.Id("email"));
        IWebElement txtPassword => Driver.FindElement(By.Id("masterPassword"));
        IWebElement lnkHint => Driver.FindElement(By.LinkText("Get master password hint"));
        IWebElement chkRemember => Driver.FindElement(By.Id("rememberEmail"));
        IWebElement btnLogin => Driver.FindElement(By.XPath("/html/body/app-root/app-frontend-layout/app-login/form/div/div/div/div/div[4]/button"));
        IWebElement btnCreateAccount => Driver.FindElement(By.XPath("/html/body/app-root/app-frontend-layout/app-login/form/div/div/div/div/div[4]/a"));
        IWebElement btnSSO => Driver.FindElement(By.XPath("/html/body/app-root/app-frontend-layout/app-login/form/div/div/div/div/div[5]/a"));

        public void EnterUserNameAndPassword(string userName, string password)
        {
            txtEmail.Clear();
            txtPassword.Clear();
            txtEmail.SendKeys(userName);
            txtPassword.SendKeys(password);
        }

        public void ClickRemember()
        {
            chkRemember.Click();
        }

        public void ClickHint()
        {
            lnkHint.Click();
        }
        public void ClickLogin()
        {
            btnLogin.Click();
        }

        public void ClickCreate()
        {
            btnCreateAccount.Click();
        }

        public void ClickSSO()
        {
            btnSSO.Click();
        }

    }
}
