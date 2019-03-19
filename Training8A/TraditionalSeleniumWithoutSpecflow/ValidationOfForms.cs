using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Training8A.Utilities;

namespace Training8A.TraditionalSeleniumWithoutSpecflow
{
    [TestClass]
    public class ValidationOfForms
    {
        [TestMethod]
        public void ValidateTestWITHWAITS()
        {
            OpenQA.Selenium.IWebDriver Driver;

            Driver = new ChromeDriver();

            Driver.Navigate().GoToUrl("http://blueskycitadel.com/test-form-for-bluesky-automation-training/");
            Driver.Manage().Window.Maximize();

            //
            Driver.FindElement(By.Id("nf-field-26")).SendKeys("My Firstname");

            Driver.FindElement(By.Id("nf-field-27")).SendKeys("My Lastname");

            SelectElement multiselect = new SelectElement(Driver.FindElement(By.Id("nf-field-41")));

            multiselect.SelectByValue("one");


            multiselect.SelectByText("Three");

            new SelectElement(Driver.FindElement(By.Id("nf-field-43"))).SelectByValue("two");

            Driver.FindElement(By.XPath("//*[@id='nf-field-31-0']")).Click();

            Driver.FindElement(By.CssSelector("#nf-field-44")).SendKeys("My long paragragh end here");

            Driver.FindElement(By.Id("nf-field-37")).Click();

            //validate if message is displayed

            //1. find the element
            //Driver.FindElement(By.CssSelector("#nf-form-4-cont > div > div.nf-response-msg > p"));

            //2. Add the action to perform on the element
            //Driver.FindElement(By.CssSelector("#nf-form-4-cont > div > div.nf-response-msg > p")).Displayed;

            //1. Thread.sleep
            // Thread.Sleep(5000);

            //Implicit waits
            //Tell your WebDriver to poll the DOM for certain amount of time in order to find the element
            //By default it is set to zero

            //When do I need to wait / When is it required

            //a) For you page to load
            //b) For a java script or ajax to finish
            //c) when new form or message is displayed/uploaded onto a form

            //2
            //Implicit waits
            /*
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //3
            //Explicit Wait

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));

            Func<IWebDriver, bool> waitForElement = new Func<IWebDriver, bool>((IWebDriver web) =>
            {
                web.FindElement(By.CssSelector("#nf-form-4-cont > div > div.nf-response-msg > p"));
                return web.FindElement(By.CssSelector("#nf-form-4-cont > div > div.nf-response-msg > p")).Displayed;
            });
            */
            WaitForElements wait = new WaitForElements();

            //waitForElements.FluentWaitWithFindElements(Driver, Driver.FindElement(By.CssSelector("#nf-form-4-cont > div > div.nf-response-msg > p")));
            wait.FluentWaitForElementByCSS(Driver, "#nf-form-4-cont > div > div.nf-response-msg > p");

            //4 Fluent Wait

            //5.Using Predicate 


            //3. Assert the displayed object
            Assert.IsTrue(Driver.FindElement(By.CssSelector("#nf-form-4-cont > div > div.nf-response-msg > p")).Displayed);

            Assert.IsTrue(Driver.FindElement(By.CssSelector("#nf-form-4-cont > div > div.nf-response-msg > p")).Displayed, "The message is not displayed");

            Driver.Close();


            //Waiting


            //Thread.Sleep(5000)


            //Explicit and Inmplicit wait


            //Fluent Waits

        }
    }
}
