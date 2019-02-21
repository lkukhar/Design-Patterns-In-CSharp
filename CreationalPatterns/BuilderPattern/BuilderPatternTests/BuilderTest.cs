using BuilderPatternImplementation;
using Xunit;

namespace BuilderPatternTests
{
    public class BuilderTest
    {
        private BuildDirector _buildDirector = new BuildDirector();

        [Fact]
        public void Build_Coupe_Car_Test()
        {
            _buildDirector.SetCarBuilder(new CoupeBuilder());
            _buildDirector.ConstructCar();
            Car car = _buildDirector.GetCar();
            Assert.Equal("Doors: 2, Seats: 2, Rows: 2.", car.DescribeCar());
        }

        [Fact]
        public void Build_Sedan_Car_Test()
        {
            _buildDirector.SetCarBuilder(new SedanBuilder());
            _buildDirector.ConstructCar();
            Car car = _buildDirector.GetCar();
            Assert.Equal("Doors: 4, Seats: 5, Rows: 2.", car.DescribeCar());
        }

        [Fact]
        public void Get_Car_Before_Construction_Is_Null_Test()
        {
            _buildDirector.SetCarBuilder(new SedanBuilder());
            Car car = _buildDirector.GetCar();
            Assert.Null(car);
        }
    }
}
