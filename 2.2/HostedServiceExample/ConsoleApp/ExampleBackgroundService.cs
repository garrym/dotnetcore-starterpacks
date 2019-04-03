using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace StarterPacks.HostedService
{
    public class ExampleBackgroundService : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("ExampleBackgroundService executing");

            while (!cancellationToken.IsCancellationRequested)
            {
                Console.WriteLine("ExampleBackgroundService running");
                await Task.Delay(TimeSpan.FromSeconds(1), cancellationToken);
            }

            Console.WriteLine("ExampleBackgroundService exiting");
        }
    }
}