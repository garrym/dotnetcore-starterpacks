using System;

namespace StarterPacks.DependencyInjection
{
    public class ExampleDependencyInstance : IExampleDependency
    {
        public void WriteLine(string value)
        {
            Console.WriteLine($"ExampleDependencyInstance.WriteLine('{value}') called");
        }
    }
}