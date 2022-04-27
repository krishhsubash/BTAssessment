using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Helpers.DTO
{
    public static class ElementsReference
    {
        public static Dictionary<string, string> Xpath = new Dictionary<string, string>()
        {
            { "Username", "//input[@id='username']" },
            {"Password", "//input[@name='password']" },
            {"Continue", "//button[@id='login-submit']" },
            {"LogIn", "//button[@id='login-submit']/span/span" },
            {"Work_Option", "//button/span[text()='{0}']"},
            {"Project_Name", "//a/div/span[text()='{0}']" },
            {"Projects_Option", "//a//span[text()='{0}']" },
            {"Issues_Page", "//h1[text()='Issues']" },
            {"DisplayedProject_Name", "//button//span[text()='TestProject2_TA_Demo']" },
            {"Create_Jira", "//button[@id='createGlobalItem']/span" },
            {"Issue_Project", "//header/following-sibling::div[contains(@id,'issue-create')]//div[@class='xkgbo7-3 aWXco']" },
            {"Summary", "//input[@name='summary']" },
            {"Description", "//div[@aria-label='Main content area']/p" },
            {"Priority", "//label[@id='priority-field-label']/following-sibling::div//div[@class=' css-1a7rm5r-control']" },
            {"Priority_DropDown", "//label[@id='priority-field-label']/following-sibling::div//div[contains(@class, 'indicatorContainer')]" },
            {"Select_Date", "//div[text()='Select date']" },
            {"Create_Issue", "//button[@type='submit']/span[text()='Create']" },
            {"Highest_Priority", "//div[contains(@id,'react-select')]//div[text()='Highest']" },
            {"Calender_Icon", "//div[@class=' css-qgzjb9']" },
            {"Last_Day", "//div[@aria-label='calendar']//button[@data-focused='true']" },
            {"Search_Issues", "//input[@data-test-id='searchfield']" },
            {"Search_Icon", "//input[@data-test-id='searchfield']/following-sibling::div/span" },
            {"Actions_Icon", "//button[@aria-label='Actions']" },
            {"Actions_Option", "//div[contains(@data-testid,'issue-meatball-menu')]//span[text()='{0}']" },
            {"Search_Result", "//table//tbody/tr[1]/td[3]/a[text()='{0}']" },
            {"Search_Box", "//input[@data-test-id='searchfield']" },
            {"Delete_Dialog", "//div[@role='dialog']//span[text()='Delete']" },
            {"Project_Hyperlink", "//nav[@aria-label='Breadcrumbs']//a/span[text()='Projects']" }
        };

    }

    public static class DynamicsReference
    {
        public static class Login
        {
            public static string USERNAME = "Username";
            public static string PASSWORD = "Password";
            public static string CONTINUE = "Continue";
            public static string LOG_IN = "LogIn";
        }

        public static class Home
        {
            public static string WORK_OPTION = "Work_Option";
            public static string PROJECT_NAME = "Project_Name";
            public static string PROJECTS_OPTION = "Projects_Option";
        }

        public static class Issue
        {
            public static string ISSUES_PAGE = "Issues_Page";
            public static string PROJECT_NAME = "DisplayedProject_Name";
            public static string CREATE_JIRA = "Create_Jira";
            public static string ISSUE_PROJECT = "Issue_Project";
            public static string SUMMARY = "Summary";
            public static string DESCRIPTION = "Description";
            public static string PRIORITY = "Priority";
            public static string SELECT_DATE = "Select_Date";
            public static string CREATE_ISSUE = "Create_Issue";
            public static string PRIORITY_DROPDOWN = "Priority_DropDown";
            public static string HIGHEST_PRIORITY = "Highest_Priority";
            public static string CALENDER_ICON = "Calender_Icon";
            public static string LAST_DAY = "Last_Day";
            public static string SEARCH_ISSUES = "Search_Issues";
            public static string SEARCH_ICON = "Search_Icon";
            public static string ACTIONS_ICON = "Actions_Icon";
            public static string ACTIONS_OPTION = "Actions_Option";
            public static string SEARCH_RESULT = "Search_Result";
            public static string SEARCH_BOX = "Search_Box";
            public static string DELETE_DIALOG = "Delete_Dialog";
            public static string PROJECT_HYPERLINK = "Project_Hyperlink";
        }
    }
}
