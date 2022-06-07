using System;

namespace SingletonSimple.Classes
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> Lazy = new(() => new Singleton());
        public static Singleton Instance => Lazy.Value;
        public DateTime DateTime { get; set; }
        public string SomeStringValue { get; set; }

        private Singleton()
        {
            DateTime = DateTime.Now;
        }
    }
}
