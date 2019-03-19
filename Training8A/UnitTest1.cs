using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Training8A.Utilities;

namespace Training8A
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]
        public void TestingWithoutSpecflow()
        {

            IWebDriver Driver;

            Driver = new ChromeDriver();

            Driver.Navigate().GoToUrl("http://blueskycitadel.com/test-form-for-bluesky-automation-training/");
            Driver.Manage().Window.Maximize();

            Driver.FindElement(By.CssSelector("#nf-field-26")).SendKeys("Myname");
            SelectElement selectbox = new SelectElement(Driver.FindElement(By.Id("nf-field-41")));
            selectbox.SelectByText("Two");

            SelectElement selectbox2 = new SelectElement(Driver.FindElement(By.Id("nf-field-43")));
            selectbox2.SelectByText("Three");
        }
    }
}
