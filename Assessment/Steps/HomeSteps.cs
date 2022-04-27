using Assessment.Helpers.Core;
using Assessment.Pages;
using System;
using TechTalk.SpecFlow;

namespace Assessment.Steps
{
    [Binding]
    public class HomeSteps
    {

        private readonly HomePage homePage;
        private readonly AppSettings appSettings;
        public HomeSteps(BrowserDriver browserDriver, AppSettings appSettings)
        {
            homePage = new HomePage(browserDriver.Current);
            this.appSettings = appSettings;
        }

        [When(@"I click on ""(.*)"" dropdown in Home Page")]
        public void WhenIClickOnDropdownInHomePage(string option)
        {
            homePage.ClickProjectDropDown(option);
        }
        
        [When(@"I select ""(.*)"" option in Home Page")]
        public void WhenISelectOptionInHomePage(string option)
        {
            homePage.SelectProjectDropDown(option);
        }
        
        [When(@"I click on ""(.*)"" option in the Home Page")]
        public void WhenIClickOnOptionInTheHomePage(string project)
        {
            homePage.SelectProject(project);
        }
    }
}
