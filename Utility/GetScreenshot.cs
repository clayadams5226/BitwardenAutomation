using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OpenQA.Selenium;
using NUnit.Framework;

namespace BitwardenAutomation.Utility
{
    public class GetScreenshot : DriverHelper
    {
        public static Screenshot screenshot;

        public static Screenshot Screenshot
        {
            get
            {
                return screenshot;
            }
            private set
            {
                screenshot = value;
            }
        }
        public static void TakeScreenshot()
        {
            Screenshot testCase = ((ITakesScreenshot)Driver).GetScreenshot();
            string screenshotDirectory = Directory.GetCurrentDirectory() + @"\screenshots";
            string currentTestCase = TestContext.CurrentContext.Test.Name.ToString();


            if (Directory.Exists(screenshotDirectory))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\screenshots");
            }

            testCase.SaveAsFile(Directory.GetCurrentDirectory() + @"\screenshots\" + currentTestCase + ".png", ScreenshotImageFormat.Png);
        }
    }
}
