using SingletonPatternImplementation;
using Xunit;

namespace SingletonPatternTests
{
    public class SingletonTest
    {
        [Fact]
        public void Is_Instance_Of_A_Singleton_Test()
        {
            Assert.IsType<Singleton>(Singleton.Instance);
            Assert.IsType<LazySingleton>(LazySingleton.Instance);
        }

        [Fact]
        public void Singleton_Incrementer_Test()
        {
            Singleton singletonOne = Singleton.Instance;
            Singleton singletonTwo = Singleton.Instance;

            singletonOne.Incrementer += 1;
            singletonTwo.Incrementer += 1;

            Assert.Equal(2, singletonOne.Incrementer);
            Assert.Equal(2, singletonTwo.Incrementer);
        }

        [Fact]
        public void Lazy_Singleton_Incrementer_Test()
        {
            LazySingleton lazySingletonOne = LazySingleton.Instance;
            LazySingleton lazySingletonTwo = LazySingleton.Instance;

            lazySingletonOne.Incrementer += 1;
            lazySingletonTwo.Incrementer += 1;

            Assert.Equal(2, lazySingletonOne.Incrementer);
            Assert.Equal(2, lazySingletonTwo.Incrementer);
        }
    }
}
