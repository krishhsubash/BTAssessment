using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Assessment.Helpers.Core;
using Assessment.Pages;
using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Tracing;

namespace Assessment.Hooks
{
    [Binding]
    public class HooksClass
    {
        private readonly ScenarioContext scenarioContext;
        private readonly FeatureContext featureContext;
        private static readonly IObjectContainer _objectContainer = new ObjectContainer();
        private static BrowserDriver browserDriver = new BrowserDriver();


        public HooksClass(ScenarioContext scenarioContext,
            FeatureContext featureContext)
        {
            this.scenarioContext = scenarioContext;
            this.featureContext = featureContext;
        }

        [BeforeScenario]
        public static void BeforeTestRun()
        {
            _objectContainer.RegisterInstanceAs(browserDriver);
        }

        [AfterScenario]
        public static void AfterTestRun()
        {
            _objectContainer.Resolve<BrowserDriver>();
            browserDriver.Dispose();
        }
    }
}
