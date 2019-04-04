using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace StarterPacks.Logging.GenericHost
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var hostBuilder = new HostBuilder()
                .ConfigureLogging(loggingBuilder =>
                {
                    loggingBuilder.AddConsole(consoleLoggerOptions =>
                    {
                        consoleLoggerOptions.DisableColors = false;
                    });
                    loggingBuilder.SetMinimumLevel(LogLevel.Trace);
                })
                .ConfigureServices(serviceCollection =>
                {
                    serviceCollection.AddHostedService<ExampleLoggingBackgroundService>();
                });

            var host = hostBuilder.Build();

            await host.RunAsync();
        }
    }
}
