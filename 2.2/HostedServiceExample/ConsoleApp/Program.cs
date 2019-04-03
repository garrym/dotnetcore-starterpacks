using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace StarterPacks.HostedService
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var cancellationTokenSource = new CancellationTokenSource())
            {
                var cancellationToken = cancellationTokenSource.Token;

                var hostBuilder = new HostBuilder()
                    .ConfigureServices((hostContext, services) =>
                    {
                        services.AddHostedService<ExampleBackgroundService>();
                    });

                var host = hostBuilder.Build();
                host.RunAsync(cancellationToken);

                while (!cancellationToken.IsCancellationRequested)
                {
                    Console.WriteLine("Main thread running");
                    await Task.Delay(TimeSpan.FromSeconds(1), cancellationToken);
                }
            }
        }
    }
}
