﻿using System;

namespace StarterPacks.DependencyInjection.Basic
{
    public class ExampleDependencyImplementation : IExampleDependency
    {
        public void WriteLine(string value)
        {
            Console.WriteLine($"ExampleDependencyImplementation.WriteLine('{value}') called");
        }
    }
}