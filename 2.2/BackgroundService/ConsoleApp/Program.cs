using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace StarterPacks.BackgroundService
{
    class Program
    {
        static async Task Main()
        {
            var hostBuilder = new HostBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<ExampleBackgroundService1>();
                    services.AddHostedService<ExampleBackgroundService2>();
                });

            await hostBuilder.RunConsoleAsync();
        }
    }
}
