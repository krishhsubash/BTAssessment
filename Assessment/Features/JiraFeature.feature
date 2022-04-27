Feature: JiraFeature
	Simple Jjira Feature

@Jira
Scenario: Jira Feature
Given I launch the  Jira Url
When I enter username as "ccngbt@gmail.com" in the Login Page
And I click on "Continue" button in Login Page
And I enter password as "Test@123" in Login Page
And I click on "Log In" button in Login Page
When I click on "Projects" dropdown in Home Page
And I select "View all projects" option in Home Page
And I click on "TestProject2_TA_Demo" option in the Home Page
Then I verify the user is navigated to Issues Page
And I validate the Project name as "Project:TestProject2_TA_Demo" in Issues Page
When I click on the create icon in the Issues Page
Then I verify the project field is populated in Issues Page
When I select Issue type as "BUG" in Issues Page
And I enter random summary in Issues Page
And I select priority as "Highest" in Issues Page
And I enter the select date as this day in Issues Page
And I click on "Create" to create Jira in Issues Page
And I enter the case summary in the Issues Page
When I click on the searched incident in Issues Page
And I click on the Actions icon in the Issues Page
And I select the "Delete" option from the dropdown in Issues Page
And I click on the Delete dialog option in Issues Page
And I click on the "Projects" Hyperlink in Issues Page





