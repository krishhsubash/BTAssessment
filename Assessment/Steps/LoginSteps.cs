using Assessment.Helpers.Core;
using Assessment.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Assessment.Steps
{
    [Binding]
    public sealed class LoginSteps
    {
        private readonly LoginPage loginPage;
        private readonly AppSettings appSettings;
        public LoginSteps(BrowserDriver browserDriver, AppSettings appSettings)
        {
            loginPage = new LoginPage(browserDriver.Current);
            this.appSettings = appSettings;
        }

        [Given(@"I launch the  Jira Url")]
        public void GivenILaunchTheJiraUrl()
        {
            loginPage.LaunchUrl("https://ccngbt.atlassian.net/");
        }
        
        [When(@"I enter username as ""(.*)"" in the Login Page")]
        public void WhenIEnterUsernameAsInTheLoginPage(string username)
        {
            loginPage.EnterUsername(username);
        }
        
        [When(@"I click on ""(.*)"" button in Login Page")]
        public void WhenIClickOnButtonInLoginPage(string loginButton)
        {
            loginPage.ClickLoginPageButton(loginButton);
        }
        
        [When(@"I enter password as ""(.*)"" in Login Page")]
        public void WhenIEnterPasswordAsInLoginPage(string password)
        {
            loginPage.EnterPassword(password);
        }
       
    }
}
