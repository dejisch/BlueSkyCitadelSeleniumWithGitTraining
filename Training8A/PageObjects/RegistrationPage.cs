using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training8A.Utilities;

namespace Training8A.PageObjects
{
    class RegistrationPage
    {
        //1.  Inspect in Browser and decide on selector to use

        //2.  In pageobject Add the object for the Element

        //3.  In Pageobject create method for the action

        //4.  In Step Definition: You can use the method


        public RegistrationPage()
        {
            PageFactory.InitElements(Hooks.Driver, this);
        }

        ////*[@id='signup-form']/div[2]/label[2]

        //{Findsby(How.LinkText,using =Login)

        //{Findsby(How.LinkText,using ="Login")

        // 'FindsByAttribute' does not contain a constructor that takes 1 arguments,  

        [FindsBy(How = How.XPath, Using = "//*[@id='signup-form']/div[2]/label[2]")]
        private IWebElement invalidEmailMessage { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='signup-form']/div[3]/label[2]")]
        private IWebElement MobileTooShortMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='signup-form']/div[5]/label[2]")]
        private IWebElement passwordTooShortMessage { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#login-form > div.alert.alert-success")]
        private IWebElement successMessage { get; set; }

        [FindsBy(How = How.Id, Using = "confirm_password")]
        private IWebElement confirmPassword { get; set; }


        [FindsBy(How = How.LinkText, Using = "Register")]
        private IWebElement register { get; set; }

        [FindsBy(How = How.Id, Using = "first_name")]
        private IWebElement firstName { get; set; }

        [FindsBy(How = How.Id, Using = "last_name")]
        private IWebElement lastName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#mobile")]
        private IWebElement mobileNo { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement password { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailAddress { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#signup-form > div.buttons-holder.text-center > button")]
        private IWebElement signUp { get; set; }

        public string GetTextForMobileTooshort()
        {
            return MobileTooShortMessage.Text;

        }

        public string GetTextForInvalidEmail()
        {
            return invalidEmailMessage.Text;
    
        }

        public string GetTextForPasswordTooShort()
        {
            string text = passwordTooShortMessage.Text;
            return text;
        }

        public bool PasswordTooShortMessageIsDisplayed()
        {
            try
            {
                return passwordTooShortMessage.Displayed;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool SuccessMessageIsDisplayed()
        {
            try
            {
                return successMessage.Displayed;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
   
        public void EnterConfirmPassword(string confirmPasswordText)
        {
            confirmPassword.SendKeys(confirmPasswordText);
        }

        public void EnterPassword(string passwordText)
        {
            password.SendKeys(passwordText);
        }

        public void EnterMobileNo(string mobile)
        {
            mobileNo.SendKeys(mobile);
        }

        public void EnterLastName(string lastname)
        {
            lastName.SendKeys(lastname);
        }

        public void ClickSignUP()
        {

            signUp.Click();
        }


        public void ClickOnRegister()
        {
            register.Click();
        }

        public void EnterFirstName()
        {
            firstName.SendKeys("Deji");
        }

        public void EnterEmailAddress(string myEmail)
        {
            emailAddress.SendKeys(myEmail);
        }
    }
}
