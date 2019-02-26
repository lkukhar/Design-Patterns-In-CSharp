using ProxyPatternImplementation;
using Xunit;

namespace ProxyPatternTests
{
    public class ProxyTest
    {
        private CarProxy _carProxy = new CarProxy();

        [Fact]
        public void Turn_On_Through_Car_Proxy()
        {
            Assert.Equal("Car has been turned on.", _carProxy.TurnOn());
        }

        [Fact]
        public void Turn_Off_Through_Car_Proxy()
        {
            Assert.Equal("Car has been turned off.", _carProxy.TurnOff());
        }
    }
}
