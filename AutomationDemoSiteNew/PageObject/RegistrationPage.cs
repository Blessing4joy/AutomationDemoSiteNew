using AutomationDemoSiteNew.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemoSiteNew.PageObject
{
    class RegistrationPage
    {

        public RegistrationPage()
        {
            driver = Hooks1.driver;
        }


        IWebDriver driver;


        IWebElement FirstName => driver.FindElement(By.XPath("//input[@placeholder='First Name']"));
        IWebElement LastName => driver.FindElement(By.XPath("//input[@placeholder='Last Name']"));
        IWebElement Address => driver.FindElement(By.XPath("//textarea[@rows='3']"));
        IWebElement Emailaddress => driver.FindElement(By.XPath("//input[@type='email']"));
        IWebElement Phone => driver.FindElement(By.XPath("//input[@type='tel']"));
        IWebElement Password => driver.FindElement(By.XPath("(//input[@type='password'])[1]"));
        IWebElement ConfirmPassword => driver.FindElement(By.XPath("(//input[@type='password'])[2]"));
        IWebElement SubmitButton => driver.FindElement(By.XPath("//button[@type='submit']"));


        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://demo.automationtesting.in/Register.html");
        }
        public void EnterFirstName()
        {
            FirstName.SendKeys("MamaJay");
        }

        public void EnterLastName()
        {
            LastName.SendKeys("JayJay");
        }

        public void EnterAddress()
        {
            Address.SendKeys("5 St Pauls Place Sheffield");
        }

        public void EnterEmailaddress()
        {
            Emailaddress.SendKeys("jayjay123@ymail.com");
        }

        public void EnterPhone()
        {
            Phone.SendKeys("07524357896");
        }

        public void EnterPassword()
        {
            Password.SendKeys("Password12");
        }

        public void EnterConfirmPassword()
        {
            ConfirmPassword.SendKeys("Password12");
        }

        public void ClickSubmitButton()
        {
            SubmitButton.Click();
        }

    }
}
