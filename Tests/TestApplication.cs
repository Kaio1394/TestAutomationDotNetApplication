using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            appOptions.AddAdditionalCapability("app", Properties.Resources.ApplicationAppWithGrid);
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
            var combo = element.FindElementByName("comBox1");
            var open = combo.FindElementByName("Abrir");
            combo.SendKeys(Keys.Down);
            var listItems = combo.FindElementByTagName("ListItem");

            open.Click();

            listItems = combo.FindElementByTagName("ListItem");
            foreach (var item in listItems)
            {
                if (item.Text == "NJ")
                {
                    item.Click();
                }
            }
        }

        [TestMethod]
        public void MenuTest()
        {
            element.FindElementByName("File").Click();
            element.FindElementByName("New").Click(); 
            element.FindElementByName("First").Click();
        }

        [TestMethod]
        public void GridTest()
        {
            var ratesGrid = element.FindElementByName("Rates Grid");
            var allHeaders = ratesGrid.FindElementByTagName("Header");

            Debug.WriteLine($"Headers count: {allHeaders.Count()}");

            foreach (var item in allHeaders)
            {

            }
        }


    }
}
