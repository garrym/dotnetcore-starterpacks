using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace StarterPacks.OptionPattern
{
    internal class ExampleBackgroundService : BackgroundService
    {
        private readonly Settings _settings;

        public ExampleBackgroundService(IOptions<Settings> options) // Inject IOptions<T> to access
        {
            _settings = options.Value;
            
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            Console.WriteLine($"The connection string in appsettings.json is: '{_settings.ConnectionString}'");

            return Task.CompletedTask;
        }
    }
}