using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using BitwardenAutomation.Utility;
using BitwardenAutomation.Pages;
using System.Threading;
using System.IO;
using System.Linq;
using OpenQA.Selenium.Support.UI;

namespace BitwardenAutomation
{
    public class Tests : DriverHelper
    {
        string email = "cadams+test2@bitwarden.com";
        string password = "password01";

        [OneTimeSetUp]
        public void Setup()
        {  
            DriverHelper.InitBrowser();
            Driver.Navigate().GoToUrl("https://testdo.bitwarden.com");
        }

      
  [Test, Order(1)]
        public void passwordHint()
        {
            LoginPage loginPage = new LoginPage();
            HintPage hintPage = new HintPage();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            loginPage.ClickHint();
            hintPage.enterEmail("bitwarden@mailsac.com");
            hintPage.clickSubmit();
            hintPage.clickCancel();

            /*
             TODO Set this up in a new Tab
             Driver.FindElement(By.TagName("body")).SendKeys(Keys.Control + "t");
             Driver.SwitchTo().Window(Driver.WindowHandles.Last());
            */

            Driver.Navigate().GoToUrl("https://mailsac.com/login");
            MailSac mailSac = new MailSac();
            mailSac.LogIn("mad5226", "password01");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            mailSac.clickMailBox();
            bool emailRecieved = mailSac.IsEmailReceived("Your Master Password Hint");

            //TODO: Delete email after confirming, Close Tab and Continue testing
            Assert.That(emailRecieved, Is.True, "Can't find the email");

            //TODO: Change to only take screenshot of failed test cases
            GetScreenshot.TakeScreenshot();
            
        }

        [Test, Order(2)]
        public void InvalidLogin()
        {
            Driver.Navigate().GoToUrl("https://testdo.bitwarden.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            LoginPage loginPage = new LoginPage();
            loginPage.EnterUserNameAndPassword(email, "password");
            loginPage.ClickLogin();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Assert.IsTrue(loginPage.FailedLogin(), "Message not present.");
        }
      

        [Test, Order(3)]
        public void Login()
        {
            Driver.Navigate().GoToUrl("https://testdo.bitwarden.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            LoginPage loginPage = new LoginPage();
            VaultPage vaultPage = new VaultPage();

            loginPage.EnterUserNameAndPassword(email, password);
            loginPage.ClickLogin();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Assert.AreEqual(Driver.Url, "https://testdo.bitwarden.com/#/vault", "URL doesn't match");
            GetScreenshot.TakeScreenshot();

        }
/*
        [Test, Order(3)]
        public void SideBar()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            VaultPage vaultPage = new VaultPage();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            vaultPage.ClickFavorites();
            vaultPage.clickTrash();
            vaultPage.ClickLogin();
            vaultPage.ClickCard();
            vaultPage.ClickIdentity();
            vaultPage.ClickSecureNote();
            vaultPage.ClickAllItems();

            Assert.AreEqual(Driver.Url, "https://testdo.bitwarden.com/#/vault", "URL doesn't match");
            GetScreenshot.TakeScreenshot();


        }
*/
        [Test, Order(4)]
        public void LockVault()
        {
            NavBar navBar = new NavBar();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            navBar.ClickLockNow();
            Assert.AreEqual(Driver.Url, "https://testdo.bitwarden.com/#/lock", "URL doesn't match");
        }
        [Test, Order(5)]
        public void LogOut()
        {
            NavBar navBar = new NavBar();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            navBar.ClickLogOut();
            Assert.AreEqual(Driver.Url, "https://testdo.bitwarden.com/#/", "URL doesn't match");
        }

        [Test, Order(6)]
        public void CreateAccount()
        {
            LoginPage loginPage = new LoginPage();
            CreateAccount account = new CreateAccount();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            loginPage.ClickCreate();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            account.enterAccountInfo("bitwarden2@mailsac.com", "Test Account 2", "password01", "The Hint");
            account.ClickSubmit();
            account.ClickYesOnAlert();


            Driver.Navigate().GoToUrl("https://mailsac.com/login");
            MailSac mailSac = new MailSac();
            mailSac.LogIn("mad5226", "password01");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            mailSac.clickMailBox2();
            bool emailRecieved = mailSac.IsEmailReceived("Welcome");

            //TODO: Delete email after confirming, Close Tab and Continue testing
            Assert.That(emailRecieved, Is.True, "Can't find the email");

            //TODO: Change to only take screenshot of failed test cases
            GetScreenshot.TakeScreenshot();
        }
        
        /* TODO: This this to work
        [Test, Order(7)]
        public void DeleteAccount()
        {
            Driver.Navigate().GoToUrl("https://testdo.bitwarden.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            LoginPage loginPage = new LoginPage();
            NavBar navBar = new NavBar();
            Settings settings = new Settings();

            loginPage.EnterUserNameAndPassword("bitwarden2@mailsac.com", "password01");
            loginPage.ClickLogin();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            navBar.ClickMyAccount();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            settings.ClickDeleteAccount();

            settings.ConfirmDeleteAccount("password01");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Assert.AreEqual(Driver.Url, "https://testdo.bitwarden.com/#/", "URL doesn't match");
        }
        */
    }
}