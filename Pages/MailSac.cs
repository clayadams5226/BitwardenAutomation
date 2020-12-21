using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using BitwardenAutomation.Utility;
using BitwardenAutomation.Pages;

namespace BitwardenAutomation.Pages
{
    class MailSac : DriverHelper
    {
        IWebElement txtUsername => Driver.FindElement(By.Name("username"));
        IWebElement txtPassword => Driver.FindElement(By.Name("password"));
        IWebElement btnSignIn => Driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/div/div/div/form/button"));

        IWebElement lnkMailBox => Driver.FindElement(By.LinkText("bitwarden@mailsac.com"));


        public void LogIn(string userName, string password)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.SendKeys(userName);
            txtPassword.SendKeys(password);
            btnSignIn.Click();

        }

        public void clickMailBox()
        {
            lnkMailBox.Click();
        }

        public bool IsEmailReceived(String subjectOfEmail)
        {
            bool emailReceived = false;

            List<string> subjects = new List<string>();
           // List<IWebElement> subject => Driver.FindElement(By.ClassName("abc"));

            for (int i = 0; i < subjects.Count; i++)
            //for (int i = 0; i < list_Subjects.size(); i++)
            {
                if (subjects.Equals(subjectOfEmail))
                //if (subjects.get(i).getText().equalsIgnoreCase(subjectOfEmail))
                {
                    emailReceived = true;
                    break;
                }

                if (emailReceived)
                {
                    break;
                }
            }
            
    return emailReceived;
        }
    }
}
