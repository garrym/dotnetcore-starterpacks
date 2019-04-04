using Microsoft.Extensions.Logging;

namespace StarterPacks.Logging
{
    class Program
    {
        static void Main(string[] args)
        {
            // Work in progress
            
            var loggerFactory = new LoggerFactory();

            var logger = loggerFactory.CreateLogger<Program>(typeof(Program));
        }
    }
}
