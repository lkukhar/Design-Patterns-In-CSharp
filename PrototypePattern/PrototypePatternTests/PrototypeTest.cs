using PrototypePatternImplementation;
using Xunit;

namespace PrototypePatternTests
{
    public class PrototypeTest
    {
        [Fact]
        public void Create_Correct_Prototype_Test()
        {
            Assert.IsAssignableFrom<ICar>(CarPrototypeFactory.GetPrototype(CarType.Lexus));
            Assert.IsAssignableFrom<ICar>(CarPrototypeFactory.GetPrototype(CarType.Honda));
            Assert.IsAssignableFrom<ICar>(CarPrototypeFactory.GetPrototype(CarType.Toyota));

            Assert.IsType<Lexus>(CarPrototypeFactory.GetPrototype(CarType.Lexus));
            Assert.IsType<Honda>(CarPrototypeFactory.GetPrototype(CarType.Honda));
            Assert.IsType<Toyota>(CarPrototypeFactory.GetPrototype(CarType.Toyota));

            Assert.Equal(new Lexus(), CarPrototypeFactory.GetPrototype(CarType.Lexus));
            Assert.Equal(new Honda(), CarPrototypeFactory.GetPrototype(CarType.Honda));
            Assert.Equal(new Toyota(), CarPrototypeFactory.GetPrototype(CarType.Toyota));
        }
    }
}
