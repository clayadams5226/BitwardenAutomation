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
        string email = "cadams+test2@bitwarden.com";
        string password = "password01";

        [SetUp]
        public void Setup()
        {
            DriverHelper.InitBrowser();
            Driver.Navigate().GoToUrl("https://testdo.bitwarden.com");
        }

        [Test]
        public void Login()
        {
            

            //Change to implicent wait and put into method
            Thread.Sleep(1000);

            LoginPage loginPage = new LoginPage();
            VaultPage vaultPage = new VaultPage();

            loginPage.EnterUserNameAndPassword(email, password);
            loginPage.ClickLogin();

            //Change to implicent wait and put into method
            Thread.Sleep(3000);

            Assert.AreEqual(vaultPage.getURL(), "https://testdo.bitwarden.com/#/vault", "URL doesn't match");

        }

        [Test]
        public void passwordHint()
        {
            LoginPage loginPage = new LoginPage();
            HintPage hintPage = new HintPage();

            //Change to implicent wait and put into method
            Thread.Sleep(3000);

            loginPage.ClickHint();
            hintPage.enterEmail(email);
            hintPage.clickSubmit();
            //TODO Check email 
        }
    }
}