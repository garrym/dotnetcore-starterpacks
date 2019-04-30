using System.Dynamic;

namespace StarterPacks.Configuration.Basic
{
    public class AppSettings
    {
        public string Key1 { get; set; }

        public Object1 Object1 { get; set; }
    }

    public class Object1
    {
        public string Key2 { get; set; }
    }
}
