using Assessment.Helpers.Core;
using Assessment.Helpers.DTO;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Pages
{
    class IssuesPage : BasePage
    {
        private readonly IWebDriver _webDriver;
        public IssuesPage(IWebDriver webDriver) : base(webDriver)
        {
            _webDriver = webDriver;
        }

        public bool UserNavigatedToIssuesPage()
        {
            WaitForElementToBeAvailable(ElementsReference.Xpath[DynamicsReference.Issue.ISSUES_PAGE]);
            if (CountWebElements(ElementsReference.Xpath[DynamicsReference.Issue.ISSUES_PAGE]) > 0)
                return true;
            return false;
        }

        public string GetProjectName()
        {
            WaitForElementToBeAvailable(string.Format(ElementsReference.Xpath[DynamicsReference.Issue.PROJECT_NAME], "TestProject2_TA_Demo (TEST2)"));
            string projectName = GetText(string.Format(ElementsReference.Xpath[DynamicsReference.Issue.PROJECT_NAME], "TestProject2_TA_Demo (TEST2)"));
            return projectName;
        }

        public IssuesPage ClickPlusIconButton()
        {
            WaitForElementToBeAvailable(ElementsReference.Xpath[DynamicsReference.Issue.CREATE_JIRA]);
            Click(ElementsReference.Xpath[DynamicsReference.Issue.CREATE_JIRA]);
            return this;
        }

        public bool VerifyProjectField()
        {
            WaitForElementToBeAvailable(ElementsReference.Xpath[DynamicsReference.Issue.ISSUE_PROJECT]);
            return CountWebElements((ElementsReference.Xpath[DynamicsReference.Issue.ISSUE_PROJECT])) > 0;
        }

        public IssuesPage EnterRandomSummary(string summary)
        {
            EnterText(ElementsReference.Xpath[DynamicsReference.Issue.SUMMARY], summary);
            return this;
        }
        public IssuesPage EnterRandomDescription(string desc)
        {
            EnterText(ElementsReference.Xpath[DynamicsReference.Issue.DESCRIPTION], desc);
            return this;
        }

        public IssuesPage SelectPriority(string priority)
        {
            ScrollToElement(ElementsReference.Xpath[DynamicsReference.Issue.PRIORITY]);
            Click(ElementsReference.Xpath[DynamicsReference.Issue.PRIORITY_DROPDOWN]);
            WaitForElementToBeAvailable(ElementsReference.Xpath[DynamicsReference.Issue.HIGHEST_PRIORITY]);
            Click(ElementsReference.Xpath[DynamicsReference.Issue.HIGHEST_PRIORITY]);
            return this;
        }

        public IssuesPage SelectDate()
        {
            ScrollToElement(ElementsReference.Xpath[DynamicsReference.Issue.SELECT_DATE]);
            Click(ElementsReference.Xpath[DynamicsReference.Issue.CALENDER_ICON]);
            Click(ElementsReference.Xpath[DynamicsReference.Issue.LAST_DAY]);
            return this;
        }

        public IssuesPage CreateJira(string jiraCreate)
        {
            Click(string.Format(ElementsReference.Xpath[DynamicsReference.Issue.CREATE_ISSUE], jiraCreate));
            return this;
        }

        public IssuesPage EnterCaseSummary(string caseSummary)
        {
            Click(ElementsReference.Xpath[DynamicsReference.Issue.SEARCH_BOX]);
            EnterText(ElementsReference.Xpath[DynamicsReference.Issue.SEARCH_ISSUES], caseSummary);
            System.Threading.Thread.Sleep(5000);
            return this;
        }

        public IssuesPage ClickMagnifierIcon()
        {
            Click(ElementsReference.Xpath[DynamicsReference.Issue.SEARCH_ICON]);
            return this;
        }

        public IssuesPage ClickActionsOption(string actionOption)
        {
            WaitForElementToBeAvailable(string.Format(ElementsReference.Xpath[DynamicsReference.Issue.ACTIONS_OPTION], actionOption));
            Click(string.Format(ElementsReference.Xpath[DynamicsReference.Issue.ACTIONS_OPTION], actionOption));
            return this;
        }

        public IssuesPage ClickActionsIcon()
        {
            WaitForElementToBeAvailable(ElementsReference.Xpath[DynamicsReference.Issue.ACTIONS_ICON]);
            Click(ElementsReference.Xpath[DynamicsReference.Issue.ACTIONS_ICON]);
            return this;
        }

        public bool verifyIncidentSearchedSuccessfully(string incident)
        {
            WaitForElementToBeAvailable(string.Format(ElementsReference.Xpath[DynamicsReference.Issue.SEARCH_RESULT],incident));
            return CountWebElements(string.Format(ElementsReference.Xpath[DynamicsReference.Issue.SEARCH_RESULT],incident)) > 0;
        }

        public void ClickSearchedIncident(string incident)
        {
            WaitForElementToBeAvailable(string.Format(ElementsReference.Xpath[DynamicsReference.Issue.SEARCH_RESULT],incident));
            Click(string.Format(ElementsReference.Xpath[DynamicsReference.Issue.SEARCH_RESULT],incident));
        }

        public IssuesPage ClickOnDeleteDialog()
        {
            WaitForElementToBeAvailable(ElementsReference.Xpath[DynamicsReference.Issue.DELETE_DIALOG]);
            Click(ElementsReference.Xpath[DynamicsReference.Issue.DELETE_DIALOG]);
            return this;
        }

        public IssuesPage clickHyperLink(string hyperlink)
        {
            WaitForElementToBeAvailable(string.Format(ElementsReference.Xpath[DynamicsReference.Issue.PROJECT_HYPERLINK],hyperlink));
            Click(string.Format(ElementsReference.Xpath[DynamicsReference.Issue.PROJECT_HYPERLINK], hyperlink));
            return this;
        }
    }
}
