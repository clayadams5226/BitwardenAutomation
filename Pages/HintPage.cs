using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using BitwardenAutomation.Utility;

namespace BitwardenAutomation.Pages
{
    class HintPage : DriverHelper
    {
        IWebElement txtEmail => Driver.FindElement(By.Id("email"));
        IWebElement btnSubmit => Driver.FindElement(By.CssSelector("body > app-root > app-frontend-layout > app-hint > form > div > div > div > div > div.d-flex > button"));
        IWebElement btnCancel => Driver.FindElement(By.CssSelector("body > app-root > app-frontend-layout > app-hint > form > div > div > div > div > div.d-flex > a"));

        public void enterEmail(string email)
        {
            txtEmail.SendKeys(email);
        }

        public void clickSubmit()
        {
            btnSubmit.Click();
        }

        public void clickCancel()
        {
            btnCancel.Click();
        }
    }
}
