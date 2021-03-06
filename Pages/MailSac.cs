﻿using NUnit.Framework;
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
        IWebElement lnkMailBox2 => Driver.FindElement(By.LinkText("bitwarden2@mailsac.com"));

        IWebElement lnksubject => Driver.FindElement(By.CssSelector("body > div > div.container-fluid > div.ng-scope > div > div.row > div > table > tbody > tr.clickable.ng-scope > td.col-xs-5.ng-binding"));
        IWebElement btnDeleteMail => Driver.FindElement(By.CssSelector("body > div > div.container-fluid > div.ng-scope > div > div.row > div > table > tbody > tr:nth-child(2) > td.active.not-clickable > div.btn-group.pull-right > button:nth-child(4)"));
        IWebElement btnConfirmDelete => Driver.FindElement(By.CssSelector("body > div > div.container-fluid > div.ng-scope > div > div.row > div > table > tbody > tr:nth-child(2) > td.active.not-clickable > div.btn-group.pull-right > button:nth-child(5)"));

        public void LogIn(string userName, string password)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.SendKeys(userName);
            txtPassword.SendKeys(password);
            btnSignIn.Click();

        }

        public void ClickMaiBox()
        {
            lnkMailBox.Click();
        }
        public void ClickMailBox2()
        {
            lnkMailBox2.Click();
        }
        public void ClickMail()
        {
            lnksubject.Click();
        }
        public void ClickDelete()
        {
            btnDeleteMail.Click();
        }
        public void ConfirmDelete()
        {
            btnConfirmDelete.Click();
        }

        public bool IsEmailReceived(String subjectOfEmail)
        {
            bool emailReceived = false;

            {
                if (lnksubject.Text.Equals(subjectOfEmail))
                {
                    emailReceived = true;
                }
            }

            return emailReceived;
        }

        public void DeleteEmail()
        {
            ClickMail();
            ClickDelete();
            ConfirmDelete();
        }
    }
}
