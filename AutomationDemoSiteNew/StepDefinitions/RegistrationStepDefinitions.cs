using AutomationDemoSiteNew.PageObject;
using System;
using TechTalk.SpecFlow;

namespace AutomationDemoSiteNew.StepDefinitions
{
    [Binding]
    public class RegistrationStepDefinitions
    {
        RegistrationPage registrationPage;
        public RegistrationStepDefinitions() 
        {
            registrationPage = new RegistrationPage();
        }








        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            registrationPage.NavigateToWebsite();
        }

        [Given(@"I enter my First Name")]
        public void GivenIEnterMyFirstName()
        {
            registrationPage.EnterFirstName();
        }

        [Given(@"I enter my Last Name")]
        public void GivenIEnterMyLastName()
        {
            registrationPage.EnterLastName();
        }

        [Given(@"I enter my Address")]
        public void GivenIEnterMyAddress()
        {
            registrationPage.EnterAddress();
        }

        [Given(@"I enter my Email address")]
        public void GivenIEnterMyEmailAddress()
        {
            registrationPage.EnterEmailaddress();
        }

        [Given(@"I enter my Phone")]
        public void GivenIEnterMyPhone()
        {
            registrationPage.EnterPhone();
        }

        [Given(@"I enter my Password")]
        public void GivenIEnterMyPassword()
        {
            registrationPage.EnterPassword();
        }

        [Given(@"I enter my confirm Password")]
        public void GivenIEnterMyConfirmPassword()
        {
            registrationPage.EnterConfirmPassword();
        }

        [When(@"I click on Submit Button")]
        public void WhenIClickOnSubmitButton()
        {
            registrationPage.ClickSubmitButton();
        }


        [Then(@"I should be able to register sucessfully")]
        public void ThenIShouldBeAbleToRegisterSucessfully()
        {
            throw new PendingStepException();
        }
    }
}
