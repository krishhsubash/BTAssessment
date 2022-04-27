using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using TechTalk.SpecFlow;
using Microsoft.Extensions.DependencyInjection;

namespace Assessment.Steps
{
    public class BaseWorkflowSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IConfiguration _configuration;

        public BaseWorkflowSteps(ScenarioContext scenarioContext, IServiceProvider serviceProvider)
        {
            _scenarioContext = scenarioContext;
            _configuration = serviceProvider.GetService<IConfiguration>();
        }

        protected string GetUser(string key) => _configuration.GetValue<string>($"{key}.Username");

        private string GetPassword(string key) => _configuration.GetValue<string>($"{key}.Password");

        private string GetMfaSecretKey(string key) => _configuration.GetValue<string>($"{key}.MfaSecretKey");
    }
}
