using System;

namespace StarterPacks.DependencyInjection.GenericHost
{
    public class ExampleDependencyImplementation : IExampleDependency
    {
        public void WriteLine(string value)
        {
            Console.WriteLine($"ExampleDependencyImplementation.WriteLine('{value}') called");
        }
    }
}