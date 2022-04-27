using Assessment.Helpers.Core;
using Assessment.Helpers.DTO;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Pages
{
    public class HomePage: BasePage
    {
        private readonly IWebDriver _webDriver;
        public HomePage(IWebDriver webDriver) : base(webDriver)
        {
            _webDriver = webDriver;
        }

        public HomePage ClickProjectDropDown(string option)
        {
            WaitForElementToBeAvailable(string.Format(ElementsReference.Xpath[DynamicsReference.Home.WORK_OPTION],option));
            Click(string.Format(ElementsReference.Xpath[DynamicsReference.Home.WORK_OPTION],option));
            return this;
        }

        public HomePage SelectProjectDropDown(string option)
        {
            WaitForElementToBeAvailable(string.Format(ElementsReference.Xpath[DynamicsReference.Home.PROJECTS_OPTION],option));
            Click(string.Format(ElementsReference.Xpath[DynamicsReference.Home.PROJECTS_OPTION], option));
            return this;
        }

        public HomePage SelectProject(string option)
        {
            WaitForElementToBeAvailable(string.Format(ElementsReference.Xpath[DynamicsReference.Home.PROJECT_NAME],option));
            Click(string.Format(ElementsReference.Xpath[DynamicsReference.Home.PROJECT_NAME], option));
            return this;
        }
    }
}
