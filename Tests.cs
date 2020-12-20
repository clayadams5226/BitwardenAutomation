using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using BitwardenAutomation.Utility;
using BitwardenAutomation.Pages;
using System.Threading;

namespace BitwardenAutomation
{
    public class Tests : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            DriverHelper.InitBrowser();
        }

        [Test]
        public void Login()
        {
            string email = "cadams+test2@bitwarden.com";
            string password = "password01";

            Driver.Navigate().GoToUrl("https://testdo.bitwarden.com");

            //Change to implicent wait and put into method
            Thread.Sleep(1000);

            LoginPage loginPage = new LoginPage();
            VaultPage vaultPage = new VaultPage();

            loginPage.EnterUserNameAndPassword(email, password);
            loginPage.ClickLogin();

            //Change to implicent wait and put into method
            Thread.Sleep(1000);

            Assert.AreEqual(vaultPage.getURL(), "https://testdo.bitwarden.com/#/vault", "URL doesn't match");

        }
    }
}