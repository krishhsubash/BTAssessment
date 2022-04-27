using Assessment.Helpers.Core;
using Assessment.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Assessment.Steps
{
    [Binding]
    public class IssuesSteps :BaseWorkflowSteps
    {
        private readonly IssuesPage issuePage;
        private readonly AppSettings appSettings;
        public string summary { get; set; }

        public IssuesSteps(BrowserDriver browserDriver, ScenarioContext scenarioContext, IServiceProvider serviceProvider) :base(scenarioContext, serviceProvider)
        {
            issuePage = new IssuesPage(browserDriver.Current);
            this.appSettings = appSettings;
        }

        [Then(@"I verify the user is navigated to Issues Page")]
        public void ThenIVerifyTheUserIsNavigatedToIssuesPage()
        {
            Assert.That(issuePage.UserNavigatedToIssuesPage());
        }
        
        [Then(@"I validate the Project name as ""(.*)"" in Issues Page")]
        public void ThenIValidateTheProjectNameAsInIssuesPage(string projectName)
        {
            Assert.AreEqual(issuePage.GetProjectName(), projectName);
        }

        [When(@"I click on the create icon in the Issues Page")]
        public void WhenIClickOnTheCreateIconInTheIssuesPage()
        {
            issuePage.ClickPlusIconButton();
        }

        [Then(@"I verify the project field is populated in Issues Page")]
        public void ThenIVerifyTheProjectFieldIsPopulatedInIssuesPage()
        {
            Assert.IsTrue(issuePage.VerifyProjectField());
        }

        [When(@"I select Issue type as ""(.*)"" in Issues Page")]
        public void WhenISelectIssueTypeAsInIssuesPage(string issueType)
        {
        }

        [When(@"I enter random summary in Issues Page")]
        public void WhenIEnterRandomSummaryInIssuesPage()
        {
            summary =  new CommonHelper().GenerateDynamicData(3).DynamicText;
            issuePage.EnterRandomSummary(summary);
        }

        [When(@"I enter random description in Issues Page")]
        public void WhenIEnterRandomDescriptionInIssuesPage()
        {
            issuePage.EnterRandomDescription(new CommonHelper().GenerateDynamicData(3).DynamicText);
        }

        [When(@"I select priority as ""(.*)"" in Issues Page")]
        public void WhenISelectPriorityAsInIssuesPage(string priority)
        {
            issuePage.SelectPriority(priority);
        }

        [When(@"I enter the select date as this day in Issues Page")]
        public void WhenIEnterTheSelectDateAsThisDayInIssuesPage()
        {
            issuePage.SelectDate();
        }

        [When(@"I click on ""(.*)"" to create Jira in Issues Page")]
        public void WhenIClickOnToCreateJiraInIssuesPage(string issueCreate)
        {
            issuePage.CreateJira(issueCreate);
        }

        [When(@"I enter the case summary in the Issues Page")]
        public void WhenIEnterTheCaseSummaryInTheIssuesPage()
        {
            issuePage.EnterCaseSummary(summary);
        }

        [When(@"I click on the magnifir icon in the Issues Page")]
        public void WhenIClickOnTheMagnifirIconInTheIssuesPage()
        {
            issuePage.ClickMagnifierIcon();
        }

        [Then(@"I verify the incident is search successfully in the Issues Page")]
        public void ThenIVerifyTheIncidentIsSearchSuccessfullyInTheIssuesPage()
        {
            Assert.IsTrue(issuePage.verifyIncidentSearchedSuccessfully(summary));
        }

        [When(@"I click on the searched incident in Issues Page")]
        public void WhenIClickOnTheSearchedIncidentInIssuesPage()
        {
            issuePage.ClickSearchedIncident(summary);
        }

        [When(@"I click on the Actions icon in the Issues Page")]
        public void WhenIClickOnTheActionsIconInTheIssuesPage()
        {
            issuePage.ClickActionsIcon();
        }

        [When(@"I select the ""(.*)"" option from the dropdown in Issues Page")]
        public void WhenISelectTheOptionFromTheDropdownInIssuesPage(string actionOption)
        {
            issuePage.ClickActionsOption(actionOption);
        }

        [When(@"I click on the Delete dialog option in Issues Page")]
        public void WhenIClickOnTheDeleteDialogOptionInIssuesPage()
        {
            issuePage.ClickOnDeleteDialog();
        }

        [When(@"I click on the ""(.*)"" Hyperlink in Issues Page")]
        public void WhenIClickOnTheHyperlinkBreadcrumbInIssuesPage(string hyperlink)
        {
            issuePage.clickHyperLink(hyperlink);
        }


    }
}
