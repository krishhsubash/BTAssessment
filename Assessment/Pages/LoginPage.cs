using Assessment.Helpers.Core;
using Assessment.Helpers.DTO;
using Assessment.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Pages
{
    public class LoginPage: BasePage
    {
        private readonly IWebDriver _webDriver;
        public LoginPage(IWebDriver webDriver):base(webDriver)
        {
            _webDriver = webDriver;
        }

        public LoginPage LaunchUrl(string url)
        {
            if(_webDriver.Url!=url)
            {
                _webDriver.Url = url;
            }
            return this;
        }

        public LoginPage EnterUsername(string username)
        {
            EnterText(ElementsReference.Xpath[DynamicsReference.Login.USERNAME], username);
                return this;
        }

        public LoginPage EnterPassword(string password)
        {
            EnterText(ElementsReference.Xpath[DynamicsReference.Login.PASSWORD], password);
                return this;
        }

        public LoginPage ClickLoginPageButton(string buttonName)
        {
            if(buttonName.Equals("Continue"))
                Click(ElementsReference.Xpath[DynamicsReference.Login.CONTINUE]);
            else if(buttonName.Equals("Log In"))
                Click(ElementsReference.Xpath[DynamicsReference.Login.LOG_IN]);
            return this;
        }

    }
}
