using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using Training8A.PageObjects;
using Training8A.Utilities;

namespace Training8A.StepDefinitions
{
    [Binding]
    public class RegistrationsSteps
    {
        RegistrationPage registration;

        public RegistrationsSteps()
        {
            registration = new RegistrationPage();
        }

        [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            Hooks.Driver.Navigate().GoToUrl("http://www.giftrete.com");
            Hooks.Driver.Manage().Window.Maximize();
        }
        
        [When(@"Click on register link")]
        public void WhenClickOnRegisterLink()
        {
            registration.ClickOnRegister();
        }
        
        [When(@"I enter firstname")]
        public void WhenIEnterFirstname()
        {
            registration.EnterFirstName();
        }
        
        [When(@"I enter last name")]
        public void WhenIEnterLastName()
        {
            registration.EnterLastName("Ogunlaja");
        }

        [When(@"I enter email ""(.*)""")]
        public void WhenIEnterEmail(string email)
        {
            registration.EnterEmailAddress(email);
        }


        [When(@"I enter mobile number")]
        public void WhenIEnterMobileNumber()
        {
            registration.EnterMobileNo("077777");
        }
        
        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            registration.EnterPassword("MyVerySecuredPassword");
        }


        
        [When(@"I confirm password")]
        public void WhenIConfirmPassword()
        {
            registration.EnterConfirmPassword("MyVerySecuredPassword");
        }
        
        [When(@"the click on signUp")]
        public void WhenTheClickOnSignUp()
        {
            registration.ClickSignUP();
        }

        [When(@"I wait for Element")]
        public void WhenIWaitForElement()
        {
            WaitForElements waitForElements = new WaitForElements();
            //WaitForElements.Wait(Hooks.Driver, "login"); //used for static 
            waitForElements.WaitForElementByID(Hooks.Driver, "login");
            waitForElements.FluentWaitForElementByCSS(Hooks.Driver, "login");
            waitForElements.FluentWaitWithByClause(Hooks.Driver, By.LinkText("testLogin"));
            //waitForElements.FluentWaitWithFindElements(Hooks.Driver, Hooks.Driver.FindElement(By.Id("id")));
        }


        [Then(@"I should be registered")]
        public void ThenIShouldBeRegistered()
        {
            Thread.Sleep(30000);

            //NUnit Assertion
          //  Assert.Contains("", ""); 
           
            //Assert.AreEqual(registration.SuccessMessageIsDisplayed(), true);
            Assert.IsTrue(registration.SuccessMessageIsDisplayed(), "Error Message: Registration failed");

            registration.SuccessMessageIsDisplayed().Should().BeTrue("Error Message: Registration failed");
            registration.SuccessMessageIsDisplayed().Should().Be(true);
        }


        [When(@"I enter password ""(.*)""")]
        public void WhenIEnterPassword(string passwordEntered)
        {
            registration.EnterPassword(passwordEntered);
        }

        [When(@"I confirm password ""(.*)""")]
        public void WhenIConfirmPassword(string confirmPasswordEntered)
        {
            registration.EnterConfirmPassword(confirmPasswordEntered);

        }

        [Then(@"the password is too short error is displayed")]
        public void ThenThePasswordIsTooShortErrorIsDisplayed()
        {
            registration.PasswordTooShortMessageIsDisplayed().Should().BeTrue("Password is not Too Should");
        }

        [Then(@"the error message ""(.*)"" is displayed for ""(.*)""")]
        public void ThenTheErrorMessageIsDisplayedFor(string message, string test)
        {
            if (test == "PasswordTooShort")
                registration.GetTextForPasswordTooShort().Should().Be(message);
            else if (test == "Invalidemail")
                registration.GetTextForInvalidEmail().Should().Be(message);
            else if (test == "MobileTooShort")
                registration.GetTextForMobileTooshort().Should().Be(message);


        }

    }
}
