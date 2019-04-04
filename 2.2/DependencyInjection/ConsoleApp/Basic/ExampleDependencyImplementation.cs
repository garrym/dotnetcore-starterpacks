using System;

namespace StarterPacks.DependencyInjection
{
    public class ExampleDependencyImplementation : IExampleDependency
    {
        public void WriteLine(string value)
        {
            Console.WriteLine($"ExampleDependencyImplementation.WriteLine('{value}') called");
        }
    }
}