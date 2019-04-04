using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace StarterPacks.Configuration.GenericHost
{
    class Program
    {
        static async Task Main()
        {
            var hostBuilder = new HostBuilder()
                .UseEnvironment(EnvironmentName.Development)
                .ConfigureHostConfiguration(configurationBuilder =>
                {
                    configurationBuilder.SetBasePath(Directory.GetCurrentDirectory());
                    configurationBuilder.AddJsonFile("appsettings.json", optional: false);
                })
                .ConfigureAppConfiguration((hostBuilderContext, configurationBuilder) =>
                {
                    configurationBuilder.AddJsonFile($"appsettings.{hostBuilderContext.HostingEnvironment.EnvironmentName.ToLower()}.json", false);
                })
                .ConfigureServices(serviceCollection =>
                {
                    serviceCollection.AddHostedService<ExampleConfigurationBackgroundService>();
                    // TODO: Figure out how to bind appsettings class
                });

            using (var host = hostBuilder.Build())
            { 
                await host.RunAsync();
            }
        }
    }

    public class AppSettings
    { }
}
