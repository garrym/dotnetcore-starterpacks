using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Options;

namespace StarterPacks.Logging.Basic
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var loggerFactory = new LoggerFactory();
            var optionsFactory = new OptionsFactory<ConsoleLoggerOptions>(new IConfigureOptions<ConsoleLoggerOptions>[0], new IPostConfigureOptions<ConsoleLoggerOptions>[0]);
            var optionsTokenChangeSource = new IOptionsChangeTokenSource<ConsoleLoggerOptions>[0];
            var optionsCache = new OptionsCache<ConsoleLoggerOptions>();
            var optionsMonitor = new OptionsMonitor<ConsoleLoggerOptions>(optionsFactory, optionsTokenChangeSource, optionsCache);
            var consoleLoggerProvider = new ConsoleLoggerProvider(optionsMonitor);
            loggerFactory.AddProvider(consoleLoggerProvider);

            var logger = loggerFactory.CreateLogger<Program>();

            logger.LogTrace("Logging trace-level event");
            logger.LogDebug("Logging debug-level event");
            logger.LogInformation("Logging information-level event");
            logger.LogWarning("Logging warning-level event");
            logger.LogError("Logging error-level event");
            logger.LogCritical("Logging critical-level event");

            Console.ReadKey();
        }
    }
}
