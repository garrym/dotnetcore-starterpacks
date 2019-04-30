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

            Console.WriteLine($"AppSettings.Key1: {appSettings.Key1}");
            Console.WriteLine($"AppSettings.Object1.Key2: {appSettings.Object1.Key2}");
            Console.ReadKey();
        }
    }
}
