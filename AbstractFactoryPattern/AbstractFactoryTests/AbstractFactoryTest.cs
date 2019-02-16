using AbstractFactoryImplementation;
using Xunit;

namespace AbstractFactoryTests
{
    public class AbstractFactoryTest
    {
        AbstractFactory lexusFactory = AbstractFactory.CreateFactory(BrandType.Lexus);
        AbstractFactory toyotaFactory = AbstractFactory.CreateFactory(BrandType.Toyota);

        [Fact]
        public void Create_Factory_Test()
        {
            Assert.IsType<LexusFactory>(lexusFactory);
            Assert.IsType<ToyotaFactory>(toyotaFactory);
            Assert.IsAssignableFrom<AbstractFactory>(lexusFactory);
            Assert.IsAssignableFrom<AbstractFactory>(toyotaFactory);
        }

        [Fact]
        public void Create_Lexus_Car_Test()
        {
            Car lexusCar = lexusFactory.CreateCar();

            Assert.IsType<LexusCar>(lexusCar);
            Assert.IsAssignableFrom<Car>(lexusCar);
            Assert.Equal("Lexus car has been turned on.", lexusCar.TurnOn());
            Assert.Equal("Lexus car has been turned off.", lexusCar.TurnOff());
        }

        [Fact]
        public void Create_Lexus_SUV_Test()
        {
            SUV lexusSUV = lexusFactory.CreateSUV();

            Assert.IsType<LexusSUV>(lexusSUV);
            Assert.IsAssignableFrom<SUV>(lexusSUV);
            Assert.Equal("Lexus SUV has been turned on.", lexusSUV.TurnOn());
            Assert.Equal("Lexus SUV has been turned off.", lexusSUV.TurnOff());
        }

        [Fact]
        public void Create_Toyota_Car_Test()
        {
            Car toyotaCar = toyotaFactory.CreateCar();

            Assert.IsType<ToyotaCar>(toyotaCar);
            Assert.IsAssignableFrom<Car>(toyotaCar);
            Assert.Equal("Toyota car has been turned on.", toyotaCar.TurnOn());
            Assert.Equal("Toyota car has been turned off.", toyotaCar.TurnOff());
        }

        [Fact]
        public void Create_Toyota_SUV_Test()
        {
            SUV toyotaSUV = toyotaFactory.CreateSUV();

            Assert.IsType<ToyotaSUV>(toyotaSUV);
            Assert.IsAssignableFrom<SUV>(toyotaSUV);
            Assert.Equal("Toyota SUV has been turned on.", toyotaSUV.TurnOn());
            Assert.Equal("Toyota SUV has been turned off.", toyotaSUV.TurnOff());
        }
    }
}
