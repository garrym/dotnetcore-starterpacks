namespace StarterPacks.DependencyInjection
{
    public class Application
    {
        private readonly IExampleDependency _exampleDependency;
 
        public Application(IExampleDependency exampleDependency)
        {
            _exampleDependency = exampleDependency;
        }
 
        public void Start()
        {
            _exampleDependency.WriteLine("Using ExampleDependency");
        }
    }
}