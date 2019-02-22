using PrivateClassDataPatternImplementation;
using Xunit;

namespace PrivateClassDataPatternTests
{
    public class PrivateClassDataTest
    {
        [Fact]
        public void Gets_Private_Specifications_From_Public_Method()
        {
            Car car = new Car(6, 300, 300);
            Assert.Equal("This car has 6 cylinders, 300 horsepower, and 300 pounds of torque.", car.GetAllSpecifications());
        }
    }
}
