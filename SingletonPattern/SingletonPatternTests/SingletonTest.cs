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
    }
}
