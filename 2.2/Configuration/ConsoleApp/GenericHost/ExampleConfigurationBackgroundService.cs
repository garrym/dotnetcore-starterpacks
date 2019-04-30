using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace StarterPacks.Configuration.GenericHost
{
    public class ExampleConfigurationBackgroundService : BackgroundService
    {
        private readonly IConfiguration _configuration;

        public ExampleConfigurationBackgroundService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            var configurationSection = _configuration.GetSection("Key1");
            var value = configurationSection.Value;

            while (!cancellationToken.IsCancellationRequested)
            {
                Console.WriteLine($"Configuration: Key1 = {value}");
                await Task.Delay(TimeSpan.FromSeconds(1), cancellationToken);
            }
        }
    }
}
