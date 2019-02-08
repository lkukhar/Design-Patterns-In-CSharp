using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonImplementation
{
    public sealed class Singleton
    {
        public static Singleton Instance { get; } = new Singleton();
        static Singleton() { }
        private Singleton() { }

    }
}
