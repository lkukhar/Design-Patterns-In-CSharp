namespace SingletonPatternImplementation
{
    public sealed class Singleton
    {
        public static Singleton Instance { get; } = new Singleton();
        static Singleton() { }
        private Singleton() { }

        public int Incrementer = 0;
    }
}
