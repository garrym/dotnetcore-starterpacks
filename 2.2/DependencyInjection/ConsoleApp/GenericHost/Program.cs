using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace StarterPacks.DependencyInjection.GenericHost
{
    class Program
    {
        static async Task Main()
        {
            var hostBuilder = new HostBuilder()
                .ConfigureServices(serviceCollection =>
                    {
                        serviceCollection.AddTransient<IExampleDependency, ExampleDependencyImplementation>();
                        serviceCollection.AddSingleton<IHostedService, ExampleHostedService>();
                    });

            using (var host = hostBuilder.Build())
            { 
                await host.RunAsync();
            }
        }
    }
}
