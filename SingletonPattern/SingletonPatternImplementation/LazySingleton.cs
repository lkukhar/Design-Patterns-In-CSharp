using System;

namespace SingletonPatternImplementation
{
    //Credit to http://csharpindepth.com/Articles/General/Singleton.aspx for code example
    public sealed class LazySingleton
    {
        private static readonly Lazy<LazySingleton> lazyInitializer = new Lazy<LazySingleton>(() => new LazySingleton());
        private LazySingleton() { }

        public static LazySingleton Instance { get { return lazyInitializer.Value; } }
    }
}
