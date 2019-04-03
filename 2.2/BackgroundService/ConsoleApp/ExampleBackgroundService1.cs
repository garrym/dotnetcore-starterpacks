using System;
using System.Threading;
using System.Threading.Tasks;

namespace StarterPacks.BackgroundService
{
    public class ExampleBackgroundService1 : Microsoft.Extensions.Hosting.BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("ExampleBackgroundService1 executing");

            while (!cancellationToken.IsCancellationRequested)
            {
                Console.WriteLine("ExampleBackgroundService1 running");
                await Task.Delay(TimeSpan.FromSeconds(1), cancellationToken);
            }

            Console.WriteLine("ExampleBackgroundService1 exiting");
        }
    }
}