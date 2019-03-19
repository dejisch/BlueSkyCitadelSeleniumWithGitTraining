using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;
using Training8A.Utilities;

namespace Training8A.StepDefinitions
{
    [Binding]
    public class FormElementsAutomation1Steps: Hooks
    {
        [Given(@"I navigate to sie ""(.*)""")]
        public void GivenINavigateToSie(string url)
        {
            Driver.Navigate().GoToUrl(url);
            Driver.Manage().Window.Maximize();

        }

        [When(@"I enter name")]
        public void WhenIEnterName()
        {
            Driver.FindElement(By.CssSelector("#nf-field-26")).SendKeys("Myname");
            SelectElement selectbox = new SelectElement(Driver.FindElement(By.Id("nf-field-41")));
            selectbox.SelectByText("Two");

            SelectElement selectbox2 = new SelectElement(Driver.FindElement(By.Id("nf-field-43")));
            selectbox2.SelectByText("Three");
        }

        [When(@"click submit")]
        public void WhenClickSubmit()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the successful form is displayed")]
        public void ThenTheSuccessfulFormIsDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
