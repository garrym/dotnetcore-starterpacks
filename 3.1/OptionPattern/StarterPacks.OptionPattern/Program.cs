using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace StarterPacks.OptionPattern
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await CreateHostBuilder(args).Build().RunAsync();
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host
                .CreateDefaultBuilder(args)
                .ConfigureServices((context, serviceCollection) =>
                {
                    serviceCollection.AddOptions(); // Add required services for using Options
                    serviceCollection.Configure<Settings>(context.Configuration.GetSection(nameof(Settings))); // Binds against the 'Settings' section in the appsettings.json

                    serviceCollection.AddHostedService<ExampleBackgroundService>(); // Add an example background service to demonstrate constructor injection of IOptions
                });
        }
    }
}
