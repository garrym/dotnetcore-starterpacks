namespace StarterPacks.Configuration.Basic
{
    public class AppSettings
    {
        public string Hello { get; set; }

        public NestedSettings NestedSettings { get; set; }
    }

    public class NestedSettings
    {
        public string Value1 { get; set; }
        public int Value2 { get; set; }
    }
}
