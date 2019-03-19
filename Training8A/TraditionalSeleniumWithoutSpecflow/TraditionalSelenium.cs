using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Support.UI;

namespace Training8A.TraditionalSeleniumWithoutSpecflow
{
    [TestClass]
    public class TraditionalSelenium
    {
        [TestMethod]
        public void BlueSkyFormValidationWITHOUTSPECFLOW()
        {
            //1. Create instance of the browser
            IWebDriver Driver;

            //2. Open the Browser

            //Driver = new ChromeDriver();  //For Chrome
            //Driver = new SafariDriver();

            //InternetExplorerDriver driver = new InternetExplorerDriver();
            //Driver = new InternetExplorerDriver();

            // System.setProperty("webdriver.gecko.driver", "D:\\\\ToolsQA\\trunk\\Library\\drivers\\geckodriver.exe");
            Driver = new FirefoxDriver();


            //3. Do you test


            //3a) Navigate  website
            Driver.Navigate().GoToUrl("http://blueskycitadel.com/test-form-for-bluesky-automation-training/");
            //3a i) Maximize the window
            Driver.Manage().Window.Maximize();

            //3b) Enter a text into textbox

            //3b i)Inspect your element
            //DONE with f12 DEveloper Tool 

            //3b ii)Decide on the attribute to use to find your element
            //Decide to ID

            //3b iii) Copy the attibute
            //nf-field-26
            //nf-field-27


            //3b iv) Write the code to find the element
            //Driver.FindElement(By.Id("nf-field-26"));

            //3b v) Perform the action (ie Type into textbox)
            //enter the firstname
            Driver.FindElement(By.Id("nf-field-26")).SendKeys("My Firstname");

            //enter the lastname
            Driver.FindElement(By.Id("nf-field-27")).SendKeys("My Lastname");

            //3c Select from a drop list

            //3c i) Inspect your element for the SELECT (NOT THE OPTION)

            //3c ii) Decide on the attribute to use to find your element
            //Decide to ID

            //3c iii) Copy the attibute
            //nf-field-41

            //3c iv) Write the code to find the element

            //3c 1v a) Find the element for the select
            //Driver.FindElement(By.Id("nf-field-41"));

            //3c iv b Use the element you found with the SelementElement Instance
            SelectElement multiselect = new SelectElement(Driver.FindElement(By.Id("nf-field-41")));

            //3c iv c) Select the Option from the list
            multiselect.SelectByValue("one");

            //multiselect.SelectByValue("two");

            multiselect.SelectByText("Three");


            //3c I Select Drop down list
           // SelectElement country= new SelectElement(Driver.FindElement(By.Id("nf-field-43")));
            new SelectElement(Driver.FindElement(By.Id("nf-field-43"))).SelectByValue("two");

            //3d Click a radio button
            //3d i) Inspect your element for the RADIO (INPUT NOT THE LABEL)

            //3d ii) Decide on the attribute to use to find your element
            //Decide to xpath

            //3d iii) Copy the xpath
            //*[@id='nf-field-31-0']

            //3d iv) Write the code to find the element

            //IWebElement radio = Driver.FindElement(By.XPath("//*[@id='nf-field-31-0']"));

            //3d v) click on the element;
            //radio.Click();
            Driver.FindElement(By.XPath("//*[@id='nf-field-31-0']")).Click();

            //3e Typing a paragraph textbox
            Driver.FindElement(By.CssSelector("#nf-field-44")).SendKeys("My long paragragh end here");




            //3e Click a submit button
            Driver.FindElement(By.Id("nf-field-37")).Click();

            //4 Close Browser
            Driver.Close();

        }
    }
}
