using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Threading;

namespace WinFormUITesting
{
    [TestClass]
    public class TestApplication
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

        [TestMethod]
        public void RadioButtonTest()
        {
            var check = element.FindElementByName("First");
            check.Click();
            Thread.Sleep(3000);
        }

        [TestMethod]
        public void ComboTest()
        {
            var combo = element.FindElementByClassName("Edit");
            var open = combo.FindElementByName("Abrir");
            combo.SendKeys(Keys.Down);

            open.Click();
            var listItems = combo.FindElementByTagName("ListItem");
            Thread.Sleep(3000);
        }


    }
}
