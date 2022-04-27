using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Assessment.Helpers.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SolidToken.SpecFlow.DependencyInjection;
using TechTalk.SpecFlow.Tracing;

namespace Assessment
{
    public class Startup
    {
        protected Startup() { }
        public static IConfiguration _configuration;
        public static string configurationName;

        private static IServiceProvider serviceProvider { get; set; }

        [ScenarioDependencies]
        public static IServiceCollection CreateServices()
        {
            var serviceCollection = new ServiceCollection();

            serviceProvider = ConfigureServices(serviceCollection).BuildServiceProvider();

            InitializeCrmService();

            return serviceCollection;
        }

        private static IServiceCollection ConfigureServices(IServiceCollection serviceCollection)
        {

            // Build configuration
            _configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                .AddJsonFile("appSettings.json", false)
                .AddJsonFile("appSettings.Development.json", true)
                .Build();
            configurationName = Directory.GetParent(AppContext.BaseDirectory).Parent.Name;

            // Add access to generic IConfigurationRoot
            serviceCollection.AddSingleton(_configuration);

            serviceCollection.AddScoped<BrowserDriver>();
            serviceCollection.AddScoped<AppSettings>();
            return serviceCollection;
        }

        internal static void InitializeCrmService()
        {
            var appSettingsInstance = ActivatorUtilities.CreateInstance<AppSettings>(serviceProvider);
            appSettingsInstance.Username = serviceProvider.GetService<IConfiguration>().GetValue<string>("Username");
            appSettingsInstance.Browser = serviceProvider.GetService<IConfiguration>().GetValue<string>("Browser");
            appSettingsInstance.Password = serviceProvider.GetService<IConfiguration>().GetValue<string>("Password");
            appSettingsInstance.Url = serviceProvider.GetService<IConfiguration>().GetValue<string>("OnlineCrmUrl");
           // BrowserOption.Browser = serviceProvider.GetService<IConfiguration>().GetValue<string>("Browser");
            //Authenticator.Init(appSettingsInstance);
        }
    }
}
