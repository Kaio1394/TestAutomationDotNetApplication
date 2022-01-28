using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Threading;

namespace WinFormUITesting
{
    [TestClass]
    public class UnitTest1
    {
        public WindowsDriver<WindowsElement> element;

        [TestInitialize]
        public void Init()
        {
            AppiumOptions appOptions = new AppiumOptions();
            appOptions.AddAdditionalCapability("app", Properties.Resources.ApplicationApp);
            element = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/"), appOptions);
        }

        [TestCleanup]
        public void CleanUp()
        {
            element.Quit();
        }
        [TestMethod]
        public void CheckBoxTest()
        {
            var check = element.FindElementByName("checkBox1");
            check.Click();
            Thread.Sleep(3000);
        }

    }
}
