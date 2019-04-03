using System;
using System.Threading;
using System.Threading.Tasks;

namespace StarterPacks.BackgroundService
{
    public class ExampleBackgroundService2 : Microsoft.Extensions.Hosting.BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("ExampleBackgroundService2 executing");

            while (!cancellationToken.IsCancellationRequested)
            {
                Console.WriteLine("ExampleBackgroundService2 running");
                await Task.Delay(TimeSpan.FromSeconds(3), cancellationToken);
            }

            Console.WriteLine("ExampleBackgroundService2 exiting");
        }
    }
}