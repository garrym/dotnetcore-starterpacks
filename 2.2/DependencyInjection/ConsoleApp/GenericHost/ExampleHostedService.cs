using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace StarterPacks.DependencyInjection.GenericHost
{
    public class ExampleHostedService : IHostedService
    {
        private readonly IExampleDependency _exampleDependency;
 
        public ExampleHostedService(IExampleDependency exampleDependency)
        {
            _exampleDependency = exampleDependency;
        }
 
        public Task StartAsync(CancellationToken cancellationToken)
        {
            _exampleDependency.WriteLine($"Starting {nameof(ExampleHostedService)}.");

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _exampleDependency.WriteLine($"Stopping {nameof(ExampleHostedService)}.");

            return Task.CompletedTask;
        }
    }
}