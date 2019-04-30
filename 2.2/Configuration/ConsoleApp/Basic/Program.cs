using System;
using Microsoft.Extensions.Configuration;

namespace StarterPacks.Configuration.Basic
{
    class Program
    {
        static void Main()
        {
            var environment = "development";

            var configurationBuilder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", false)
                .AddJsonFile($"appsettings.{environment}.json", false);

            var configuration = configurationBuilder.Build();

            var appSettings = new AppSettings();
            configuration.Bind(appSettings);

            Console.WriteLine("Reading from configuration: " + appSettings.Hello + " - " + appSettings.NestedSettings.Value1 + " - " + appSettings.NestedSettings.Value2);
            Console.ReadKey();
        }
    }
}
