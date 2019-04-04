using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace StarterPacks.BackgroundService
{
    public class ExampleHostedService : IHostedService
    {
        public Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine($"{nameof(ExampleHostedService)} starting");

            var runTask = RunAsync(cancellationToken);

            return runTask.IsCompleted ? runTask : Task.CompletedTask;
        }

        private async Task RunAsync(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                Console.WriteLine($"{nameof(ExampleHostedService)} running");

                await Task.Delay(TimeSpan.FromSeconds(3), cancellationToken);
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine($"{nameof(ExampleHostedService)} stopping");

            return Task.CompletedTask;
        }
    }
}