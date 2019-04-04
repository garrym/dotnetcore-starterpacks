using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace StarterPacks.Logging.GenericHost
{
    public class ExampleLoggingBackgroundService : BackgroundService
    {
        private readonly ILogger<ExampleLoggingBackgroundService> _logger;

        public ExampleLoggingBackgroundService(ILogger<ExampleLoggingBackgroundService> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                _logger.LogTrace("Logging trace-level event");
                _logger.LogDebug("Logging debug-level event");
                _logger.LogInformation("Logging information-level event");
                _logger.LogWarning("Logging warning-level event");
                _logger.LogError("Logging error-level event");
                _logger.LogCritical("Logging critical-level event");

                await Task.Delay(TimeSpan.FromSeconds(1), cancellationToken);
            }
        }
    }
}