using System;
using System.Threading;
using System.Threading.Tasks;

namespace StarterPacks.BackgroundService
{
    public class ExampleBackgroundService : Microsoft.Extensions.Hosting.BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine($"{nameof(ExampleBackgroundService)} executing");

            while (!cancellationToken.IsCancellationRequested)
            {
                Console.WriteLine($"{nameof(ExampleBackgroundService)} running");
                await Task.Delay(TimeSpan.FromSeconds(2), cancellationToken);
            }

            Console.WriteLine($"{nameof(ExampleBackgroundService)} exiting");
        }
    }
}