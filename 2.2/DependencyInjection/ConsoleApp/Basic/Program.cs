using System;
using Microsoft.Extensions.DependencyInjection;

namespace StarterPacks.DependencyInjection.Basic
{
    class Program
    {
        static void Main()
        {
            var serviceCollection = new ServiceCollection()
                .AddTransient<IExampleDependency, ExampleDependencyImplementation>()
                .AddTransient<Application>();
 
            var serviceProvider = serviceCollection.BuildServiceProvider();

            var application = serviceProvider.GetService<Application>();
            application.Start();

            Console.ReadKey();
        }
    }
}
